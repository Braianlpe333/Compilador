using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.AnalisisLexico
{
    public class ComponenteLexico
    {
        private int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private string lexema;
        private CategoriaGramatical categoria;
        private TipoComponente tipo;

        private ComponenteLexico(int numeroLinea, int posicionInicial, int posicionFinal, string lexema, CategoriaGramatical categoria, TipoComponente tipo)
        {
            this.NumeroLinea = numeroLinea;
            this.PosicionInicial = posicionInicial;
            this.PosicionFinal = posicionFinal;
            this.Lexema = lexema;
            this.Categoria = categoria;
            this.Tipo = tipo;
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public int PosicionInicial { get => posicionInicial; set => posicionInicial = (value < 0) ? 1 : value; }
        public int PosicionFinal { get => posicionFinal; set => posicionFinal = (value<0)? 1:value; }
        public string Lexema { get => lexema; set => lexema = value; }
        public CategoriaGramatical Categoria { get => categoria; set => categoria = value; }
        public TipoComponente Tipo { get => tipo; set => tipo = value; }

        public static ComponenteLexico CREAR_SIMBOLO(int numeroLinea, int posicionInicial,  string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea,posicionInicial,posicionInicial+lexema.Length,lexema,categoria, TipoComponente.SIMBOLO);
        }
        public static ComponenteLexico CREAR_LITERAL(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.LITERAL);
        }
        public static ComponenteLexico CREAR_DUMMY(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.DUMMY);
        }
        public static ComponenteLexico CREAR_PALABRA_RESERVADA(int numeroLinea, int posicionInicial, string lexema, CategoriaGramatical categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionInicial + lexema.Length, lexema, categoria, TipoComponente.PATABRA_RESERVADA);
        }

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("...................................INICIO..........................").Append("\r\n");
            sb.Append("Tipo Componente: ").Append(Tipo).Append("\r\n");
            sb.Append("Categoria: ").Append(Tipo).Append("\r\n");
            sb.Append("lexema: ").Append(lexema).Append("\r\n");
            sb.Append("Numero Linea: ").Append(numeroLinea).Append("\r\n");
            sb.Append("posicion Inicial: ").Append(posicionInicial).Append("\r\n");
            sb.Append("posicion final: ").Append(posicionFinal).Append("\r\n");
            sb.Append("...................................FIN..........................").Append("\r\n");
            return sb.ToString();

        }

    }
}
