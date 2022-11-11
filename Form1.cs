// Simple Web Browser 
// Authur: Haoran Hong

//Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace F21SC_CW1
{
    public partial class Form1 : Form
    {
        //Objects and variables set up
        List<string> current_histoy_list = new List<string>();  //list to store URL history for this session
        List<string> full_histoy_list = new List<string>();     //list to store previous history
        List<string> temp_histoy_list = new List<string>();     //list to store temporary history 
        List<string> bulk_list = new List<string>();            //list to store bulk download URLs
        string url;
        string home_url;
        int current_history_index = -1;                         //index count for current history list
        int back_forward_count = 0;                             //count to determine were the current page is respective to the history list
        string current_directory = Environment.CurrentDirectory;

        public Form1()
        {      
            //Initialise and hidding form componets
            InitializeComponent();
            favListBox.Visible = false;
            favPanel.Visible = false;
            histListBox.Visible = false;
            histPanel.Visible = false;
            bulkPanel.Visible = false;
            homePanel.Visible = false;

            //Home URL import and setup
            home_url = System.IO.File.ReadAllText(current_directory + "\\home_page.txt");
            url = home_url;
            displayWindow.Text = html_output(url);
            searchBar.Text = url;

            //Appending history to list
            current_history_append(url);

            //Import favourites to listbox
            foreach (string line in System.IO.File.ReadLines(current_directory + "\\favourites.txt"))
            {
                favListBox.Items.Add(line);
            }

            //Import stored history to list
            foreach (string line in System.IO.File.ReadLines(current_directory + "\\history.txt"))
            {
                full_histoy_list.Add(line);
            }
        }

        
        //Display About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Browser Ver: 1.0 \n\n" +
                "Made By: Haoran Hong (H00128802)");
            
        }


        //Method to request and output HTML from input URL
        private string html_output(string address)
        {
            string status_code = "";
            
            try
            {
                //Send HTTPS request to input URL and read response
                string html;
                WebRequest request = WebRequest.Create(address);
                WebResponse response;
                response = request.GetResponse();
                status_code +=  (int)((HttpWebResponse)response).StatusCode + " " + ((HttpWebResponse)response).StatusCode;
                StreamReader reader = new StreamReader(response.GetResponseStream());
                html = reader.ReadToEnd();
                reader.Close();
                response.Close();

                //Output status code, byte size, and HTML 
                string output = "Showing HTML code from: " + address + "\n" + "HTTP response status: " 
                    + status_code + "\n\n" + "HTML size in bytes: " + System.Text.Encoding.ASCII.GetByteCount(html) + "\n\n"
                    + "HTML code:\n\n" + (html);
                return output;
            }
            //Catch and display error exceptions
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //This method checks if the URL entered in the searchbar is the correct format
        //It then passes to https request
        private void navigate_url(string url_input)
        {
            url = url_input.Trim();
            string url_check;

            if (url.Length > 4)
            {
                url_check = url.Substring(0, 4);
            }
            else
            {
                url_check = url;
            }

            if (String.IsNullOrEmpty(url_check))
            {
                displayWindow.Text = "Input Error:\n\nURL textbox is empty.";
            }
            else
            {
                if (url_check == "http")
                {
                    displayWindow.Text = html_output(url);
                }
                else
                {
                    displayWindow.Text = "Input Error:\n\nURL must start with 'http'.";
                }
            }
        }

        //Method to run when the go button is pressed 
        private void goButton_click(object sender, EventArgs e)
        {
            //This if/else block checks the position of the current page compared to current history list
            //This if/els block is repeated everytime when a URL is being requested
            //If the position is the last in the list search as normal
            if (back_forward_count == 0)
            {
                url = searchBar.Text;           //read url from searchbar
                navigate_url(url);              //request and output URL HTML
                current_history_append(url);    //append url to current history list
            }
            //If the position is lower than list then sort list to match current
            else
            {
                url = searchBar.Text;
                navigate_url(url);
                current_history_sort(url);      //sort current history list
            }
        }

        //Method to reuest HTML fomr searchbar when enter key is pressed
        private void searchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (back_forward_count >= 0)
            {
                if (e.KeyChar == (char)ConsoleKey.Enter)
                {
                    url = searchBar.Text;
                    navigate_url(url);
                    current_history_append(url);
                }
            }

            else
            {
                if (e.KeyChar == (char)ConsoleKey.Enter)
                {
                    url = searchBar.Text;
                    navigate_url(url);
                    current_history_sort(url);
                }
            }
        }

        //Method to refersh current page 
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayWindow.Text = html_output(url);
            searchBar.Text = url;
        }

        //Method to set current page as homepage and save to text file 
        private void set_home_page (string url_input)
        {
            home_url = url_input;
            File.WriteAllText(current_directory + "\\home_page.txt", home_url); 
        }

        //Method to close home panel
        private void homeCloseButton_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
        }

        //Method for textbox on click
        private void homeTestBox_MouseClick(object sender, MouseEventArgs e)
        {
            homeTestBox.Text = "https://";
        }

        //Method to show set home panel
        private void enterHomePageURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            histListBox.Visible = false;
            histPanel.Visible = false;
            favListBox.Visible = false;
            favPanel.Visible = false;
            bulkPanel.Visible = false;
        }

        //Method to set home page and save home URL entered in the text box to text file 
        private void homeSaveButton_Click(object sender, EventArgs e)
        {
            home_url = homeTestBox.Text;
            File.WriteAllText(current_directory + "\\home_page.txt", home_url);
            homePanel.Visible = false;
        }

        //Method to navigate to home page when clicking the home button
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (back_forward_count >= 0)
            {
                navigate_url(home_url);
                searchBar.Text = home_url;
                current_history_append(url);
            }
            else
            {
                navigate_url(home_url);
                searchBar.Text = home_url;
                current_history_sort(url);
            }
        }

        //Method to set current page as home page on button click
        private void setCurrentPageAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set_home_page(url);
            MessageBox.Show(url + " set as home page.");
        }

        //Method to append each URL visited to current history list
        private void current_history_append(string url_input)
        {
            current_histoy_list.Add(url_input);
            current_history_index += 1;
        }

        //Method to sort the current history list according to current page indexing and append new URL visited to current history list
        private void current_history_sort(string url_input)
        {
            current_history_index += 1;
            current_histoy_list = current_histoy_list.GetRange(0, current_history_index);
            back_forward_count = 0;
            current_histoy_list.Add(url_input);
        }

        //Method to go forward a URL if possible on button click
        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current_history_index < (current_histoy_list.Count - 1))
            {
                navigate_url(current_histoy_list[current_history_index + 1]);
                searchBar.Text = current_histoy_list[current_history_index + 1];
                current_history_index += 1;
            }
        }

        //Method to go back a URL if possible on button click
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (current_history_index > 0)
            {
                navigate_url(current_histoy_list[current_history_index - 1]);
                searchBar.Text = current_histoy_list[current_history_index - 1];
                current_history_index -= 1;
                back_forward_count -= 1;
            }
        }

        //Method to show show favourite listbox and panel on click
        private void showFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            favListBox.Visible = true;
            favPanel.Visible = true;

            //Hide other panels if open
            histListBox.Visible = false;
            histPanel.Visible = false;
            bulkPanel.Visible = false;
            homePanel.Visible = false;
        }

        //Method to add current page to favourites
        private void addToFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var address = "No name given, " + url;
            favListBox.Items.Add(address);
            MessageBox.Show(url + " added to favourites.");
        }

        //Methdo to delete selected saved favourite from favourite listbox on click
        private void favDeleteButton_Click(object sender, EventArgs e)
        {
            favListBox.Items.Remove(favListBox.SelectedItem);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(current_directory + "\\favourites.txt");
            foreach (var item in favListBox.Items)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }

        //Method to close favourites listbox and panel
        private void favCloseButton_Click(object sender, EventArgs e)
        {
            favListBox.Visible = false;
            favPanel.Visible = false;
        }

        //Method to add a favourte URL and associated name 
        private void favAddButton_Click(object sender, EventArgs e)

        {
            string text = string.Format("{0},          {1}", favNameTextBox.Text, favURLTextBox.Text);
            favListBox.Items.Add(text);
        }

        //Method to navigate to a favourite URL selected in the favourite listbox
        private void favGoButton_Click(object sender, EventArgs e)
        {

            //split favourte URL and associated name by comma
            string[] split = favListBox.GetItemText(favListBox.SelectedItem).Split(',');
            string address = split[split.Length - 1];
            url = address.Trim();

            //Navigate URL
            if (back_forward_count >= 0)
            {
                
                navigate_url(url);
                current_history_append(url);
                searchBar.Text = url;
            }
            else
            {
                navigate_url(url);
                current_history_sort(url);
                searchBar.Text = url;
            }

            favListBox.Visible = false;
            favPanel.Visible = false;
        }

        //Method to enter https format to textbox
        private void favTextBoxURL_MouseClick(object sender, MouseEventArgs e)
        {
            favURLTextBox.Text = "https://";
        }

        //Method to clear textbox
        private void favNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            favNameTextBox.Clear();
        }

        //Method to edit currently selected favourite in the listbox
        private void faveEditButton_Click(object sender, EventArgs e)
        {
            //Save index of selected item
            int index = favListBox.SelectedIndex;

            //Read new input from textboxes and replace selected item by index
            string text = string.Format("{0},  {1}", favNameTextBox.Text, favURLTextBox.Text);
            favListBox.Items[index] = text;
        }

        //Method to Show History panel and listbox
        private void showHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add saved history list and the current session history list
            histListBox.Items.Clear();
            temp_histoy_list = full_histoy_list.ToList();
            temp_histoy_list.AddRange(current_histoy_list);

            //Display all history in listbox
            foreach (string adress in temp_histoy_list)
            {
                histListBox.Items.Add(adress);
            }
            temp_histoy_list.Clear();

            histListBox.Visible = true;
            histPanel.Visible = true;
            favListBox.Visible = false;
            favPanel.Visible = false;
            bulkPanel.Visible = false;
            homePanel.Visible = false;
        }

        //Method close history panel and listbox on click
        private void histCloseButton_Click(object sender, EventArgs e)
        {
            histListBox.Visible = false;
            histPanel.Visible = false;
        }

        //Method to navigate to the selected URL in the the history listbox
        private void histGoButton_Click(object sender, EventArgs e)
        {
            url = histListBox.GetItemText(histListBox.SelectedItem);

            if (back_forward_count >= 0)
            {

                navigate_url(url);
                current_history_append(url);
                searchBar.Text = url;
            }
            else
            {
                navigate_url(url);
                current_history_sort(url);
                searchBar.Text = url;
            }

            histListBox.Visible = false;
            histPanel.Visible = false;
        }

        //Method to delete the selected history in the listbox
        private void histDeleteButton_Click(object sender, EventArgs e)
        {
            histListBox.Items.Remove(histListBox.SelectedItem);
            current_histoy_list.Clear();
            back_forward_count = 0;
            full_histoy_list.Clear();
            histListBox.Items.Clear();
            current_history_index = -1;

        }

        //Method to request HTML of URLs in the files containing bulk download URLs
        //This process is the same as HTML ouput method previously
        private string bulkDownload (string address)
        {
            try
            {
                WebRequest request = WebRequest.Create(address);
                WebResponse response;
                response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                reader.Close();
                response.Close();

                //Output URL, status code and byte size
                string output = "<" + (int)((HttpWebResponse)response).StatusCode + "> <" 
                    + System.Text.Encoding.ASCII.GetByteCount(html) + "> <" + address + ">";
                return output;
            }
            //Catch web errors errors such as 404
            catch (WebException we)
            {
                var response = (HttpWebResponse)we.Response;
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string html = reader.ReadToEnd();
                string output = "<" + (int)((HttpWebResponse)response).StatusCode + "> <" 
                    + System.Text.Encoding.ASCII.GetByteCount(html) + "> <" + address + ">";
                return output;
            }
        }

        //Method to close panel
        private void bulkCloseButton_Click(object sender, EventArgs e)
        {
            bulkPanel.Visible = false;
        }

        //Method to load defualt bulk download file
        private void loadDefaultFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string line in System.IO.File.ReadLines(current_directory + "\\bulk.txt"))
            {
                bulk_list.Add(bulkDownload(line));
            }

            displayWindow.Text = String.Join(Environment.NewLine, bulk_list);

            searchBar.Text = "File Path: " + current_directory + "\\bulk.txt";

            MessageBox.Show("File Path: " + current_directory + "\\bulk.txt" + " loaded.");
        }

        //Method to show bulk download panel
        private void enterFilePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bulkPanel.Visible = true;
            histListBox.Visible = false;
            histPanel.Visible = false;
            favListBox.Visible = false;
            favPanel.Visible = false;
            homePanel.Visible = false;
        }

        //Method to read file path entered in the text box for bulkdownload
        private void bulkButton_Click(object sender, EventArgs e)
        {
            try
            {
                string file_location = bulkTextBox.Text;

                //Read each line from file to list
                foreach (string line in System.IO.File.ReadLines(current_directory + file_location))
                {
                    bulk_list.Add(bulkDownload(line));  //request http information for each URL and add output to list
                }

                //Display all output to window
                displayWindow.Text = String.Join(Environment.NewLine, bulk_list);

                searchBar.Text = "File Path: " + current_directory + file_location;

                MessageBox.Show("File Path: " + current_directory + file_location + " loaded.");

                bulkPanel.Visible = false;
            }
            //Catch and display file not found exceptions
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: File not found, please check file path is correct");
            }
        }

        //Method to clear textbox
        private void bulkTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            bulkTextBox.Clear();
        }
        
        //Method to clear all panels/listboxes when clikciong on the main display window
        private void displayWindow_MouseClick(object sender, MouseEventArgs e)
        {
            favListBox.Visible = false;
            favPanel.Visible = false;
            histListBox.Visible = false;
            histPanel.Visible = false;
            bulkPanel.Visible = false;
            homePanel.Visible = false;
        }
        
        //Method for actions on closing the browser form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Add saved history and current seesion history
            temp_histoy_list.AddRange(full_histoy_list);
            temp_histoy_list.AddRange(current_histoy_list);

            //Write all history to file
            System.IO.StreamWriter writer = new System.IO.StreamWriter(current_directory + "\\history.txt");
            foreach (var address in temp_histoy_list)
            {
                writer.WriteLine(address);
            }
            writer.Close();

            //Write all favourites stored in listbox to file
            System.IO.StreamWriter writer2 = new System.IO.StreamWriter(current_directory + "\\favourites.txt");
            foreach (var item in favListBox.Items)
            {
                writer2.WriteLine(item);
            }
            writer2.Close();

            //Exit message box
            MessageBox.Show("Thank you for using \"GO Browser\".");
        }
    }
}
