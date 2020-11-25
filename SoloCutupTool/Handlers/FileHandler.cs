using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloCutupTool.Handlers
{
    class FileHandler
    {
        public List<string> LoadTextFile()
        {
            var results = new List<string>();

            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Title = "Browse Text Files";
            loadFileDialog.DefaultExt = "txt";
            loadFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            loadFileDialog.FilterIndex = 2;
            loadFileDialog.CheckFileExists = true;
            loadFileDialog.CheckPathExists = true;
            loadFileDialog.Multiselect = true;
            loadFileDialog.ShowDialog();

            foreach (String file in loadFileDialog.FileNames)
            {
                //load text files
                var loadedStrings = GetTextFromFile(file);
                var loadedCutups = CutupHandler.LoadCutupsFromText(loadedStrings);

                foreach (string Cutup in loadedCutups)
                {
                    results.Add(Cutup);
                }
            }

            return results;
        }

        public List<string> LoadCutupFile()
        {
            var results = new List<string>();

            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Title = "Browse Text Files";
            loadFileDialog.DefaultExt = "txt";
            loadFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            loadFileDialog.FilterIndex = 2;
            loadFileDialog.CheckFileExists = true;
            loadFileDialog.CheckPathExists = true;
            loadFileDialog.Multiselect = true;
            loadFileDialog.ShowDialog();

            foreach (String file in loadFileDialog.FileNames)
            {
                //load text files
                var loadedCutups = GetCutupFromFile(file);

                foreach (string Cutup in loadedCutups)
                {
                    results.Add(Cutup);
                }
            }

            return results;
        }

        public bool SaveCutupFile(List<string> listToSave)
        {
            bool didSave = false;
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = "Browse Text Files";
            SaveFileDialog1.DefaultExt = "txt";
            SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.ShowDialog();
            var filepath = SaveFileDialog1.FileName;
            //save file
            TextWriter tw = new StreamWriter(filepath);

            foreach (String s in listToSave)
                tw.WriteLine(s);

            tw.Close();

            if (File.Exists(filepath))
            {
                didSave = true;
            }

            return didSave;
        }

        private string[] GetTextFromFile(string path)
        {
            var loadfile = "";
            if (!File.Exists(path))
            {
                //throw exception
            }
            else
            {
                loadfile = File.ReadAllText(path);
            }

            TextReader reader = new StringReader(loadfile);
            string[] results = reader.ReadToEnd().Split(' ');

            return results;
        }

        private List<string> GetCutupFromFile(string path)
        {
            string line;
            var results = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                results.Add(line);
            }

            return results;
        }
    }
}
