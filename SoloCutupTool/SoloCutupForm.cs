using SoloCutupTool.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloCutupTool
{
    public partial class SoloCutupTool : Form
    {
        FileHandler currentFileHandler = new FileHandler();

        List<string> loadedWords = new List<string>();

        public SoloCutupTool()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            TxtNumberCutups.Text = "5";
            loadedWords.Clear();

            ListCutups.DoubleClick += new EventHandler(ListCutups_DoubleClick);
        }

        private void UpdateUI()
        {
            var wordCount = loadedWords.Count;
            LblLoadedWords.Text = wordCount + " Cutups Loaded";
            LblLoadedWords.Update();
        }

        private void ListCutups_DoubleClick(object sender, EventArgs e)
        {
            if (ListCutups.SelectedItem != null)
            {
                ListSaved.Items.Add(ListCutups.SelectedItem.ToString());
                ListSaved.Update();
            }
        }

        private void BtnLoadTextFile_Click(object sender, EventArgs e)
        {
            var tempWords = currentFileHandler.LoadTextFile();
            loadedWords.AddRange(tempWords);
            UpdateUI();
        }

        private void BtnLoadCutupFile_Click(object sender, EventArgs e)
        {
            var tempWords = currentFileHandler.LoadCutupFile();
            loadedWords.AddRange(tempWords);
            UpdateUI();
        }

        private void BtnSaveLoadedCutups_Click(object sender, EventArgs e)
        {
            if (currentFileHandler.SaveCutupFile(loadedWords))
            {

                MessageBox.Show("Cutups saved!");
            }
            else
            {
                MessageBox.Show("Cutups failed to save!");
            }
        }

        private void btnClearLoadedCutups_Click(object sender, EventArgs e)
        {
            loadedWords.Clear();
            UpdateUI();
        }

        private void BtnGetCutups_Click(object sender, EventArgs e)
        {
            var tryInt = 0;
            Int32.TryParse(TxtNumberCutups.Text.ToString(), out tryInt);
            if (tryInt > 0)
            {
                ListCutups.Items.Clear();
                ListCutups.Update();
                if (loadedWords.Count > 0)
                {
                    var newCutups = CutupHandler.GetRandomCutups(loadedWords, tryInt);
                    foreach (var cutup in newCutups)
                    {
                        ListCutups.Items.Add(cutup);
                    }
                    ListCutups.Update();
                }else
                {
                    MessageBox.Show("No cutups loaded.");
                }
            }
            else
            {
                MessageBox.Show("Please use a number.");
                TxtNumberCutups.Text = "5";
            }
        }

        private void BtnClearSavedCutups_Click(object sender, EventArgs e)
        {
            ListSaved.Items.Clear();
            ListSaved.Update();
        }

        private void BtnRandomSaved_Click(object sender, EventArgs e)
        {
            if (ListSaved.Items.Count > 0)
            {
                var randomList = RandomHandler.RandomizeList(RandomHandler.GetListFromItems(ListSaved));
                ListSaved.Items.Clear();
                foreach (var cutup in randomList)
                {
                    ListSaved.Items.Add(cutup);
                }
                ListSaved.Update();
            }
        }

        private void BtnRandomCutups_Click(object sender, EventArgs e)
        {
            if (ListCutups.Items.Count > 0)
            {
                var randomList = RandomHandler.RandomizeList(RandomHandler.GetListFromItems(ListCutups));
                ListCutups.Items.Clear();
                foreach (var cutup in randomList)
                {
                    ListCutups.Items.Add(cutup);
                }
                ListCutups.Update();
            }
        }
    }
}
