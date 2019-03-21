using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;
using Builder.Factory;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vwBuilder = new VolkswagenBuilder();
            //vwBuilder.BildFrames();
            //vwBuilder.BildEngine();
            //vwBuilder.BildWheels();

            //var car = vwBuilder.GetCar();
            //Console.WriteLine(car);

            //vwBuilder.BildMultimedia();
            //car = vwBuilder.GetCar();
            //Console.WriteLine(car);


            Console.WriteLine("Cheap VW");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury VW");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Cheap Audi");
            constructor = new CheapCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Audi");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);
        }
    }
}
