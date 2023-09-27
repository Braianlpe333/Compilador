using _22023_UCO_Compilador22023.AnalisisLexico;
using _22023_UCO_Compilador22023.Cache;
using _22023_UCO_Compilador22023.Gestor_Errores;
using _22023_UCO_Compilador22023.TablaComponentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataCache.AgregarLinea("Hola 1 class");
            


            AnalizadorLexico anaLex = new AnalizadorLexico();
            ComponenteLexico componente = anaLex.DevolverSiguienteComponente();
            try
            {
                do
                {
                    //Console.WriteLine(componente.ToString() );
                    componente = anaLex.DevolverSiguienteComponente();
                } while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.Categoria));
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            ImprimirComponentes(TipoComponente.SIMBOLO);
            ImprimirComponentes(TipoComponente.LITERAL);
            ImprimirComponentes(TipoComponente.DUMMY);
            ImprimirComponentes(TipoComponente.PATABRA_RESERVADA);

            ImprimirErrores(TipoError.LEXICO);


            Thread.Sleep(20000);

        }

        private static void ImprimirComponentes(TipoComponente tipo)
        {
            Console.WriteLine("*************INICIO COMPONENTES " + tipo.ToString() + "*************");
            List<ComponenteLexico> componentes = TablaMaestra.ObtenerTablaMaestra().ObtenerTodosSimbolos(tipo);
            foreach (ComponenteLexico componente in componentes)
            {
                Console.WriteLine(componente.toString());
            }
            Console.WriteLine("*************FIN COMPONENTES " + tipo.ToString() + "*************");
        }

        private static void ImprimirErrores(TipoError tipo)
        {
            Console.WriteLine("*************INICIO ERRORES " + tipo.ToString() + "*************");
            List<Error> errores = ManejadorErrores.ObtenerManejadorErrores().ObtenerErrores();
            foreach (Error errores in error)
            {
                Console.WriteLine(error.toString());
            }
            Console.WriteLine("*************FIN COMPONENTES " + tipo.ToString() + "*************");
        }
    }
}
