using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRelogio
{
    class Relogio
    {

        private double segundos;

        /*Contrutor*/

        public Relogio(double seg)
        {
            segundos = seg;
        }


        public double Segundos
        {
            get { return segundos; }
            set { segundos = value; }

        }

        public double Hora
        {
            get { return segundos / 3600; }
            set {if (value <= 1 && value >= 24)
                    System.Console.WriteLine("Valor deve ser entre 1 e 24");
                segundos = value * 3600; }
        }

    }
}
