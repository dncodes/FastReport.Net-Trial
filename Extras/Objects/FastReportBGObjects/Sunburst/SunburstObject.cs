using System.ComponentModel;
using FastReport;
using FastReport.BG.Styling;
using FastReport.BG.Sunburst;
using FastReport.Utils;

namespace FastReportBGObjects.SunburstChart
{
    public partial class SunburstObject : ChartBaseBG
    {
        #region Fields        
        #endregion

        #region Properties
        [Browsable(false)]
        public Sunburst Sunburst
        {
            get { return (Sunburst)baseChart; }
        }

        /// <summary>
        /// Gets or sets start angle for sunburst.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DefaultValue(-90)]
        public int StartAngle
        {
            get { return Sunburst.StartAngle; }
            set { Sunburst.StartAngle = value; }
        }

        /// <summary>
        /// Gets or sets text direction for sunburst.
        /// </summary>
        [Browsable(false)]
        [Category("Appearance")]
        [DefaultValue(TextArcDirection.Radial)]
        public TextArcDirection TextDirection
        {
            get { return Sunburst.TextDirection; }
            set { Sunburst.TextDirection = value; }
        }
        #endregion

        #region Public Methods
        public SunburstObject() : base(new Sunburst())
        {
        }

        /// <inheritdoc/>
        public override void Assign(Base source)
        {
            base.Assign(source);
            SunburstObject src = source as SunburstObject;

            StartAngle = src.StartAngle;
            TextDirection = src.TextDirection;
        }

        /// <inheritdoc/>
        public override void Serialize(FRWriter writer)
        {
            SunburstObject c = writer.DiffObject as SunburstObject;
            base.Serialize(writer);

            if (StartAngle != c.StartAngle)
                writer.WriteInt("StartAngle", StartAngle);

            if (TextDirection != c.TextDirection)
                writer.WriteValue("TextDirection", TextDirection);
        }

        #endregion
    }
}
