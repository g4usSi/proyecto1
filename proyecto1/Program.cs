using System.Threading.Channels;
class Program
{
    public static void Main(String[] arg)
    {
        Persona people = new Persona();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Listo...");
        people.Saludo();

    }

}

class Persona
{
    public void Saludo() {
        Console.WriteLine("Wenasss :3");
        Console.WriteLine("Hola, soy Jennifer");
    }

    public void Regalo2()
    {
        Console.WriteLine("UN abrazo");
    }
}
//listo