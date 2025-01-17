﻿namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# basics\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}