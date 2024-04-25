using Mi_Primer_OOP;
using System.Drawing;
using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        //Declaración de variables
        int day, month, year;

        //pedir datos por pantalla
        Console.Write("Ingrese el día: ");
        day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el mes: ");
        month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el año: ");
        year = Convert.ToInt32(Console.ReadLine());

        //Crear instancia del objeto Date
        Date date = new Date(day, month, year);

        string myDate = date.ShowDate(); //Esta es la forma de acceder a las propiedas/métodos de una clase

        Console.WriteLine(myDate);
        Console.WriteLine(date.ShowDate());
    }
}