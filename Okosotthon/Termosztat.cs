using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class Termosztat : OkosEszkoz
    {
        private double jelenlegiHomerseklet;
        private double celHomerseklet;

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
            throw new NotImplementedException();
        }

        public override string AllapotJelentes()
        {
            throw new NotImplementedException();
        }

        protected override bool OnTesztFuttatasa()
        {
            throw new NotImplementedException();
        }

    }
}
