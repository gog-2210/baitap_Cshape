using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2050531200134_Huynh_Xuan_Guyn.Bai_58_70
{
    internal class bai58
    {
        static void Main(string[] agrs)
        {
            int n_134, i_134, j_134;
            Console.Write("Moi ban nhap so luong phan tu cho mang: ");
            n_134 = int.Parse(Console.ReadLine());
            Boolean[] a_134 = new Boolean[n_134 + 1];

            for (i_134 = 2; i_134 <= n_134; i_134++)
            {
                a_134[i_134] = true;
            }

            for (i_134 = 2; i_134 <= n_134; i_134++)
            {
                if (a_134[i_134] == true)
                {
                    for (j_134 = 2 * i_134; j_134 <= n_134; j_134 += i_134)
                    {
                        a_134[j_134] = false;
                    }
                }
            }

            for (i_134 = 2; i_134 <= n_134; i_134++)
            {
                if (a_134[i_134] == true)
                {
                    Console.Write(" {0} ", i_134);
                }
            }
            Console.ReadKey();
        }
    }
}
