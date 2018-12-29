using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //"int" è un tipo di variabile che ricopre un raggio determinato di numeri interi. ".MaxValue" è servito per mostrare quale è il valore massimo;
            if (a+1<=int.MaxValue)
            {
                Console.WriteLine(a + 1); //Valore massimo del tipo "int" +1, cioè di un'unità più grande di quanto possa contenere;
            }
            int b = -128; //Inizializzo la variabile "b" che ci servirà per la verifica di un numero binario dopo averne ricavato l'opposto;
            int c = -b; //Inizializzo la variabile "c" che sarà l'opposto del valore della variabile "b";
            Console.WriteLine(Convert.ToString(b, 2)); //Stampiamo la variabile "b" in base 2, il cui valore intero in base 10 è -128;
            Console.WriteLine(Convert.ToString(c, 2)); //Stampiamo la variabile "c" in base 2, il cui valore intero in base 10 è 128;
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
