using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class Termosztat : OkosEszkoz, IIdozitheto, IStatisztika
    {
        private double jelenlegiHomerseklet;
        private double celHomerseklet;
        private int idozito;

        public double JelenlegiHomerseklet { get => jelenlegiHomerseklet; private set => jelenlegiHomerseklet = value; }
        public double CelHomerseklet { get => celHomerseklet; private set => celHomerseklet = value; }

        public Termosztat(string azonosito, string nev, double celHomerseklet)
        : base(azonosito, nev)
        {
            CelHomerseklet = celHomerseklet;
            JelenlegiHomerseklet = 21.0;
        }

        public override void ParancsVegrehajtasa(string parancs)
        {
            string[] parancsReszek = parancs.Split(':');
            if ( parancs.Contains("BEALLIT_HOMERSEKLET:") )
            {
                CelHomerseklet = Convert.ToDouble(parancsReszek[1].Replace('.',','));
                Console.WriteLine(CelHomerseklet);
            }
        }

        public override string AllapotJelentes()
        {
            return $"{CelHomerseklet}";
        }

        protected override bool OnTesztFuttatasa()
        {
            if (CelHomerseklet > 5.0 && 35.0 > CelHomerseklet)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IdozitestBeallit(int perc)
        {
            idozito = perc;
            Console.WriteLine($"Fűtés ideje: {idozito} perc");
        }

        public int GetMaradtIdo()
        {
            return idozito;
        }

        public string StatisztikatKeszit()
        {
            return $"Jelenlegi hőmérséklet: {JelenlegiHomerseklet} °C, Célhőmérséklet: {CelHomerseklet} °C, Hátramaradt idő: {idozito} perc";
        }
    }
}
