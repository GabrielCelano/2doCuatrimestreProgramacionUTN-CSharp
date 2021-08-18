using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double num)
        {
            long bin = BitConverter.DoubleToInt64Bits(num);
            return Convert.ToString(bin, 2);
        }

        public static double BinarioDecimal(string bin)
        {
            return BitConverter.Int64BitsToDouble(Convert.ToInt64(bin, 2));
        }
    }
}
