using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//Question Natalie is learning to count on her fingers. When her Daddy tells her a number n (1 ≤ n ≤ 10),
//she asks “What is n, Daddy?”, by which she means “How many fingers should I hold up on each
//hand so that the total is n?”
//To make matters simple, her Daddy gives her the correct finger representation according to the
//following rules:
//• the number may be represented on one or two hands;
//• if the number is represented on two hands, the larger number is given first.
//For example, if Natalie asks “What is 4, Daddy?”, her Dad may reply:
//• 4 is 4.
//• 4 is 3 and 1.
//• 4 is 2 and 2.

namespace assignment2_Jaskaran_Kaur_n01664609.Controllers
{
    public class J1Controller : ApiController
    {
        // GET: J1
        [Route("api/J1/result/{n}")]
        [HttpGet]
        public int result(int n)

        {
            int r = n /2 + 1; // r declared to store the comndition

            //for loop to run it several times
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);

            }
            //returned the result 
            return r;
        }
    }
}