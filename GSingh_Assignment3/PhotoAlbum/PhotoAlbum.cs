/*
 * File Name: photoAlbum.cs
 * Assignment2 for PROG1815-20S-Sec2-Programming Concepts II
 * 
 * Revision History
 *      Garima Singh, 2020-07-24 : Created
*/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Windows.Documents;

namespace PhotoAlbum
{
    public partial class PhotoAlbum : Form
    {
        public PhotoAlbum()
        {
            InitializeComponent();
        }
        List<Photo> pic = new List<Photo>(); //List of type Photo class
        int flagVariable = 0; //Variable for increment and checking the dates and labels
        int variableForClosingForm = 0; //Variable for checking whether message box with Yes No & Cancel buttons should appear
        private void photoAlbum_Load(object sender, EventArgs e)
        {
            rdbBlack.Checked = true;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            txtDescription.Enabled = false;
            btnAddPhotos.Enabled = false;
            btnSaveAlbum.Enabled = false;
            btnCreateAlbum.Focus();
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBlack.Checked)
            {
                picAlbum.BackColor = Color.Black;
            }
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWhite.Checked)
            {
                picAlbum.BackColor = Color.White;
            }
        }

        private void rdbGrey_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGrey.Checked)
            {
                picAlbum.BackColor = Color.Gray;
            }
        }

        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            if (variableForClosingForm != 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the album before closing?", "Closing", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    btnSaveAlbum_Click(sender, e);
                    variableForClosingForm = 0;
                    txtDescription.Text = "";
                    picAlbum.ImageLocation = "";
                    lblFileCreation.Text = "";
                    lblCreationDateAndTime.Text = "";
                }
            }

            /**/
            OpenFileDialog.Filter = "Album Files (*.alb)|*.alb";
            OpenFileDialog.InitialDirectory = Environment.CurrentDirectory;

            variableForClosingForm++;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageToOpen = OpenFileDialog.FileName;
                picAlbum.ImageLocation = imageToOpen;
                //this.Text = "Photo Album - " + title + " " + imageToOpen;

                DateTime creationTime = File.GetCreationTime(imageToOpen);
                lblFileCreation.Text = "File Created: " + creationTime.ToString("MM/dd/yyyy hh:mm tt");

                using (StreamReader reader = new StreamReader(imageToOpen))
                {
                    string savedFileData = reader.ReadLine();

                    string[] wordsForImageOne = savedFileData.Split('|');

                    title = wordsForImageOne[0];
                    this.Text = "Photo Album - " + title + " - " + imageToOpen;
                    picAlbum.ImageLocation = wordsForImageOne[1];
                    txtDescription.Text = wordsForImageOne[2];
                    lblCreationDateAndTime.Text = wordsForImageOne[3];

                    List<Photo> newPhotos = new List<Photo>();

                    while (savedFileData != null)
                    {
                        string[] words = savedFileData.Split('|');

                        //MessageBox.Show($"{words[0]}{Environment.NewLine}{words[1]}{Environment.NewLine}{words[2]}{Environment.NewLine}{words[3]}");

                        Photo newPhoto = new Photo();
                        newPhotos.Add(newPhoto);
                        title = words[0];
                        newPhoto.imgPath = words[1];
                        newPhoto.imgDescription = words[2];
                        newPhoto.imgCreationDateAndTime = words[3];
                        //this.Name += " - " + imageToOpen;
                        savedFileData = reader.ReadLine();
                        //increment++;
                    }

                    for (int totalCount = 0; totalCount < newPhotos.Count; totalCount++)
                    {
                        Photo newpic = new Photo();
                        pic.Add(newpic);
                        //newpic.imgPath = file;
                        newpic.imgPath = newPhotos.ElementAt(totalCount).imgPath;
                        newpic.imgDescription = newPhotos.ElementAt(totalCount).imgDescription;
                        newpic.imgCreationDateAndTime = newPhotos.ElementAt(totalCount).imgCreationDateAndTime;
                        //MessageBox.Show($"{newPhotos.ElementAt(totalCount).imgPath}{Environment.NewLine}{newPhotos.ElementAt(totalCount).imgDescription}{Environment.NewLine}{newPhotos.ElementAt(totalCount).imgCreationDateAndTime}");
                    }

                    flagVariable = 0;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddPhotos.Enabled = true;
                    btnSaveAlbum.Enabled = true;
                    txtDescription.Enabled = true;
                }
            }/**/
            else if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            { }
        }

        int i = 0, j = 0, k = 0; //Multiple variables for increment & changing value of 'flagVariableForLabel'
        int flagVariableForLabel = 0; //A variable for increment & check
        private void btnAddPhotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Image Files (*.jpeg;*.jpg;*.bmp;*.gif)|*.jpeg;*.jpg;*.bmp;*.gif";
            OpenFileDialog.InitialDirectory = Environment.CurrentDirectory;
            OpenFileDialog.Multiselect = true;

            j = pic.Count;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filesToOpen = OpenFileDialog.FileNames;

                lblFileCreation.Text = timeForFileCreation;
                
                //string message = "";
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                txtDescription.Enabled = true;
                foreach (string file in filesToOpen)
                {
                    Photo newpic = new Photo();
                    newpic.imgPath = file;
                    pic.Add(newpic);
                    //MessageBox.Show($"{file}");
                    i++;

                    FileInfo fileInfo = new FileInfo(newpic.imgPath);
                    DateTime dt = fileInfo.CreationTime;
                    newpic.imgCreationDateAndTime = "Image Created: " + dt.ToString();
                                        
                    lblCreationDateAndTime.Text = newpic.imgCreationDateAndTime;                       

                    if (txtDescription.Text != null)
                    {
                        newpic.imgDescription = txtDescription.Text;
                    }                    

                    string imageToOpen = OpenFileDialog.FileName;
                    picAlbum.ImageLocation = imageToOpen;
                }
                
                flagVariable = j;
                flagVariableForLabel = k;
                if (pic.Count > 1)
                {
                    lblCreationDateAndTime.Text = pic[flagVariableForLabel].imgCreationDateAndTime;
                }
                k = pic.Count;
            }
        }

        private void txtDescription_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                pic[flagVariable].imgDescription = txtDescription.Text;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pic.Count > 1)
            {
                if (flagVariable == 0)
                {
                    flagVariable = pic.Count-1;
                }
                else
                {
                    flagVariable--;
                }
                 picAlbum.Image = Image.FromFile(pic[flagVariable].imgPath.ToString());
                
                lblCreationDateAndTime.Text = pic[flagVariable].imgCreationDateAndTime;
            }
            txtDescription.Text = pic[flagVariable].imgDescription;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pic.Count > 0)
            {
                if (flagVariable == pic.Count-1)
                {
                    flagVariable = 0;
                }
                else
                {
                    flagVariable++;
                }
                picAlbum.Image = Image.FromFile(pic[flagVariable].imgPath.ToString());

                lblCreationDateAndTime.Text = pic[flagVariable].imgCreationDateAndTime;
            }
            txtDescription.Text = pic[flagVariable].imgDescription;
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Album Files(*.alb)| *.alb";
            SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            variableForClosingForm = 0;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                string userSelectedFile = SaveFileDialog.FileName;

                this.Text = "Photo Album - " + title + " - " + userSelectedFile;
                using (StreamWriter writer = new StreamWriter(userSelectedFile))
                {
                    for (int i = 0; i < pic.Count; i++)
                    {
                        writer.WriteLine($"{title}|{pic.ElementAt(i).imgPath}|{pic.ElementAt(i).imgDescription}|{pic.ElementAt(i).imgCreationDateAndTime}");
                    }
                }
            }
            m++;
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            if (variableForClosingForm == 0)
            {
                /**/
                title = "";
                CreateNewAlbum newAlbum = new CreateNewAlbum();/**/
                lblFileCreation.Text = "";

                /**/
                if (newAlbum.ShowDialog(this) == DialogResult.OK)
                {
                    //btnSaveAlbum_Click(sender, e);                    
                    variableForClosingForm++;
                }/**/
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to save the album before closing?", "Closing", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    lblFileCreation.Text = "";
                    btnSaveAlbum_Click(sender, e);
                    variableForClosingForm = 0;
                    this.Text = "Photo Album";
                    txtDescription.Text = "";
                    picAlbum.ImageLocation = "";
                    lblCreationDateAndTime.Text = "";
                    CreateNewAlbum newAlbum = new CreateNewAlbum();
                    /**/
                    if (newAlbum.ShowDialog(this) == DialogResult.OK)
                    {
                        //btnSaveAlbum_Click(sender, e);
                        variableForClosingForm++;
                    }/**/
                }
                else if (dr == DialogResult.No)
                {
                    lblFileCreation.Text = "";
                    this.Text = "Photo Album";
                    txtDescription.Text = "";
                    picAlbum.ImageLocation = "";
                    lblCreationDateAndTime.Text = "";
                    variableForClosingForm = 0;
                    CreateNewAlbum newAlbum = new CreateNewAlbum();/**/

                    /**/
                    if (newAlbum.ShowDialog(this) == DialogResult.OK)
                    {
                        //btnSaveAlbum_Click(sender, e);
                        variableForClosingForm++;
                    }/**/
                }
            }            
        }

        int m = 0; //A variable for increment & check

        private void photoAlbum_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (variableForClosingForm != 0)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the album before closing?", "Closing", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    btnSaveAlbum_Click(sender, e);
                    MessageBox.Show($"Album {title} saved!");
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        string title; //For Album title
        string timeForFileCreation; //For getting the creation date & time of that particular album

        /// <summary>
        /// Changes name of form to "Photo Album - " + Album Name
        /// Enables controls
        /// </summary>
        /// <param name=textFromSecondaryForm></param>
        public void SetTextInLabel(string textFromSecondaryForm)
        {
            this.Text = "Photo Album - " + textFromSecondaryForm;
            title = textFromSecondaryForm;

            picAlbum.ImageLocation = "";
            lblFileCreation.Text = "";
            lblCreationDateAndTime.Text = "";

            string time = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            timeForFileCreation = "File Created: " + time;

            if (pic.Count == 0)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                txtDescription.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                txtDescription.Enabled = true;
            }
            btnSaveAlbum.Enabled = true;
            btnAddPhotos.Enabled = true;
        }
    }
}