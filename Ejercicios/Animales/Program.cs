using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro b = new Perro();
            Console.WriteLine("*****");
            Console.WriteLine("Perro");
            Console.WriteLine("*****");
            b.Nombre = "Manchas";
            b.Patas = 4;
            b.EsDomestico = true;
            b.Comer();
            b.Caminar();
            b.Ladrar();
            b.Tamano();

            Console.WriteLine(b.Nombre);
            Console.WriteLine(b.Patas);
            

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("****");
            Console.WriteLine("Gato");
            Console.WriteLine("****");
            g.Nombre = "Luck";
            g.Patas = 4;
            g.Pelaje = "Pelo largo, blanco";
            g.Raza = "birmano";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsAmargado = true;

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);
            Console.WriteLine(g.Raza);         

            Console.WriteLine();

            Mono m = new Mono();
            Console.WriteLine("****");
            Console.WriteLine("Mono");
            Console.WriteLine("****");
            m.Nombre = "Manos largas";
            m.Patas = 4;
            m.Orden = "Primates";
            m.Reproduccion = "son viviparo";
            m.Comer();
            m.SonSalvajes = true;
            m.Caminar();
            m.Aullar();

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine(m.Orden);
            Console.WriteLine(m.Reproduccion);

            Console.WriteLine();

            Aguila a = new Aguila();
            Console.WriteLine("******");
            Console.WriteLine("Aguila");
            Console.WriteLine("******");
            a.Nombre = "falcon";
            a.Patas = 2;
            a.Incubacion = 30 ;
            a.ColorPlumaje = "las alas son de color gris oscuro uniforme, presentan parches blancuzcos más cerca de la base";
            a.Volar();
            a.Comer();
            a.Cazadoras();

            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Incubacion);
            Console.WriteLine(a.Patas);
            Console.WriteLine(a.ColorPlumaje);

            Console.WriteLine();

            Loro l = new Loro();
            Console.WriteLine("****");
            Console.WriteLine("Loro");
            Console.WriteLine("****");
            l.Nombre = "pacheca";
            l.Patas = 2;
            l.ColorPlumaje = "Verdoso";
            l.Comer();
            l.Volar();
            l.Hablan();
            l.Pico();

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.ColorPlumaje);

            Console.WriteLine();

            PezGlobo z = new PezGlobo();
            Console.WriteLine("*********");
            Console.WriteLine("Pez Globo");
            Console.WriteLine("*********");
            z.Nombre = "Globito";
            z.Piel = "suelen tener la piel áspera de punta";
            z.NumeroAletas = 2;
            z.Comer();
            z.Nadar();
            z.Color = "Amarillo y verdoso con manchas negras  ";
            z.Venenosa();
            z.Incharse();

            Console.WriteLine(z.Nombre);
            Console.WriteLine(z.NumeroAletas);
            Console.WriteLine(z.Piel);
            Console.WriteLine(z.Color);

            PezDorado n = new PezDorado();
            Console.WriteLine("**********");
            Console.WriteLine("Pez Dorado");
            Console.WriteLine("**********");
            n.Nombre = "Sol";
            n.Piel = "suelen tener la piel lisa";
            n.NumeroAletas = 2;
            n.Comer();
            n.Nadar();
            n.Color = "Dorado completo  ";
            n.Mascota();
            n.Nada();

            Console.WriteLine(n.Nombre);
            Console.WriteLine(n.NumeroAletas);
            Console.WriteLine(n.Piel);
            Console.WriteLine(n.Color);

            }
        }
}