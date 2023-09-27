using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.Cache
{
    public class Linea
    {
        private int numeroLinea;
        private string contenido;

        private Linea(int numeroLinea,string contenido)
        {
            NumeroLinea = numeroLinea;
            Contenido = contenido;
        }
        public static Linea CREAR(int numeroLinea, string contenido)
        {
            return new Linea(numeroLinea, contenido);
        }

        public int NumeroLinea { get => numeroLinea; set => numeroLinea = value; }
        public string Contenido { get => contenido; set => contenido = value; }
    }
}
