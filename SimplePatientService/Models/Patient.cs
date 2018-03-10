using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimplePatientService.Models
{
    /// <summary>
    /// Patient Data Model
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// An ID not unique
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// First Name of Patient
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of Patient
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Age of Patient
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// Address of Patient
        /// </summary>
        public string Address { get; set; }

    }
}