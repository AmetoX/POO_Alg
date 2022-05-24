namespace Lab_24_05.Algoritmi
{
    internal class PrimaCifraMinimaAlgoritm : Algoritm
    {
        int n;
        int result;
        int[] data;
        protected override void Compute()
        {
            result = data[0];
            for (int i = 1; i < n; i++)
            {
                if (getFirstDigit(result) > getFirstDigit(data[i]))
                {
                    result = data[i];
                }
            }
        }
        private int getFirstDigit(int n)
        {
            while (n > 9)
            {
                n /= 10;
            }
            return n;
        }
        protected override void ReadInput()
        {
            n = int.Parse(Console.ReadLine());
            data = new int[n];
            for (int i = 0; i < n; i++)
            {
                data[i] = int.Parse(Console.ReadLine());
            }
        }
        protected override void WriteOutput()
        {
            Console.WriteLine("Rezultat: " + result);
        }
    }
}