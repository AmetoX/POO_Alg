namespace Lab_24_05.Algoritmi
{
    internal class sumaPutere : Algoritm
    {
        int n, s = 0;
        protected override void Compute()
        {
            for (int i = 1; i <= n; i++)
            {
                s = s + (int)Math.Pow(i, 4);
            }
            s %= 10;
        }
        protected override void ReadInput()
        {
            n = int.Parse(Console.ReadLine());
        }
        protected override void WriteOutput()
        {
            Console.WriteLine("Resultat: {0}", s);
        }
    }
}