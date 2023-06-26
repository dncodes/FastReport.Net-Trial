using FastReport;
using FastReport.BG.Gantt;
using FastReport.BG.Styling;
using FastReport.Data;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;

namespace FastReportBGObjects.Gantt
{
    public partial class GanttObject : ReportComponentBase
    {
        #region private fields
        private DataSourceBase dataSource;
        private string nameColumn;
        private string startDateColumn;
        private string endDateColumn;
        private string resourceColumn;

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
        public string NameColumn
        {
            get { return nameColumn; }
            set { nameColumn = value; }
        }

        /// <summary>
        /// Gets or sets the data column or expression to use as value for the chart
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        [Editor("FastReport.TypeEditors.ExpressionEditor, FastReport", typeof(UITypeEditor))]
        public string StartDateColumn
        {
            get { return startDateColumn; }
            set { startDateColumn = value; }
        }

        /// <summary>
        /// Gets or sets the data column or expression to use as value for the chart
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        [Editor("FastReport.TypeEditors.ExpressionEditor, FastReport", typeof(UITypeEditor))]
        public string EndDateColumn
        {
            get { return endDateColumn; }
            set { endDateColumn = value; }
        }

        /// <summary>
        /// Gets or sets the data column or expression to use as value for the chart
        /// </summary>
        [Browsable(true)]
        [Category("Data")]
        [Editor("FastReport.TypeEditors.ExpressionEditor, FastReport", typeof(UITypeEditor))]
        public string ResourceColumn
        {
            get { return resourceColumn; }
            set { resourceColumn = value; }
        }

        /// <summary>
        /// Maximum width of the block with the name of the node
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int MaxLeftPartWidth { get; set; }

