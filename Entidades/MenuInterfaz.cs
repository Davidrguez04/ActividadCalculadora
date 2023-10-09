using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCalculadora.Entidades
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Interfaz que corresponde a la funcionalidad del menú
        /// Contiene las acciones desde el menú
        /// </summary>
        public void mensajeBienvenida();

        public int mostrarMenu();

        public int hacerSuma();

        public int hacerResta();

        public int hacerMultipli();

        public int hacerDivis();
    }
}
