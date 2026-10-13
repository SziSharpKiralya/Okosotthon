using System;
using System.Collections.Generic;
using System.Text;

namespace Okosotthon
{
    public class OkosKozpontiRiaszto: OkosEszkoz, IIdozitheto, IHangjelzo, IStatisztika
    {
        private bool riasztas;
        private int riasztasIdeje;
        private int riasztasokSzama;

        public bool Riasztas { get => riasztas; set => riasztas = value; }
        public int RiasztasIdeje { get => riasztasIdeje; set => riasztasIdeje = value; }
        public int RiasztasokSzama { get => riasztasokSzama; set => riasztasokSzama = value; }

        public OkosKozpontiRiaszto(string azonosito, string nev)
        : base(azonosito, nev)
        {
            Riasztas = false;
            RiasztasIdeje = 5;
            RiasztasokSzama = 0;
        }

        public override void ParancsVegrehajtasa(string parancs)
        {
            if (Riasztas)
            {
                Riasztas = false;
            }

        }

        public override string AllapotJelentes()
        {
            if (Riasztas)
            {
                return "Hangot ad ki.";
            }
            return "Nem ad ki hangot.";
        }

        protected override bool OnTesztFuttatasa()
        {
            return true;
        }

        public override void GyariBeallitasokVisszaallitasa()
        {
            base.GyariBeallitasokVisszaallitasa();
            Riasztas = false;
            RiasztasokSzama = 0;
        }

        public void IdozitestBeallit(int perc)
        {
            RiasztasIdeje = perc;
            Console.WriteLine($"Riasztás ideje: {RiasztasIdeje} perc");
        }

        public int GetMaradtIdo()
        {
            return RiasztasIdeje;
        }

        public void Csipog(int hosszu)
        {
            Console.WriteLine($"*Csipogás {hosszu} másodpercig*");
        }

        public void VeszjelzesInditasa()
        {
            Console.WriteLine("Vészjelzés elindítva");
        }

        public string StatisztikatKeszit()
        {
            return $"{RiasztasokSzama}.";
        }
    }
}
