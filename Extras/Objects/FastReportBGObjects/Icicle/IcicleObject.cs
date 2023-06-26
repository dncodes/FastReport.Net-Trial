using System.ComponentModel;
using FastReport;
using FastReport.Utils;
using FastReport.BG.Icicle;

namespace FastReportBGObjects.IcicleChart
{

    public partial class IcicleObject : ChartBaseBG
    {
        private Icicle Icicle
        {
            get { return (Icicle)baseChart; }
        }

        public IcicleObject() : base(new Icicle())
        {
        }

        /// <summary>
        /// Get or set the direction of icicles
        /// </summary>
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(IcicleDirection.Down)]
        public IcicleDirection Direction
        {
            get { return Icicle.Direction; }
            set { Icicle.Direction = value; }
        }

        /// <inheritdoc/>
        public override void Assign(Base source)
        {
            base.Assign(source);
            IcicleObject src = source as IcicleObject;

            Direction = src.Direction;
        }

        /// <inheritdoc/>
        public override void Serialize(FRWriter writer)
        {
            IcicleObject c = writer.DiffObject as IcicleObject;
            base.Serialize(writer);

            if (Direction != c.Direction)
                writer.WriteValue("Direction", Direction);
        }
    }
}
