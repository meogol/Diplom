using ConsoleApp1.InfoClass;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using ConsoleApp2;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace ConsoleApp1.Generator
{
    class Generators
    {
        private string namepace { get; set; }

        public List<EntityInfo> entityInfos { get; set; }

        public Generators() { }

        public Generators(string Namespace, List<EntityInfo> EntityInfos)
        {
            namepace = Namespace;
            entityInfos = EntityInfos;
        }

        public void MyTestGenerator()
        {
            List<MemberDeclarationSyntax> lClassDeclaration = new List<MemberDeclarationSyntax>();

            for (int i = 0; i < 2; i++)
            {
            lClassDeclaration.Add(//создаем классы
                
                    ClassDeclaration("C").WithModifiers
                        (
                            TokenList
                            (
                                Token(SyntaxKind.PublicKeyword)
                            )
                        ).WithMembers(List<MemberDeclarationSyntax>(AddEntity())).//добавим к классу entity
                        WithBaseList//добавим интерфейс
                            (
                                BaseList
                                (
                                    SingletonSeparatedList<BaseTypeSyntax>
                                    (
                                        SimpleBaseType
                                        (
                                            IdentifierName("GraphBase")
                                        )
                                    )
                                )
                            ).
                        WithMembers
                        (
                        List<MemberDeclarationSyntax>
                            (
                                new MemberDeclarationSyntax[]
                                {
                                    CreateConstructor(), CreateMethod()
                                }
                            )
                        )
                    );
                
            }
           


            //соберем все вместе
            var code = CompilationUnit().WithUsings(List(CreateUsing()))
                .WithMembers(SingletonList<MemberDeclarationSyntax>(CreateNamespace().
                    WithMembers(List(lClassDeclaration))
                    )
                ).NormalizeWhitespace();


            Console.WriteLine(code.GetText());
        }
        
        private NamespaceDeclarationSyntax CreateNamespace()
        {
            var namespaseDiective = NamespaceDeclaration//namespace
                    (
                        QualifiedName
                        (
                            QualifiedName
                            (
                                IdentifierName("Egar"),
                                IdentifierName("Focus")
                            ),
                            IdentifierName("DealModule")
                        )
                    );

            return namespaseDiective;
        }

        private MemberDeclarationSyntax[] AddEntity()
        {
            MemberDeclarationSyntax[] entity = {//подключаем entity
                FieldDeclaration
                                (
                                    VariableDeclaration
                                    (
                                        QualifiedName
                                        (
                                            QualifiedName
                                            (
                                                QualifiedName
                                                (
                                                    QualifiedName
                                                    (
                                                        IdentifierName("Egar"),
                                                        IdentifierName("Focus")
                                                    ),
                                                    IdentifierName("DealModule")
                                                ),
                                                IdentifierName("Deals")
                                            ),
                                            IdentifierName("FutureBaseGen")
                                        )
                                    )
                                    .WithVariables
                                    (
                                        SingletonSeparatedList<VariableDeclaratorSyntax>
                                        (
                                            VariableDeclarator
                                            (
                                                Identifier("Entity")
                                            )
                                        )
                                    )
                                )

            };

            return entity;
        }
        
        private ConstructorDeclarationSyntax CreateConstructor()
        {
            var constructorMemberDeclarationSyntax =
                ConstructorDeclaration
                        (
                            Identifier("C")
                        )
                        .WithModifiers
                        (
                            TokenList
                            (
                                Token(SyntaxKind.PublicKeyword)
                            )
                        )
                        .WithParameterList//параметры конструктора
                        (
                            ParameterList
                            (
                                SeparatedList<ParameterSyntax>
                                (
                                    new SyntaxNodeOrToken[]
                                    {
                                        Parameter
                                        (
                                            Identifier("entity")
                                        )
                                        .WithType
                                        (
                                            IdentifierName("FieldsEntity")
                                        ),
                                        Token(SyntaxKind.CommaToken),
                                        Parameter
                                        (
                                            Identifier("extention")
                                        )
                                        .WithType
                                        (
                                            IdentifierName("EntityExtentionBase")
                                        )
                                    }
                                )
                            )
                        ).WithInitializer(//конструктор родителя 
                            ConstructorInitializer
                            (
                                SyntaxKind.BaseConstructorInitializer,
                                ArgumentList
                                (
                                    SeparatedList<ArgumentSyntax>
                                    (
                                        new SyntaxNodeOrToken[]
                                        {
                                            Argument
                                            (
                                                IdentifierName("entity")
                                            ),
                                            Token(SyntaxKind.CommaToken),
                                            Argument
                                            (
                                                IdentifierName("extention")
                                            )
                                        }
                                    )
                                )
                            )
                    ).WithBody//добавим тело коструктора
                    (
                        Block
                        (
                            SingletonList<StatementSyntax>
                                (
                                    CreateConstructorBody()
                                )
                        )
                    );

            return constructorMemberDeclarationSyntax;
        }
        
        private ExpressionStatementSyntax CreateConstructorBody()
        {
            var constructorBodeExpressionStatement= ExpressionStatement//сгененрируем тело конструктора
            (
                AssignmentExpression
                (
                    SyntaxKind.SimpleAssignmentExpression,MemberAccessExpression
                    (
                        SyntaxKind.SimpleMemberAccessExpression,
                        ThisExpression(),
                        IdentifierName("Entity")
                    ),
                    CastExpression
                    (
                        QualifiedName
                        (
                            QualifiedName
                            (
                                QualifiedName
                                (
                                    QualifiedName
                                    (
                                        IdentifierName("Egar"),IdentifierName("Focus")
                                    ),IdentifierName("DealModule")
                                ),IdentifierName("Deals")
                             ),IdentifierName("FutureBaseGen")
                        ),IdentifierName("entity")
                    )
               )
           );

            return constructorBodeExpressionStatement;
        }

        private UsingDirectiveSyntax[] CreateUsing()
        {
            UsingDirectiveSyntax[] usingDirective = { //генерируем using
            UsingDirective
            (
                QualifiedName
                (
                    QualifiedName
                    (
                        IdentifierName("System"),
                        IdentifierName("Collections")
                    ),
                    IdentifierName("Generic")
                )
            ),
            UsingDirective
            (
                QualifiedName
                (
                    QualifiedName
                    (
                        QualifiedName
                        (
                            IdentifierName("Egar"),
                            IdentifierName("Focus")
                        ),
                        IdentifierName("DealModule")
                    ),
                    IdentifierName("Fields")
                )
            ),
            UsingDirective
            (
                QualifiedName
                (
                    QualifiedName
                    (
                        QualifiedName
                        (
                            IdentifierName("Egar"),
                            IdentifierName("Focus")
                        ),
                        IdentifierName("Framework")
                    ),
                    IdentifierName("Types")
                )
            )
            };

            return usingDirective;
        }

        private MethodDeclarationSyntax CreateMethod()
        {
            var methodDeclaration = MethodDeclaration
                            (
                                GenericName
                                (
                                    Identifier("Dictionary")
                                )
                                .WithTypeArgumentList
                                (
                                    TypeArgumentList
                                    (
                                        SeparatedList<TypeSyntax>
                                        (
                                            new SyntaxNodeOrToken[]
                                            {
                                                PredefinedType
                                                (
                                                    Token(SyntaxKind.StringKeyword)
                                                ),
                                                Token(SyntaxKind.CommaToken),
                                                GenericName
                                                (
                                                    Identifier("List")
                                                )
                                                .WithTypeArgumentList
                                                (
                                                    TypeArgumentList
                                                    (
                                                        SingletonSeparatedList<TypeSyntax>
                                                        (
                                                            IdentifierName("CalcFieldInfo")
                                                        )
                                                    )
                                                )
                                            }
                                        )
                                    )
                                ),
                                Identifier("CreateCalcOrder")
                            ).WithModifiers
                            (
                                TokenList
                                (
                                    new[]
                                    {
                                        Token(SyntaxKind.ProtectedKeyword),
                                        Token(SyntaxKind.OverrideKeyword)
                                    }
                                )
                            ).
                            WithBody
                            (
                                Block
                                (
                                    CreateMethodBody(), 
                                    ReturnStatement
                                    (
                                        IdentifierName("calcOrder")
                                    )
                                )
                            );

            return methodDeclaration;
        }

        private LocalDeclarationStatementSyntax CreateMethodBody()
        {
            var methodBodyLocalDeclarationStatement = LocalDeclarationStatement
            (
                    VariableDeclaration
                    (
                        IdentifierName("var")
                    )
                .WithVariables
                (
                SingletonSeparatedList<VariableDeclaratorSyntax>
                    (
                    VariableDeclarator
                    (
                        Identifier("calcOrder")
                    )
                    .WithInitializer
                    (
                        EqualsValueClause
                        (
                            ObjectCreationExpression
                                (
                                    GenericName
                                    (
                                        Identifier("Dictionary")
                                    )
                                    .WithTypeArgumentList
                                    (
                                        TypeArgumentList
                                        (
                                            SeparatedList<TypeSyntax>
                                            (
                                                new SyntaxNodeOrToken[]
                                                {
                                                    PredefinedType
                                                    (
                                                        Token(SyntaxKind.StringKeyword)
                                                    ),
                                                    Token(SyntaxKind.CommaToken),GenericName
                                                    (
                                                        Identifier("List")
                                                    )
                                                    .WithTypeArgumentList
                                                    (
                                                        TypeArgumentList
                                                        (
                                                            SingletonSeparatedList<TypeSyntax>
                                                            (
                                                                IdentifierName("CalcFieldInfo")
                                                            )
                                                        )
                                                    )
                                                }
                                            )
                                        )
                                    )
                                )
                                .WithArgumentList
                                (
                                    ArgumentList()
                                )
                                .WithInitializer
                                (
                                    InitializerExpression
                                    (
                                        SyntaxKind.CollectionInitializerExpression,
                                        SingletonSeparatedList<ExpressionSyntax>
                                        (
                                           CreateList()
                                        )
                                    )
                                )
                            )
                        )
                    )
                )
            );

            return methodBodyLocalDeclarationStatement;
        }

        private InitializerExpressionSyntax CreateList()
        {
            var newList = InitializerExpression
            (
                SyntaxKind.ComplexElementInitializerExpression,
                SeparatedList<ExpressionSyntax>
                (
                    new SyntaxNodeOrToken[]
                    {
                        LiteralExpression
                        (
                            SyntaxKind.StringLiteralExpression,
                            Literal("")
                        ),
                        Token(SyntaxKind.CommaToken),
                        ObjectCreationExpression
                        (
                            GenericName
                            (
                                Identifier("List")
                            )
                            .WithTypeArgumentList
                            (
                                TypeArgumentList
                                (
                                    SingletonSeparatedList<TypeSyntax>
                                    (
                                        IdentifierName("CalcFieldInfo")
                                    )
                                )
                            )
                        )
                        .WithArgumentList
                        (
                            ArgumentList()
                        )
                        .WithInitializer
                        (
                            InitializerExpression
                            (
                                SyntaxKind.CollectionInitializerExpression,
                                SingletonSeparatedList<ExpressionSyntax>
                                (
                                    ObjectCreationExpression
                                    (
                                        IdentifierName("CalcFieldInfo")
                                    )
                                    .WithArgumentList
                                    (
                                        ArgumentList
                                        (
                                            SeparatedList<ArgumentSyntax>
                                            (
                                                new SyntaxNodeOrToken[]
                                                {
                                                    Argument
                                                    (
                                                        MemberAccessExpression
                                                        (
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        IdentifierName("Entity"),
                                                        IdentifierName("DayRule")
                                                        )
                                                    ),
                                                    Token(SyntaxKind.CommaToken),
                                                    Argument
                                                    (
                                                        ObjectCreationExpression
                                                        (
                                                            GenericName
                                                            (
                                                                Identifier("List")
                                                            )
                                                            .WithTypeArgumentList
                                                            (
                                                                TypeArgumentList
                                                                (
                                                                    SingletonSeparatedList<TypeSyntax>
                                                                    (
                                                                        IdentifierName("FieldBase")
                                                                    )
                                                                )
                                                            )
                                                        )
                                                        .WithArgumentList
                                                        (
                                                            ArgumentList()
                                                        )
                                                    )
                                                }
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    }
                )
            );
                            

            return newList;
        }

        
    }
}
