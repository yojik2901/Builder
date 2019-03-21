namespace Builder.Builder
{
    public abstract class CarBuilderBase
    {
        protected Car car;

        protected CarBuilderBase()
        {
            car = new Car();
        }

        public Car GetCar()
        {
            return car;
        }

        public abstract void BildMultimedia();
        public abstract void BildWheels();
        public abstract void BildEngine();
        public abstract void BildFrames();
        public abstract void BildLuxury();
        public abstract void BildSafety();
    }
}