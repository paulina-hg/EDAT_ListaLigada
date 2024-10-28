
using ListaLigada.Logica;
using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple");
        Console.WriteLine("");

        var singleList = new SingleList<string>();

        int opcion = 0;
        do
        {
            opcion = Menu();

            switch (opcion) 
            {
                case 1: AgregarElemento();  break;
                case 2: MostrarLista();  break;
                case 0: break;
                    default: Console.WriteLine("Esta opción no existe"); break;
            }
        }
        while (opcion != 0);


        void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo\n");
            var data = Console.ReadLine();
            singleList.Add(data);

        }

        void MostrarLista() 
        {
            Console.WriteLine("La lista es:\n");
            Console.WriteLine(singleList);
        }

        Console.ReadKey();
    } //TERMINA EL MAIN 

   

    private static int Menu()
    {
        Console.WriteLine("\nMenu\n");
        Console.WriteLine("1. Agregar elemnto");
        Console.WriteLine("2. Mostrar lista");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;

        int opcion = 0;
        do
        {
            Console.Write("Elige una opción del menú:   ");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Digite una opción valida");
                esValido = false;
            }
            else 
            {
                esValido = true;
            }
        }
        while (esValido == false);

        return opcion;
    }
}