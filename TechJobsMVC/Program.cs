using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TechJobsMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

/*
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    *                                                               *
    *   Start Unit 2 Assignment 3 edits on Views/List/Jobs.cshtml   *
    *                                                               *
    *   #0: Review the code                                        *
    *                                                               *
    *                                                               *
    *   #1: Use a loop to display job results in a table.           *
    *                   /Views/List/Jobs.cshtml                     *
    *                                                               *
    *   #2: Complete the View Jobs By Category Table                * 
    *                   /Views/List/index.cshtml                    *
    *                                                               *
    *   #3: Create an action method to process a search             *
    *            request and render the updated search view.        *             
    *                   /Controllers/SearchController.cs            *
    *                                                               *
    *   #4: Loop over the search results                            *
    *            to display all job fields.                         *      
    *                   /Search/Index.cshtml                        *
    *                                                               *
    * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
*/

/*
    Sanity Check:
    
    Before submitting, make sure that your application:     
    1.  Displays all 98 jobs in the system when the user
        goes to the /list page and selects “All”.
    2.  Displays all jobs matching a particular category 
        when the user selects a specific employer, location, skill, 
        or position type from the /list page.
    3.  Displays jobs with alternating white and gray backgrounds 
        (this is provided by the "job-listing" class).
    4.  Allows a user at /search to search for jobs matching a 
        specific search term, both within a specific category 
        and across all categories.
    5.  Displays search results below the form at /search/results.
*/