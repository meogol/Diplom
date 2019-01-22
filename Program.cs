using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program //BaseListSyntax
    {
        static void Main(string[] args)
        {
            Analisys();
            Console.WriteLine("Completed!");
            Console.ReadKey();
        }


        static void Analisys()
        {
            string solutionPath = @"C:\Users\Вера\source\repos\ConsoleApp1 — копия\ConsoleApp1.sln";//получаем солюшн.Из него возьмем все проджекты, в которых будем искать нужные файлы
            var msWorkspace = MSBuildWorkspace.Create();
            var solution = msWorkspace.OpenSolutionAsync(solutionPath).Result;
            MethodAnalisysWalker methodAnalisysWalker = new MethodAnalisysWalker();

            foreach (var project in solution.Projects)
            {
                methodAnalisysWalker.projectPath = @project.FilePath.Remove(project.FilePath.LastIndexOf(@"\") + 1);
                methodAnalisysWalker.ProjectAnalysis(project);
            }
        }


    }
}
