namespace ProyectoConversiones
{
    internal class Program
    {
        //Este es el método principal
        static void Main(string[] args)
        {
            //Creamos un ciclo infinito
            while (true)
            {
                //Llamamos al método MostrarMenu para que aparezca en la pantalla de inicio
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    case "3":
                        ConvertirPesosAEuros();
                        break;
                    case "4":
                        ConvertirEurosAPesos();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.ReadLine();
            }
        }
        //Este es un método que me imprime las opciones para el usuario

        //decimal conversion = Dolares a pesos (1.50m, 20.43m);
        //decimal conversoon = Euros a pesos (1.50m, 21.32m);
        //Console.WriteLine(conversion.ToString("N2"));
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a pesos");
            Console.WriteLine("3) Pesos a Euros");
            Console.WriteLine("4) Euros a Pesos");
            Console.WriteLine("");
        }
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("Pesos a Dolares");
            Console.WriteLine("Introducir tipo de cambio");
            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);
            Console.WriteLine("Introduir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);
            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en dolares:{dolares.ToString("N2")}");
        }
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a Pesos");
            Console.WriteLine("Introducir tipo de cambio");
            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);
            Console.WriteLine("Introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal dolares);
            decimal pesos = DolaresAPesos(tipoCambio, dolares);
            Console.WriteLine($"Cantidad en pesos es: {pesos.ToString("N2")}");
        }
        static void ConvertirPesosAEuros() 
        {
            Console.WriteLine("Pesos a Euros");
            Console.WriteLine("Introducir tipo de cambio");
            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario , out decimal tipoCambio);
            Console.WriteLine("Introducir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);
            decimal euros = ConvertirPesosAEuros(tipoCambio, pesos);
            Console.WriteLine($"Cantidad en euros es: {euros.ToString("N2")}");
        }
        static void ConvertirEurosAPesos() 
        {
            Console.WriteLine("Euros a Pesos");
            Console.WriteLine("Introducir tipo de cambio");
            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);
            Console.WriteLine("Introducir la cantidad en euros");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal euros);
            decimal pesos = ConvertirEurosAPesos(tipoCambio, euros);
            Console.WriteLine($"Cantidad en pesos es: {pesos.ToString("N2")}");

        }

        //Función que recibe un tipo de cambio y cantidad en pesos 
        //Y regresa el resultado de la división 
        //En el caso de los pesos a euros, se tienen que divir
        //En el caso de los euros a pesos, se tienen que multiplicar

        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;

            return dolares;
        }

        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * dolares;
            return pesos;
        }

        static decimal PesosAEuros(decimal tipoCambio, decimal pesos) 
        {
            decimal euros = 0.00m;
            euros = pesos / tipoCambio;
            return euros;
        }
        static decimal EurosAPesos(decimal tipoCambio, decimal euros) 
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * euros;
            return pesos;
        }
    }
}

