using System;
namespace Lesson_1
{
    class Pro
    {
        static void zhuanhuanjiayibai()
        {
            Console.WriteLine("пишите ваше число");
            string about = Console.ReadLine();
            int numabout = int.Parse(about);
            Console.WriteLine(numabout + 100);
        }
        static void bidaxiao()
        {
            double a = (double)7 / 2;
            int b = (int)7.0 / 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void cuowuchuli()
        {
            Console.WriteLine("давайте чтото писать , но наверное будет ошибок");
            string about = Console.ReadLine();
            int numabout = 0;
            try
            {
                numabout = int.Parse(about);
            }
            catch
            {
                Console.WriteLine("ты пишешь неправто и ошибка ввода");
            }
            int a = numabout * numabout;
            Console.WriteLine(a);
        }
        
        static void shujuzhuanhuan()
        {
            double a = 3.2;
            int b = (int)a;
            Console.WriteLine(b);
        }
        static void shuzu()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        static void shuzu2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    m++;
                }
                
            }
            Console.WriteLine(m);
        }
        static void shuzu3()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                m = m + arr[i];

            }
           
            int n = m / arr.Length;
            Console.WriteLine(m);
            Console.WriteLine(n);
        }
        static void shuzu4()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int m = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = m;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void shuzu5()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);

        }



        static void Main()
        {
            Console.WriteLine("11111");
            zhuanhuanjiayibai();
            Console.WriteLine("стучать что то, чтобы к следующему");  
            Console.ReadKey();
            Console.WriteLine("22222");
            bidaxiao();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("33333");
            cuowuchuli();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("44444");
            shujuzhuanhuan();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("55555");
            shuzu();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("66666");
            shuzu2();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("77777");
            shuzu3();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("88888");
            shuzu4();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
            Console.WriteLine("99999");
            shuzu5();
            Console.WriteLine("стучать что то, чтобы к следующему");
            Console.ReadKey();
        }
    }
}
