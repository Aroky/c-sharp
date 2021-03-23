using System;

public class PezGlobo: Peces
{
    public string Piel { get; set; }

    public void Incharse()
    {
        Console.WriteLine("Inflarse");
        Console.WriteLine("");
    }

    public void Venenosa()
    {
        SonVenenosa();
    }

    private void SonVenenosa()
    {
        Console.WriteLine("Son venenosos. ");
        Console.WriteLine("");
    }
}