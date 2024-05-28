namespace Pesquisa_Binaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int[] array = {1, 2, 6, 9, 15, 18, 24, 28, 35, 42, 78 };
            int aux = pesquisa_binaria(array, numero);

            if (aux != -1)
            {
                Console.WriteLine($"Número encontrado na posição {aux} do vetor!");
            } else
            {
                Console.WriteLine("Número não encontrado no vetor!");
            }
        }

        public static int pesquisa_binaria(int[] array, int item)
        {
            int baixo = 0;
            int alto = array.Length -1;

            while (baixo <= alto)
            {
                int meio = (baixo + alto) / 2;
                int palpite = array[meio];

                if (palpite == item)
                {
                    return meio;
                }
                if (palpite > item)
                {
                    alto = meio - 1;
                }
                else
                {
                    baixo = meio + 1;
                }
            }
            return -1;
        }
    }
}
