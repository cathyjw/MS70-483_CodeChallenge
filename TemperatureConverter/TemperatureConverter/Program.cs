using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
   
    class FahrenheitTemperature
    {
        public float temp;

        public FahrenheitTemperature(float temp)
        {
            this.temp = temp;
        }

        public static implicit operator FahrenheitTemperature(float ftemp)
        {
            return new FahrenheitTemperature(ftemp);
        }

        public static implicit operator FahrenheitTemperature(CelsiusTemperature ctemp)
        {
            float result = ((ctemp.temp * 5 / 9) + 32);
            return new FahrenheitTemperature(result);
        }
    }

    class CelsiusTemperature
    {
        public float temp;

        public CelsiusTemperature(float temp)
        {
            this.temp = temp;
        }

        public static implicit operator CelsiusTemperature(float ctemp)
        {
            return new CelsiusTemperature(ctemp);
        }

        public static implicit operator CelsiusTemperature(FahrenheitTemperature ftemp) 
        {
            float result = ((ftemp.temp - 32) * 5 / 9);
            return new CelsiusTemperature(result);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            float ftemp = 32F;
            float ctemp = 0F;
            FahrenheitTemperature c = new FahrenheitTemperature(ftemp);
            var cresult = (CelsiusTemperature) c;
            Console.WriteLine(cresult.temp);

            Console.WriteLine("****************");

            CelsiusTemperature f = new CelsiusTemperature(ctemp);
            var fresult = (FahrenheitTemperature) f;
            Console.WriteLine(fresult.temp);
            Console.ReadLine();
        }
    }
}
