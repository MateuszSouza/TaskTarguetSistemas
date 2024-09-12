namespace Fibonacci
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            
        }
        public void Resolve()
        {
            // Solicita que o usuário informe um número
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            // Chama a função para verificar se o número está na sequência de Fibonacci
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }

        // Função que verifica se um número pertence à sequência de Fibonacci
        private bool PertenceFibonacci(int num)
        {
            // Valores iniciais da sequência
            int a = 0;
            int b = 1;

            // Verifica se o número é 0 ou 1, que são parte da sequência
            if (num == 0 || num == 1)
            {
                return true;
            }

            // Calcula os próximos valores da sequência de Fibonacci até que 'b' seja maior ou igual ao número informado
            while (b <= num)
            {
                int temp = a + b;
                a = b;
                b = temp;

                // Se o valor calculado é igual ao número, ele pertence à sequência
                if (b == num)
                {
                    return true;
                }
            }

            // Se o loop terminar e o número não for encontrado, ele não pertence à sequência
            return false;
        }

    }
}
