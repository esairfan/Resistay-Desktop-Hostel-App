using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistayDLL.Utilities
{
    public static class Validation
    {
        public static bool IsEmptyInput(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        public static bool IsValidAmount(string amount)
        {
            if (int.TryParse(amount, out int amounts))
            {
                if (amounts > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidUsername(string username)
        {
            return IsEmptyInput(username)  ;
        }

        public static bool IsValidPassword(string password)
        {
            return IsEmptyInput(password) && password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        public static bool IsValidGender(string gender)
        {
            return IsEmptyInput(gender) && (gender.ToLower() == "male" || gender.ToLower() == "female");
        }

         

        public static bool IsValidCNIC(string cnic)
        {
            return IsEmptyInput(cnic) && cnic.StartsWith("33") && cnic.Length == 13 && cnic.Substring(2).All(char.IsDigit);
        }

        public static bool IsValidAge(string age)
        {
            if (int.TryParse(age, out int ageValue))
            {
                if (ageValue > 0)
                {
                    return true; 
                }
            }
            return false;
        }
        public static bool IsValidRoom(string room)
        {
            if (int.TryParse(room, out int roomValue))
            {
                if (roomValue > 0)
                {
                    return true; 
                }
            }
            return false;
        }

        public static bool IsValidRole(string role)
        {
            return IsEmptyInput(role) && (role.ToLower() == "student");
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return IsEmptyInput(phoneNumber) && phoneNumber.StartsWith("03") && phoneNumber.Length == 11 && phoneNumber.Substring(2).All(char.IsDigit);
        }

         
    }
}