        /// <summary>
        /// Specifies the position of the text relative to the spacing of the rectangle.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TextPosition TextPosition
        {
            get { return GanttChart.TextPosition; }
            set { GanttChart.TextPosition = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating the scale of dates in titles.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Distance Distance
        {
            get { return GanttChart.Distance; }
            set { GanttChart.Distance = value; }
        }

        /// <summary>
        /// Gets or sets the number of divisions in the bottom date.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SegmentationInHeader
        {
            get { return GanttChart.SegmentationInHeader; }
            set { GanttChart.SegmentationInHeader = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display the horizontal grid.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DrawHorizontalGrid
        {
            get { return GanttChart.DrawHorizontalGrid; }
            set { GanttChart.DrawHorizontalGrid = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display the vertical grid.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DrawVerticalGrid
        {
            get { return GanttChart.DrawVerticalGrid; }
            set { GanttChart.DrawVerticalGrid = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display the title of the task in the interval area.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool TextOnIntervals
        {
            get { return GanttChart.TextOnIntervals; }
            set { GanttChart.TextOnIntervals = value; }
        }

        /// <summary>
        /// Gets or sets the template by which dates will be displayed.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Pattern
        {
            get { return GanttChart.Pattern; }
            set { GanttChart.Pattern = value; }
        }

        /// <summary>
        /// Gets or sets the position of the title relative to the chart.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DefaultValue(HeaderPosition.Top)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public HeaderPosition HeaderPosition
        {
            get { return GanttChart.HeaderPosition; }
            set { GanttChart.HeaderPosition = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to use the standard header height.
        /// </summary>
        /// <remarks>If the value is false, <see cref="HeaderHeight"/> property is responsible for the height of the header.</remarks>
        [Browsable(false)]
        [DefaultValue(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool DefaultHeaderHeight
        {
            get { return GanttChart.DefaultHeaderHeight; }
            set { GanttChart.DefaultHeaderHeight = value; }
        }

        /// <summary>
        /// Gets or sets the height of the title.
        /// </summary>
        /// <remarks>Header height will be applied if the property <see cref="DefaultHeaderHeight"/> is disabled</remarks>
        [Browsable(false)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float HeaderHeight
        {
            get { return GanttChart.HeaderHeight; }
            set { GanttChart.HeaderHeight = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to display the top date in the header.
        /// </summary>
        [Browsable(false)]
        [DefaultValue(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowTopDateInHeader
        {
            get { return GanttChart.ShowTopDateInHeader; }
            set { GanttChart.ShowTopDateInHeader = value; }
        }

        /// <summary>
        /// Gets or sets a lower date alignment 
        /// </summary>
        [Browsable(false)]
        [DefaultValue(BottomDateView.Cell)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BottomDateView BottomDateView
        {
            get { return GanttChart.BottomDateView; }
            set { GanttChart.BottomDateView = value; }
        }

        [Browsable(false)]
        Palette Palette
        {
            get { return GanttChart.Palette; }
            set { GanttChart.Palette.Assign(value); }
        }
        #endregion

        internal GanttChart GanttChart = new GanttChart();

        public GanttObject()
        {
            Width = 500;
            Height = 180;
            SetupDemoData();
        }

        private void SetupDemoData()
        {
            List<GanttRecord> records = new List<GanttRecord>()
            {
                new GanttRecord()
                {
                    Text = "Task 1",
                    StartDate = new DateTime(day: 1, month: 1, year: 2020),
                    EndDate = new DateTime(day: 10, month: 1, year: 2020),
                },
                new GanttRecord()
                {
                    Text = "Task 2",
                    StartDate = new DateTime(day: 10, month: 1, year: 2020),
                    EndDate = new DateTime(day: 20, month: 1, year: 2020),
                },
                new GanttRecord()
                {
                    Text = "Task 3",
                    StartDate = new DateTime(day: 20, month: 1, year: 2020),
                    EndDate = new DateTime(day: 31, month: 1, year: 2020),
                }
            };
            GanttChart.DataSource.DataSource = records;
        }

        /// <inheritdoc/>
        public override void Draw(FRPaintEventArgs e)
        {
            Rectangle chartRect = new Rectangle(0, 0, (int)Math.Floor(Width), (int)Math.Floor(Height));
            IGraphicsState state = e.Graphics.Save();

            try
            {
                base.Draw(e);
                GanttChart.Bounds = chartRect;
                using (Matrix transform = new Matrix())
                {
                    transform.Translate(AbsLeft, AbsTop);
                    transform.Scale(e.ScaleX, e.ScaleY, MatrixOrder.Append);
                    e.Graphics.MultiplyTransform(transform, MatrixOrder.Prepend);
                    e.Graphics.Clip = new Region(new RectangleF(0, 0, Width - 0.5f, Height - 0.5f));
                    GanttChart.Draw(e.Graphics.Graphics);
                }
            }
            catch (Exception ex)
            {
                using (Font font = new Font("Tahoma", 8))
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

        public override void Assign(Base source)
        {
            base.Assign(source);
            GanttObject src = source as GanttObject;
            MaxLeftPartWidth = src.MaxLeftPartWidth;
            TextPosition = src.TextPosition;
            Distance = src.Distance;
            SegmentationInHeader = src.SegmentationInHeader;
            DrawHorizontalGrid = src.DrawHorizontalGrid;
            DrawVerticalGrid = src.DrawVerticalGrid;
            TextOnIntervals = src.TextOnIntervals;
            Pattern = src.Pattern;
            HeaderPosition = src.HeaderPosition;
            DefaultHeaderHeight = src.DefaultHeaderHeight;
            HeaderHeight = src.HeaderHeight;
            ShowTopDateInHeader = src.ShowTopDateInHeader;
            BottomDateView = src.BottomDateView;

            DataSource = src.DataSource;
            NameColumn = src.NameColumn;
            StartDateColumn = src.StartDateColumn;
            EndDateColumn = src.EndDateColumn;
            ResourceColumn = src.ResourceColumn;
        }

        public override void Serialize(FRWriter writer)
        {
            GanttObject c = writer.DiffObject as GanttObject;
            base.Serialize(writer);


            if (DataSource != null)
                writer.WriteRef("DataSource", DataSource);
            if (NameColumn != c.NameColumn)
                writer.WriteStr("NameColumn", NameColumn);
            if (StartDateColumn != c.StartDateColumn)
                writer.WriteStr("StartDateColumn", StartDateColumn);
            if (EndDateColumn != c.EndDateColumn)
                writer.WriteStr("EndDateColumn", EndDateColumn);
            if (ResourceColumn != c.ResourceColumn)
                writer.WriteStr("ResourceColumn", ResourceColumn);

            if (MaxLeftPartWidth != c.MaxLeftPartWidth)
                writer.WriteInt("MaxLeftPartWidth", MaxLeftPartWidth);
            if (TextPosition != c.TextPosition)
                writer.WriteValue("TextPosition", TextPosition);
            if (Distance != c.Distance)
                writer.WriteValue("Distance", Distance);
            if (SegmentationInHeader != c.SegmentationInHeader)
                writer.WriteInt("SegmentationInHeader", SegmentationInHeader);
            if (DrawHorizontalGrid != c.DrawHorizontalGrid)
                writer.WriteBool("DrawHorizontalGrid", DrawHorizontalGrid);
            if (DrawVerticalGrid != c.DrawVerticalGrid)
                writer.WriteBool("DrawVerticalGrid", DrawVerticalGrid);
            if (TextOnIntervals != c.TextOnIntervals)
                writer.WriteBool("TextOnIntervals", TextOnIntervals);
            if (Pattern != c.Pattern)
                writer.WriteStr("Pattern", Pattern);
            if (HeaderPosition != c.HeaderPosition)
                writer.WriteValue("SegmentationInHeader", HeaderPosition);
            if (DefaultHeaderHeight != c.DefaultHeaderHeight)
                writer.WriteBool("DefaultHeaderHeight", DefaultHeaderHeight);
            if (HeaderHeight != c.HeaderHeight)
                writer.WriteFloat("HeaderHeight", HeaderHeight);
            if (ShowTopDateInHeader != c.ShowTopDateInHeader)
                writer.WriteBool("ShowTopDateInHeader", ShowTopDateInHeader);
            if (BottomDateView != c.BottomDateView)
                writer.WriteValue("BottomDateView", BottomDateView);
            if (DefaultHeaderHeight != c.DefaultHeaderHeight)
                writer.WriteBool("DefaultHeaderHeight", DefaultHeaderHeight);


            using (MemoryStream stream = new MemoryStream())
            {
                GanttChart.SaveNodes(stream);
                stream.Position = 0;
                writer.WriteValue("NodeData", stream);
            }

            using (MemoryStream stream = new MemoryStream())
            {
                Palette.Save(stream);
                stream.Position = 0;
                writer.WriteValue("PaletteData", stream);
            }

            using (MemoryStream stream = new MemoryStream())
            {
                GanttChart.SaveResources(stream);
                stream.Position = 0;
                writer.WriteValue("GanttResourceData", stream);
            }
        }

        public override void Deserialize(FRReader reader)
        {
            base.Deserialize(reader);

            if (reader.HasProperty("PaletteData"))
            {
                string streamStr = reader.ReadStr("PaletteData");
                using (MemoryStream stream = Converter.FromString(typeof(Stream), streamStr) as MemoryStream)
                {
                    Palette.Load(stream);
                }
            }

            if (reader.HasProperty("NodeData"))
            {
                string streamStr = reader.ReadStr("NodeData");
                using (MemoryStream stream = Converter.FromString(typeof(Stream), streamStr) as MemoryStream)
                {
                    GanttChart.LoadNodes(stream);
                }
            }

            if (reader.HasProperty("GanttResourceData"))
            {
                string streamStr = reader.ReadStr("GanttResourceData");
                using (MemoryStream stream = Converter.FromString(typeof(Stream), streamStr) as MemoryStream)
                {
                    GanttChart.LoadResources(stream);
                }
            }
        }

        public override void GetData()
        {
            base.GetData();

            if (DataSource != null)
            {
                GanttChart.Resources.Clear();
                DataSource.First();
                List<GanttRecord> records = new List<GanttRecord>();
                dataSource.Init();
                while (DataSource.HasMoreRows)
                {
                    GanttRecord record = new GanttRecord();
                    record.Text = Report.GetColumnValue(RemoveBrackets(NameColumn)).ToString();
                    record.StartDate = DateTime.Parse(Report.GetColumnValue(RemoveBrackets(StartDateColumn)).ToString());
                    record.EndDate = DateTime.Parse(Report.GetColumnValue(RemoveBrackets(EndDateColumn)).ToString());
                    object resource = Report.GetColumnValue(RemoveBrackets(ResourceColumn));
                    if (resource != null)
                        record.Index = GanttChart.GetResourceIndex(resource.ToString());
                    records.Add(record);
                    this.DataSource.Next();
                }
                GanttChart.DataSource.DataSource = records;
            }
        }

        private string RemoveBrackets(string str)
        {
            return str.Replace("]", "").Replace("[", "");
        }
    }
}
