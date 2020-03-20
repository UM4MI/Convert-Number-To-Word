using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class NumberToWordsProgram
    {
        public string ToEnglish(UInt64 inputNumber, bool aboveQuintillion)
        {
            switch (inputNumber)
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

            }
            if (aboveQuintillion)
            {
                switch (inputNumber)
                {
                    case 1000: return "One Quintillion";
                    case 10000: return "Ten Quintillion";
                    case 100000: return "One Hundred Quintillion";
                    case 1000000: return "One Sextillion";
                    case 10000000: return "Ten Sextillion";
                    case 100000000: return "One Hundred Sextillion";
                    case 1000000000: return "One Septillion";
                    case 10000000000: return "Ten Septillion";
                    case 100000000000: return "One Hundred Septillion";
                    case 1000000000000: return "One Octillion";
                    case 10000000000000: return "Ten Octillion";
                    case 100000000000000: return "One Hundred Octillion";
                    case 1000000000000000: return "One Nonillion";
                    case 10000000000000000: return "Ten Nonillion";
                    case 100000000000000000: return "One Hundred Nonillion";
                    case 1000000000000000000: return "One Decillion";
                    case 10000000000000000000: return "Ten Decillion";
                }
            }
            else
            {
                switch (inputNumber)
                {
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
            }

            for (UInt64 iteration = 1; iteration <= 9; iteration++)
            {
                UInt64 iterationMultipleByTen = iteration * 10;
                if ((inputNumber >= iterationMultipleByTen) && (inputNumber < iterationMultipleByTen + 10))
                {
                    UInt64 r = inputNumber - iterationMultipleByTen;
                    //iterationMultipleByTen puluhan r satuan
                    return ToEnglish(iterationMultipleByTen, aboveQuintillion) + (r > 0 ? ("-" + ToEnglish(r, aboveQuintillion)) : "");
                }
            }

            for (UInt64 iteration = 1; iteration <= 9; iteration++)
            {
                UInt64 iterationMultipleByTen = iteration * 100;
                if ((inputNumber >= iterationMultipleByTen) && (inputNumber < iterationMultipleByTen + 100))
                {
                    UInt64 r = inputNumber - iterationMultipleByTen;
                    // inputNumber ratusan , r sisa puluhan, loop ke iterasi puluhan
                    return ToEnglish(iteration, aboveQuintillion) + " Hundred" + (r > 0 ? (" " + ToEnglish(r, aboveQuintillion)) : "");
                }
            }

            NumberToWordsProgram program = new NumberToWordsProgram();
            return program.BigNumberWord(inputNumber, aboveQuintillion);
        }
        //public string ToEnglishQuintillion(UInt64 inputNumber)
        //{
        //    switch (inputNumber)
        //    {
        //        case 0: return "Zero";
        //        case 1: return "One";
        //        case 2: return "Two";
        //        case 3: return "Three";
        //        case 4: return "Four";
        //        case 5: return "Five";
        //        case 6: return "Six";
        //        case 7: return "Seven";
        //        case 8: return "Eight";
        //        case 9: return "Nine";
        //        case 10: return "Ten";
        //        case 11: return "Eleven";
        //        case 12: return "Twelve";
        //        case 13: return "Thirteen";
        //        case 14: return "Fourteen";
        //        case 15: return "Fifteen";
        //        case 16: return "Sixteen";
        //        case 17: return "Seventeen";
        //        case 18: return "Eighteen";
        //        case 19: return "Nineteen";
        //        case 20: return "Twenty";
        //        case 30: return "Thirty";
        //        case 40: return "Forty";
        //        case 50: return "Fifty";
        //        case 60: return "Sixty";
        //        case 70: return "Seventy";
        //        case 80: return "Eighty";
        //        case 90: return "Ninety";
        //        case 100: return "One Hundred";
        //        case 1000: return "One Quintillion";
        //        case 10000: return "Ten Quintillion";
        //        case 100000: return "One Hundred Quintillion";
        //        case 1000000: return "One Sextillion";
        //        case 10000000: return "Ten Sextillion";
        //        case 100000000: return "One Hundred Sextillion";
        //        case 1000000000: return "One Septillion";
        //        case 10000000000: return "Ten Septillion";
        //        case 100000000000: return "One Hundred Septillion";
        //        case 1000000000000: return "One Octillion";
        //        case 10000000000000: return "Ten Octillion";
        //        case 100000000000000: return "One Hundred Octillion";
        //        case 1000000000000000: return "One Nonillion";
        //        case 10000000000000000: return "Ten Nonillion";
        //        case 100000000000000000: return "One Hundred Nonillion";
        //        case 1000000000000000000: return "One Decillion";
        //        case 10000000000000000000: return "Ten Decillion";
        //    }

        //    for (UInt64 iteration = 1; iteration <= 9; iteration++)
        //    {
        //        UInt64 iterationMultipleByTen = iteration * 10;
        //        if ((inputNumber >= iterationMultipleByTen) && (inputNumber < iterationMultipleByTen + 10))
        //        {
        //            UInt64 r = inputNumber - iterationMultipleByTen;
        //            //iterationMultipleByTen puluhan r satuan
        //            return ToEnglishQuintillion(iterationMultipleByTen) + (r > 0 ? ("-" + ToEnglishQuintillion(r)) : "");
        //        }
        //    }

        //    for (UInt64 iteration = 1; iteration <= 9; iteration++)
        //    {
        //        UInt64 iterationMultipleByTen = iteration * 100;
        //        if ((inputNumber >= iterationMultipleByTen) && (inputNumber < iterationMultipleByTen + 100))
        //        {
        //            UInt64 r = inputNumber - iterationMultipleByTen;
        //            // inputNumber ratusan , r sisa puluhan, loop ke iterasi puluhan
        //            return ToEnglishQuintillion(iteration) + " Hundred" + (r > 0 ? (" " + ToEnglishQuintillion(r)) : "");
        //        }
        //    }
        //    Program program = new Program();
        //    return program.BigNumberWord(inputNumber, true);
        //}
        public string BigNumberWord(UInt64 inputNumber, bool quintillion)
        {
            string output = "";
            UInt64 kilo = 0;
            while (inputNumber > 0)
            {
                UInt64 remainderMod = inputNumber % 1000;
                inputNumber = inputNumber / 1000;

                if (remainderMod > 0)
                {

                    string bigNumberWord = "";
                    if (quintillion)
                    {
                        if (kilo == 1) bigNumberWord = " Sextillion ";
                        if (kilo == 2) bigNumberWord = " Septillion ";
                        if (kilo == 4) bigNumberWord = " Octillion ";
                        if (kilo == 3) bigNumberWord = " Nonillion ";
                        if (kilo == 5) bigNumberWord = " Decillion ";
                        if (kilo == 6) bigNumberWord = " Undecillion ";
                    }
                    else
                    {
                        if (kilo == 1) bigNumberWord = " Thousand ";
                        if (kilo == 2) bigNumberWord = " Million ";
                        if (kilo == 3) bigNumberWord = " Billion ";
                        if (kilo == 4) bigNumberWord = " Trilion ";
                        if (kilo == 5) bigNumberWord = " Quadrillion ";
                        if (kilo == 6) bigNumberWord = " Quintillion ";
                    }
                    output = ToEnglish(remainderMod, quintillion) + bigNumberWord + output;
                }
                kilo++;
            }

            return (output);
        }
        public string numberToWords(UInt64 num)
        {
            return ToEnglish(num, false);
        }
        public string numberToWordQuintillion(UInt64 num)
        {
            return ToEnglish(num, true);
        }
        public struct DollarCent
        {
            public String dollar;
            public String cent;
        }
        public DollarCent DollarCentReturns(String inputNumber)
        {
            DollarCent values = new DollarCent();

            if (inputNumber.Contains("."))
            {
                int separator = inputNumber.Split('.').Length - 1;
                if (separator > 1)
                {
                    throw new InvalidInputNumberDecimalException();
                }
                string[] parts = inputNumber.Split('.');
                values.dollar = parts[0];
                values.cent = parts[1];
            }
            else if (inputNumber.Contains(","))
            {
                int separator = inputNumber.Split(',').Length - 1;
                if (separator > 1)
                {
                    throw new InvalidInputNumberDecimalException();
                }
                string[] parts = inputNumber.Split(',');
                values.dollar = parts[0];
                values.cent = parts[1];
            }
            else
            {
                values.cent = "0";
                values.dollar = inputNumber;
            }

            return values;
        }
        private static void Exception(BusinessException std)
        {
            string pattern = @"^[0-9]+$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(std.stringNumber))
                throw new InvalidInputNumberException(std.stringNumber);
            if (std.stringDecimalNumber == null)
            {
                throw new InvalidInputNumberDecimalException(std.stringDecimalNumber);
            }
            if (!regex.IsMatch(std.stringDecimalNumber))
                throw new InvalidInputNumberDecimalException(std.stringDecimalNumber);
            if (std.stringDecimalNumber.Length > 1 && !std.stringDecimalNumber.Equals("00"))
            {
                pattern = @"^[1-9]{1}[0-9]{1}$";
                regex = new Regex(pattern);
                if (!regex.IsMatch(std.stringDecimalNumber))
                    throw new InvalidInputNumberDecimalException(std.stringDecimalNumber);
            }
            if (std.stringNumber.Length > 37)
                throw new NumberOverflowException(std.stringNumber);
        }
        public string AboveQuintillion(String inputNumber, UInt64 decimalNumber)
        {
            NumberToWordsProgram program = new NumberToWordsProgram();
            String beforeQuintillionStr = inputNumber.Substring(inputNumber.Length - 18);
            String afterQuintillionStr = inputNumber.Substring(0, inputNumber.Length - beforeQuintillionStr.Length);
            String quintillionStr = afterQuintillionStr.Substring(afterQuintillionStr.Length - 3);
            UInt64 numberBeforeQuintilion = 0;
            UInt64 numberAfterQuintilion = 0;
            numberBeforeQuintilion = UInt64.Parse(beforeQuintillionStr);
            numberAfterQuintilion = UInt64.Parse(afterQuintillionStr);
            UInt64 quintillionNumber = UInt64.Parse(quintillionStr);
            if (decimalNumber == 0)
                if (numberBeforeQuintilion == 0)
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + "Dollars");
                }
                else if (quintillionNumber != 0)
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + " Quintillion " + program.numberToWords(numberBeforeQuintilion) + " Dollars ");
                }
                else
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + program.numberToWords(numberBeforeQuintilion) + " Dollars ");
                }

            else
            {
                if (numberBeforeQuintilion == 0)
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + "Dollars " + "and " + program.numberToWords(decimalNumber) + " Cents");
                }
                else if (quintillionNumber != 0)
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + " Quintillion " + program.numberToWords(numberBeforeQuintilion) + " Dollars " + "and " + program.numberToWords(decimalNumber) + " Cents");
                }
                else
                {
                    return (program.numberToWordQuintillion(numberAfterQuintilion) + program.numberToWords(numberBeforeQuintilion) + " Dollars " + "and " + program.numberToWords(decimalNumber) + " Cents");
                }
            }

        }
        public String BelowQuintillion(String inputNumber, UInt64 decimalNumber)
        {
            NumberToWordsProgram program = new NumberToWordsProgram();
            UInt64 numberBeforeQuintilion = 0;
            string dollar = " Dollar ";
            numberBeforeQuintilion = UInt64.Parse(inputNumber);
            if (!(numberBeforeQuintilion == 1 || numberBeforeQuintilion == 0))
            {
                dollar = " Dollars ";
            }

            if (decimalNumber == 0)
            {
                return (program.numberToWords(numberBeforeQuintilion) + dollar);
            }
            else if (numberBeforeQuintilion == 0 && !(decimalNumber == 0))
            {
                return program.numberToWords(decimalNumber) + " Cents ";
            }
            else
            {
                return (program.numberToWords(numberBeforeQuintilion) + dollar + "and " + program.numberToWords(decimalNumber) + " Cents ");
            }
        }
        public string ConvertToWords(string input)
        {
            String inputNumber = input;
            DollarCent results;
            BusinessException exception;
            try
            {
                results = DollarCentReturns(inputNumber);
                exception = new BusinessException();
                exception.stringNumber = results.dollar;
                exception.stringDecimalNumber = results.cent;
                Exception(exception);
            }
            catch (InvalidInputNumberException e)
            {
                return (e.Message);
            }
            catch (InvalidInputNumberDecimalException e)
            {
                return (e.Message);
            }
            catch (NumberOverflowException e)
            {
                return (e.Message);
            }
            NumberToWordsProgram program = new NumberToWordsProgram();
            inputNumber = results.dollar;
            UInt64 decimalNumber = UInt64.Parse(results.cent);
            //above quintillion
            if (inputNumber.Length > 18)
            {
                return program.AboveQuintillion(inputNumber, decimalNumber);
            }
            //below quintilion
            else
            {
                return program.BelowQuintillion(inputNumber, decimalNumber);
            }
        }

    }
}
