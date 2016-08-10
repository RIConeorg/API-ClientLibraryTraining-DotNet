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
    class Solution1
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
                * Retrieve all rosters by a particular school
                * HINT: use XRosterType object and GetXRostersbySchool()
                * See: school_refids.txt for list of school refIds
                */
                foreach (XRosterType r in xPress.GetXRostersByXSchool("8367CF40-9F20-4AD0-BCF5-1AB89032AFB9").Data)
                {
                    /*
	    		    * Display courseRefId and courseTitle within the foreach loop
	    		    */
                    Console.WriteLine("###courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);

                    /*
	        	    * Display all students per course within the foreach loop
	        	    * HINT: use XPersonReferenceType to iterate though students.studentReference
	        	    */
                    foreach (XPersonReferenceType p in r.students.studentReference)
                    {
                        Console.WriteLine("refId: " + p.refId);
                        Console.WriteLine("localId: " + p.localId);
                        Console.WriteLine("givenName: " + p.givenName);
                        Console.WriteLine("familyName: " + p.familyName);
                    }
                }
            }


            /*
            * Create a new XPress object and pass the endpoint href
            */


            /* 
             * Retrieve all rosters by a particular school
             * HINT: use XRosterType object and getXRostersbySchool()
             * See: school_refids.txt for list of school refIds
             */


            /*
             * Display courseRefId and courseTitle within the for-each loop
            */


            /*
            * Display all students per course within the for-each loop
            * HINT: use XPersonReferenceType to iterate though getStudents().getStudentReference()
            */
            Console.Read();
        }
    }
}
