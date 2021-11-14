using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
     
      
        static void Main(string[] args)
        {
            double Ktop = 0,  Btop=0, Atop=0,m=0,t=0;
            Console.WriteLine("Boştaki gücü girin");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Araç Sayısını girin");
            int x =Convert.ToInt32(Console.ReadLine());
            double[] ListA = new double[x];
            double[] ListB = new double[x];
            double[] ListK= new double[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i+1 +".Aracın güç kapasitesini girin");
                ListA[i] = Convert.ToDouble(Console.ReadLine());
                Atop = Atop + ListA[i];
                Console.WriteLine(i + 1 + ".Aracın içindeki güç miktarını girin");
                ListB[i] = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(ListB[i]) ;
                Btop = Btop + ListB[i];
            }
           
            m = (Btop + n) / Atop;
         //   Console.WriteLine("m  :" +m);
            for (int i = 0; i < x; i++)
            {
                ListK[i] = Math.Abs((m - (ListB[i] / ListA[i]))*ListA[i]*(1- ListB[i] / ListA[i]));
                Ktop = Ktop + ListK[i];
               // Console.WriteLine(" k lar"+ListK[i]);
            }
            Console.WriteLine(Ktop);
            t = n / Ktop;
            for (int i = 0; i < x; i++)
            {
               double toplam =  ListB[i] + (t * ListK[i]);
                double yuzde = toplam / ListA[i];
                yuzde = yuzde * 100;
                Console.WriteLine((i+1)+".arabadaki yakıt:"+toplam);
                Console.WriteLine((i+1) + ".arabadaki doluluk oranı yuzde :" + yuzde);
            }
          
        }
       
    }
}
