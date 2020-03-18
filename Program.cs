using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRelogio
{
    class Program
    {
        static void Main(string[] args)
        {

            Relogio R = new Relogio(7200);
           // R.Segundos = 7200;


            double ss = R.Segundos;
            System.Console.WriteLine(ss);
            System.Console.WriteLine("SEGUNDOS:");



           
            double hh = R.Hora;
            System.Console.WriteLine(hh);
            System.Console.WriteLine("HORAS");
            System.Console.ReadKey();



        }
    }
}
