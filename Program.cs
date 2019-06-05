using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphGeneratorUtil.Generator;
using GraphGeneratorUtil.InfoClass;

//using ConsoleApp1.Generator;

namespace GraphGeneratorUtil
{
    public class Program //BaseListSyntax
    {
        static void Main(string[] args)
        {
            GraphGeneratorUtil.Program.Analisys(@"C:\Users\Вера\Desktop\focus\server\TransactionService\DealModule\DealModule.csproj", @"C:\Users\Вера\Desktop\GraphCS.cs");
            //GraphGeneratorUtil.Program.Analisys(@"C:\Users\Вера\source\repos\ConsoleApp2\ConsoleApp2\EntityProject.csproj", @"C:\Users\Вера\Desktop\GraphCS.cs");

            Console.WriteLine("Completed!");
            Console.ReadKey();
        }


        static public void Analisys(string analisysProjectPath, string outGraphPath)
        {
            AnalisysCode analisys = new AnalisysCode("FieldsEntity");
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

            foreach (var a in analisys.entityInfos)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("class " + a.className);
                Console.WriteLine("base " + a.baseClassName);
                foreach (var b in a.lFieldInfo.Keys)
                {
                    Console.WriteLine("name " + b + "      type " + a.lFieldInfo[b].TypeField);
                    foreach (var c in a.lFieldInfo[b].lParamInfo)
                    {
                        Console.WriteLine("prent " + c.FieldName + "     type " + c.FieldType + "     param " + c.ParamName);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");
            Console.WriteLine("t");

            T4Generator t= new T4Generator(entityInfos);
            String tText = t.TransformText();

            Console.WriteLine(tText);

            System.IO.File.WriteAllText(outGraphPath, tText);
                        
        }


    }
}
