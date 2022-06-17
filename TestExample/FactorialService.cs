namespace TestExample
{
    public class FactorialService
    {
        public int Calcular(int numero)
        {
            if (numero == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= numero; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}