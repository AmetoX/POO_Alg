namespace Lab_24_05.Algoritmi
{
    internal class NumerePerechiAlgoritm : Algoritm
    {
        int result = 0;
        List<int> data = new List<int>();
        protected override void Compute()
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                if (data[i] % 10 == data[i + 1] % 10)
                {
                    result++;
                }
            }
        }
        protected override void ReadInput()
        {
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                data.Add(n);
                n = int.Parse(Console.ReadLine());
            }
        }
        protected override void WriteOutput()
        {
            Console.WriteLine("Resultat: {0}", result);
        }
    }
}