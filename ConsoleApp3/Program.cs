namespace ConsoleApp3
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            string nombre;
            string tamano;
            float precio;

            Console.WriteLine("Ingrese el nombre de la bebida 1: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño: ");
            tamano = Console.ReadLine();
            Console.WriteLine("Ingrese el costo: ");
            precio = float.Parse(Console.ReadLine());

            Bebida bebida_n1 = new Bebida(nombre, tamano, precio);
            Console.Clear();

            Console.WriteLine("Ingrese el nombre de la bebida 2: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño: ");
            tamano = Console.ReadLine();
            Console.WriteLine("Ingrese el costo: ");
            precio = float.Parse(Console.ReadLine());

            Bebida bebida_n2 = new Bebida(nombre, tamano, precio);
            Console.Clear();

            Console.WriteLine("Ingrese el nombre de la bebida 3: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño: ");
            tamano = Console.ReadLine();
            Console.WriteLine("Ingrese el costo: ");
            precio = float.Parse(Console.ReadLine());

            Bebida bebida_n3 = new Bebida(nombre, tamano, precio);
            Console.Clear();

            bebida_n1.Descuento(20);
            bebida_n2.Descuento(10);
            bebida_n3.Descuento(0);

            Console.WriteLine("Preparando....");
            Console.WriteLine("\n" + bebida_n1.preparar());
            Console.WriteLine("\n"+bebida_n2.preparar());
            Console.WriteLine("\n"+bebida_n3.preparar());
            


            Console.WriteLine("\n Descripcion del pedido....");
            Console.WriteLine("\n" + bebida_n1.Descripcion());
            Console.WriteLine("\n" + bebida_n2.Descripcion());
            Console.WriteLine("\n" + bebida_n3.Descripcion());
            

        }
    }
}
