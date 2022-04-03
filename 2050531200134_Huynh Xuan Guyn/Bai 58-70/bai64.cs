using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2050531200134_Huynh_Xuan_Guyn.Bai_58_70
{
    internal class bai64
    {
        static void Main(string[] agrs)
        {
            int n_134, X_134;
            Console.Write("Nhap so luong phan tu cua mang: ");
            n_134 = int.Parse(Console.ReadLine());
            int[] a_134 = new int[n_134 + 1];
            Nhap(a_134, n_134);
            Xuat(a_134, n_134);
            Console.WriteLine("\nSo luy thuy cua 2 co trong mang: {0}", DemLuyThua(a_134, n_134));
            Console.Write("Nhap so X can xoa: ");
            X_134 = int.Parse(Console.ReadLine());
            XoaX(ref a_134, ref n_134, X_134);
            Xuat(a_134, n_134);
            Console.ReadKey();
        }
        static void Nhap(int[] a_134, int n_134)
        {
            for (int i = 1; i <= n_134; i++)
            {
                Console.Write(" a_134[{0}] ", i);
                a_134[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a_134, int n_134)
        {
            Console.Write("Mang a_134[]: ");
            for (int i = 1; i <= n_134; i++)
            {
                Console.Write(" {0} ", a_134[i]);
            }
        }
        static int DemLuyThua(int[] a_134, int n_134)
        {
            int dem = 0;
            for (int i = 1; i <= n_134; i++)
            {
                int j = 2;
                while (Math.Pow(2, j) <= a_134[i])
                {
                    if (a_134[i] == Math.Pow(2, j))
                    {
                        dem++;
                    }
                    j++;
                }
            }
            return dem;
        }
        static void XoaX(ref int[] a_134, ref int n_134, int X_134)
        {
            for (int i = 1; i <= n_134; i++)
            {
                if (a_134[i] == X_134)
                {
                    for (int j = i; j < n_134; j++)
                    {
                        a_134[j] = a_134[j + 1];
                    }
                    n_134 = n_134 - 1;
                }
            }
        }
    }
}
