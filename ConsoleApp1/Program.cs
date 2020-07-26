using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for Enter the String
            Console.WriteLine("Please Enter the String : ");
            string Str = Console.ReadLine();
            #endregion

            #region for Check the String duplicate character and length of duplicate character
            int i, j, l, k = 0;
            int MatchLength = 0;
            string MatchValue = string.Empty;
            string NewStr = string.Empty;
            try
            {
                if (Str.Length > 0)
                {
                    for (i = 0; i < Str.Length; i++)
                    {
                        for (j = 0; j < Str.Length; j++)
                        {
                            if (Str[i] == Str[j])
                            {
                                if (NewStr.Contains(Str[i]) == false)
                                {
                                    if (k == 0)
                                    {
                                        k = 1;
                                    }
                                    else
                                    {
                                        if (k == 1)
                                        {
                                            NewStr = NewStr + Str[i].ToString();
                                        }
                                    }
                                }
                            }
                        }
                        k = 0;
                    }

                    for (l = 0; l < NewStr.Length; l++)
                    {
                        if (l == 0)
                        {
                            MatchLength = Str.Count(x => (x == NewStr[l]));
                            MatchValue = NewStr[l].ToString();
                        }
                        else
                        {
                            if (MatchLength < Str.Count(x => (x == NewStr[l])))
                            {
                                MatchLength = Str.Count(x => (x == NewStr[l]));
                                MatchValue = NewStr[l].ToString();
                            }
                        }
                    }
                    Console.WriteLine("FrequentCharacter :\"" + MatchValue + "\" , Count: " + MatchLength + "");
                }
                else
                {
                    Console.WriteLine("Error : Please Enter the String First.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :\"" + ex.Message + "\"");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
