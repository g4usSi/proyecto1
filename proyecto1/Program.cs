using System.Threading.Channels;
class Program
{
    public static void main(String[] arg)
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
    }
}