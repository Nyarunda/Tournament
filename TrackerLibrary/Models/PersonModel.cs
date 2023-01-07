using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Reps one person
    /// </summary>
   public class PersonModel
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNo { get; set; }
    }
}
