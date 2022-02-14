using System;

using R5T.T0037;
using R5T.T0037.X0001;


namespace System
{
    public static class ICodeDirectoryNameExtensions
    {
        public static string Classes(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Classes;
        }

        public static string Code(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Code;
        }

        public static string Constants(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Constants;
        }

        public static string Extensions(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Extensions;
        }

        public static string Interfaces(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Interfaces;
        }

        public static string Source(this ICodeDirectoryName _)
        {
            return CodeDirectoryNames.Source;
        }
    }
}
