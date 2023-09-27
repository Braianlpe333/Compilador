using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.Gestor_Errores
{
    public enum TipoError
    {
        LEXICO, SINTACTICO, SEMANTICO, GENERADOR_CODIGO_INTERMEDIO, GENERADOR_CODIGO_FINAL, OPTIMIZACION
    }
}
