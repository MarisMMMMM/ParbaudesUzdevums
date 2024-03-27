using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParbaudesUzdevums
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Range(1, int.MaxValue)]
        [RegularExpression("([0-9]+)")]
        public int MobilePhone { get; set; }
    }
    
}
