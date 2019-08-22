using System;
using ConversorBinario;
using Lucchettinni;

namespace Ejercicio_02
{
    class Program
    {
        static void Main()
        {
            string decimalNumberString = null;
            string decimalNumberStringBuilder = null;
            double decimalNumber;
            int index = 0;
            string binaryNumber;

            do
            {
                Console.Write("Ingrese un numero: ");
                decimalNumberString = Console.ReadLine();

                if (LuccheTools.StringValidateOnlyDecimalNumbers(decimalNumberString) == 0)
                {
                    LuccheTools.MessageColoured("\nERROR: Se detectaron caracteres invalidos: por favor utilice NUMEROS.\n\n", ConsoleColor.Red);
                }

            } while (LuccheTools.StringValidateOnlyDecimalNumbers(decimalNumberString) == 0);

            while (index != decimalNumberString.Length)
            {
                if (decimalNumberString[index] == '.')
                {
                    decimalNumberStringBuilder = string.Concat(decimalNumberStringBuilder, ',');
                }
                else
                {
                    decimalNumberStringBuilder = string.Concat(decimalNumberStringBuilder, decimalNumberString[index]);
                }
                index++;
            }


            decimalNumberString = decimalNumberStringBuilder;
            decimalNumber = double.Parse(decimalNumberString);

            binaryNumber = Conversor.DecimalBinario(decimalNumber);
            LuccheTools.MessageColoured("\nConversion satisfactoria!\n\n", ConsoleColor.Green);
            Console.WriteLine("Numero en binario: " + binaryNumber);
            LuccheTools.MessagePause("Presione una tecla para continuar...");
        }
    }
}
