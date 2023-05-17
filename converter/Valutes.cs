namespace converter;

public class Valutes
{
    public string ID { get; set; }
    public string NumCode { get; set; }
    public string CharCode { get; set; }
    public int Nominal { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }
    public double Previous { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

