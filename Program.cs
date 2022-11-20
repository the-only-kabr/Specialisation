
using System.Globalization;

string text = Console.ReadLine();
string[] words = text.Split(' ');
string[] shortwords = new string[words.Length];
int k = 0;
 for (int i = 0; i < words.Length; i++)
       {if (words[i].Length <= 3)
             {
        shortwords[k] = words[i];
        k++;
              }
             
        } 
 for (int i = 0; i < k; i++)
    Console.WriteLine(shortwords[i] + " ");