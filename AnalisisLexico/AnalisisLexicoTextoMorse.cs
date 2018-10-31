using Compilador.Transversal;
using System;

namespace Compilador.AnalisisLexico
{
    class AnalisisLexicoTextoMorse
    {
        private int numeroLineaActual = 0;
        private string contenidoLineaActual;
        private int puntero;
        private string caracterActual;

        private void devolverPuntero()
        {
            puntero--;
        }

        public AnalisisLexicoTextoMorse()
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
                        if ("A".Equals(caracterActual) || "a".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 1;
                        }
                        else if ("B".Equals(caracterActual) || "b".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 2;
                        }
                        else if ("C".Equals(caracterActual) || "c".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 3;
                        }
                        else if ("D".Equals(caracterActual) || "d".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 4;
                        }
                        else if ("E".Equals(caracterActual) || "e".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 5;
                        }
                        else if ("F".Equals(caracterActual) || "f".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 6;
                        }
                        else if ("G".Equals(caracterActual) || "g".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 7;
                        }
                        else if ("H".Equals(caracterActual) || "h".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 8;
                        }
                        else if ("I".Equals(caracterActual) || "i".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 9;
                        }
                        else if ("J".Equals(caracterActual) || "j".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 10;
                        }
                        else if ("K".Equals(caracterActual) || "k".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 11;
                        }
                        else if ("L".Equals(caracterActual) || "l".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 12;
                        }
                        else if ("M".Equals(caracterActual) || "m".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 13;
                        }
                        else if ("N".Equals(caracterActual) || "n".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 14;
                        }
                        else if ("O".Equals(caracterActual) || "o".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 15;
                        }
                        else if ("P".Equals(caracterActual) || "p".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 16;
                        }
                        else if ("Q".Equals(caracterActual) || "q".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 17;
                        }
                        else if ("R".Equals(caracterActual) || "r".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 18;
                        }
                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 20;
                        }
                        else if ("@FL@".Equals(caracterActual))
                        {
                            lexemareserva = lexemareserva + caracterActual;
                            estadoActual = 21;
                        }
                        else if ("S".Equals(caracterActual) || "s".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 22;
                        }
                        else if ("T".Equals(caracterActual) || "t".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 23;
                        }
                        else if ("U".Equals(caracterActual) || "u".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 24;
                        }
                        else if ("V".Equals(caracterActual) || "v".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 25;
                        }
                        else if ("W".Equals(caracterActual) || "w".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 26;
                        }
                        else if ("X".Equals(caracterActual) || "x".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 27;
                        }
                        else if ("Y".Equals(caracterActual) || "y".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 28;
                        }
                        else if ("Z".Equals(caracterActual) || "z".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 29;
                        }
                        else if ("0".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 30;
                        }
                        else if ("1".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 31;
                        }
                        else if ("2".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 32;
                        }
                        else if ("3".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 33;
                        }
                        else if ("4".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 34;
                        }
                        else if ("5".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 35;
                        }
                        else if ("6".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 36;
                        }
                        else if ("7".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 37;
                        }
                        else if ("8".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 38;
                        }
                        else if ("9".Equals(caracterActual))
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 39;
                        }
                        else
                        {
                            lexemareserva = caracterActual;
                            estadoActual = 19;
                        }
                        break;

                    case 1:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 2:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 3:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 4:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 5:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 6:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 7:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 8:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 9:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 10:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 11:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 12:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 13:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 14:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 15:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 16:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 17:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 18:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;

                    case 19:
                        continuarAnalisis = false;
                        Error r = Error.crear(lexemareserva, "LEXICOS", "Caracter no valido.", "Ingrese una letra o un numero.", numeroLineaActual, puntero - lexemareserva.Length, (puntero - 1));
                        ManejadorErrores.obtenerManejadorErrores().reportarError(r);
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "ERROR SINTACTICO", numeroLineaActual, puntero - lexemareserva.Length, (puntero - 1));
                        //TablaSimbolos.ObtenerInstancia().agregar(componente);
                        TablaErrores.ObtenerInstancia().agregar(r);
                        break;

                    case 20:
                        continuarAnalisis = false;
                        estadoActual = 0;
                        lexemareserva = "";
                        lexema="";
                        //Console.WriteLine("FIN DE ARCHIVO");
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "FIN DE ARCHIVO", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 21:
                        // Salto de linea
                        continuarAnalisis = true;
                        estadoActual = 0;
                        lexema = lexema + " ";
                        cargarNuevaLinea();
                        break;
                    case 22:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 23:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;

                    case 24:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 25:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 26:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 27:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 28:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 29:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Letra", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 30:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 31:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 32:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 33:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 34:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 35:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 36:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 37:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 38:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
                        AgregarComponente(componente);
                        break;
                    case 39:
                        //leerSiguienteCaracter();
                        lexema = TablaPalabrasReservadas.ObtenerInstancia().obtenerPalabraReservada(lexemareserva);
                        continuarAnalisis = false;
                        componente = ComponenteLexico.crear(lexemareserva, lexema, "Numero", numeroLineaActual, puntero - lexemareserva.Length, puntero - 1);
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
