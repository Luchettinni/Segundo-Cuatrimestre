using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LT = LuccheTools;


namespace LuccheTools_Utility
{
    class Utility
    {
        static void Main(string[] args)
        {
            string[] opciones = { "1) Manual", "2) Testing ", "3) Salir", };
            string[] manualOptions = { "1) ConsoleTools", "2) SortingTools ", "3) ValidationTools", };
            string inputAwait = "Ingrese el numero de la opcion que desea ejecutar: ";
            string image = "|osy+-.+ss/.`          `:++hdMMs/++os//+o++...-:+.`  -. `.  `|/`-   ``.--.```. ``/shNMMMMMMMNNNNNNMNh+```  `...:.     -:--|:o/-`..:/so+:`    sNMMMMMMNNMNNNNNNNNNNNmy+:o/+o++-        `|`              `.sMMMMMMMNNNNNNNNNNNNNNNNNMh+`    ......-odm|y::+o/.`.//.`./yyMMMMMMMMNNNNNNNNNNNNNNNMMMMMN/-:+o/..`.+/+s|hyymd+/ohhhsysssmMMMMMMMNNNNNNNNNNNNNNNNNNNMMN/-+//o++:+hmdh|NNNNmmNmdmmhhyydNMMMMMMMNNNNNNNNNNNNNNNNNNNNMNdhmNNNMMMNNmNN|+dyyyhhyhhhhyyhMMMMMMMMMNNNNNNNNNNNNNNNNNNNNNMhy+oshhydyoo++|NNMmdhysoyhsosmMMMmyyyyyyyyy+++++++++oMNNNNNNMNs/.--...```  |yyyyyyyhhmNmmmNMMMd/////////`        -MNNNNNNNd     `  `` ``|mdNmmdddmmmNyohMMMd////////:         -MNNNNNNNd`--`-..-.:..`|MMMMmNNNdddmmhdMMMd////////-         -MNNNNMMNmo:---..--```.|NNdhddmNNNNmhdNdhMd+++++///-     ````-MNNNNNsdN+-`.`````  ``|mNmdmMMMMMMMNmNmymddMMMNmh+-  /hdMMMN/MNNNNN/so:.`.. ``     |NMMMMMMMMMMNo-oMNmdyNMN0MMy-  MMM0MMs:MNNNMy++:``--:::--.-..|MMMMMNMNNNMMMNmMhmd///ssss/-  .:::`  -MMMMhydmhhdmmNNyhmddyy|NNNNNmdddmmdNmdNMMd+hs/////-      `o:-MhNsoooo/+::/os+/-.-/:|NdyhyhdNNMMMMMMmdNd+ys/////-      `+--M:.`` `:.  ````` `````|mmNNMNNmhsss/-.:/Md+///////-         :Md.     ````..--:.``  |dyss/-..::--.` +NMMmho/////:      `/yNNNN:``   ``..``..::///|```.:+:++--``.yMMMMMMMNyo///.  `:hNMMMmNMNssso+ossshsyNMNmhh|:.``   ```  .+hhydMMMMmNNmh+-:yysMMMNmNdms+:+sys+yshmmho````|```` ``....hMNmMMNNNNMhdmmmNy+:--yNdmmdhNMNhddmmss+:/+s+++/o|.-//:.````-MNNMNNMNNMmyydhyh:----oMmmmmhmMmNMNddNNmmmmdmdddm|/:``..``./mMNNNNNNNmMmyyhmyy-----oNmNmNmNmdmNMNh+`-:/osNNNmM|//++yhddddMMMNNNNmNNNMdyhmyy-----dmmmNNdymdhMNhy`  /NmmNMhdm|/ymNNhdmmMMMMNMMMNmNMNNNhmyy----/MhhdmhdmmNNNMMMs/.:hyss+ +d|ydNdddNMNNNNMMNNNNdoNNNNNhyy---/NddmmdhNNMmdhNmhmmMhhh:``  .|mNmNNMNNNNMMNNNMMM.:MNNNMNhs:-sNdNNNh-yNNmdNNdmmmmddmmmNmo  |NNMMMMMMNNNMNNNNNo.hNNNMNMMhohNmdmdmm+.sdhmmNmdNdmmdNhydNN- ";

            LuccheLogo(image, 61);
            LT.ConsoleTools.PausaConMensaje("");

            switch ( LT.ConsoleTools.GenericMenu(" LuccheTools Utility App ", " Main Menu ", opciones, inputAwait) )
            {
                case 1:
                    {
                        LT.ConsoleTools.GenericMenu("LuccheTools Utility App", "./Manual", manualOptions, inputAwait);
                        break;
                    }

                case 2:
                    {
                        break;
                    }

                case 3:
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        public static void LuccheLogo(string asciiImage, int maxWidth)
        {
            int contador = maxWidth;
            int contadorDebug = 0;

            for (int i = 0; i < asciiImage.Length; i++)
            {
                if (contador == maxWidth)
                {
                    if (contadorDebug == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ////       LUCCHETOOLS UTILITY APPLICATION      ////");
                    }
                    else if (contadorDebug == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("                -Powered by Luchettinni-              ");
                    }
                    else if (contadorDebug == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("                   ( Version");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" 0.0.0 ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(")");
                    }
                    else if (contadorDebug == 25)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("            Presione una tecla para continuar...     ");
                    }

                    contadorDebug++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.Write("\n{0}", contadorDebug.ToString().PadLeft(3, '0'));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    contador = 0;
                }

                Console.Write(asciiImage[i]);


                contador++;

            }

            Console.ResetColor();
        }
    }
}
