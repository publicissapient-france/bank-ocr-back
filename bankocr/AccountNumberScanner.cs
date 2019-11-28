using System.Collections.Generic;

namespace bankocr
{
    public class AccountNumberScanner
    {
        private readonly Dictionary<string, string> numberCodes = new Dictionary<string, string>
        {
            { " _ | ||_|", "0" },
            { "     |  |", "1" },
            { " _  _||_ ", "2" },
            { " _  _| _|", "3" },
            { "   |_|  |", "4" },
            { " _ |_  _|", "5" },
            { " _ |_ |_|", "6" },
            { " _   |  |", "7" },
            { " _ |_||_|", "8" },
            { " _ |_| _|", "9" },
        };
        public AccountNumberScanner()
        {
        }

        public string Scan(string encodedAccountNumber)
        {
            if (encodedAccountNumber.Length >= 9) 
            {

                string firstNumber = ExtractFirstNumberCode(encodedAccountNumber);
                if(numberCodes.ContainsKey(firstNumber))
                {
                    return numberCodes[firstNumber]
                    + Scan(ExtractPendingNumbersCode(encodedAccountNumber));
                }
                return "?"
                    + Scan(ExtractPendingNumbersCode(encodedAccountNumber));
            }
            return string.Empty; 
        }

        private string ExtractPendingNumbersCode(string input)
        {
            var inputLines = input.Split('\n');
            var pendingFirstLine = inputLines[0].Substring(3, inputLines[0].Length - 3);
            var pendingSecondLine = inputLines[1].Substring(3, inputLines[1].Length - 3);
            var pendingThirdLine = inputLines[2].Substring(3, inputLines[2].Length - 3);
            return pendingFirstLine + "\n" + pendingSecondLine + "\n" + pendingThirdLine; 
        }

        private string ExtractFirstNumberCode(string input)
        {
            var inputLines = input.Split('\n');                        
            return inputLines[0].Substring(0, 3) + inputLines[1].Substring(0, 3) + inputLines[2].Substring(0, 3);
        }
    }
}