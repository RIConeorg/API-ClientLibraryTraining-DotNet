using Newtonsoft.Json;
using RicOneApi.Api;
using RicOneApi.Models.Authentication;
using RicOneApi.Models.XPress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API_ClientLibraryTraining_DotNet
{
    /*
    * In Exercise 3, convert XRosters by School from Exercise 1 
    * into a JSON object and print the results in the console. This exercise 
    * uses the NewtonSoft JsonConvert.
    */
    class Exercise3
    {
        const String authUrl = "https://auth.test.ricone.org/login";
        const String clientId = "DevConf";
        const String clientSecret = "test-password";

        const String providerId = "sandbox";

        static void Main(string[] args)
        {
            /*
		    * Create a new Authenticator object and pass authUrl, clientId, and clientSecret
		    */


            /*
            * Create a for-each loop to iterate through your providers and pass in the sandbox provider
            */


            /*
			* Create a new XPress object and pass the endpoint href
			*/

            /*
            * Create an XRosterType list  
            */


            /*
            * Create a try/catch statement with JsonProcessingException
            */

            /*
            * Inside your try, create a variable of type var.
            * Set your variable equal to JsonConvert.SerializeObject(YOUR_LIST_HERE, Formatting.Indented);
            */

            Console.Read();
        }
    }
}
