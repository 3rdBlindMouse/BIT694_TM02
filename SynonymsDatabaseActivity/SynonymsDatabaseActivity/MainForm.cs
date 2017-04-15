using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace SynonymsDatabaseActivity
{
    public partial class MainForm : Form
    {
        static int fileCount = 0;
        static int folderCount = 0;

        public MainForm()
        {
            InitializeComponent();
            selectedFolderFilesListbox.MouseDoubleClick += 
                new MouseEventHandler(selectedFolderFilesListbox_DoubleClick);
        }

        private void selectedFolderFilesListbox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = selectedFolderFilesListbox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                System.Diagnostics.Process.Start(selectedFolderFilesListbox.SelectedItem.ToString());
            }
        }
        private void wordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.newWordsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newWordsDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.newWordsDataSet.Words);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = newWordsDataSet.Tables["Words"].NewRow();
                newRow["Word"] = addWord.Text;
                newRow["Synonyms"] = addSynonyms.Text;
                addWord.Text = "";
                addSynonyms.Text = "";

                newWordsDataSet.Tables["Words"].Rows.Add(newRow);
                wordsTableAdapter.Update(newWordsDataSet);
                MessageBox.Show("New Entry Added to Database!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error Occured " + error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = newWordsDataSet.Words.FindByWord(deleteWord.Text);
                wordsRow.Delete();
                MessageBox.Show("Deleted Row!");
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has occured " + error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewWordsDataSet.WordsRow wordsRow = newWordsDataSet.Words.FindByWord(updateWord.Text);
                wordsRow.Synonyms = updateSynonyms.Text;
                MessageBox.Show("Updated Row");
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has occured " + error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string word = queryWord.Text;
            queryResults(word);
        }
        private void queryResults(string word)
        {
            NewWordsDataSet.WordsRow wordsRow = newWordsDataSet.Words.FindByWord(word);
            if (wordsRow != null)
            {
                string[] synList = wordsRow.Synonyms.ToString().Split(',');
                string str = "";
                foreach (string s in synList)
                {
                    str += s + "\r\n";
                }
                querySynonyms.Text = str;
            }
            else
            {
                querySynonyms.Text = "No Results";
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            fileCount = 0;
            folderCount = 0;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                selectedFolderTextBox.Clear();
                selectedFolderFilesListbox.Items.Clear();
                selectedFolderTextBox.Text = folderPath;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                getFoldersAndFiles(folderPath);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                timeTextBox.Text = ($"{elapsedMs.ToString()} milliseconds");
                filesFoundTextBox.Text = fileCount.ToString();
                foldersFoundTextBox.Text = folderCount.ToString();
            } 
        }
        /*
         * Accepts a folder as an argument
         * looks through folder for other folders and files
         * displays files in each folder
         * 
         * @param folderPath a folder
         */
        private void getFoldersAndFiles(string folderPath) 
        {              
            try
            {
                // http://stackoverflow.com/questions/1277222/how-to-list-text-files-in-the-selected-directory-in-a-listbox

                DirectoryInfo dinfo = new DirectoryInfo(folderPath);
                FileInfo[] files = dinfo.GetFiles("*.txt"); // files found in foler are placed into a string array
//
                foreach (FileInfo file in files)
                {
                    fileCount++;
                    
                    selectedFolderFilesListbox.Items.Add(file.FullName);// add each file found to listBox display
                }

                string[] folders = Directory.GetDirectories(folderPath); // folders found are placed into string array

                foreach (string folder in folders)
                {
                    folderCount++;
                    //selectedFolderFilesListbox.Items.Add(folder);
                    getFoldersAndFiles(folder);
                }
            }
            catch (Exception error)
            {
                // MessageBox.Show(error.ToString());
            }

            if (includeSynonymsCheckBox.Checked == true)
            {
                string searchTerm = searchTermsTextBox.Text;
                queryResults(searchTerm);
            }
            else
            {

            }








        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            selectedFolderFilesListbox.Items.Clear();
            string folderPath = selectedFolderTextBox.Text;
            getFoldersAndFiles(folderPath);
        }

       
    }
}
