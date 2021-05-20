using System;
using System.Collections.Generic;
using System.Text;

namespace Lexico3
{
    class Token
    {
        public enum Clasificaciones
        {
            identificador, numero, asignacion, inicializacion, caracter,
            FinSentencia, OperadorLogico, OperadorRelacional, OperadorTermino,
            OperadorFactor, IncrementoTermino, IncrementoFactor, Cadena, OperadorTernario,
            TipoDato, Zona, Condicion, ciclo, IniciodeBloque, FindeBloque,
        }
        private string contenido;
        private Clasificaciones clasificacion;

        public void SetContenido(string contenido)
        {
            this.contenido = contenido;
        }

        public void SetClasificacion(Clasificaciones clasificacion)
        {
            this.clasificacion = clasificacion;
        }

        public string GetContenido()
        {
            return contenido;
        }
        public Clasificaciones GetClasificacion()
        {
            return clasificacion;
        }
    }
}
