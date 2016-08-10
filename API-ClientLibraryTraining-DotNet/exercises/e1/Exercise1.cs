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
    * Excercise 1 is used to demonstrate pulling rosters by a school
    */
    class Exercise1
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
            * Retrieve all rosters by a particular school
            * HINT: use XRosterType object and GetXRostersbySchool()
            * See: school_refids.txt for list of school refIds
            */
               
            /*
	    	* Display courseRefId and courseTitle within the foreach loop
	    	*/
                    

            /*
	        * Display all students per course within the foreach loop
	        * HINT: use XPersonReferenceType to iterate though students.studentReference
	        */
            Console.Read();
        }
    }
}
