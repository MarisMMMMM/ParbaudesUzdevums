using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParbaudesUzdevums
{
    public static  class UserValidator
    {
        public static bool IsUserModelValid(UserModel user)
        {
            ValidationContext context = new ValidationContext(user);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if(user != null && !Validator.TryValidateObject(user, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}
