namespace Lab_24_05
{
    internal class Program
    {
        //Probleme de pe pbinfo 171 , 119
        //Prima Cifra Minima dint-un sir de nr (Algoritm)
        //2 cele mai mari cifre dintr-un sir (Algaoritm)
        static void Main(string[] args)
        {
            Algoritm a = new PrimaCifraMinimaAlgoritm();
            //a.Initiate();

            a = new Maxim2Algaoritm();
            a.Initiate();
        }
    }
}