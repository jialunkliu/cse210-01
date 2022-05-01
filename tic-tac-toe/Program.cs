// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Author: Chia-Lun Liu
// Assignment: Create a Tic-Tac-Toe game

using System.Collections.Generic;

// List<string> position = new List<string>()
// {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

void main()
{   
    int keeplay = 1;
    Console.WriteLine("Hello, Welcome to our Tic-Tac-Toe Game!\n");
    List<string> userInfo = nameAndIcon();
    string name1 = userInfo[0];
    string name2 = userInfo[2];
    string icon1 = userInfo[1];
    string icon2 = userInfo[3];
    Console.WriteLine("\nOkay! Let's start the Game!");
    do
    {
        List<string> position = new List<string>()
        {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        List<string> inputHistory = new List<string>();
        int count = 0;
        while (true)
        {
            // X's turn
            draw3x3(position);
            while (true)
            {
                Console.Write($"{name1}'s turn to choose a square (1-9): ");
                string userInputx = Console.ReadLine();
                if (int.TryParse(userInputx, out int value))
                {
                    if (int.Parse(userInputx) >= 1 && int.Parse(userInputx) <= 9)
                    {
                        if (inputHistory.Contains(userInputx) == false)
                        {
                            position.Replace(userInputx, icon1);
                            Console.WriteLine("");
                            inputHistory.Add(userInputx);
                            count += 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, {userInputx} has been taken, please choose a new spot.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{userInputx} is not in the range of (1-9), please try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"{userInputx} is not a valid input, please try again.");
                }
            }

            int checkpoint = checkIfWin(position);

            if (checkpoint == 1)
            {
                draw3x3(position);
                Console.WriteLine($"Congratuation {name1}! You won the Game!");
                break;
            } 

            else if (checkpoint ==0 && count == 5)
            {
                draw3x3(position);
                Console.WriteLine("It's a draw! Both of you did great! Good game!");
                break;
            }


            // O's turn
            draw3x3(position);
            while (true)
            {
                Console.Write($"{name2}'s turn to choose a square (1-9): ");
                string userInputo = Console.ReadLine();
                if (int.TryParse(userInputo, out int value))
                {
                    if (int.Parse(userInputo) >= 1 && int.Parse(userInputo) <= 9)
                    {
                        if (inputHistory.Contains(userInputo) == false)
                        {
                            position.Replace(userInputo, icon2);
                            Console.WriteLine("");
                            inputHistory.Add(userInputo);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, {userInputo} has been taken, please choose a new spot.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{userInputo} is not in the range of (1-9), please try again.");
                    }
                }
                else
                {
                    Console.WriteLine($"{userInputo} is not a valid input, please try again.");
                }
            }
            
            int checkpoint1 = checkIfWin(position);

            if (checkpoint1 == 1)
            {
                draw3x3(position);
                Console.WriteLine($"Congratuation {name2}! You won the Game!");
                break;
            } 
        }
        Console.Write("Play again(Y/N)? ");
        string answer = Console.ReadLine();
        Console.WriteLine();
        if (answer.ToLower() == "y")
        {
            keeplay = 1;
        }
        else
        {
            keeplay = 0;
        }
    } while (keeplay == 1);
    Console.WriteLine("Thank you for playing our Game! Bye~");
}

List<string> nameAndIcon()
{   // Get player1 and player2's name and icon they wanted.
    // Return a list of {name1, icon1, name2, icon2}
    List<string> userInfo = new List<string>();
    Console.Write("What is the name of first player? ");
    userInfo.Add(Console.ReadLine());
    Console.Write("Which icon would you like?\n(Could be normal 'O' or 'X' or what ever you want) ");
    userInfo.Add(Console.ReadLine());
    Console.Write("What is the name of second player? ");
    userInfo.Add(Console.ReadLine());
    Console.Write("Which icon would you like? ");
    userInfo.Add(Console.ReadLine());
    return userInfo;
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

int checkIfWin(List<string> list)
{   
    int result;
    // Check for rows horizontally
    if ((list[0] == list[1] && list[1] == list[2]) || (list[3] == list[4] && list[4] == list[5]) || (list[6] == list[7] && list[7] == list[8]))
    {
        result = 1;
    }
    // Check for rows vertically
    else if ((list[0] == list[3] && list[3] == list[6]) || (list[1] == list[4] && list[4] == list[7]) || (list[2] == list[5] && list[5] == list[8]))
    {
        result = 1;
    }
    // Check for rows diagonally
    else if ((list[0] == list[4] && list[4] == list[8]) || (list[2] == list[4] && list[4] == list[6]))
    {
        result = 1;
    }
    
    else
    {
        result = 0;
    }

    return result;
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