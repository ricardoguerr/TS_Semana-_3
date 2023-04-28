using TS_SEMANA_13;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TRABAJO SUPERVISADO SEMANA 13 RICARDO GUERRA 1234123");
        Persona persona = new Persona();
        persona.CrearPersona("Ricardo", "Guerra", 17, 1.66);
        persona.MostrarDatos();

        Console.ReadKey();
    }

}
