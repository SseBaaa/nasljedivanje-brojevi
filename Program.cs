using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brojeviiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            x.Broj = 100;
            Console.WriteLine(x.ApsVrijednost());
            Negativni y = new Negativni();
            y.Broj = -100;
            Console.WriteLine(y.ApsVrijednost());
            Decimalni z = new Decimalni();
            z.Broj = 100.45;
            Console.WriteLine(z.ApsVrijednost());

            Console.ReadKey();
        }
    }

    class Brojevi
    {
        double broj;

        

        virtual public double ApsVrijednost()
        {
            return 0;
        }

        public double Broj { get => broj; set => broj = value; }
    }

    class Cijeli : Brojevi
    {
       
        public override double ApsVrijednost()
        {
            return Broj < 0 ? -Broj : Broj;
        }
    }

    class Decimalni : Brojevi
    {
        
        public override double ApsVrijednost()
        {
            return Broj < 0 ? -Broj : Broj;
        }
    }

    class Pozitivni : Cijeli
    {
        

        public override double ApsVrijednost()
        {
            return Broj;
        }
    }

    class Negativni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Broj*-1;
        }
    }
}
