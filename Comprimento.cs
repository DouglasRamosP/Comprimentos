using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMedidas
{
    class Comprimento
    {
        private double quilometro;
        private double metro;
        private double centimetro;
        private double milimetro;
        private double micrometro;
        private double nanometro;
        private double milha;
        private double jarda;
        private double pe;
        private double polegada;
        private double milhanautica;

        public Comprimento(double mt)
        {
            metro = mt;
        }

        public Comprimento(double km)
        {
            quilometro = km;
        }

        public Comprimento(double cm)
        {
            centimetro = cm;
        
        }

        public Comprimento(double ml)
        {
            milimetro = ml;
        }

        public Comprimento(double mc)
        {
            micrometro = mc;
        }

        public Comprimento(double nn)
        {
            nanometro = nn;
        }

        public Comprimento(double mlh)
        {
            milha = mlh;
        }

        public Comprimento(double jd)
        {
            jarda = jd;
        }

        public Comprimento(double pp)
        {
            pe = pp;
        }

        public Comprimento(double pl)
        {
            polegada = pl;
        }

        public Comprimento(double mln)
        {
            milhanautica = mln;
        }

        public double Quilometro
        {
            get { return quilometro; }
            set
            {
                quilometro = value;
                metro = value * 1000;
                centimetro = value * 100000;
                milimetro = value * 1000000;
                micrometro = value * 1000000000;
                milha = value / 1.60934;
                jarda = value * 1094;
                pe = value * 3281;
                polegada = value * 39370;
                milhanautica = value / 1.852;

            }

        }

        public double Metro
        {
            get { return metro; }
            set
            {
                metro = value;
                quilometro = value / 1000;
                centimetro = value * 100;
                milimetro = value * 1000;
                micrometro = value * 1000000;
                milha = value / 1609;
                jarda = value * 1.094;
                pe = value * 3.281;
                polegada = value * 39.37;
                milhanautica = value / 1852;

            }


        }
    }
}
