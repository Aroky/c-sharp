using System;

public class PezGlobo: Peces
{
    public string Piel { get; set; }

    public void Incharse()
    {
        Console.WriteLine("Inflarse");
    }

    public void Venenosa()
    {
        SonVenenosa();
    }

    private void SonVenenosa()
    {
        Console.WriteLine("Pueden ser venenosos. ");
    }
}