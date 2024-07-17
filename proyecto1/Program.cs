using System.Threading.Channels;
class Program
{
    public static void Main(String[] arg)
    {
        Persona people = new Persona();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Listo...");
        people.Saludo();
        people.Regalo();
    }

}

class Persona
{
    public void Saludo() {
        Console.WriteLine("Wenasss :3");

        Console.WriteLine("EH BUENA A TODOS GUAPISIMOS AQUI Henry");

        Console.WriteLine("Hola, soy Jennifer");
    }

    public void Regalo2()
    {
        Console.WriteLine("UN abrazo");
    }

    public void Regalo() {
        Console.WriteLine("Te he dado un regalo... <3");
    }
}
//listo