using System.ComponentModel;
using FastReport;
using FastReport.BG.TreeMap;
using FastReport.Utils;


namespace FastReportBGObjects.TreemapChart
{
    public partial class TreeMapObject : ChartBaseBG
    {
        private TreeMap TreeMap
        {
            get { return (TreeMap)baseChart; }
        }

        public TreeMapObject() : base(new TreeMap())
        {
        }

        /// <summary>
        /// Gets or sets the TreeMap algorithm used for layouting nodes
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(TreeMapLayoutMode.BestAspectRatio)]
        public TreeMapLayoutMode LayoutMode
        {
            get { return TreeMap.LayoutMode; }
            set { TreeMap.LayoutMode = value; }
        }

        /// <inheritdoc/>
        public override void Assign(Base source)
        {
            base.Assign(source);
            TreeMapObject src = source as TreeMapObject;

            LayoutMode = src.LayoutMode;
        }

        /// <inheritdoc/>
        public override void Serialize(FRWriter writer)
        {
            TreeMapObject c = writer.DiffObject as TreeMapObject;
            base.Serialize(writer);

            if (LayoutMode != c.LayoutMode)
                writer.WriteValue("LayoutMode", LayoutMode);
        }
    }
}
