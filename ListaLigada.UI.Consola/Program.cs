
using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple");
        Console.WriteLine("");

        var singleList = new SingleList<string>();

        singleList.Add("Alomdra");
        singleList.Add("Karla");

        singleList.Add("Juan");
        singleList.Add("Luis");
        singleList.Add("José");
        Console.WriteLine(singleList);

        Console.ReadKey();
    }
}