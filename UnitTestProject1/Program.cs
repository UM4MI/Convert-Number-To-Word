using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject1
{
    class Program
    {
         public string ToEnglish(UInt64 x)
        {
            switch (x)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                case 20: return "Twenty";
                case 30: return "Thirty";
                case 40: return "Forty";
                case 50: return "Fifty";
                case 60: return "Sixty";
                case 70: return "Seventy";
                case 80: return "Eighty";
                case 90: return "Ninety";
                case 100: return "One Hundred";
                case 1000: return "One Thousand";
                case 10000: return "Ten Thousand";
                case 100000: return "One Hundred Thousand";
                case 1000000: return "One Million";
                case 10000000: return "Ten Million";
                case 100000000: return "One Hundred Million";
                case 1000000000: return "One Billion";
                case 10000000000: return "Ten Billion";
                case 100000000000: return "One Hundred Billion";
                case 1000000000000: return "One Trillion";
                case 10000000000000: return "Ten Trillion";
                case 100000000000000: return "One Hundred Trillion";
                case 1000000000000000: return "One Quadrillion";
                case 10000000000000000: return "Ten Quadrillion";
                case 100000000000000000: return "One Hundred Quadrillion";
                case 1000000000000000000: return "One Quintillion";
                case 10000000000000000000: return "Ten Quintillion";
            }
            if (x < 100)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 10;
                    if ((x >= j) && (x < j + 10))
                    {
                        UInt64 r = x - j;
                        //j puluhan r satuan
                        return ToEnglish(j) + (r > 0 ? ("-" + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 1000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 100;
                    if ((x >= j) && (x < j + 100))
                    {
                        UInt64 r = x - j;
                        // x ratusan , r sisa puluhan, loop ke iterasi puluhan
                        return ToEnglish(i) + " Hundred" + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 10000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 1000;
                    if ((x >= j) && (x < j + 1000))
                    {
                        UInt64 r = x - j;
                        // x ribuan , r sisa ratusan, loop ke iterasi ratusan
                        return ToEnglish(i) + " Thousand" + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 1000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 100000;
                    // x ribuan , r sisa ratusan, loop ke iterasi ratusan
                    if ((x >= j) && (x < j + 100000))
                    {
                        UInt64 r = x - j;
                        return ToEnglish(i) + " Million" + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 1000000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 100000000;
                    if ((x >= j) && (x < j + 100000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglish(i) + " Billion" + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 1000000000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 100000000000;
                    if ((x >= j) && (x < j + 1000000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglish(i) + " Trilion " + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }

            if (x < 1000000000000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 10000000000000;
                    if ((x >= j) && (x < j + 100000000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglish(i) + " Quadrillion " + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }
            if (x < 1000000000000000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 1000000000000000;
                    if ((x >= j) && (x < j + 10000000000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglish(i) + " Quintillion " + (r > 0 ? (" " + ToEnglish(r)) : "");
                    }
                }
            }

            Program n = new Program();
            return n.tes(x);
        }
        //unused method
        public string ToEnglishBillion(UInt64 x)
        {
            switch (x)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "Thirteen";
                case 14: return "Fourteen";
                case 15: return "Fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                case 20: return "Twenty";
                case 30: return "Thirty";
                case 40: return "Forty";
                case 50: return "Fifty";
                case 60: return "Sixty";
                case 70: return "Seventy";
                case 80: return "Eighty";
                case 90: return "Ninety";
                case 100: return "One Hundred";
                case 1000: return "One Trillion";
                case 1000000: return "One Quadrillion";
                case 1000000000: return "One Quintillion";
            }
            if (x < 100)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 10;
                    if ((x >= j) && (x < j + 10))
                    {
                        UInt64 r = x - j;
                        //j puluhan r satuan
                        return ToEnglishBillion(j) + (r > 0 ? ("-" + ToEnglishBillion(r)) : "");
                    }
                }
            }
            if (x < 1000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 100;
                    if ((x >= j) && (x < j + 100))
                    {
                        UInt64 r = x - j;
                        // x ratusan , r sisa puluhan, loop ke iterasi puluhan
                        return ToEnglishBillion(i) + " Hundred" + (r > 0 ? (" " + ToEnglishBillion(r)) : "");
                    }
                }
            }
            if (x < 10000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 1000;
                    if ((x >= j) && (x < j + 1000))
                    {
                        UInt64 r = x - j;
                        // x ribuan , r sisa ratusan, loop ke iterasi ratusan
                        return ToEnglishBillion(i) + " Trillion " + (r > 0 ? (" " + ToEnglishBillion(r)) : "");
                    }
                }
            }
            if (x < 1000000)
            {
                for (UInt64 i = 1; i <= 9; i++)
                {
                    UInt64 j = i * 1000000;
                    // x ribuan , r sisa ratusan, loop ke iterasi ratusan
                    if ((x >= j) && (x < j + 1000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglishBillion(i) + " Quadrilion" + (r > 0 ? (" " + ToEnglishBillion(r)) : "");
                    }
                }
            }
            if (x < 1000000000)
            {
                for (UInt64 i = 1; i <= 4; i++)
                {
                    UInt64 j = i * 1000000000;
                    if ((x >= j) && (x < j + 1000000000))
                    {
                        UInt64 r = x - j;
                        return ToEnglishBillion(i) + " Quintilion" + (r > 0 ? (" " + ToEnglishBillion(r)) : "");
                    }
                }
            }

            Program n = new Program();
            return n.tesBillion(x);
        }
        string numberToWords(UInt64 num)
        {
            return ToEnglish(num);
        }
        string numberToWordBillion(UInt64 num)
        {
            return ToEnglishBillion(num);
        }
        string tes(UInt64 x)
        {

            string output = "";
            UInt64 kilo = 0;
            while (x > 0)
            {
                UInt64 y = x % 1000;
                x = x / 1000;
                //Console.WriteLine("x " + x);
                //Console.WriteLine("y " + y);

                if (y > 0)
                {
                    string t = "";
                    if (kilo == 1) t = " Thousand ";
                    if (kilo == 2) t = " Million ";
                    if (kilo == 3) t = " Billion ";
                    if (kilo == 4) t = " Trilion ";
                    if (kilo == 5) t = " Quadrillion ";
                    output = ToEnglish(y) + t + output;
                }
                kilo++;
            }

            return (output);
        }
        string tesBillion(UInt64 x)
        {

            string output = "";
            UInt64 kilo = 0;
            while (x > 0)
            {
                UInt64 y = x % 1000;
                x = x / 1000;
                //Console.WriteLine("x " + x);
                //Console.WriteLine("y " + y);

                if (y > 0)
                {
                    string t = "";
                    if (kilo == 1) t = " Billion ";
                    if (kilo == 2) t = " Trilion ";
                    if (kilo == 3) t = " Quadrillion ";
                    output = ToEnglish(y) + t + output;
                }
                kilo++;
            }

            return (output);
        }

        string MainTest(string input)
        {
            Program n = new Program();
            UInt64 angkaDecimal;
            String inputNumber = input;
            //bool keepLooping = true;
            //while (keepLooping)
            //{
                //Console.WriteLine("TES");
                //inputNumber = Console.ReadLine();
                Console.WriteLine("Inpuwadawdt :" + inputNumber);
                if (inputNumber.Contains("."))
                {
                    string[] parts = inputNumber.Split('.');
                    inputNumber = parts[0];
                    angkaDecimal = UInt64.Parse(parts[1]);
                }
                else if (inputNumber.Contains(","))
                {
                    string[] parts = inputNumber.Split(',');
                    inputNumber = parts[0];
                    angkaDecimal = UInt64.Parse(parts[1]);
                }
                else
                {
                    angkaDecimal = 0;
                }
                //unused approach
                //if (inputNumber.Length > 9)
                //{

                //    String string1 = inputNumber.Substring(inputNumber.Length - 9);
                //    String string2 = inputNumber.Substring(0, inputNumber.Length - string1.Length);

                //    //var floatNumber1 = float.Parse(string1);
                //    //var floatNumber2 = float.Parse(string2);

                //    //double decimalNumber = (floatNumber1 - Math.Truncate(floatNumber1));
                //    //double decimalNumber2 = (floatNumber1 - Math.Truncate(floatNumber1)) * 100;

                //    int UInt64Number = Int32.Parse(string1);
                //    //int UInt64DecimalNumber = Convert.ToInt32(decimalNumber2);

                //    int UInt64Number2 = Int32.Parse(string2);

                //    if (UInt64Number == 0)
                //    {
                //        Console.WriteLine(n.numberToWordBillion(UInt64Number2) + " Billion " + "Dollars");
                //    }else
                //    {
                //        Console.WriteLine(n.numberToWordBillion(UInt64Number2) + " Billion " + n.numberToWords(UInt64Number) + " Dollars " + "and " + n.numberToWords(angkaDecimal) + " Cents");
                //    }
                //}
                //else
                //{
                //try
                //{
                //    var floatNumber1 = float.Parse(inputNumber);
                //}
                //catch (InvalidCastException e)
                //{
                //    Console.WriteLine(e);
                //}
                //double decimalNumber = (floatNumber1 - Math.Truncate(floatNumber1));
                //double decimalNumber2 = (floatNumber1 - Math.Truncate(floatNumber1)) * 100;
                UInt64 UInt64Number = 0;
                try
                {
                    UInt64Number = UInt64.Parse(inputNumber);
                    return(n.numberToWords(UInt64Number) + " Dollars " + "and " + n.numberToWords(angkaDecimal) + " Cents");
                }
                catch (InvalidCastException e)
                {
                    return("Invalid Cast");
                }
                catch (FormatException e)
                {
                    return("Wrong Format");
                }
                catch (OverflowException e)
                {
                    return("Overflow Number");
                }
                //int UInt64DecimalNumber = Convert.ToInt32(decimalNumber2);
                //Console.WriteLine("input decimal " + UInt64DecimalNumber);
                //Console.WriteLine("input " + floatNumber);


                //}


            //    if (Console.ReadKey().Key == ConsoleKey.Escape)
            //    {
            //        keepLooping = false;
            //        inputNumber = null;
            //    }
            //}

        }

    };
 }
