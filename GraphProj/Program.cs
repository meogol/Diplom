using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.CodeAnalysis.MSBuild;

namespace GraphProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Program.Analisys(@"C:\Users\Вера\source\repos\ConsoleApp2\ConsoleApp2\EntityProject.csproj", @"C:\Users\Вера\Desktop\Graph.cs");
            Console.ReadKey();
        }
        
    }
}
