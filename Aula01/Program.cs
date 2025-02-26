namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 18;
            string nomeCompleto = "Ana Beatriz Pereira de Araujo";

            var variavelSemTipo = "Ana";

            Console.WriteLine(variavelSemTipo.GetType());

            Console.WriteLine("Digite seu nome:");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            string idadeUsuario = Console.ReadLine();


           


            Console.Write($" Meu nome é {nomeUsuario} e a Minha idade é {idadeUsuario}");
        }

    }
 }