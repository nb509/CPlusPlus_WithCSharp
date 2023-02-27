using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBaseCSharpLib;

namespace TheWpfApp
{
    internal class UsageDemo
    {
        public static void Run()
        {
            // Testing the cpp methods in the math class:
            StaticMath.Multiply(4, 6, out int myResult);
            //Debug.WriteLine(myResult);


            AravisHelper.UpdateDeviceList();
        }
    }
}
