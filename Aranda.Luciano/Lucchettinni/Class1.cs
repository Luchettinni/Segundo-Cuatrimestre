using System;

namespace Lucchettinni
{
    public class LuccheTools
    {
        // MESSAGES -----------------------------------------------------------------------------------------------------------------------------------------------------
        // herramientras
        public static void MessagePause(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.Write("\n" + message);

            Console.ResetColor();

            Console.ReadKey(true);
        }

        public static void MessagePause(string message)
        {
            Console.Write("\n" + message);

            Console.ReadKey(true);
        }

        // VALIDATION ---------------------------------------------------------------------------------------------------------------------------------------------------
        // Valida si en un string existe por lo menos un caracter especificado (puede contener otros caracteres no especificados) si encuentra el especificado retorna "1", si no "0"

        public static void MessageColoured(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        public static int StringValidateNumbersOrLettersOrSymbols(string str)
        {
            int index = 0;
            int containsNumbersOrLettersOrSymbols = 0;

            while (index != str.Length)
            {
                if (str[index] >= 33 && str[index] <= 127)
                {
                    containsNumbersOrLettersOrSymbols = 1;
                    break;
                }
                index++;
            }

            return containsNumbersOrLettersOrSymbols;
        }

        public static int StringValidateNumbers(string str)
        {
            int index = 0;
            int containsNumbers = 0;

            while (index != str.Length)
            {
                if (str[index] > 48 && str[index] <= 57)
                {

                    containsNumbers = 1;
                    break;
                }
                index++;
            }

            return containsNumbers;
        }

        public static int StringValidateLettersLower(string str)
        {
            int index = 0;
            int containsLettersLower = 0;

            while (index != str.Length)
            {
                if (str[index] >= 97 && str[index] <= 122)
                {
                    containsLettersLower = 1;
                    break;
                }
                index++;
            }

            return containsLettersLower;
        }

        public static int StringValidateLettersUpper(string str)
        {
            int index = 0;
            int containsLettersUpper = 0;

            while (index != str.Length)
            {
                if (str[index] >= 65 && str[index] <= 90)
                {
                    containsLettersUpper = 1;
                    break;
                }
                index++;
            }

            return containsLettersUpper;
        }

        public static int StringValidateLetters(string str)
        {
            int index = 0;
            int containsLetters = 0;

            while (index != str.Length)
            {
                if ((str[index] >= 65 && str[index] <= 90) || (str[index] >= 97 && str[index] <= 122))
                {
                    containsLetters = 1;
                    break;
                }
                index++;
            }

            return containsLetters;
        }

        public static int StringValidateLettersOrSimbols(string str)
        {
            int index = 0;
            int containsLetters = 0;

            while (index != str.Length)
            {
                if ((str[index] >= 65 && str[index] <= 90) || (str[index] >= 97 && str[index] <= 122))
                {
                    containsLetters = 1;
                    break;
                }
                index++;
            }

            return containsLetters;
        }

        public static int StringValidateCustom1Dimetion(string str, int min, int max)
        {
            int index = 0;
            int containsCustom = 0;

            while (index != str.Length)
            {
                if (str[index] >= min && str[index] <= max)
                {
                    containsCustom = 1;
                    break;
                }
            }

            return containsCustom;
        }

        public static int StringValidateCustom2Dimetions(string str, int min, int max, int min2, int max2)
        {
            int index = 0;
            int containsCustom = 0;

            while (index != str.Length)
            {
                if ((str[index] >= min && str[index] <= max) || (str[index] >= min2 && str[index] <= max2))
                {
                    containsCustom = 1;
                    break;
                }
                index++;
            }

            return containsCustom;
        }

        // VALIDATION ONLY ----------------------------------------------------------------------------------------------------------------------------------------------
        // Valida si en un string existe sola y exclusivamente los caracteres especificados, si encuentra un caracter no especificado retorna "0", si no "1"

        public static int StringValidateOnlyNumbers(string str)
        {
            int index = 0;
            int containsNumbers = 0;

            while (index != str.Length)
            {
                if (str[index] >= 48 && str[index] <= 57 )
                {

                    containsNumbers = 1;
                }
                else
                {
                    containsNumbers = 0;
                    break;
                }
                index++;
            }

            return containsNumbers;
        }

        public static int StringValidateOnlyDecimalNumbers(string str)
        {
            int index = 0;
            int containsNumbers = 0;

            while (index != str.Length)
            {
                if ( (str[index] >= 48 && str[index] <= 57) || str[index] == 46 || str[index] == 44)
                {

                    containsNumbers = 1;
                }
                else
                {
                    containsNumbers = 0;
                    break;
                }
                index++;
            }

            return containsNumbers;
        }
    }
}
