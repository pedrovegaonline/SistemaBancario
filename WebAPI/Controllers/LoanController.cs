﻿using Core.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class LoanController : ControllerBase
    {
        // GET: api/<LoanController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string [] { "value1", "value2" };
        }

        // GET api/<LoanController>/5
        [HttpGet( "{id}" )]
        public string Get( int id )
        {
            return "value";
        }

        // POST api/<LoanController>
        [HttpPost]
        public void Post( [FromBody] string value )
        {
        }

        // PUT api/<LoanController>/5
        [HttpPut( "{id}" )]
        public void Put( int id, [FromBody] string value )
        {
        }

        // DELETE api/<LoanController>/5
        [HttpDelete( "{id}" )]
        public void Delete( int id )
        {
        }

        [HttpPost]
        public ActionResult PostNewRequest( Loan loan )
        {
            return null;
        }

        [HttpPost]
        public ActionResult PostUpdateRequest( Loan loan )
        {
            return null;
        }

        [HttpPost]
        public ActionResult GetLoanInfo( Loan loan )
        {
            return null;
        }
    }
}
