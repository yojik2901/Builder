using Builder.Builder;

namespace Builder.Factory
{
    public class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder) { }

        public override Car Construct()
        {
            _carBuilder.BildFrames();
            _carBuilder.BildEngine();
            _carBuilder.BildWheels();
            _carBuilder.BildSafety();
            _carBuilder.BildLuxury();
            _carBuilder.BildMultimedia();

            return _carBuilder.GetCar();
        }
    }
}