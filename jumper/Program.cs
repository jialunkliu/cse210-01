// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Random aString = new Random();
int ranIndex = aString.Next(0,3);
string[] texts = new[]
{
    "hello", "apple", "string"
};

string text = texts[ranIndex];

Console.WriteLine(text);
char[] textSplit = text.ToCharArray();
// List<string> letters = new List<string>();

foreach (char letter in textSplit)
{
    Console.WriteLine($"substring: {letter}");
    // letters.Add(txt);
}

// Console.WriteLine(string.Join(",", letters));