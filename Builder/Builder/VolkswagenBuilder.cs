namespace Builder.Builder
{
    public class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder()
            : base()
        {

        }

        public override void BildEngine()
        {
            car.Engine = "1.8 TSI";
        }

        public override void BildFrames()
        {
            car.Frame = "VW frame";
        }

        public override void BildLuxury()
        {
            car.Luxury = "VW R-style";
        }

        public override void BildMultimedia()
        {
            car.Multimedia = "VW RNS 510";
        }

        public override void BildSafety()
        {
            car.Safety = "VW Lane Assist";
        }

        public override void BildWheels()
        {
            car.Wheels = "17\" VW Wheel";
        }
    }
}