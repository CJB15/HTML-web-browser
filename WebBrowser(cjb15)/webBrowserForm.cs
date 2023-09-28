using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

// This is the main interface window form
// This is the first class called, all others are called from here

namespace WebBrowser_cjb15_
{
    public partial class webBrowserForm : Form
    {
        // Creates 3 classes where all the code for website lookups, favorites and history
        WebLookUp webpage = new WebLookUp();
        UpdateFavList favUpdate = new UpdateFavList();
        UpdateHistoryList historyUpdate = new UpdateHistoryList();

        String currentUrl; // Holds the vurrent loaded page url
        Boolean currentPageFav; // Holds if the current page is favorited by the user
        Boolean loading = true; // Holds that the current page is loading

        private void disablebuttons()
        {
            // Disables all the buttons so the user can't use them while the app is doing somthing
            searchBtn.Enabled = false;
            reBtn.Enabled = false;
            favBtn.Enabled = false;
            historyBtn.Enabled = false;
            homeBtn.Enabled = false;
            bulkBtn.Enabled = false;
            viewFavBtn.Enabled = false;
        }

        private void enablebuttons()
        {
            // Enables the button so the user can use them again
            historyBtn.Enabled = true;
            bulkBtn.Enabled = true;
            viewFavBtn.Enabled = true;
            // Enables the set new home button if the current page isn't the current home page
            if (currentUrl != Properties.Settings.Default.HomePage && currentUrl != null)
            {
                homeBtn.Enabled = true;
            }
            // Enables the set new favorite button if the current page isn't on the favorite list
            if (currentPageFav == false && currentUrl != null)
            {
                favBtn.Enabled = true;
            }
            if (urlBox.Text != "")
            {
                searchBtn.Enabled = true;
            }
            if(currentUrl != null)
            {
                reBtn.Enabled = true;
            }
        }

        private async void loadpage(String url)
        {
            // This function is to load the page beloging to the url provided
            {
                // The buttons are disabled, the textbox and labels made blank and Loading... is displayed
                disablebuttons();
                htmlTextBox.Text = "";
                headerLable.Text = "Loading...";
                titleLable.Text = "";
                // Gets the function from the httplookup class, saving it in a string array
                String[] webdata = await webpage.httplookup(url);
                // Sets the htmlTextBox to the html code returned and the headerLabel to the pages return code
                htmlTextBox.Text = webdata[0];
                headerLable.Text = webdata[1];
                // Uses regex to search for the pages title
                Match mTitle = Regex.Match(webdata[0], @"\<title\>\s*([\s\S]*?)\s*\<\/title\>");
                if(mTitle.Success)
                {
                    // Removing any new lines then displaying it in the titleLable, if succesfull
                    titleLable.Text = mTitle.Groups[1].Value.Replace("\n", "").Replace("\r", "");
                }
                else
                {
                    // If unsucsesfull an error is displayed
                    titleLable.Text = "No page title found";
                }
                // Sets the newly loaded page url as the cuurent loaded page
                currentUrl = url;
                // Adds the current page to the users history
                historyUpdate.historyAdd(currentUrl);
                // Sets if the current page is in the favorite list
                currentPageFav = favUpdate.checkFav(currentUrl);
                // Enables the buttons
                enablebuttons();

            }
        }

