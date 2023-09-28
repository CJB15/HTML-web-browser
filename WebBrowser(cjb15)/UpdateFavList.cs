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
    class UpdateFavList
    {
        // Class dedicated to working with the favorited pages list
        // The list that holds each fav entry object
        List<favEntry> favList = new List<favEntry>();

        public Boolean favAdd(String url)
        {
            // Calls the AddFavForm which gives the user a dialog to enter a nickname for the entry
            using (var m = new AddFavForm(url))
            {
               var result = m.ShowDialog();

                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    // If the user confirmed the dialog box set the nickname they entered as the 
                    String enteredName = m.name;
                    // If the field was blank then the url itself is used as the nickname
                    if (enteredName == "")
                    {
                        enteredName = url;
                    }
                    // A new favEntry object is creted with the url and nickname
                    var newFav = new favEntry
                    {
                        favName = enteredName,
                        favUrl = url
                    };
                    // This is then added to the favist list
                    favList.Add(newFav);
                    // This is then serialised into json format and then save to the Favorite setting
                    Properties.Settings.Default.Favorite = JsonSerializer.Serialize(favList);
                    Properties.Settings.Default.Save();
                    // True is returned to indicate a new entry was added
                    return true;
                }
                else
                {
                    // If the user cancelled nothing happens and false is returned
                    return false;
                }
 
            }
            
            
        }
        public Boolean favEdit(String url)
        {
            // Searches list for the url that the user has requested to edit
            // Saves the object
            favEntry entryEditing = favList.Find(x => x.favUrl.Contains(url));
            // As well as the index number of it
            int index = favList.FindIndex(x => x.favUrl.Contains(url));
            // Open the window form for the user to edit it
            using (var m = new EditFavForm(url, entryEditing.favName))
            {
                var result = m.ShowDialog();
                // If the user selected confirm
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Change the nickname to the one the user entered, using the url itself if the user left the text field blank
                    String enteredName = m.newName;
                    if (enteredName == "")
                    {
                        enteredName = url;
                    }
                    entryEditing.favName = enteredName;
                    // Uodate the favs list
                    favList[index] = entryEditing;
                    // Update the Favorites setting with the new fav list
                    Properties.Settings.Default.Favorite = JsonSerializer.Serialize(favList);
                    Properties.Settings.Default.Save();
                    // Reurn true to indicate that the entry is still in the fav list
                    return true;
                } 
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    // Remove the entry if the user selected delete
                    favList.RemoveAt(index);
                    // Update the Favorites setting to relfect the now removed entry
                    Properties.Settings.Default.Favorite = JsonSerializer.Serialize(favList);
                    Properties.Settings.Default.Save();
                    // Return false to indicate the url is no longer favorited
                    return false;
                }
                else
                {
                    // If the user cancelled do nothing, return true to indicate that the entry is still on the fav list
                    return true;
                }
            }
        }
        public void loadFavList()
        {
            // Loaded when the program is first opened, loads the Favorite setting into the favList
            try
            {
                favList = JsonSerializer.Deserialize<List<favEntry>>(Properties.Settings.Default.Favorite);
            }
            catch
            {
                // If the setting is blank or corrupted then don't load anything
            }
            
        }
        public Boolean checkFav(String url)
        {
            // Cycles through favlist to check of the requested url is in the list, return true if so
            foreach(var i in favList)
            {
                if(i.favUrl == url)
                {
                    return true;
                }
            }
            return false;
        }
        public String viewFavList()
        {
            while (true)
            {
                // Opens the FavListForm, displaying the favorited entries to the user
                using (var m = new FavListForm(favList))
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
                    else if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // If the user selected to edit one of the entires then run the favEdit function
                        favEdit(m.selectedUrl);
                        // Afterwards the program loops on the previous while loop and reopens the favlist with the updated favlist
                    }
                }
            }
        }
    }
}