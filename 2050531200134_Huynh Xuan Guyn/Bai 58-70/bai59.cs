using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2050531200134_Huynh_Xuan_Guyn.Bai_58_70
{
    internal class bai59
    {
        static void Main(string[] agrs)
        {
            string[] Can_134 = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] Chi_134 = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
            int nam_134;
            Console.Write("Moi ban nhap nam duong: ");
            nam_134 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} {2}", nam_134, Can_134[nam_134 % 10], Chi_134[nam_134 % 12]);
            Console.WriteLine("{0} - {1} {2}", nam_134 + 60, Can_134[nam_134 % 10], Chi_134[nam_134 % 12]);
            Console.ReadKey();
        }
    }
}
