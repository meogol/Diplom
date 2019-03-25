﻿using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Generator;

//using ConsoleApp1.Generator;

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
            string solutionPath = @"C:\Users\Вера\source\repos\ConsoleApp1 — копия — копия\ConsoleApp1.sln";//получаем солюшн.Из него возьмем все проджекты, в которых будем искать нужные файлы
            var msWorkspace = MSBuildWorkspace.Create();
            var solution = msWorkspace.OpenSolutionAsync(solutionPath).Result;
            AnalisysCode analisys = new AnalisysCode();
            foreach (var project in solution.Projects)
            {
                //methodAnalisysWalker.projectPath = @project.FilePath.Remove(project.FilePath.LastIndexOf(@"\") + 1);
                //methodAnalisysWalker.ProjectAnalysis(project);
                analisys.ProjectAnalysis(project);
            }
            T4Generator t= new T4Generator(analisys.entityInfos);
            String tText = t.TransformText();

            Console.WriteLine(tText);

            foreach (var a in analisys.entityInfos)
            {
                Console.WriteLine(a.className);
                foreach(var b in a.lFieldInfo.Keys)
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
