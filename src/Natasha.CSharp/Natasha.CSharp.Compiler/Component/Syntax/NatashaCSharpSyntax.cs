﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace Natasha.CSharp.Compiler.Component
{
    public static class NatashaCSharpSyntax
    {

        //private readonly static AdhocWorkspace _workSpace;
        private readonly static CSharpParseOptions _options;
        //private readonly static OptionSet _formartOptions;
        static NatashaCSharpSyntax()
        {

            _options = new CSharpParseOptions(LanguageVersion.Preview);
            #region Settings
            //var workspace = new AdhocWorkspace();
            //_formartOptions = workspace.Options;
            ////_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.IndentBraces, true);
            ////_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.IndentBlock, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.IndentSwitchCaseSection, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.IndentSwitchCaseSectionWhenBlock, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.IndentSwitchSection, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.LabelPositioning, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForCatch, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForClausesInQuery, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForElse, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForFinally, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForMembersInAnonymousTypes, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLineForMembersInObjectInit, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAccessors, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAnonymousMethods, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAnonymousTypes, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInControlBlocks, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInLambdaExpressionBody, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInMethods, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInObjectCollectionArrayInitializers, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInProperties, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInTypes, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterCast, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterColonInBaseTypeDeclaration, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterComma, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterControlFlowStatementKeyword, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterDot, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterMethodCallName, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceAfterSemicolonsInForStatement, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBeforeColonInBaseTypeDeclaration, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBeforeComma, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBeforeDot, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBeforeOpenSquareBracket, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBeforeSemicolonsInForStatement, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptyMethodCallParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptyMethodDeclarationParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptySquareBrackets, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpacesIgnoreAroundVariableDeclaration, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinCastParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinExpressionParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinMethodCallParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinMethodDeclarationParenthesis, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinOtherParentheses, false);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpaceWithinSquareBrackets, false);
            ////_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpacingAfterMethodDeclarationName, true);
            ////_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.SpacingAroundBinaryOperator, _options.Language);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.WrappingKeepStatementsOnSingleLine, true);
            //_formartOptions = _formartOptions.WithChangedOption(CSharpFormattingOptions.WrappingPreserveSingleLine, true);
            #endregion

        }


        public static SyntaxTree ParseTree(string script, CSharpParseOptions? options, Encoding? encoding = null)
        {
            return ParseTree(script, "", options, encoding);
        }

        public static SyntaxTree ParseTree(string script, string filePath, CSharpParseOptions? options, Encoding? encoding = null)
        {
            if (options == null)
            {
                options = _options;
            }
            encoding = encoding == null ? Encoding.UTF8 : encoding;
            //Mark1 : 647ms
            //Mark2 : 128ms
            //Mark : 5.0M (Memory:2023-02-27)
            var tree = CSharpSyntaxTree.ParseText(script.Trim(), options, filePath, encoding);
            return FormartTree(tree.GetCompilationUnitRoot(), options, encoding);
        }


        /// <summary>
        /// 格式化语法树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static SyntaxTree FormartTree(CompilationUnitSyntax root, CSharpParseOptions? options, Encoding encoding, string filePath = "")
        {
            if (options == null)
            {
                options = _options;
            }
            //return tree.GetRoot().NormalizeWhitespace().SyntaxTree;
            //Console.ReadKey();
            //Mark : 0.3M (Memory:2023-02-27)
            //Roslyn BUG https://github.com/dotnet/roslyn/issues/58150
            return CSharpSyntaxTree.ParseText(root.NormalizeWhitespace().SyntaxTree.ToString(), options, filePath, encoding: encoding);
        }
    }
}


