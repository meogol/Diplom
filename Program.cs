using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Generator;

//using ConsoleApp1.Generator;

namespace ConsoleApp1
{
    public class Program //BaseListSyntax
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Program.Analisys(@"C:\Users\Вера\source\repos\ConsoleApp2\ConsoleApp2\EntityProject.csproj", @"C:\Users\Вера\Desktop\Graph.cs");


            Console.WriteLine("Completed!");
            Console.ReadKey();
        }


        static public void Analisys(string analisysProjectPath, string outGraphPath)
        {
           
            AnalisysCode analisys = new AnalisysCode("Entity");

            
            //путь к анализируемому csproj файлу
             string projectPath =analisysProjectPath;

            //по указанному пути получаем проджект
            MSBuildWorkspace msWorkspace = MSBuildWorkspace.Create();
            var Project = msWorkspace.OpenProjectAsync(projectPath).Result;
            analisys.ProjectAnalysis(Project);

            var diagnostics = msWorkspace.Diagnostics;
            foreach (var diagnostic in diagnostics)
            {
                Console.WriteLine(diagnostic.Message);
            }

            var entityInfos = analisys.entityInfos;
            T4Generator t= new T4Generator(entityInfos);
            String tText = t.TransformText();

            Console.WriteLine(tText);

            System.IO.File.WriteAllText(outGraphPath, tText);

            foreach (var a in analisys.entityInfos)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(a.className);
                Console.WriteLine(a.baseClassName);
                foreach (var b in a.lFieldInfo.Keys)
                {
                    Console.WriteLine(b + "       " + a.lFieldInfo[b].TypeField);
                    foreach (var c in a.lFieldInfo[b].lParamInfo)
                    {
                        Console.WriteLine(c.FieldName + "     " + c.FieldType + "     " + c.ParamName);
                    }
                    Console.WriteLine();
                }
            }

            
        }


    }
}
