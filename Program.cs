using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[]args)
        {

            // //manggil class method dan method parameter
            // Method.tampilkanNama("dimas", 23);
            // MethodParameter.tampilkanHitungan(2,3);
            
            // //manggil class Car
            // Car volvo = new Car();
            // volvo.color = "blue";
            // volvo.speed = 300;

            // Car bmw = new Car();
            // bmw.color = "red";
            // bmw.speed = 200;

            // Console.WriteLine("ini adalah mobil volvo " + "warnanya adalah " +  volvo.color + " kecepatanya adalah " + volvo.speed);
            // Console.WriteLine("ini adalah mobil bmw " + "warnanya adalah " +  bmw.color + " kecepatanya adalah " + bmw.speed);
            // volvo.FullThrottle();

            // //manggil Class CarCostructor dengan Constructor
            // CarConstructor honda = new CarConstructor("green", 500);
            // Console.WriteLine(honda.speed);

            // //manggil class person untuk belajar properties
            // Person manusia = new Person();
            // manusia.Name = "dimas";

            // Console.WriteLine(manusia.Name);

            //manggil class motor dan brand motor latihan inheritance
            Motor byson = new Motor("kuning",200);
            Console.WriteLine(@"ini adalah brand motor " + byson.brand + " bewarna " + byson.color + 
            " kecepatannya adalah " + byson.speed);
            byson.brandMotto();
        
        }
    }
}