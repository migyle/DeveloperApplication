using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperApplication.Interface
{
    class Validation
    {
        public static class UserValidation
    {
        public static bool ValidateName(string name, out string errorMessage)
        {
            int numCount = name.Count(c => "1234567890".Contains(c));
            if (string.IsNullOrWhiteSpace(name) || numCount>0)
            {
                errorMessage = "Name cannot be empty or contain any numericals.";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }


        //Validate email address.
        //formated like so: name@domain.com / name@domain.co.za
        public static bool ValidateEmail(string email, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email cannot be empty.";
                return false;
            }

            if (!email.Contains("@"))
            {
                errorMessage = "Email must contain '@'. Example: johndoe@gmail.com";
                return false;
            }

            var parts = email.Split('@');
            if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]))
            {
                errorMessage = "Email must have a username before '@'. Example: johndoe@gmail.com";
                return false;
            }

            if (string.IsNullOrWhiteSpace(parts[1]))
            {
                errorMessage = "Email must have a domain after '@'. Example: johndoe@gmail.com";
                return false;
            }

            if (!parts[1].Contains("."))
            {
                errorMessage = "Email must have a top-level domain (e.g., .com or .co.za). Example: johndoe@gmail.com";
                return false;
            }

            // Check allowed TLDs (.com or .co.za)
            if (!(parts[1].EndsWith(".com", StringComparison.OrdinalIgnoreCase) ||
                  parts[1].EndsWith(".co.za", StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "Email must end with '.com' or '.co.za'. Example: johndoe@gmail.com or johndoe@gmail.co.za";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }



            //Validate contact number.
            //10 digit only.
            //contact number must start with 0.
            public static bool ValidateContactNumber(string contactNumber, out string errorMessage)
            {
                if (contactNumber.Length != 10 || !contactNumber.All(char.IsDigit))
                {
                    errorMessage = "Contact number must be 10 digits long and numeric.";
                    return false;
                }

                if (!contactNumber.StartsWith("0"))
                {
                    errorMessage = "Contact number must start with a '0'.";
                    return false;
                }

                errorMessage = string.Empty;
                return true;
            }

            public static bool ValidateDOB(DateTime dob, out string errorMessage) 
            {
                if (dob >= DateTime.Now)
                {
                    errorMessage = "Date of Birth must be in the past.";
                    return false;
                }
                int age = DateTime.Now.Year - dob.Year;
                if (dob > DateTime.Now.AddYears(-age)) age--;
                if (age < 18)
                {
                    errorMessage = "You must be at least 18 years old to sign up.";
                    return false;
                }
                errorMessage = string.Empty;
                return true;
            }


            //Validate password
            //Minimum: 8 characters, 2 numbers, 1 symbol.
            public static bool ValidatePassword(string password, out string errorMessage)
        {
            if (password.Length < 8)
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }

            int numberCount = password.Count(char.IsDigit);
            int symbolCount = password.Count(c => "!@#$%^&".Contains(c));

            if (numberCount < 2)
            {
                errorMessage = "Password must contain at least 2 numbers.";
                return false;
            }

            if (symbolCount < 1)
            {
                errorMessage = "Password must contain at least 1 symbol (!,@,#,$,%,^,&).";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

    }
        }
}
