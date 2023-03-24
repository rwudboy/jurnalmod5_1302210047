using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mod5_1302210047
{
    public class Penjumlahan
    {
            private dynamic data;
            public Penjumlahan() { }
            public T PenjumlahanTigaAngka<T>(T a, T b, T c)
            {
                dynamic x = a;
                dynamic y = b;
                dynamic z = c;

                data = x + y + z;
            }

        public void Print()
        {
            Console.WriteLine($"Hasil Penjumlahan: {this.data}");
        }
    }

}

