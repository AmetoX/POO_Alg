namespace Lab_24_05.Algoritmi
{
    internal class Maxim2Algaoritm : Algoritm
    {
        int x, y, n;
        int[] data;
        protected override void Compute()
        {
            x = y = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= x)
                {
                    y = x;
                    x = data[i];
                }
                else if (data[i] > y)
                {
                    y = data[i];
                }
            }
        }

        protected override void ReadInput()
        {
            n = int.Parse(Console.ReadLine());
            data = new int[n];
            for (int i = 0; i < n; i++)
                data[i] = int.Parse(Console.ReadLine());
        }

        protected override void WriteOutput()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
    }
}