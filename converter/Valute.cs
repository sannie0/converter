using System.Collections;

namespace converter;

public class Valute
{
    public Valutes AUD { get; set; }
    public Valutes AZN { get; set; }
    public Valutes GBP { get; set; }
    public Valutes AMD { get; set; }
    public Valutes BYN { get; set; }
    public Valutes BGN { get; set; }
    public Valutes BRL { get; set; }
    public Valutes HUF { get; set; }
    public Valutes VND { get; set; }
    public Valutes HKD { get; set; }
    public Valutes GEL { get; set; }
    public Valutes DKK { get; set; }
    public Valutes AED { get; set; }
    public Valutes EUR { get; set; }
    public Valutes EGP { get; set; }
    public Valutes USD { get; set; }
    public Valutes INR { get; set; }
    public Valutes IDR { get; set; }
    public Valutes KZT { get; set; }
    public Valutes CAD { get; set; }
    public Valutes QAR { get; set; }
    public Valutes KGS { get; set; }
    public Valutes CNY { get; set; }
    public Valutes MDL { get; set; }
    public Valutes NZD { get; set; }
    public Valutes NOK { get; set; }
    public Valutes PLN { get; set; }
    public Valutes RON { get; set; }
    public Valutes XDR { get; set; }
    public Valutes SGD { get; set; }
    public Valutes TJS { get; set; }
    public Valutes THB { get; set; }
    public Valutes TRY { get; set; }
    public Valutes TMT { get; set; }
    public Valutes UZS { get; set; }
    public Valutes UAH { get; set; }
    public Valutes CZK { get; set; }
    public Valutes SEK { get; set; }
    public Valutes CHF { get; set; }
    public Valutes RSD { get; set; }
    public Valutes ZAR { get; set; }
    public Valutes KRW { get; set; }
    public Valutes JPY { get; set; }

    public IEnumerable<Valutes> Items
    {
        get
        {
            yield return USD;
            yield return JPY;
            yield return ZAR;
            yield return KRW;
            yield return RSD;
            yield return CHF;
            yield return SEK;
            yield return CZK;
            yield return UAH;
            yield return UZS;
            yield return TMT;
            yield return TRY;
            yield return THB;
            yield return TJS;
            yield return SGD;
            yield return XDR;
            yield return RON;
            yield return PLN;
            yield return NOK;
            yield return NZD;
            yield return MDL;
            yield return CNY;
            yield return KGS;
            yield return QAR;
            yield return CAD;
            yield return KZT;
            yield return IDR;
            yield return INR;
            yield return EGP;
            yield return EUR;
            yield return DKK;
            yield return GEL;
            yield return HKD;
            yield return VND;
            yield return HUF;
            yield return GBP;
            yield return BRL;
            yield return BYN;
            yield return BGN;
            yield return AED;
            yield return AUD;
            yield return AMD;
            yield return AZN;
        }
    }
}
