namespace converter;

public class Root
{
    public string error { get; set; }
    public int code { get; set; }
    public string explanation { get; set; }
    public DateTime Date { get; set; }
    public DateTime PreviousDate { get; set; }
    public string PreviousURL { get; set; }
    public DateTime Timestamp { get; set; }
    public Valute Valute { get; set; }
}