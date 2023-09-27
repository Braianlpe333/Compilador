﻿using _22023_UCO_Compilador22023.AnalisisLexico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22023_UCO_Compilador22023.TablaComponentes
{
    public  class TablaSimbolos
    {
        private Dictionary<string,List<ComponenteLexico>> tabla = new Dictionary<string, List<ComponenteLexico>>();

        public void Limpiar()
        {
            tabla.Clear();
        }
        public void Agregar(ComponenteLexico componente)
        {
            if(componente != null && TipoComponente.SIMBOLO.Equals(componente.Tipo))
            {
                ObtenerSimbolos(componente.Lexema).Add(componente);
            }
        }

        public List<ComponenteLexico> ObtenerSimbolos(string lexema)
        {
            if (!tabla.ContainsKey(lexema))
            {
                tabla.Add(lexema,new List<ComponenteLexico>());
            }
            return tabla[lexema];
        }
        public List<ComponenteLexico> ObtenerTodosSimbolos()
        {
            List<ComponenteLexico> listaRetorno = new List<ComponenteLexico> ();
            foreach(List<ComponenteLexico> lista in tabla.Values)
            {
                listaRetorno.AddRange(lista);
            }
            return listaRetorno;
        }
    }
}
