using System;

namespace licao24
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, hf, tt;
            string[] vl = Console.ReadLine().Split(' ');

            hi= int.Parse(vl[0]);
            hf= int.Parse(vl[1]);

            if ( hi < hf)
            {
                tt = hf - hi;
            }
            else
            {
                tt = 24 - hi + hf;
            }
            Console.WriteLine("O JOGO DUROU " + tt + "HORA(S)");
        }
    }
}