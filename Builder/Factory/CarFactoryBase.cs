using Builder.Builder;

namespace Builder.Factory
{
    public abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase _carBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            _carBuilder = builder;
        }

        public abstract Car Construct();
    }
}