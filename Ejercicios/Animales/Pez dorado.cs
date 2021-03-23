using System;

public class PezDorado: Peces
{
    public string Piel { get; set; }

    public void Nada()
    {
        Console.WriteLine("Nadar en pecera");
        Console.WriteLine("");
    }

    public void Mascota()
    {
        SonMascota();
    }

    private void SonMascota()
    {
        Console.WriteLine("Perfectos para ser una linda mascota. ");
        Console.WriteLine("");
    }
}