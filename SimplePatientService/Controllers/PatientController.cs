using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SimplePatientService.Models;
using System.Web.Mvc;

namespace SimplePatientService.Controllers
{
    /// <summary>
    /// Patient end point.
    /// </summary>
    public class PatientController : ApiController
    {
        //Instead of DB for quick Ref we would create hard code the data.
        List<Patient> listPatients = new List<Patient>()
        {
        new Patient { ID = 1, FirstName = "John", LastName = "Smith", Age = "34", Address = "1 Smith st, Matrix 001001101 " },
        new Patient { ID = 2, FirstName = "John", LastName = "Smith", Age = "34", Address = "32 Smith st, Matrix 001001101 " },
        new Patient { ID = 3, FirstName = "John", LastName = "Smith", Age = "34", Address = "44 Smith st, Matrix 001001101 " },
        new Patient { ID = 4, FirstName = "John", LastName = "Smith", Age = "34", Address = "65 Smith st, Matrix 001001101 " }
        };
        /// <summary>
        /// Gets the list of all patients 
        /// </summary>
        /// <returns>list<Patient></Patient>/returns>
        public IEnumerable<Patient> Get()
        {
            return listPatients;
        }



        /// <summary>
        /// Gets the first occuring patient with the given id
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Patient</returns>
        public IHttpActionResult Get(int id)
        {
            var pat = listPatients.FirstOrDefault(x => x.ID == id);
            if (pat == null)
            {
                return NotFound();
            }
            return Ok(pat);
        }

        /// <summary>
        /// Add the given Patient to the collection
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public IHttpActionResult Post(Patient value)
        {
            listPatients.Add(value);
            return Ok();
        }





    }
}
