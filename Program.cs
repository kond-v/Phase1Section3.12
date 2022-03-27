using System.IO;
using System;
using System.Text;

doApp();

static void doApp()
{
    string dir = Environment.CurrentDirectory;
    string filename = Path.Combine(dir, "data.txt");
    if (File.Exists(filename))
    {
        Console.WriteLine("File {0} exists.", filename);
        string [] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    else { 
        Console.WriteLine("No file {0} exists", filename); 
        using (StreamWriter swr = File.CreateText(filename))
        {
            swr.WriteLine("This is line one");
            swr.WriteLine("This is line two");
            swr.WriteLine("This is line three");
            swr.WriteLine("This is line four");
            swr.WriteLine("This is line five");
        }
        Console.WriteLine(filename + "created");

    }
    return;
}