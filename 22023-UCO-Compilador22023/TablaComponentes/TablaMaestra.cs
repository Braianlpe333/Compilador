using _22023_UCO_Compilador22023.AnalisisLexico;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.TablaComponentes
{
    public class TablaMaestra
    {
        private static TablaMaestra TABLA_MAESTRA = new TablaMaestra();
        private TablaSimbolos tablaSimbolos = new TablaSimbolos();
        private TablaDummy tablaDummy = new TablaDummy();
        private TablaLiteral tablaLiteral = new TablaLiteral();
        private TablaPalabraReservada tablaPabraReservada = new TablaPalabraReservada();

        public static TablaMaestra ObtenerTablaMaestra()
        {
            return TABLA_MAESTRA;
        }

        public void limpiar()
        {
            tablaDummy.Limpiar();
            tablaLiteral.Limpiar();
            tablaPabraReservada.Limpiar();
            tablaSimbolos.Limpiar();
        }

        public void Agregar(ComponenteLexico componente)
        {
            tablaPabraReservada.ComprobarPalabraReservada(componente);
            tablaDummy.Agregar(componente);
            tablaLiteral.Agregar(componente);
            tablaSimbolos.Agregar(componente);
            tablaPabraReservada.Agregar(componente);
        }
        public List<ComponenteLexico>ObtenerSimbolo(TipoComponente tipo, string lexema)
        {
            switch (tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerSimbolos(lexema);
                case TipoComponente.LITERAL:
                    return tablaLiteral.ObtenerSimbolos(lexema);
                case TipoComponente.PATABRA_RESERVADA:
                    return tablaPabraReservada.ObtenerSimbolos(lexema);
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerSimbolos(lexema);
                default:
                    throw new Exception("Tipo de componente no valido");
            }
        }
        public List<ComponenteLexico> ObtenerTodosSimbolos(TipoComponente tipo)
        {
            switch (tipo)
            {
                case TipoComponente.SIMBOLO:
                    return tablaSimbolos.ObtenerTodosSimbolos();
                case TipoComponente.LITERAL:
                    return tablaLiteral.ObtenerTodosSimbolos();
                case TipoComponente.PATABRA_RESERVADA:
                    return tablaPabraReservada.ObtenerTodosSimbolos();
                case TipoComponente.DUMMY:
                    return tablaDummy.ObtenerTodosSimbolos();
                default:
                    throw new Exception("Tipo de componente no valido");
            }
        }
    }
}
