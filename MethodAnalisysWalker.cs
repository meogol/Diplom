using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodAnalisysWalker : CSharpSyntaxWalker
    {
        /// <summary>
        /// лист с именами классов, реализующих IFilf
        /// </summary>
        List<string> isIFild;
        /// <summary>
        /// лист считыннах из  CreateFilds филдов
        /// </summary>
        List<Fild> lFilds;
        /// <summary>
        /// путь к папке проекта(для записи .тхт)
        /// </summary>
        public string projectPath { get; set; }

        public MethodAnalisysWalker() : base(SyntaxWalkerDepth.Token)
        {
            lFilds = new List<Fild>();
            isIFild = new List<string>();
        }
        
        public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node) //сюда, попадаем из VisitMethodDeclaration. этот узел продставляет строку объявления переменной/объекта и тп.
        {
            string nameType = node.DescendantNodes().OfType<IdentifierNameSyntax>().LastOrDefault().GetText().ToString();
            string name = node.DescendantNodes().OfType<VariableDeclaratorSyntax>().LastOrDefault().ChildTokens().LastOrDefault().Text;
            if (isIFild.Contains(nameType))//из всей строки берем только первые 2 значения: тип и имя объекта, проверяем, есть ли такой тип в isIFild 
                lFilds.Add(new Fild(nameType, name));//получаем список созданных филдов с интерфейсом IFilds
        }

        public override void VisitExpressionStatement(ExpressionStatementSyntax node)//сюда попадаем из в самом конце
        {//узел представляет строку операции(fild1.fild2 = fild2;) из этого берем первый и последний токен- имена филдов. соответственно первый зависит от последнего
            string nameFildOne = node.DescendantNodes().OfType<IdentifierNameSyntax>().FirstOrDefault().GetFirstToken().Text;
            string nameFildTwo= node.DescendantNodes().OfType<IdentifierNameSyntax>().LastOrDefault().GetLastToken().Text;
            
            Fild fildOne= lFilds.Where(f => f.Name == nameFildOne).FirstOrDefault();//проверяем, есть ли это имя в списке филдов, чем отметаем лишние операции
            Fild fildTwo = lFilds.Where(f => f.Name == nameFildTwo).FirstOrDefault();

            if (fildOne != null && fildTwo != null)
            {//т пишем в файл
                System.IO.StreamWriter textFile = new System.IO.StreamWriter(@projectPath + "text.txt", true);
                textFile.WriteLine(fildOne.NameType + " зависит от " + fildTwo.NameType);
                textFile.Close();
            }
        }
        
        public void VisitMethodDeclaration(SyntaxNode node)//перегружаем visitMethodDeclaration под наше дерево и ищем нужный метод. дефолтный визит будет гулять по дереву за нас
        {
            var methods = node.DescendantNodes().OfType<MethodDeclarationSyntax>();

            foreach (var method in methods)
            {
                string methodName = method.Identifier.ToString();

                if(methodName== "CreateFilds")
                    base.VisitMethodDeclaration(method);
            }
        }
        

        public void VisitSimpleBaseType(SyntaxNode node)//узел SimpleBaseType содержит имена реализованных интерфейсов и наследников(все что после :)
        {
            var interfaceNames = node.DescendantNodes().OfType<SimpleBaseTypeSyntax>().Where(c => c.GetFirstToken().Text == "IFild").FirstOrDefault();//сравнимаем полученные имена с IFild и в случае истины добавляем имя класса в лист
            
            if (interfaceNames != null)
            {
                isIFild.Add(node.DescendantNodes().OfType<ClassDeclarationSyntax>().LastOrDefault().Identifier.Text);//имя содержитсяв узле ClassDeclaration, так что идем в него
            }

            
        }

    }
}
