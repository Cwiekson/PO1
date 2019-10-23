namespace Bccw2
{
    class Car
    {
         public string marka;
         public int Rokprodukcji;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public Car(string marka, int rokprodukcji)
        {
            this.marka = marka;
            Rokprodukcji = rokprodukcji;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            
            double spalanie = srednieSpalanie * dlugoscTrasy;
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double cenaPaliwa, double dlugoscTras)
        {
          double  kosztPrzejazdu = srednieSpalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }
    }
}
