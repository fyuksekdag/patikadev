public abstract class Otomobil
{
    public int TekerlekSayisi(){
        return 4;
    }

    public virtual Renkler RengiNe()
    {
        return Renkler.Beyaz;
    }

    public abstract Markalar MarkasıNe();
}