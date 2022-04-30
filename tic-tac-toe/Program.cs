// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Author: Chia-Lun Liu
// Assignment: Create a Tic-Tac-Toe game

using System.Collections.Generic;

// List<string> position = new List<string>()
// {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

void main()
{
    Console.WriteLine("Hello, Welcome to our Tic-Tac-Toe Game!");
    List<string> position = new List<string>()
    {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
    
}

void draw3x3(List<string> list)
{
    Console.WriteLine(String.Join("|", list.GetRange(0,3)));
    Console.WriteLine("-+-+-");
    Console.WriteLine(String.Join("|", list.GetRange(3,3)));
    Console.WriteLine("-+-+-");
    Console.WriteLine(String.Join("|", list.GetRange(6,3)));
    Console.WriteLine("");
}

main();


// The Replace extensions I found.
namespace System.Collections.Generic
{
    public static class Extensions
    {
        public static int Replace<T>(this IList<T> source, T oldValue, T newValue)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var index = source.IndexOf(oldValue);
            if (index != -1)
                source[index] = newValue;
            return index;
        }

        public static void ReplaceAll<T>(this IList<T> source, T oldValue, T newValue)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            int index = -1;
            do
            {
                index = source.IndexOf(oldValue);
                if (index != -1)
                    source[index] = newValue;
            } while (index != -1);
        }


        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, T oldValue, T newValue)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return source.Select(x => EqualityComparer<T>.Default.Equals(x, oldValue) ? newValue : x);
        }
    }
}