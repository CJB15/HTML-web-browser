using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebBrowser_cjb15_
{
    class UpdateHistoryList
    {
        // Class dedicated to working with the browsing pages history list
        // The list that holds each history entry object
        List<historyEntry> historyList = new List<historyEntry>();

        public void historyAdd(String url)
        {
            // A new historyEntry object is creted with the url and display text string with the url, date and time of access
            var newHistory = new historyEntry
            {
                historyText = DateTime.Now + " - " + url,
                historyUrl = url
            };
            // This is then added to the list
            historyList.Add(newHistory);
            // And the History setting is updated
            Properties.Settings.Default.History = JsonSerializer.Serialize(historyList);
            Properties.Settings.Default.Save();
        }

        public void loadHistoryList()
        {
            // Loaded when the program is first opened, loads the History setting into the historyList
            try
            {
                historyList = JsonSerializer.Deserialize<List<historyEntry>>(Properties.Settings.Default.History);
            }
            catch
            {
                // If the setting is blank or corrupted then don't load anything
            }

        }

        public String viewHistoryList()
        {
            while (true)
            {
                // Opens the FavListForm, displaying the favorited entries to the user
                using (var m = new HistoryListForm(historyList))
                {
                    var result = m.ShowDialog();

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        // If the user selected to open one of the entries then return that url
                        return m.selectedUrl;
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        // If the user closed the window then return null
                        return null;
                    }
                    else if (result == System.Windows.Forms.DialogResult.Abort)
                    {
                        // If the user selected the clear history then whipe historyList and overwrite the History setting with the now empty list
                        historyList = new List<historyEntry>();
                        Properties.Settings.Default.History = JsonSerializer.Serialize(historyList);
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }
    }
}
