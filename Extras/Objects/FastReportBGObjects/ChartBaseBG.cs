using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using FastReport;
using FastReport.Utils;
using FastReport.Data;
using FastReport.BG.Data;
using FastReport.BG.Common;
using FastReport.BG.Styling;

namespace FastReportBGObjects
{
    public class ChartBaseBG : ReportComponentBase
    {
        #region Fields
        private DataSourceBase dataSource;
        private string valueColumn = "";
        private string rootText = "";
        private readonly List<string> textColumns = new List<string>();
        protected HierarchicalChartBase baseChart;
        #endregion

        #region hidden properties
        [Browsable(false)]
        public HierarchicalChartBase BGChart => baseChart;


        [Category("Data")]
        protected HierarchicalDataSourceBase HierarchicalDataSource
        {
            get { return baseChart.DataSource; }
            set { baseChart.DataSource = value; }
        }
        #endregion

        #region Hidden Properties
        /// <summary>
        /// This property is not relevant to this class.
        /// </summary>
        [Browsable(false)]
        public override Border Border
        {
            get { return base.Border; }
            set { base.Border = value; }
        }

        /// <summary>
        /// This property is not relevant to this class.
        /// </summary>
        [Browsable(false)]
        public override FillBase Fill
        {
            get { return base.Fill; }
            set { base.Fill = value; }
        }

        /// <summary>
        /// This property is not relevant to this class.
        /// </summary>
        [Browsable(false)]
        public new string Style
        {
            get { return base.Style; }
            set { base.Style = value; }
        }

        /// <summary>
        /// This property is not relevant to this class.
        /// </summary>
        [Browsable(false)]
        public new string EvenStyle
        {
            get { return base.EvenStyle; }
            set { base.EvenStyle = value; }
        }

        /// <summary>
        /// This property is not relevant to this class.
        /// </summary>
        [Browsable(false)]
        public new string HoverStyle
        {
            get { return base.HoverStyle; }
            set { base.HoverStyle = value; }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        public DataSourceBase DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        /// <summary>
        /// Gets or sets the data column or expression to use as value for the chart
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        [Editor("FastReport.TypeEditors.ExpressionEditor, FastReport", typeof(UITypeEditor))]
        public string ValueColumn
        {
            get { return valueColumn; }
            set { valueColumn = value; }
        }

        /// <summary>
        /// Gets or sets the collection of data columns or expressions to use as text for the chart
        /// </summary>
        // todo: open object editor
        [Browsable(false)]
        [Category("Data")]
        public List<string> TextColumns
        {
            get { return textColumns; }
            set { textColumns.Clear(); textColumns.AddRange(value); }
        }

        /// <summary>
        /// Gets or sets root text of chart.
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        [DefaultValue("")]
        public string RootText
        {
            get { return rootText; }
            set { rootText = value; }
        }

        /// <summary>
        /// Gets or sets depth data for visuaise.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DefaultValue(0)]
        public int MaxDepth
        {
            get { return baseChart.MaxDepth; }
            set { baseChart.MaxDepth = value; }
        }

        /// <summary>
        /// Gets or sets palette for chart.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Palette Palette
        {
            get { return baseChart.Palette; }
            set { baseChart.Palette.Assign(value); }
        }
        #endregion
        public ChartBaseBG(HierarchicalChartBase baseChart)
        {
            this.baseChart = baseChart;
            this.baseChart.DataSource = GetDemoData();
            FlagUseFill = false;
            FlagUseBorder = false;
            FlagProvidesHyperlinkValue = true;
        }

        /// <inheritdoc/>
        public override void Draw(FRPaintEventArgs e)
        {
            Rectangle chartRect = new Rectangle(0, 0, (int)Math.Round(Width), (int)Math.Round(Height));
            IGraphicsState state = e.Graphics.Save();

            try
            {
                base.Draw(e);
                baseChart.Bounds = chartRect;
                using (Matrix transform = new Matrix())
                {
                    transform.Translate(AbsLeft, AbsTop);
                    transform.Scale(e.ScaleX, e.ScaleY, MatrixOrder.Append);
                    e.Graphics.MultiplyTransform(transform, MatrixOrder.Prepend);
                    baseChart.Draw(e.Graphics.Graphics);
                }
            }
            catch (Exception ex)
            {
                Font font = FastReport.Utils.DrawUtils.DefaultFont;
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(ex.Message, font, Brushes.Red, chartRect, sf);
                }
            }
            finally
            {
                e.Graphics.Restore(state);
            }
        }

