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
        Console.WriteLine("EH BUENA A TODOS GUAPISIMOS AQUI Henry");
    }
}
//listo