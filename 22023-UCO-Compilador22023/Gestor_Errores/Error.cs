using _22023_UCO_Compilador22023.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.Gestor_Errores
{
    public class Error
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private string lexema;
        private string falla;
        private string causa;
        private string solucion;
        private TipoError tipo;
        private CategoriaError categoria;



        public Error(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, string falla, string causa, string solucion, TipoError tipo, CategoriaError categoria)
        {
            NumeroLinea = numeroLinea;
            PosicionInicial = posicionInicial;
            PosicionFinal = posicionFinal;
            Lexema = lexema;
            Falla = falla;
            //this.falla = falla;
            this.causa = causa;
            this.solucion = solucion;
            this.tipo = tipo;
            this.categoria = categoria;
        }

        public static Error CREAR_ERROR_LEXICO_RECUPERABLE(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, string falla, string causa, string solucion, TipoError tipo, CategoriaError categoria)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa, solucion, tipo, CategoriaError.RECUPERABLE);
        }

        public static Error CREAR_ERROR_LEXICO_STOPPER(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, string falla, string causa, string solucion, TipoError tipo, CategoriaError categoria)
        {
            return new Error(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, falla, causa, solucion, tipo, CategoriaError.STOPPER);
        }


        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = (value < 0) ? 1 : value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = (value < 0) ? 1 : value; }
        public string Lexema { get => lexema; set => lexema = value; }
        
        


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("...................................INICIO..........................").Append("\r\n");
            sb.Append("Tipo Componente: ").Append(Tipo).Append("\r\n");
            sb.Append("Categoria: ").Append(Tipo).Append("\r\n");
            sb.Append("lexema: ").Append(lexema).Append("\r\n");
            sb.Append("Numero Linea: ").Append(numeroLinea).Append("\r\n");
            sb.Append("posicion Inicial: ").Append(posicionInicial).Append("\r\n");
            sb.Append("posicion final: ").Append(posicionFinal).Append("\r\n");
            sb.Append("Falla: ").Append(falla).Append("\r\n");
            sb.Append("Causa: ").Append(causa).Append("\r\n");
            sb.Append("Solucion: ").Append(solucion).Append("\r\n");
            sb.Append("...................................FIN..........................").Append("\r\n");
            return sb.ToString();

        }
    }
}
