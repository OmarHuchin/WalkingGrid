using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Read:
            Console.WriteLine("Enter number of cases");
            string numberString = Console.ReadLine();
            int cases = 0;
            if (int.TryParse(numberString, out cases))
            {
                for (int i = 0; i < cases; i++) {
                    int rows, columns;
                    string rowStr, columStr;
                    Entries:
                    Console.WriteLine("Enter number of rows");
                    rowStr = Console.ReadLine();
                    Console.WriteLine("Enter number of columns");
                    columStr = Console.ReadLine();
                    if (int.TryParse(rowStr, out rows) && int.TryParse(columStr, out columns))
                    {
                        Console.WriteLine("Output is");
                        if (columns == 1)
                        {
                            if (rows == 1)
                            {
                                Console.WriteLine("R");
                            }
                            else
                            {
                                Console.WriteLine("D");
                            }

                        }
                        else if ((rows == columns) && (rows > 1))
                         {
                            if ((rows % 2) == 0)
                            {
                                Console.WriteLine("L");
                            }
                            else
                            {
                                Console.WriteLine("R");
                            }

                        }
                        else if ((rows > columns) && (columns > 1))
                        {
                            if ((columns % 2)
                                        == 0)
                            {
                                Console.WriteLine("U");
                            }
                            else
                            {
                                Console.WriteLine("D");
                            }

                        }
                        else if (columns > rows)
                        {
                            if ((rows % 2) == 0)
                            {
                                Console.WriteLine("L");
                            }
                            else
                            {
                                Console.WriteLine("R");
                            }

                        }
                         
                    }
                    else
                    {
                        Console.WriteLine("Incorrect entry");
                        goto Entries;
                    }
                }
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Incorrect entry");
                goto Read;
            }
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
