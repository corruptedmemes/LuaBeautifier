using System.IO;
using Loretta.CodeAnalysis;
using Loretta.CodeAnalysis.Lua;

namespace LuaBeautifier
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var file = File.ReadAllText("input.lua");

            var parsed = LuaSyntaxTree.ParseText(file);

            File.WriteAllText("output.lua", parsed.GetRoot().NormalizeWhitespace().ToFullString());
        }
    }
}