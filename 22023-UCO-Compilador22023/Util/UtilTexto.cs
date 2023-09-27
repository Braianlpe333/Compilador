using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.Util
{
    public class UtilTexto
    {
        public static bool EsLetra(string caracter)
        {
            return char.IsLetter(caracter,0);
        }
        public static bool EsDigito(string caracter)
        {
            return char.IsDigit(caracter, 0);
        }
        public static bool EsGuionBajo(string caracter)
        {
            return "_".Equals(caracter);
        }
        public static bool EsSingoPesos(string caracter)
        {
            return "$".Equals(caracter);
        }
        public static bool EsLetraODigito(string caracter)
        {
            return char.IsLetterOrDigit(caracter, 0);
        }
        public static bool EsComa(string caracter)
        {
            return ",".Equals(caracter);
        }
        public static bool EsSuma(string caracter)
        {
            return "+".Equals(caracter);
        }
        public static bool EsResta(string caracter)
        {
            return "-".Equals(caracter);
        }
        public static bool EsProducto(string caracter)
        {
            return "*".Equals(caracter);
        }
        public static bool EsBarraInclinada(string caracter)
        {
            return "/".Equals(caracter);
        }
        public static bool EsParentesisAbre(string caracter)
        {
            return "(".Equals(caracter);
        }
        public static bool EsParentesisCierra(string caracter)
        {
            return ")".Equals(caracter);
        }
        public static bool EsPorcentaje(string caracter)
        {
            return "%".Equals(caracter);
        }
        public static bool EsIgual(string caracter)
        {
            return "=".Equals(caracter);
        }
        public static bool EsMayorQue(string caracter)
        {
            return ">".Equals(caracter);
        }
        public static bool EsMenorQue(string caracter)
        {
            return "<".Equals(caracter);
        }
        public static bool EsExclamacion(string caracter)
        {
            return "!".Equals(caracter);
        }
        public static bool EsDosPuntos(string caracter)
        {
            return ":".Equals(caracter);
        }
        public static bool EsFinArchivo(string caracter)
        {
            return "@EOF@".Equals(caracter);
        }
        public static bool EsFinLinea(string caracter)
        {
            return "@FL@".Equals(caracter);
        }
    }
}
