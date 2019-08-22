using System;

namespace ConversorBinario
{
    public class Conversor
    {
        public static string DecimalBinario(double dec)
        {
            string binCat;
            string bin = null;

            string decString = dec.ToString();
            string intPartString = null;
            string decPartString = null;
            int indice = 0;

            int intPart = 0;
            double decPart = 0;

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

            // con esto busco la parte "entera" del decimal. discriminando todo numero despues de la coma, incluyendo a la anterior.
            while (indice != decString.Length)
            {
                // si encuentro la coma, me voy del loop
                if (decString[indice] == ',')
                {
                    break;
                }

                intPartString = string.Concat(intPartString, decString[indice]);
                indice++;
            }

            // a partir de este punto, el indice esta parado en la "coma" del numero. por lo cual solo resta guardar el contenido decimal (incluyendo la coma) en una variable
            // en caso de que no exista parte decimal, se contemplara mas adelante...
            while (indice != decString.Length)
            {
                decPartString = string.Concat(decPartString, decString[indice]);
                indice++;
            }

            // mensaje para debugear y confirmar si lo anterior funciono correctamente
            //Console.WriteLine("\nNumero ingresado: " + intPartString + "," + decPartString );

            // ahora guardamos la parte entera en una variable para poder realizar la conversion.
            intPart = int.Parse(intPartString);

            // CONVERSION PARTE ENTERA A BINARIO
            while (intPart != 0)
            {
                binCat = Convert.ToString(intPart % 2);
                /* el resto de esta division siempre es 0 o 1, es lo que genera nuestro numero binario (parte entera)
                   obviamente, esta division por algun motivo el cual no entiendo ni pienso cuestionar, genera el numero binario AL REVES
                   (BIN, es el numero binario COMPLETO (parte entera y decimal) a retornar) por lo tanto, cuando agrego los resultados de 
                   "binToCat" a "Bin" tuve como resultado el numero binario correcto de la parte entera, pero invertido.
                   La solucion a este problema es no concatenarle a bin los numeros de bincat, si no al reves: */
                bin = string.Concat(binCat, bin);
                intPart = intPart / 2;
            }

            // si intpart era cero, no realizo ninguno de las cuentas de arriba, por lo tanto BIN, al ser el numero final a retornar, hay que avisarle que su parte entera es cero
            if (intPart == 0)
            {
                bin = string.Concat("0", bin);
            }

            // por supuesto, cuando separamos el numero en 2 partes (entera y decimal) la segunda parte aun sigue estando como "entera".
            // para correjir esto, vamos a concatenarle un cero al inicio de la cadena, quedando asi "0" + ",00000" = "0,00000"
            // y esto nos va a servir para poder trabajar correctamente con la conversion binaria:

            // pero antes hay que asegurarnos que EXISTE este parte decimal.
            if (decPartString != null)
            {
                decPartString = string.Concat("0", decPartString);

                // por ultimo, este string, parte decimal, se la vamos a guardar a una variable flotante para poder realizar los calculos
                // necesarios para el pasaje binario:
                decPart = double.Parse(decPartString);

                // ya que terminamos la parte entera y la parte decimal si existe, ahora sigue agregarle un punto al numero final, ya que cuando se haga la conversion
                // binaria de la parte decimal, vamos a tener que añadirla al numero guardado en "bin" que contiene la parte entera exclusivamente
                // y para separar la parte entera de la binaria, vamos a tener que hacerlo de forma manual con esto: 
                bin = string.Concat(bin, ".");
            }

            // CONVERSION PARTE DECIMAL A BINARIO
            while (decPart != 1 && decPart != 0)
            {
                decPart = decPart * 2;
                if (decPart > 1)
                {
                    decPart += -1;
                    bin = string.Concat(bin, "1");
                }
                else if (decPart == 1)
                {
                    bin = string.Concat(bin, "1");
                }
                else
                {
                    bin = string.Concat(bin, "0");
                }

            }

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------

            // por ultimo retornamos el numero bonito que nos quedo :3
            return bin;
        }
    }
}
