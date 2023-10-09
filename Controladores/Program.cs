using ActividadCalculadora.Entidades;

namespace ActividadCalculadora.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 091023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Llamada al método que imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            bool cerrarMenu = false;

            menuInterfaz.mensajeBienvenida();

            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.Clear();
                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.Write("\n\n[INFO]- Has seleccionado la opción Cerrar\n\n");
                        cerrarMenu |= true;
                        break;

                    case 2:
                        Console.Write("\n\n[INFO]- Has seleccionado la operación Suma\n\n");
                        menuInterfaz.hacerSuma();
                        break;
                    case 3:
                        Console.Write("\n\n[INFO]- Has seleccionado la operación Resta\n\n");
                        menuInterfaz.hacerResta();
                        break;

                    case 4:
                        Console.Write("\n\n[INFO]- Has seleccionado la operación Multiplicación\n\n");
                        menuInterfaz.hacerMultipli();
                        break;

                    case 5:
                        Console.Write("\n\n[INFO]- Has seleccionado la operación División\n\n");
                        menuInterfaz.hacerDivis();
                        break; ;

                    default:
                        Console.WriteLine("[ERROR]- Ha seleccionado una opción incorrecta!!!!");
                        break;
                }

                


            }


        }
    }
}
