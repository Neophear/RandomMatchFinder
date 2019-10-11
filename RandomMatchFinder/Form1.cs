using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMatchFinder
{
    public partial class Form1 : Form
    {
        private List<string> matches = new List<string>();

        public Form1()
        {
            InitializeComponent();
            txtbxAddMatch.Focus();
            txtbxAddMatch.Select();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string textToAdd = txtbxAddMatch.Text.Trim().Trim(new char[] { '*' });

            if (textToAdd != "")
            {
                if (matches.Exists(delegate(string stringToFind) { return (stringToFind == txtbxAddMatch.Text); }))
                {
                    MessageBox.Show("Denne kamp findes i forvejen");
                }
                else
                {
                    matches.Add(txtbxAddMatch.Text);
                    txtbxAddMatch.Text = "";
                    txtbxAddMatch.Select();
                    UpdateList();
                }
            }

            txtbxAddMatch.Focus();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (matches.Count == 0)
            {
                txtbxFoundMatch.Text = "Der er ingen kampe";
            }
            else
            {
                Random rnd = new Random();
                int highest = matches.Count();
                int randomNumber = rnd.Next(0, highest);
                string chosenMatch = "";

                chosenMatch = matches[randomNumber];

                txtbxFoundMatch.Text = chosenMatch;
                Clipboard.SetText(chosenMatch);


                matches.Remove(chosenMatch);

                UpdateList();
            }
        }
        private void UpdateList()
        {
            lstbxMatches.Items.Clear();
            lstbxMatches.Items.AddRange(matches.ToArray());
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Made by Stiig \"Neophear\" Gade\nstiiggade@gmail.com");
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            string[] strings = Clipboard.GetText(TextDataFormat.UnicodeText).Split(new char[] { '\n' });

            foreach (string _item in strings)
            {
                string newItem = Regex.Replace(_item, @"\s+", " ").Trim();

                if (!matches.Exists(delegate(string stringToFind) { return (stringToFind == newItem); }) && newItem != "")
                {
                    matches.Add(newItem);
                }
            }

            UpdateList();
        }

        private void txtbxFoundMatch_Click(object sender, EventArgs e)
        {
            if (txtbxFoundMatch.Text != "")
            {
                string text = txtbxFoundMatch.Text.TrimEnd(new char[] { '*' });
                Clipboard.SetText(text);
                txtbxFoundMatch.Text = text + "*";
            }
            txtbxAddMatch.Focus();
        }

        private void lstbxMatches_DoubleClick(object sender, EventArgs e)
        {
            matches.Remove(lstbxMatches.SelectedItem.ToString());
            txtbxAddMatch.Focus();
            txtbxAddMatch.Select();
            UpdateList();
        }
    }
}