using System;

namespace Metodos
{
    class Program
    {
        static void Main()
        {
            //Instanciar un objeto de la clase Program
            Program objeto = new Program();

            objeto.metodoPrivado();

            objeto.metodoPublico();

            Console.WriteLine(objeto.metodoReturn());

            Console.WriteLine(objeto.metodoReturnParametros("Envio datos"));
        }



        // METODOS DE CLASE
        private void metodoPrivado()
        {
            Console.WriteLine("Método Privado");
        }

        public void metodoPublico()
        {
            Console.WriteLine("Este es el metodo publico");
        }

        private String metodoReturn()
        {
            int numero = Convert.ToInt16("52");

            String texto = "Metodo con return" + numero;
            return texto;
        }

        private String metodoReturnParametros(String parametro)
        {
            String texto = parametro + " y los imprimo con más texto";

            return texto;

        }

    }
}
