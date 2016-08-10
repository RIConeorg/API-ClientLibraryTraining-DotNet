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
    *  Exercise 2 is used to demonstrate pulling a schedule for a student.
    */
    class Solution2
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
                * Retrieve all rosters by a particular student
                * HINT: use XRosterType object and GetXRostersbyStudent()
                * See: student_refids.txt for list of school refIds
                */
                foreach (XRosterType r in xPress.GetXRostersByXStudent("669C244E-53DE-40FC-85A5-C5E2A561E809").Data)
                {
                    /*
	    		    * Display courseRefId and courseTitle within the foreach loop
	    		    */
                    Console.WriteLine("###courseRefId: " + r.courseRefId);
                    Console.WriteLine("courseTitle: " + r.courseTitle);

                    /*
                    * Display meeting time information per course within the for-each loop
                    * HINT: use XMeetingTimeType to iterate though meetingTimes.meetingTime
                    */
                    foreach (XMeetingTimeType m in r.meetingTimes.meetingTime)
                    {
                        Console.WriteLine("bellScheduleDay: " + m.classMeetingDays.bellScheduleDay);
                        Console.WriteLine("timeTablePeriod: " + m.timeTablePeriod);
                        Console.WriteLine("roomNumber: " + m.roomNumber);
                        Console.WriteLine("classEndingTime: " + m.classEndingTime);
                        Console.WriteLine("classEndingTime: " + m.classEndingTime);
                    }
                }
            }
            Console.Read();
        }
    }
}
