using _22023_UCO_Compilador22023.Cache;
using _22023_UCO_Compilador22023.Gestor_Errores;
using _22023_UCO_Compilador22023.TablaComponentes;
using _22023_UCO_Compilador22023.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int numeroLineaActual = 0;
        private string contenidoLineaActual = "";
        private int puntero = 0;
        private string caracterActual;
        private string lexema = "";
        private CategoriaGramatical categoria;
        private string estadoActual = "";
        private int posicionInicial = 0;
        //private int posicionFinal = 0;
        private bool continuarAnalisis = false;
        private ComponenteLexico componente = null;
        private string falla = "";
        private string causa = "";
        private string solucion = "";



        public AnalizadorLexico()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            if (!"@EOF@".Equals(contenidoLineaActual))
            {
                numeroLineaActual += 1;
                contenidoLineaActual = DataCache.ObtenerLinea(numeroLineaActual).Contenido;
                numeroLineaActual = DataCache.ObtenerLinea(numeroLineaActual).NumeroLinea;
                puntero = 1;
            }


        }
        private void LeerSiguienteCaracter()
        {
            if ("@EOF@".Equals(contenidoLineaActual))
            {
                caracterActual = "@EOF@";
            }
            else if (puntero > contenidoLineaActual.Length)
            {
                caracterActual = "@FL@";
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(puntero - 1, 1);
                puntero += 1;
            }
        }
        private void DevolverPuntero()
        {
            if (!"@FL@".Equals(caracterActual))
            {
                puntero = puntero - 1;
            } 
        }
        private void Concatenar()
        {
            lexema = lexema + caracterActual;
        }
        private void Resetear()
        {
            estadoActual = "q0";
            lexema = "";
            categoria = CategoriaGramatical.DEFAULT;
            posicionInicial = 0;
            //posicionFinal = 0;
            caracterActual = "";
            continuarAnalisis = true;
            componente = null;
            falla = "";
            causa = "";
            solucion = "";
        }
        public ComponenteLexico DevolverSiguienteComponente()
        {
            Resetear();
            while (continuarAnalisis)
            {
                if ("q0".Equals(estadoActual))
                {
                    ProcesarEstado0();
                }
                else if ("q1".Equals(estadoActual))
                {
                    ProcesarEstado1();
                }
                else if ("q2".Equals(estadoActual))
                {
                    ProcesarEstado2();
                }
                else if ("q3".Equals(estadoActual))
                {
                    ProcesarEstado3();
                }
                else if ("q4".Equals(estadoActual))
                {
                    ProcesarEstado4();
                }
                else if ("q5".Equals(estadoActual))
                {
                    ProcesarEstado5();
                }
                else if ("q6".Equals(estadoActual))
                {
                    ProcesarEstado6();
                }
                else if ("q7".Equals(estadoActual))
                {
                    ProcesarEstado7();
                }
                else if ("q8".Equals(estadoActual))
                {
                    ProcesarEstado8();
                }
                else if ("q9".Equals(estadoActual))
                {
                    ProcesarEstado9();
                }
                else if ("q10".Equals(estadoActual))
                {
                    ProcesarEstado10();
                }
                else if ("q11".Equals(estadoActual))
                {
                    ProcesarEstado11();
                }
                else if ("q12".Equals(estadoActual))
                {
                    ProcesarEstado12();
                }
                else if ("q13".Equals(estadoActual))
                {
                    ProcesarEstado13();
                }
                else if ("q14".Equals(estadoActual))
                {
                    ProcesarEstado14();
                }
                else if ("q15".Equals(estadoActual))
                {
                    ProcesarEstado15();
                }
                else if ("q16".Equals(estadoActual))
                {
                    ProcesarEstado16();
                }
                else if ("q17".Equals(estadoActual))
                {
                    ProcesarEstado17();
                }
                else if ("q19".Equals(estadoActual))
                {
                    ProcesarEstado19();
                }
                else if ("q20".Equals(estadoActual))
                {
                    ProcesarEstado20();
                }
                else if ("q21".Equals(estadoActual))
                {
                    ProcesarEstado21();
                }
                else if ("q22".Equals(estadoActual))
                {
                    ProcesarEstado22();
                }
                else if ("q23".Equals(estadoActual))
                {
                    ProcesarEstado23();
                }
                else if ("q24".Equals(estadoActual))
                {
                    ProcesarEstado24();
                }
                else if ("q25".Equals(estadoActual))
                {
                    ProcesarEstado25();
                }
                else if ("q26".Equals(estadoActual))
                {
                    ProcesarEstado26();
                }
                else if ("q27".Equals(estadoActual))
                {
                    ProcesarEstado27();
                }
                else if ("q28".Equals(estadoActual))
                {
                    ProcesarEstado28();
                }
                else if ("q29".Equals(estadoActual))
                {
                    ProcesarEstado29();
                }
                else if ("q30".Equals(estadoActual))
                {
                    ProcesarEstado30();
                }
                else if ("q31".Equals(estadoActual))
                {
                    ProcesarEstado31();
                }
                else if ("q32".Equals(estadoActual))
                {
                    ProcesarEstado32();
                }
                else if ("q33".Equals(estadoActual))
                {
                    ProcesarEstado33();
                }
                else if ("q34".Equals(estadoActual))
                {
                    ProcesarEstado34();
                }
                else if ("q35".Equals(estadoActual))
                {
                    ProcesarEstado35();
                }
                else if ("q36".Equals(estadoActual))
                {
                    ProcesarEstado36();
                }
                else
                {
                    ProcesarEstado18();
                }

            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
             return componente;
            
        }

        private void DevorarEspaciosBlanco()
        {
            while ("".Equals(caracterActual.Trim()) || caracterActual.Equals("\t") || caracterActual.Equals(" "))
            {
                LeerSiguienteCaracter();
            }
        }

        private void ProcesarEstado0()
        {
            
            DevorarEspaciosBlanco();
            if (UtilTexto.EsLetra(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSingoPesos(caracterActual))
            {
                estadoActual = "q4";
            }
            else if (UtilTexto.EsDigito(caracterActual))
            {
                estadoActual = "q1";
            }
            else if (UtilTexto.EsSuma(caracterActual))
            {
                estadoActual = "q5";
            }
            else if (UtilTexto.EsResta(caracterActual))
            {
                estadoActual = "q6";
            }
            else if (UtilTexto.EsProducto(caracterActual))
            {
                estadoActual = "q7";
            }
            else if (UtilTexto.EsBarraInclinada(caracterActual))
            {
                estadoActual = "q8";
            }
            else if (UtilTexto.EsPorcentaje(caracterActual))
            {
                estadoActual = "q9";
            }
            else if (UtilTexto.EsParentesisAbre(caracterActual))
            {
                estadoActual = "q10";
            }
            else if (UtilTexto.EsParentesisCierra(caracterActual))
            {
                estadoActual = "q11";
            }
            else if (UtilTexto.EsFinArchivo(caracterActual))
            {
                estadoActual = "q12";
            }
            else if (UtilTexto.EsIgual(caracterActual))
            {
                estadoActual = "q19";
            }
            else if (UtilTexto.EsMenorQue(caracterActual))
            {
                estadoActual = "q20";
            }
            else if (UtilTexto.EsMayorQue(caracterActual))
            {
                estadoActual = "q21";
            }
            else if (UtilTexto.EsDosPuntos(caracterActual))
            {
                estadoActual = "q22";
            }
            else if (UtilTexto.EsExclamacion(caracterActual))
            {
                estadoActual = "q30";
            }
            else if (UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q13";
            }
            else
            {
                estadoActual = "q18";
            }
            TablaMaestra.ObtenerTablaMaestra().Agregar(componente);
            //return componente;

        }
        private void ProcesarEstado1()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito(estadoActual))
            {
                estadoActual = "q1";
            }
            else if(UtilTexto.EsComa(estadoActual))
            {
                estadoActual = "q2";
            }else
            {
                estadoActual = "q14";
            }
        }

        
        private void ProcesarEstado2()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito(estadoActual))
            {
                estadoActual = "q3";
            }
            else
            {
                estadoActual = "q17";
            }

        }
        private void ProcesarEstado3()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsDigito(caracterActual)){
                estadoActual = "q3";
            }
            else
            {
                estadoActual = "q15";
            }
        }
        private void ProcesarEstado4()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsLetra(caracterActual) || UtilTexto.EsGuionBajo(caracterActual) || UtilTexto.EsSingoPesos(caracterActual) || UtilTexto.EsDigito(caracterActual))
            {
                estadoActual = "q4";
            }
            else
            {
                estadoActual = "q16";
            }

        }
        private void ProcesarEstado5()
        {
            categoria = CategoriaGramatical.SUMA;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado6()
        {
           categoria = CategoriaGramatical.RESTA;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado7()
        {
           categoria = CategoriaGramatical.MULTIPLICACION;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado8()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsProducto(caracterActual))
            {
                estadoActual = "q34";
            }
            else if (UtilTexto.EsBarraInclinada(caracterActual))
            {
                estadoActual = "q36";
            }
            else
            {
                estadoActual = "q33";
            }
        }
        private void ProcesarEstado9()
        {
            categoria = CategoriaGramatical.MODULO;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado10()
        {
            categoria = CategoriaGramatical.PARENTESIS_ABRE;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado11()
        {
            categoria = CategoriaGramatical.PARENTESISI_CIERRA;
            Concatenar();
            LeerSiguienteCaracter();
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado12() 
        {
            categoria = CategoriaGramatical.FIN_ARCHIVO;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado13()
        {
            CargarNuevaLinea();
            Resetear(); 
        }
        private void ProcesarEstado14()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.NUMERO_ENTERO;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;

        }
        private void ProcesarEstado15()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.NUMERO_DECIMAL;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }

        private void ProcesarEstado16()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.IDENTIFICADOR;
            FormarComponenteLexicoSimbolo();
            continuarAnalisis = false;

        }
        private void ProcesarEstado17()
        {
            DevolverPuntero();
            falla = "Numero Decimal NO valido...";
            causa = "Se recibio luego del separador decimal el simbolo "+ caracterActual;
            solucion = "Asegurese que en la posicion esperada se encuentre un digito para formar un numero decimal valido";
            ReportarErrorLexicoRecuperable();

            caracterActual = "0";
            Concatenar();
            categoria = CategoriaGramatical.NUMERO_DECIMAL;
            FormarComponenteLexicoDummy();
            //throw new Exception("Numero decimal no valido");
            continuarAnalisis = false;
        }
        private void ProcesarEstado18()
        {
            //SIMBOLO NO VALIDO
            DevolverPuntero();
            falla = "Simbolo NO valido...";
            causa = "Se recibio un simbolo no reconosido por el lenguaje" + caracterActual;
            solucion = "Asegurese que en la posicion esperada se encuentre un Simboo valido reconocido por el lenguaje...";
            ReportarErrorLexicoStopper();
        }
        private void ProcesarEstado19()
        {
            Concatenar();
            categoria = CategoriaGramatical.IGUAL_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado20()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsMayorQue(caracterActual))
            {
                estadoActual = "q23";
            }
            else if (UtilTexto.EsIgual(caracterActual))
            {
                estadoActual = "q24";
            }
            else
            {
                estadoActual = "q25";
            }
        }
        private void ProcesarEstado21()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsIgual(caracterActual))
            {
                estadoActual = "q26";
            }
            else
            {
                estadoActual = "q27";
            }
        }
        private void ProcesarEstado22()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsIgual(caracterActual))
            {
                estadoActual = "q28";
            }
            else
            {
                estadoActual = "q29";
            }
        }
        private void ProcesarEstado23()
        {
            Concatenar();
            LeerSiguienteCaracter();
            categoria = CategoriaGramatical.DIFERENTE_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado24()
        {
            Concatenar();
            LeerSiguienteCaracter();
            categoria = CategoriaGramatical.MENOR_IGUAL_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado25()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.MENOR_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado26()
        {
            Concatenar();
            LeerSiguienteCaracter();
            categoria = CategoriaGramatical.MAYOT_IGUAL_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado27()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.MAYOR_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado28()
        {
            Concatenar();
            LeerSiguienteCaracter();
            categoria = CategoriaGramatical.ASIGANACION;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado29()
        {
            categoria = CategoriaGramatical.NO_DEFINIDA;
            //FormarComponenteLexico();
            throw new Exception("Asignacion no valida");
        }
        private void ProcesarEstado30()
        {
            Concatenar();
            LeerSiguienteCaracter();
            if (UtilTexto.EsIgual(caracterActual))
            {
                estadoActual = "q31";
            }
            else
            {
                estadoActual = "q32";
            }
        }
        private void ProcesarEstado31()
        {
            Concatenar();
            LeerSiguienteCaracter();
            categoria = CategoriaGramatical.DIFERENTE_QUE;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;
        }
        private void ProcesarEstado32()
        {
            categoria = CategoriaGramatical.NO_DEFINIDA;
            //FormarComponenteLexico();
            throw new Exception("Asignacion no valida");
        }
        private void ProcesarEstado33()
        {
            DevolverPuntero();
            categoria = CategoriaGramatical.DIVISION;
            FormarComponenteLexicoLiteral();
            continuarAnalisis = false;

        }
        private void ProcesarEstado34()
        {
            lexema = "";
            if (UtilTexto.EsProducto(caracterActual))
            {
                estadoActual = "q35";
            }
            else
            {
                estadoActual = "q34";
            }
        }
        private void ProcesarEstado35()
        {
            LeerSiguienteCaracter();
            if (UtilTexto.EsProducto(caracterActual))
            {
                estadoActual = "q35";
            }
            else if (UtilTexto.EsBarraInclinada(caracterActual))
            {
                lexema = "";
                estadoActual = "q0";
            }
            else
            {
                estadoActual = "q34";
            }
        }
        private void ProcesarEstado36()
        {
            lexema = "";
            LeerSiguienteCaracter();
            if (!UtilTexto.EsFinLinea(caracterActual))
            {
                estadoActual = "q36";
            }
            else
            {
                estadoActual = "q13";
            }
        }


        private void FormarComponenteLexicoSimbolo()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_SIMBOLO(numeroLineaActual, posicionInicial, lexema, categoria);
        }

        private void FormarComponenteLexicoDummy()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_DUMMY(numeroLineaActual, posicionInicial, lexema, categoria);
        }

        private void FormarComponenteLexicoLiteral()
        {
            posicionInicial = puntero - lexema.Length;
            componente = ComponenteLexico.CREAR_LITERAL(numeroLineaActual, posicionInicial, lexema, categoria);
        }

        private void ReportarErrorLexicoRecuperable()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_RECUPERABLE(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion){
                ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
            }
        }

        private void ReportarErrorLexicoStopper()
        {
            posicionInicial = puntero - lexema.Length;
            Error error = Error.CREAR_ERROR_LEXICO_STOPPER(numeroLineaActual, posicionInicial, lexema, falla, causa, solucion){
                ManejadorErrores.ObtenerManejadorErrores().ReportarError(error);
            }
        }



    }
}
