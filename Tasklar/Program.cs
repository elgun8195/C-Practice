using System;

namespace Tasklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mertebeler
            //int a = 5582;
            //int count = 0;
            //while (a > 0)
            //{
            //    a = a / 10;
            //    count++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region nece dene herf var
            //Console.WriteLine("Sozu daxil edin: ");
            //string soz = Console.ReadLine().ToLower();
            //Console.WriteLine("aranacak kelimeyi giriniz");
            //char herf = char.Parse(Console.ReadLine().ToLower());
            //int count = 0;

            //for (int i = 0; i < soz.Length; i++)
            //{
            //    if (soz[i] == herf)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("girilen soz:" + soz);
            //Console.WriteLine("-----------------");
            //Console.WriteLine(String.Format("'{0}' bunda bu '{1}' dene var.",herf,count));
            #endregion

            #region 3e bolunenler
            int[] a = {2,3,4,5,6,7,8,9,12,15 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]%3==0) 
                {
                    sum = sum + a[i];
                }
                
            }
            Console.WriteLine(sum);
            #endregion
        }
    }
}
