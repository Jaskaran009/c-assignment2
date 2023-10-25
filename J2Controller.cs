using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


//Diana is playing a game with two dice.● One dice has ​ m ​ sides labelled 1, 2, 3 ..., ​ m●
//The other dice has ​ n ​ sides labelled 1, 2, 3, ..., ​ n
//Write a program which determines how many ways she can roll the value of 10.For example,
//when the first die has 6 sides (m=6) and the second die has 8 sides (n=8), thereare 5 ways to get the sum 10 write c# program
namespace assignment2_Jaskaran_Kaur_n01664609.Controllers
{
    public class J2Controller : ApiController
    {
        // GET: J2
        [Route("api/J2/dicerolled/{n}{m}")]
        [HttpGet]
        public int Dicerolled(int n, int m)
        {

            m = 6; // number of sides on first die
            n = 8; // number of sides on second die
            int count = 0;
            int r = n+m ;
             //for loop to run it several times 
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                { 
                    //condition if 1i+j value is true it return
                    if (i + j == 10)
                    {
                        count++;
                        Console.WriteLine("Number of ways to roll a sum of 10: " + count);

                    }
                }

            }
            return r;
        }
    }
}

  
