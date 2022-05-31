using Lab_24_05.Algoritmi;

namespace Lab_24_05
{
    internal class Program
    {
        //Probleme de pe pbinfo 171 , 119 , 943 , 56
        //1.Prima Cifra Minima dint-un sir de nr (Algoritm)
        //2.2 cele mai mari cifre dintr-un sir (Algaoritm)
        //3.Ultima cifra sumei : nr 4 = > 1+2+3+4 , fiecare cifra ridicata la puterea 4
        //4.Citirea se încheie la introducerea valorii 0, reprezentând numărul de perechi citite
        static void Main(string[] args)
        {
            Algoritm a;
            a = new PrimaCifraMinimaAlgoritm();
            //a.Initiate();

            a = new Maxim2Algaoritm();
            //a.Initiate();

            a = new sumaPutere();
            //a.Initiate();

            a = new NumerePerechiAlgoritm();
            //a.Initiate();
        }      
    }
}