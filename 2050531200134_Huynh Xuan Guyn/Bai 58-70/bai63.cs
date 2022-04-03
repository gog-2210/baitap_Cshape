using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2050531200134_Huynh_Xuan_Guyn.Bai_58_70
{
    internal class bai63
    {
        static void Main(string[] agrs)
        {
            Random rd_134 = new Random();
            int n_134;
            Console.Write("Moi ban nhap so luong phan tu cua mang: ");
            n_134 = int.Parse(Console.ReadLine());
            int[] a_134 = new int[n_134 + 1];
            for (int i = 1; i <= n_134; i++)
            {
                a_134[i] = rd_134.Next(-100, 100);
            }
            Xuat(a_134, n_134);
            Console.WriteLine("\nSo phan tu chia het cho 4 va tan cung la 6: {0}", Dem(a_134, n_134));
            ThayDoiGT(ref a_134, n_134);
            Console.WriteLine("Thay phan tu le bang 2 lan gia tri cua no: ");
            Xuat(a_134, n_134);
            Console.ReadKey();
        }

        static void Xuat(int[] a_134, int n_134)
        {

            for (int i = 1; i <= n_134; i++)
            {
                Console.Write(" {0} ", a_134[i]);
            }
        }
        static int Dem(int[] a_134, int n_134)
        {
            int dem_134 = 0;
            for (int i = 1; i <= n_134; i++)
            {
                if (a_134[i] % 4 == 0 && a_134[i] % 10 == 6)
                {
                    dem_134++;
                }
            }
            return dem_134;
        }
        static void ThayDoiGT(ref int[] a_134, int n_134)
        {
            for (int i = 1; i <= n_134; i++)
            {
                if (a_134[i] % 2 != 0)
                {
                    a_134[i] = 2 * a_134[i];
                }
            }
        }
    }
}
