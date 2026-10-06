namespace Okosotthon
{
    public class Program
    {
        static void Main(string[] args)
        {
            new OkosotthonKozpont();
            Termosztat t = new Termosztat("TH-01", "Nappali Termosztát", 22.0);
            t.ParancsVegrehajtasa("BEALLIT_HOMERSEKLET:50.0");
        }
    }
}
