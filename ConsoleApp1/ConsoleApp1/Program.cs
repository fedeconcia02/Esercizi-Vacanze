using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //"int" è un tipo di variabile che ricopre un raggio determinato di numeri interi. ".MaxValue" è servito per mostrare quale è il valore massimo;
            Console.WriteLine(a + 1); //Valore massimo del tipo "int" +1, cioè di un'unità più grande di quanto possa contenere;
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1; //NOT;
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
