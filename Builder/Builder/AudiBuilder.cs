namespace Builder.Builder
{
    public class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder(): base() { }

        public override void BildEngine()
        {
            car.Engine = "2.0 TFSI";
        }

        public override void BildFrames()
        {
            car.Frame = "Audi frame";
        }

        public override void BildLuxury()
        {
            car.Luxury = "Audi Exclusive Iterior";
        }

        public override void BildMultimedia()
        {
            car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BildSafety()
        {
            car.Safety = "Side Assist";
        }

        public override void BildWheels()
        {
            car.Wheels = "18\" Audi Wheel";
        }
    }
}