        /// <inheritdoc/>
        public override void Assign(Base source)
        {
            base.Assign(source);
            ChartBaseBG src = source as ChartBaseBG;

            RootText = src.RootText;
            DataSource = src.DataSource;
            ValueColumn = src.ValueColumn;
            TextColumns = src.TextColumns;
            MaxDepth = src.MaxDepth;
            Palette = src.Palette;
        }

        /// <inheritdoc/>
        public override void Serialize(FRWriter writer)
        {
            ChartBaseBG c = writer.DiffObject as ChartBaseBG;
            base.Serialize(writer);

            if (DataSource != null)
                writer.WriteRef("DataSource", DataSource);
            if (ValueColumn != c.ValueColumn)
                writer.WriteStr("ValueColumn", ValueColumn);
            if (!writer.AreEqual(TextColumns.ToArray(), c.TextColumns.ToArray()))
                writer.WriteValue("TextColumns", TextColumns.ToArray());
            if (RootText != c.RootText)
                writer.WriteStr("RootText", RootText);
            if (MaxDepth != c.MaxDepth)
                writer.WriteInt("MaxDepth", MaxDepth);

            using (MemoryStream stream = new MemoryStream())
            {
                Palette.Save(stream);
                stream.Position = 0;
                writer.WriteValue("PaletteData", stream);
            }

            using (MemoryStream stream = new MemoryStream())
            {
                HierarchicalDataSource.Save(stream);
                stream.Position = 0;
                writer.WriteValue("ChartData", stream);
            }
        }

        /// <inheritdoc/>
        public override void Deserialize(FRReader reader)
        {
            base.Deserialize(reader);

            if (reader.HasProperty("TextColumns"))
            {
                TextColumns.Clear();
                TextColumns.AddRange((string[])reader.ReadValue("TextColumns", typeof(string[])));
            }

            if (reader.HasProperty("PaletteData"))
            {
                string streamStr = reader.ReadStr("PaletteData");
                using (MemoryStream stream = Converter.FromString(typeof(Stream), streamStr) as MemoryStream)
                {
                    Palette.Load(stream);
                }
            }

            if (reader.HasProperty("ChartData"))
            {
                string streamStr = reader.ReadStr("ChartData");
                using (MemoryStream stream = Converter.FromString(typeof(Stream), streamStr) as MemoryStream)
                {
                    HierarchicalDataSource.Load(stream);
                }
            }
        }

        /// <inheritdoc/>
        public override void GetData()
        {
            base.GetData();

            if (DataSource != null)
            {
                HierarchicalReportSource source = new HierarchicalReportSource();
                source.Root.Text = RootText;
                source.DataSource = DataSource;
                source.ValueMember = ValueColumn;
                source.LevelTextMembers = TextColumns.ToArray();
                source.Load();

                baseChart.DataSource = source;
            }
        }

        protected virtual HierarchicalDataSourceBase GetDemoData()
        {
            HierarchicalRecordsSource demoSource = new HierarchicalRecordsSource();
            demoSource.BeginInit();
            demoSource.Records.Clear();

            HierarchicalRecord r = new HierarchicalRecord("Bakery products");
            r.Children.Add(new HierarchicalRecord("Ciabatta", 3));
            r.Children.Add(new HierarchicalRecord("Bread", 5));
            r.Children.Add(new HierarchicalRecord("Croissant", 1));
            demoSource.Records.Add(r);

            r = new HierarchicalRecord("Alcohol");
            r.Children.Add(new HierarchicalRecord("Wine", 6));
            r.Children.Add(new HierarchicalRecord("Whiskey", 2));
            r.Children.Add(new HierarchicalRecord("Beer", 5));
            demoSource.Records.Add(r);

            r = new HierarchicalRecord("Dairy products");
            r.Children.Add(new HierarchicalRecord("Yoghurt", 3));
            r.Children.Add(new HierarchicalRecord("Milk", 4));
            demoSource.Records.Add(r);

            demoSource.EndInit();
            return demoSource;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && baseChart != null)
            {
                baseChart.Dispose();
                baseChart = null;
            }
            base.Dispose(disposing);
        }
    }
}
