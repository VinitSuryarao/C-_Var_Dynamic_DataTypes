using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var_Dynamic_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var :- Store Any Type Of Data. But Var is compile Time. Once we assign Value at Compile time its fixed.
            var varNum = 123;
            var varData = " Sample Test";
            Console.WriteLine(varData);

            // Once Value assign then type getting fixed and cannot changed at runtime.
            varData = 123;


            //Dynamic : Store any type of data. we can change data at runime as well.
                        dynamic dynData = "Sample Dynamic Data";
            Console.WriteLine(dynData);

            dynData = 123465789;
            dynData = 12.326;
            dynData = true;
            dynData = "Dyanamic";


        }
    }
}
