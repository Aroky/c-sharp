using System;
public class Perro: Mamifero 
{
    public bool EsDomestico { get; set; }

    public Perro() 
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() 
    {
        Console.WriteLine("Gua gua gua");
    }

    public void Tamano()
    {
       DescribirTamano();
    }

    private void DescribirTamano()
    {
        Console.WriteLine(" 65cm es grande");

    }

}