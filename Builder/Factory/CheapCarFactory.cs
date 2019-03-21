using Builder.Builder;

namespace Builder.Factory
{
    public class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder) { }

        public override Car Construct()
        {
            _carBuilder.BildFrames();
            _carBuilder.BildEngine();
            _carBuilder.BildWheels();
            _carBuilder.BildSafety();

            return _carBuilder.GetCar();
        }
    }
}