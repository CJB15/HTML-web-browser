using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebBrowser_cjb15_
{
    public class BulkDownload
    {
        // Create a new weblookup object and other varables
        WebLookUp bulkLookup = new WebLookUp();
        public String outcome { get; set; }
        public String fileLocation { get; set; }
        List<String[]> bulkData = new List<String[]>();

        public async Task<List<String[]>> BulkDownloadFunc()
        {
            // Opens the BulkDownloadForm so the user can enter the filelocation of the file to be used
            using (var m = new BulkDownloadForm())
            {
                var result = m.ShowDialog();

                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    // If the user pressed the confirm button
                    try
                    {
                        // Retrieve the file location from the dialog box
                        fileLocation = m.filelocation;
                        // Saves the file extension of the file just 
                        String fileType = System.IO.Path.GetExtension(m.filelocation);
                        // If not a .txt then end with the outcome being an error
                        if (fileType != ".txt")
                        {
                            outcome = "Not .txt";
                            return null;
                        }

                        // Loads each line of the file into the irlList list
                        List<String> urlList = new List<String>(File.ReadAllLines(fileLocation));
                        // If the file is empty the end with teh outcome being an error
                        if (!urlList.Any() || urlList == null)
                        {
                            outcome = "File empty";
                            return null;
                        }
                        else
                        {
                            // If it is a .txt and not empty then load the url from each line into the httplookup function, saving each result into the bulkData list
                            foreach(var i in urlList)
                            {
                                String[] bulkTemp = await bulkLookup.httplookup(i);
                                bulkData.Add(new string[] { i, bulkTemp[0], bulkTemp[1] });
                            }
                            // Outcome is success and return the bulkData list
                            outcome = "Success";
                            return bulkData;
                        }
                    }
                    catch
                    {
                        // If there was any error whilest loading the program end with the outome being error
                        outcome = "Error";
                        return null;
                    }
                    
                }
                else
                {
                    // If the user pressed cancel on the dialog box then end with no outcome
                    return null;
                }
            }
        }
    }
}
