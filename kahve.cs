namespace KahveAsistani
{
    public abstract class Kahve
    {
        public string Ad { get; set; }
        public string Icindekiler { get; set; }
        public int DemlemeSuresiSaniye { get; set; }
        public double Fiyat { get; set; }

        public abstract void ReceteGoster(); 
    }
}