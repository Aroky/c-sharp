using System;

public class PezDorado: Peces
{
    public string Piel { get; set; }

    public void Nada()
    {
        Console.WriteLine("Nadar en pecera");
    }

    public void Mascota()
    {
        SonMascota();
    }

    private void SonMascota()
    {
        Console.WriteLine("Perfectos para ser una linda mascota. ");
    }
}