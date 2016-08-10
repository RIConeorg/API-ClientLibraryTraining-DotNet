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
    class Solution3
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
            Authenticator auth = new Authenticator(authUrl, clientId, clientSecret);

            /*
            * Create a for-each loop to iterate through your providers and pass in the sandbox provider
            */

            foreach (Endpoint e in auth.GetEndpoints(providerId))
            {
                /*
			    * Create a new XPress object and pass the endpoint href
			    */
                XPress xPress = new XPress(e.href);

                /*
                * Create an XRosterType list  
                */
                List<XRosterType> roster = xPress.GetXRostersByXSchool("8367CF40-9F20-4AD0-BCF5-1AB89032AFB9").Data;

                /*
                * Create a try/catch statement with JsonProcessingException
                */
                try
                {
                    /*
            	    * Inside your try, create a variable of type var.
            	    * Set your variable equal to JsonConvert.SerializeObject(YOUR_LIST_HERE, Formatting.Indented);
            	    */
                    var x = JsonConvert.SerializeObject(roster, Formatting.Indented);
                    Console.WriteLine(x);
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            Console.Read();
        }
    }
}
