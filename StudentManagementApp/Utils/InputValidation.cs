using System;
using System.Text.RegularExpressions;


namespace StudentManagementApp.Utils
{
    internal class InputValidation
    {
        public bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
        public bool IsNullOrEmpty(int input)
        {
            return input == 0;
        }

        public bool IsAlphabetic(string input)
        {
            input = input.Trim();
            return Regex.IsMatch(input, @"^[a-zA-Z]+(?: [a-zA-Z]+)*$");
        }

        public bool IsNumeric(string input)
        {
            return Int32.TryParse(input, out _);
        }

        public bool IsValidEmail(string input) // Regex for email validation
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input.Trim(), pattern);
        }

        public bool IsValidDate(string input) // Verifying date
        {
            DateTime tempDate;
            return DateTime.TryParse(input, out tempDate);
        }

        public bool isValidGrade(int grade) // Verifying grade
        {
            return grade <= 30;
        }

        public bool IsLessThanTenChar(string input) // More or equal to 2 char, less or equal to 10 char (for acronym and groups)
        {
            string trimmed = input.Trim();
            char[] chars = trimmed.ToCharArray();
            return chars.Length >= 2 && chars.Length <= 10;
        }


        public bool IsLessThanFiftyChar(string input) // More or equal to 2 char, less or equal to 50 char
        {
            string trimmed = input.Trim();
            char[] chars = trimmed.ToCharArray();
            return chars.Length >= 2 && chars.Length <= 50;
        }

        public bool HaveSameEmail(char[] arr1, char[] arr2)
        {
            if (arr1 == null || arr2 == null)
                return false;

            string email1 = new string(arr1).Trim();
            string email2 = new string(arr2).Trim();

            return string.Equals(email1, email2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
