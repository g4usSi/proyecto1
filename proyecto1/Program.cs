using System.Threading.Channels;
class Program
{
    public static void Main(String[] arg)
    {
        Persona people = new Persona();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Listo...");
        people.Saludo();
        people.Regalo2();
        people.RechazoDeRegalo();

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

    public void RechazoDeRegalo()
    {
        Console.WriteLine("rechazo tu UN abrazo");
    }
}
//listo