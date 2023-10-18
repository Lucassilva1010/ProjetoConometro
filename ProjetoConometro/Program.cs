namespace ProjetoConometro
{
    public class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        #region Menu da Aplicação
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo = 10s");
            Console.WriteLine("M - Minuto = 10m");
            Console.WriteLine("0 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("Qual das opções deseja realizar?");
            string valor = Console.ReadLine().ToUpper();
            char letra = char.Parse(valor.Substring(valor.Length - 1, 1));
            double numero = double.Parse(valor.Substring(0, valor.Length - 1));

            Operacoes(letra, numero);
        }
        #endregion
        #region Chamada de Operações da Aplicação
        static void Operacoes(char valor, double numero)
        {

            switch (valor)
            {
                case 'S':
                    Console.Clear();
                    // Console.WriteLine("Quantos minutos deseja cronometrar? ");
                    // int minuto = int.Parse(Console.ReadLine());
                    int multS = 1;//para trasnformar o valor em segundo
                    Animacao();
                    Iniciar(numero * multS); break;
                case 'M':
                    Console.Clear();
                    // Console.WriteLine("Quantos minutos deseja cronometrar? ");
                    // int minuto = int.Parse(Console.ReadLine());
                    int multM = 60;//Vai transformar o valor em minuto
                    Animacao();
                    Iniciar(numero * multM);
                    break;

                default:

                    Console.Write("Saindo");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(0200);
                    Console.Write(".");
                    Thread.Sleep(0200);
                    Console.Write(".");

                    break;
            }
        }
        #endregion
        #region Animações para finalizar e começar contagens
        static void Animacao()
        {
            Console.Clear();
            Console.Write("lest... ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Gooo!");
            Thread.Sleep(2500);
        }
        #endregion
        #region Função para contagem regressiva
        static void Iniciar(double valor)
        {

            int tempoAtual = 0;
            while (tempoAtual < valor)
            {

                Console.Clear();
                Console.WriteLine(valor);
                valor--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Contagem finalizada!");
            Thread.Sleep(2500);
            Menu();
        }
        #endregion

    }
}