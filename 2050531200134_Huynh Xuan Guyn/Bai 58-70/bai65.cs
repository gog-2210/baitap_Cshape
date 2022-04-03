using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2050531200134_Huynh_Xuan_Guyn.Bai_58_70
{
    internal class bai65
    {
        static void Main(string[] agrs)
        {
            int n_134;
            Console.Write("Moi ban nhap so luong phan tu cua mang: ");
            n_134 = int.Parse(Console.ReadLine());
            int[] a_134 = new int[n_134 + 1];
            Nhap(a_134, n_134);
            Console.Write("Mang cua ban la a_134[]: ");
            Xuat(a_134, n_134);
            Console.WriteLine("\nTrung binh cac so nguyen am le S = {0}", TBLe(a_134, n_134));
            XoaTrung(ref a_134, ref n_134);
            Console.Write("Mang cua ban sau khi xoa trung la a_134[]: ");
            Xuat(a_134, n_134);
            Console.ReadKey();
        }
        static void Nhap(int[] a_134, int n_134)
        {
            for (int i = 1; i <= n_134; i++)
            {
                Console.Write("a_134[{0}]: ", i);
                a_134[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a_134, int n_134)
        {
            for (int i = 1; i <= n_134; i++)
            {
                Console.Write(" {0} ", a_134[i]);
            }
        }
        static float TBLe(int[] a_134, int n_134)
        {
            int tong = 0, dem = 0;
            for (int i = 1; i <= n_134; i++)
            {
                if (a_134[i] < 0 && a_134[i] % 2 != 0)
                {
                    tong = tong + a_134[i];
                    dem = dem + 1;
                }
            }
            return (float)tong / dem;
        }
        static void XoaTrung(ref int[] a_134, ref int n_134)
        {
            for (int i = 1; i < n_134; i++)
            {
                for (int j = i + 1; j <= n_134; j++)
                {
                    if (Math.Abs(a_134[i]) == Math.Abs(a_134[j]))
                    {
                        for (int k = j; k < n_134; k++)
                        {
                            a_134[k] = a_134[k + 1];
                        }
                        n_134 = n_134 - 1;
                    }
                }
            }
        }
    }
}