        public webBrowserForm()
        {
            // Loads the form in
            InitializeComponent();
            // Calls the function that loads the favorite list in to the favUpdate class
            favUpdate.loadFavList();
            // Calls the function that loads the history list in to the historyUpdate class
            historyUpdate.loadHistoryList();
            // Call the loadpage to load the url saved as the home page
            loadpage(Properties.Settings.Default.HomePage);
            // Loads the homepage url into the text box
            urlBox.Text = Properties.Settings.Default.HomePage;
            // Page has finished loading
            loading = false;
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            // If the url textbox is empty disable the search button
            if(urlBox.Text == "")
            {
                searchBtn.Enabled = false;
            }
            else if (!loading)
            {
                searchBtn.Enabled = true;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Saves the current page as the new homepage
            Properties.Settings.Default.HomePage = currentUrl;
            Properties.Settings.Default.Save();
            // Displays a message confirming this
            headerLable.Text = "New home page saved";
            // Disables the homeBtn
            homeBtn.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Dose Nothing
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Dose Nothing
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Loads a page using the url in the urltextbox
            loadpage(urlBox.Text);
        }

        private void reBtn_Click(object sender, EventArgs e)
        {
            // Loads a page using the current loaded page url
            loadpage(currentUrl);
        }

        private void favBtn_Click(object sender, EventArgs e)
        {
            // Calls the function with the current url which opens the add favorite dialog box
            currentPageFav = favUpdate.favAdd(currentUrl);
            // If the page was added to favorites then the add favorite button is diabled and text is displayed confirming it
            if (currentPageFav)
            {
                favBtn.Enabled = false;
                headerLable.Text = "New favorite page saved";
            }
            
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            // The buttons are disabled
            disablebuttons();
            // The function that opens the window to view the users history
            // If the user selected an entry in the list it is returned in the string
            String returnUrl = historyUpdate.viewHistoryList();
            // If the user did select an entry it is opened with the loadpage function
            if (returnUrl != null)
            {
                loadpage(returnUrl);
                urlBox.Text = returnUrl;
            }
            // The buttons are enabled
            enablebuttons();
        }

        private async void bulkBtn_Click(object sender, EventArgs e)
        {
            // Buttons disabled
            disablebuttons();
            // Text is displayed informing the user that the app is bulk downloading
            headerLable.Text = "Bulk Downloading...";
            // A new bulkdownload object is created and the bulkdownloadfunc is called, the results are saved in the list of string arrays
            BulkDownload bulk = new BulkDownload();
            List<String[]> outputList = await bulk.BulkDownloadFunc();
            // If a file was succesfully loaded and downloaded
            if(bulk.outcome == "Success")
            {
                // Blank all the textboxes/labels
                htmlTextBox.Text = "";
                titleLable.Text = "";
                urlBox.Text = "";
                currentUrl = null;
                // Load each list entry from the output from bulkdownloadfunc and display them
                foreach (var i in outputList)
                {
                    htmlTextBox.Text += i[2] + "    -   " + i[1].Length + " bytes   -   " + i[0] + "\n";
                }
                // Enable only soome of the buttons
                // The reload button, add fav button and make home page button arn't as they wouldn't do anything
                bulkBtn.Enabled = true;
                viewFavBtn.Enabled = true;
                historyBtn.Enabled = true;
                // Text confirming the download was sucsesfull
                headerLable.Text = "Finished Bulk Download";
                titleLable.Text = "File location loaded: " + bulk.fileLocation;
            }
            else if(bulk.outcome == "File empty")
            {
                // If file is empty display error and re-enable buttons
                headerLable.Text = "Error: Text file Empty";
                enablebuttons();
            }
            else if(bulk.outcome == "Not .txt")
            {
                // If file is not a .txt file display error and re-enable buttons
                headerLable.Text = "Error: File not valid .txt file";
                enablebuttons();
            }
            else if (bulk.outcome == "Error")
            {
                // If there was an error display error and re-enable buttons
                headerLable.Text = "Error: Issue bulk downloading";
                enablebuttons();
            }
            else
            {
                // If the user cancelled the download notify the user and re-enable buttons
                headerLable.Text = "Bulk Download Cancelled";
                enablebuttons();
            }
        }

        private void viewFavBtn_Click(object sender, EventArgs e)
        {
            // The buttons are disabled
            disablebuttons();
            // The function that opens the window to view the users favorites
            // If the user selected an entry in the list it is returned in the string
            String returnUrl = favUpdate.viewFavList();
            // It checks if the current page is favorited by the user, in case they deleted the current page from the list
            currentPageFav = favUpdate.checkFav(currentUrl);
            // If the user did select an entry it is opened with the loadpage function
            if (returnUrl != null)
            {
                loadpage(returnUrl);
                urlBox.Text = returnUrl;
            }
            // The buttons are enabled
            enablebuttons();
        }

        private void webBrowserForm_Load(object sender, EventArgs e)
        {
            // Dosn't do anything
        }

        private void urlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Dosn't do anything
        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && urlBox.Text != "")
            {
                // If the user presses enter while editing the urlbox and the text box isn't empty then run the funtion for the search button being pressed
                searchBtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5 && reBtn.Enabled == true)
            {
                // If the user presses F5 while editing the urlbox then run the function for the reload button being pressed
                reBtn_Click(sender, e);
            }
        }

        private void htmlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && reBtn.Enabled == true)
            {
                // If the user presses F5 while editing the htmlbox then run the function for the reload button being pressed
                reBtn_Click(sender, e);
            }
        }
    }
}
