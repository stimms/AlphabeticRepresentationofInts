using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onetoonethousand
{
    public static class IntExtensions
    {
        public static string GetAlphabeticalRepresentation(this int i)
        {
            string currentNumber = "";
            currentNumber = ProcessThousands(i, currentNumber);
            currentNumber = ProcessHundreds(i, currentNumber);
            currentNumber = ProcessTens(i, currentNumber);
            currentNumber = ProcessUnits(i, currentNumber);
            return currentNumber;
        }

        private static string ProcessUnits(int i, string currentNumber)
        {
            if (i % 100 < 10 || i % 100 >= 20)
            {
                currentNumber = AddOneToTen(i, currentNumber);
            }
            else
            {
                currentNumber = AddTeens(i, currentNumber);
            }
            return currentNumber;
        }

        private static string ProcessTens(int i, string currentNumber)
        {
            if ((i / 10) % 10 > 1)
            {
                currentNumber = AddTens(i, currentNumber);
            }
            return currentNumber;
        }

        private static string ProcessHundreds(int i, string currentNumber)
        {
            if (i >= 100 && i % 1000 > 0)
            {
                currentNumber = AddOneToTen(i / 100, currentNumber);
                currentNumber += "hundred";
                if (i % 100 != 0)
                    currentNumber += "and";
            }
            return currentNumber;
        }

        private static string ProcessThousands(int i, string currentNumber)
        {
            if (i >= 1000)
            {
                currentNumber = AddOneToTen(i / 1000, currentNumber);
                currentNumber += "thousand";
            }
            return currentNumber;
        }

        private static string AddTeens(int i, string currentNumber)
        {
            switch (i % 10)
            {
                case 0:
                    currentNumber += "ten";
                    break;
                case 1:
                    currentNumber += "eleven";
                    break;
                case 2:
                    currentNumber += "twelve";
                    break;
                case 3:
                    currentNumber += "thirteen";
                    break;
                case 4:
                    currentNumber += "fourteen";
                    break;
                case 5:
                    currentNumber += "fifteen";
                    break;
                case 6:
                    currentNumber += "sixteen";
                    break;
                case 7:
                    currentNumber += "seventeen";
                    break;
                case 8:
                    currentNumber += "eighteen";
                    break;
                case 9:
                    currentNumber += "nineteen";
                    break;
            }
            return currentNumber;
        }

        private static string AddTens(int i, string currentNumber)
        {
            switch ((i / 10) % 10)
            {
                case 2:
                    currentNumber += "twenty";
                    break;
                case 3:
                    currentNumber += "thirty";
                    break;
                case 4:
                    currentNumber += "fourty";
                    break;
                case 5:
                    currentNumber += "fifty";
                    break;
                case 6:
                    currentNumber += "sixty";
                    break;
                case 7:
                    currentNumber += "seventy";
                    break;
                case 8:
                    currentNumber += "eighty";
                    break;
                case 9:
                    currentNumber += "ninety";
                    break;

            }
            return currentNumber;
        }

        private static string AddOneToTen(int i, string currentNumber)
        {
            switch (i % 10)
            {
                case 1:
                    currentNumber += "one";
                    break;
                case 2:
                    currentNumber += "two";
                    break;
                case 3:
                    currentNumber += "three";
                    break;
                case 4:
                    currentNumber += "four";
                    break;
                case 5:
                    currentNumber += "five";
                    break;
                case 6:
                    currentNumber += "six";
                    break;
                case 7:
                    currentNumber += "seven";
                    break;
                case 8:
                    currentNumber += "eight";
                    break;
                case 9:
                    currentNumber += "nine";
                    break;
            }
            return currentNumber;
        }
    }
}
