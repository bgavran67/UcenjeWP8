namespace Ucenje.E14KlasaObjekt
{
    class Automobil
    {
        public int Sifra { get; set; }
        public string Marka { get; set; } = "";

        public bool Automatik { get; set; }

        public DateTime? DatumProizvodnje { get; set; }
        public Decimal Cijena { get; set; }

    }
}