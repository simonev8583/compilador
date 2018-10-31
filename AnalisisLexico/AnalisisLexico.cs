using Compilador.Transversal;
using System;

namespace Compilador.AnalisisLexico
{
    public class AnalisisLexico
    {

        private int numeroLineaActual = 0;
        private string contenidoLineaActual;
        private int puntero;
        private string caracterActual;

        private void devolverPuntero()
        {
            puntero --;
        }

        public AnalisisLexico()
        {
            cargarNuevaLinea();
        }

        private void cargarNuevaLinea()
        {
            if (!"@EOF@".Equals(contenidoLineaActual))
            {
                numeroLineaActual++;
                puntero = 1;
                contenidoLineaActual = Archivo.obtenerInstancia().obtenerLinea(numeroLineaActual).contenido;
            }
            else if (contenidoLineaActual == null)
            {
                contenidoLineaActual = Archivo.obtenerInstancia().obtenerLinea(1).contenido;
            }
        }

        private void leerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
                puntero++;
            }
            else if ("/".Equals(contenidoLineaActual))
            {
                caracterActual = "/";
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(((puntero - 1)), 1);
                puntero++;
            }
        }

        public ComponenteLexico devolverComponenteLexico()
        {
            int estadoActual = 0;
            string lexema = "";
            string lexemareserva = "";
            bool continuarAnalisis = true;
            ComponenteLexico componente = null;

            while (continuarAnalisis)
            {
                switch (estadoActual)
                {
                    case 0:
                        leerSiguienteCaracter();
                        while (" ".Equals(caracterActual))
                        {
                            leerSiguienteCaracter();
                        }
                        if (".".Equals(caracterActual))
                        {
                            lexemareserva += caracterActual;
                            //lexema = lexema + caracterActual;
                            estadoActual = 1;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 40;
                        }
                        else if (caracterActual.Equals("/"))
                        {
                            //lexema = lexema + " ";
                            lexemareserva += caracterActual;
                            estadoActual = 78;
                        }
                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 77;
                        }
                        else if ("@FL@".Equals(caracterActual))
                        {
                            //lexema = lexema + caracterActual;
                            estadoActual = 76;
                        }
                        break;
                    case 1:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 2;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 3;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 4;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 2:
                        //leerSiguienteCaracter();
                        lexema = lexema + 'E';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 3:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 5;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 6;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 18;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 4:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 25;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 26;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 27;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 5:
                        leerSiguienteCaracter();
                        lexema = lexema + 'I';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 6:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 7;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 8;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 14;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 7:
                        leerSiguienteCaracter();
                        lexema = lexema + 'S';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 8:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 9;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 10;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 12;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 9:
                        leerSiguienteCaracter();
                        lexema = lexema + 'H';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 10:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 11;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 11:
                        leerSiguienteCaracter();
                        lexema = lexema + '5';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero -1 - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 12:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 13;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 13:
                        leerSiguienteCaracter();
                        lexema = lexema + '4';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 14:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 15;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 39;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 16;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 15:
                        leerSiguienteCaracter();
                        lexema = lexema + 'V';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 16:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 17;
                        }
                        else
                        {
                            estadoActual = 39;
                        }

                        break;
                    case 17:
                        leerSiguienteCaracter();
                        lexema = lexema + '3';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 18:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 19;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 20;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 22;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 19:
                        leerSiguienteCaracter();
                        lexema = lexema + 'U';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 20:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 21;
                        }
                        else
                        {
                            estadoActual = 39;
                        }

                        break;
                    case 21:
                        leerSiguienteCaracter();
                        lexema = lexema + 'F';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 22:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 39;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 39;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 23;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 23:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 24;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 24:
                        leerSiguienteCaracter();
                        lexema = lexema + '2';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 25:
                        leerSiguienteCaracter();
                        lexema = lexema + 'A';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 26:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 28;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 29;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 39;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 27:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 31;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 32;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 33;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 28:
                        leerSiguienteCaracter();
                        lexema = lexema + 'R';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 29:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 30;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 30:
                        leerSiguienteCaracter();
                        lexema = lexema + 'L';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 31:
                        leerSiguienteCaracter();
                        lexema = lexema + 'W';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 32:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 36;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 33:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 37;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 34;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 34:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 35;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 35:
                        leerSiguienteCaracter();
                        lexema = lexema + '1';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 36:
                        leerSiguienteCaracter();
                        lexema = lexema + 'P';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 37:
                        leerSiguienteCaracter();
                        lexema = lexema + 'J';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 38:// el / retorna Lexema
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);

                        leerSiguienteCaracter();
                        break;
                    case 39: // ESTADO DE ERROR
                        devolverPuntero();
                        Error r = Error.crear(lexemareserva, "LEXICOS", "ERROR CADENA", "No se reconoce ninguna letra con la cadena ingresada", numeroLineaActual, puntero - lexemareserva.Length, (puntero - 1));
                        ManejadorErrores.obtenerManejadorErrores().reportarError(r);
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "ERROR SINTACTICO", numeroLineaActual, puntero - lexemareserva.Length, (puntero - 1));
                        //TablaSimbolos.ObtenerInstancia().agregar(componente);
                        TablaErrores.ObtenerInstancia().agregar(r);

                        
                        continuarAnalisis = false;

                        
                        //Console.WriteLine("ERROR");
                        break;
                    case 40:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 41;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 47;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 42;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 41:
                        leerSiguienteCaracter();
                        lexema = lexema + 'T';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 42:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 43;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 49;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 44;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 43:
                        leerSiguienteCaracter();
                        lexema = lexema + 'M';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 44:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 45;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 69;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 46;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 45:
                        leerSiguienteCaracter();
                        lexema = lexema + 'O';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 46:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 70;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 72;
                        }
                        break;
                    case 47:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 48;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 57;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 58;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 48:
                        leerSiguienteCaracter();
                        lexema = lexema + 'N';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 49:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 50;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 51;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 55;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 50:
                        leerSiguienteCaracter();
                        lexema = lexema + 'G';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 51:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 52;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 53;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 39;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 52:
                        leerSiguienteCaracter();
                        lexema = lexema + 'Z';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 53:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 54;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 54:
                        leerSiguienteCaracter();
                        lexema = lexema + '7';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 55:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 56;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 56:
                        leerSiguienteCaracter();
                        lexema = lexema + 'Q';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 57:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 59;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 60;
                        }
                        else if (caracterActual.Equals("-"))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 61;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 58:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 66;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 67;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 59:
                        leerSiguienteCaracter();
                        lexema = lexema + 'D';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 60:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 62;
                        }
                        else if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 63;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 61:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 65;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 62:
                        leerSiguienteCaracter();
                        lexema = lexema + 'B';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 63:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 64;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 64:
                        leerSiguienteCaracter();
                        lexema = lexema + '6';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 65:
                        leerSiguienteCaracter();
                        lexema = lexema + 'X';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 66:
                        leerSiguienteCaracter();
                        lexema = lexema + 'K';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 67:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 68;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 68:
                        leerSiguienteCaracter();
                        lexema = lexema + 'C';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 69:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals("."))
                        {
                            lexemareserva += caracterActual;
                            estadoActual = 74;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 70:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 71;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 71:
                        leerSiguienteCaracter();
                        lexema = lexema + '9';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 72:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 73;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 73:
                        leerSiguienteCaracter();
                        lexema = lexema + '0';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 74:
                        leerSiguienteCaracter();
                        if (caracterActual.Equals(" "))
                        {
                            estadoActual = 75;
                        }
                        else
                        {
                            estadoActual = 39;
                        }
                        break;
                    case 75:
                        leerSiguienteCaracter();
                        lexema = lexema + '8';
                        devolverPuntero();
                        //Console.WriteLine("lexema  "+ lexema+" lexemareserva "+ lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Número", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 76:
                        //Salto de línea
                        continuarAnalisis = true;
                        estadoActual = 0;
                        lexema = lexema + " ";
                        cargarNuevaLinea();
                        break;

                    case 77:
                        //Cargar componente
                        continuarAnalisis = false;
                        estadoActual = 0;
                        //Console.WriteLine("FIN DE ARCHIVO");
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "FIN DE ARCHIVO", numeroLineaActual, puntero- lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 78:
                        continuarAnalisis = true;
                        estadoActual = 0;
                        ////Console.WriteLine("ESPACIO");
                        lexema = lexema + " ";
                        //devolverPuntero();
                        //Console.WriteLine("lexema  " + lexema + " lexemareserva " + lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Espacio", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                }
            }

            return componente;
        }

        private void AgregarComponente(ComponenteLexico componente)
        {
            componente.numeroLinea = numeroLineaActual;
            componente.posicionInicial = puntero - componente.lexema.Length;
            componente.posicionFinal = (puntero - 1);
            TablaSimbolos.ObtenerInstancia().agregar(componente);
        }

        private void agregarError(Error error)
        {
            error.numeroLinea = numeroLineaActual;
            error.posicionInicial = puntero - error.lexema.Length;
            error.posicionFinal = (puntero - 1);
            TablaErrores.ObtenerInstancia().agregar(error);
        }

    }
}