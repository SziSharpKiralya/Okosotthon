using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class OkosZar: OkosEszkoz
    {
        private bool zartE;
        private string pinKod;

        public bool ZartE { get => zartE; private set => zartE = value; }
        private string PinKod { get => pinKod; set => pinKod = value; }

        public OkosZar(string azonosito, string nev, string pinKod)
        : base(azonosito, nev)
        {
            ZartE = true;
            PinKod = pinKod;
        }

        public override void ParancsVegrehajtasa(string parancs)
        {
            string[] parancsReszek = parancs.Split(':');
            if ( parancs.Contains("NYITAS:") )
            {
                if (parancsReszek[1] == PinKod)
                {
                    ZartE = false;
                }
            }
            if ( parancs.Contains("ZARAS:") ) 
            {
                ZartE = true;
            }
        }


        public override string AllapotJelentes() 
        { 
            if (ZartE) 
            { 
                return "Zárva."; 
            } 
            return "Nyitva."; 
        }

        protected override bool OnTesztFuttatasa()
        {
            return true;
        }

        public override void GyariBeallitasokVisszaallitasa()
        {
            base.GyariBeallitasokVisszaallitasa();
            PinKod = "0000";
            ZartE = true;
        }


    }
}
