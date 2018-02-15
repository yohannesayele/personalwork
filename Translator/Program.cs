using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<char, string>();
            map.Add('a', "@"); map.Add('A', "@");
            map.Add('b', "8"); map.Add('B', "8");
            map.Add('c', "("); map.Add('C', "(");
            map.Add('d', "|)"); map.Add('D', "|)");
            map.Add('e', "3"); map.Add('E', "3");
            map.Add('f', "#"); map.Add('F', "#");
            map.Add('g', "6"); map.Add('G', "6");
            map.Add('h', "[-]"); map.Add('H', "[-]");
            map.Add('i', "|"); map.Add('I', "|");
            map.Add('j', "_|"); map.Add('J', "_|");
            map.Add('k', "|<"); map.Add('K', "|<");
            map.Add('l', "1"); map.Add('L', "1");
            map.Add('m', "[]\\/[]"); map.Add('M', "[]\\/[]");
            map.Add('n', "[]\\[]"); map.Add('N', "[]\\[]");
            map.Add('o', "0"); map.Add('O', "0");
            map.Add('p', "|D"); map.Add('P', "|D");
            map.Add('q', "(,)"); map.Add('Q', "(,)");
            map.Add('r', "|Z"); map.Add('R', "|Z");
            map.Add('s', "$"); map.Add('S', "$");
            map.Add('t', "']['"); map.Add('T', "']['");
            map.Add('u', "|_|"); map.Add('U', "|_|");
            map.Add('v', "\\/"); map.Add('V', "\\/");
            map.Add('w', "\\/\\/"); map.Add('W', "\\/\\/");
            map.Add('x', "}{"); map.Add('X', "}{");
            map.Add('y', "`/"); map.Add('Y', "`/");
            map.Add('z', "2"); map.Add('Z', "2");

            Stream inputStream = Console.OpenStandardInput();
            StreamReader reader = new StreamReader(inputStream);
            //string x = reader.ReadToEnd();
            byte[] bytes = new byte[10000];
            Console.WriteLine("write word or prhase and press enter:");
            int outputLength = inputStream.Read(bytes, 0, 10000);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            //Char [] chars= x.ToCharArray();
            string input = new string(chars);                
                if (input.Length >= 1000)
                {
                    Console.WriteLine("input is so big");
                    Console.WriteLine("write word or phrhase again");
                    input = Console.ReadLine();
                }
                char[] array = input.ToCharArray();
                Console.WriteLine( array);
                string output = "";
                 foreach (var i in array)
                {
                    int asci=Convert.ToInt32(i);

                if (asci <= 126 && asci >= 32)
                {
                    if (map.ContainsKey(i))
                    {
                        output += (map[i]);
                    }

                    else {
                        output += i.ToString();
                    }
                }
                }
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }
    }

