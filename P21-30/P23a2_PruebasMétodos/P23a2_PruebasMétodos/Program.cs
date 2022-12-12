using System;

class PruebasMetodosPosicion
{
    static void Main(string[] args)
    {
        #region--- No tocar este código -------
        for (int f = 10; f < 20; f++)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, f);
            Console.Write("{0}                                                                              ", f);
            Console.ResetColor();
            
            
        }
        #endregion

        //----- Escribe a partir de esta línea tu código de prueba -------
        Print("Pulsa para seguir",true,14);

        Console.Write("\n\n\n\t\tPulsa una tecla para salir:");
        Console.ReadKey();
    }

    // Escribe aquí el método
    static void LimpiaFila(int fila)
    {
        Console.SetCursorPosition(0, fila);
        Console.Write("                                                                                    ");
        Console.SetCursorPosition(0, fila);
         
    }
    static void Pausa(string txt,int fila)
    {
        Console.SetCursorPosition(0, fila);
        Console.Write("                                                                                    ");
        Console.SetCursorPosition(0, fila);                                                                       
        Console.Write("Pulsa una tecla para {0}", txt);
        Console.ReadKey();
        Console.SetCursorPosition(0, fila);
        Console.Write("                                                                                    ");
    }
    static void Print(string txt,bool conReadKey,int fila)
    {
        Console.SetCursorPosition(0, fila);
        Console.Write("                                                                                    ");
        Console.SetCursorPosition(0, fila);
        Console.Write(txt);
        if (conReadKey) {
            Console.ReadKey();
        }
    }
}

