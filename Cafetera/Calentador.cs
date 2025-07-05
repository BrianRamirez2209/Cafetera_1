namespace Cafetera
{
    public partial class Cafetera
    {
        public class Calentador

        {
           
            

            public void encender()
            {
                Console.WriteLine("Encendiendo cafetera");
            }

            public void apagar()
            {
                Console.WriteLine("Apagando cafetera \n ¡CUIDADO SIGUE CALIENTE!");

            }

            public void limpiar()
            {
                Console.WriteLine("Iniciando proceso de limpieza...");
                
                Console.WriteLine("Circulando agua caliente para limpieza...");
                
                Console.WriteLine("Cafetera limpia. Lista para otro cafésito.");
            }

        }
    }
}
