using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale
{
    class Program
    {
     //everything statrs here, builds into the first GUI, Build
        static void Main(string[] args)
        {
            Build a = new Build();
            a.ShowDialog();
            a.Close();
        }
    }
}
