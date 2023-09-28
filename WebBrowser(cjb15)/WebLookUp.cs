using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

namespace WebBrowser_cjb15_
{
    class WebLookUp
    {
        // Class dedicated to looking up the provided url and returning the return code and html code
        public async Task<String[]> httplookup(String url)
        {
            // Checks if the url is valid format
            Uri myUri;
            if (Uri.TryCreate(url, UriKind.Absolute, out myUri))
            {
                try
                {
                    // Retrieve the data from the provided url to test if it is succesful
                    var webtest = new HttpClient();
                    dynamic webpagetest = await webtest.GetAsync(url);
                    webpagetest.EnsureSuccessStatusCode();
     
                }
                catch (HttpRequestException e) when (e.Message == "An error occurred while sending the request.")
                {
                    // If the page couldn't be retrieved due to the website not being found then return the error message as the response code alsong with no html code
                    return new String[] { "", "Error: Page not found"};
                }
                catch (HttpRequestException e) when (e.Message != "An error occurred while sending the request.")
                {
                    // If the error was due to the website being found but a different error occured then continue on as normal
                    // This is so that if a 404 page not found error occurs then the function will return the 404 page html as it would a normal page
                }
                // Retirieve the data again but this time to save the retuend response code and html code
                var web = new HttpClient();
                dynamic webpage = await web.GetAsync(url);
                String html = await webpage.Content.ReadAsStringAsync();
                String code = "Response: " + (int)webpage.StatusCode + " " + webpage.StatusCode.ToString();
                // And return the chtml code and response code
                return new String[] { html, code};


            } else
            {
                // If not valid format return no html code and the error as the return code
                return new String[] { "", "Error: Invalid URL",};
            }
        }
    }
}