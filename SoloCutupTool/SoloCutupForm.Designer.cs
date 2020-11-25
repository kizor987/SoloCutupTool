namespace SoloCutupTool
{
    partial class SoloCutupTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoadTextFile = new System.Windows.Forms.Button();
            this.BtnLoadCutupFile = new System.Windows.Forms.Button();
            this.ListCutups = new System.Windows.Forms.ListBox();
            this.LblCutupResults = new System.Windows.Forms.Label();
            this.ListSaved = new System.Windows.Forms.ListBox();
            this.LblSavedCutps = new System.Windows.Forms.Label();
            this.BtnGetCutups = new System.Windows.Forms.Button();
            this.TxtNumberCutups = new System.Windows.Forms.TextBox();
            this.BtnRandomCutups = new System.Windows.Forms.Button();
            this.LblLoadedWords = new System.Windows.Forms.Label();
            this.BtnClearSavedCutups = new System.Windows.Forms.Button();
            this.BtnSaveLoadedCutups = new System.Windows.Forms.Button();
            this.btnClearLoadedCutups = new System.Windows.Forms.Button();
            this.BtnRandomSaved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoadTextFile
            // 
            this.BtnLoadTextFile.Location = new System.Drawing.Point(12, 12);
            this.BtnLoadTextFile.Name = "BtnLoadTextFile";
            this.BtnLoadTextFile.Size = new System.Drawing.Size(114, 23);
            this.BtnLoadTextFile.TabIndex = 0;
            this.BtnLoadTextFile.Text = "Load Text to Cut";
            this.BtnLoadTextFile.UseVisualStyleBackColor = true;
            this.BtnLoadTextFile.Click += new System.EventHandler(this.BtnLoadTextFile_Click);
            // 
            // BtnLoadCutupFile
            // 
            this.BtnLoadCutupFile.Location = new System.Drawing.Point(12, 41);
            this.BtnLoadCutupFile.Name = "BtnLoadCutupFile";
            this.BtnLoadCutupFile.Size = new System.Drawing.Size(114, 23);
            this.BtnLoadCutupFile.TabIndex = 1;
            this.BtnLoadCutupFile.Text = "Load Cutup File";
            this.BtnLoadCutupFile.UseVisualStyleBackColor = true;
            this.BtnLoadCutupFile.Click += new System.EventHandler(this.BtnLoadCutupFile_Click);
            // 
            // ListCutups
            // 
            this.ListCutups.FormattingEnabled = true;
            this.ListCutups.Location = new System.Drawing.Point(132, 43);
            this.ListCutups.Name = "ListCutups";
            this.ListCutups.Size = new System.Drawing.Size(205, 368);
            this.ListCutups.TabIndex = 2;
            // 
            // LblCutupResults
            // 
            this.LblCutupResults.AutoSize = true;
            this.LblCutupResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCutupResults.Location = new System.Drawing.Point(156, 9);
            this.LblCutupResults.Name = "LblCutupResults";
            this.LblCutupResults.Size = new System.Drawing.Size(149, 26);
            this.LblCutupResults.TabIndex = 3;
            this.LblCutupResults.Text = "Cutup Results";
            // 
            // ListSaved
            // 
            this.ListSaved.FormattingEnabled = true;
            this.ListSaved.Location = new System.Drawing.Point(353, 43);
            this.ListSaved.Name = "ListSaved";
            this.ListSaved.Size = new System.Drawing.Size(205, 368);
            this.ListSaved.TabIndex = 4;
            // 
            // LblSavedCutps
            // 
            this.LblSavedCutps.AutoSize = true;
            this.LblSavedCutps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSavedCutps.Location = new System.Drawing.Point(417, 8);
            this.LblSavedCutps.Name = "LblSavedCutps";
            this.LblSavedCutps.Size = new System.Drawing.Size(74, 26);
            this.LblSavedCutps.TabIndex = 5;
            this.LblSavedCutps.Text = "Saved";
            // 
            // BtnGetCutups
            // 
            this.BtnGetCutups.Location = new System.Drawing.Point(132, 417);
            this.BtnGetCutups.Name = "BtnGetCutups";
            this.BtnGetCutups.Size = new System.Drawing.Size(114, 23);
            this.BtnGetCutups.TabIndex = 6;
            this.BtnGetCutups.Text = "Get Cutups";
            this.BtnGetCutups.UseVisualStyleBackColor = true;
            this.BtnGetCutups.Click += new System.EventHandler(this.BtnGetCutups_Click);
            // 
            // TxtNumberCutups
            // 
            this.TxtNumberCutups.Location = new System.Drawing.Point(252, 419);
            this.TxtNumberCutups.Name = "TxtNumberCutups";
            this.TxtNumberCutups.Size = new System.Drawing.Size(35, 20);
            this.TxtNumberCutups.TabIndex = 7;
            // 
            // BtnRandomCutups
            // 
            this.BtnRandomCutups.Location = new System.Drawing.Point(132, 446);
            this.BtnRandomCutups.Name = "BtnRandomCutups";
            this.BtnRandomCutups.Size = new System.Drawing.Size(114, 23);
            this.BtnRandomCutups.TabIndex = 8;
            this.BtnRandomCutups.Text = "Randomize Cutups";
            this.BtnRandomCutups.UseVisualStyleBackColor = true;
            this.BtnRandomCutups.Click += new System.EventHandler(this.BtnRandomCutups_Click);
            // 
            // LblLoadedWords
            // 
            this.LblLoadedWords.AutoSize = true;
            this.LblLoadedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoadedWords.Location = new System.Drawing.Point(272, 500);
            this.LblLoadedWords.Name = "LblLoadedWords";
            this.LblLoadedWords.Size = new System.Drawing.Size(147, 22);
            this.LblLoadedWords.TabIndex = 9;
            this.LblLoadedWords.Text = "0 Cutups Loaded";
            // 
            // BtnClearSavedCutups
            // 
            this.BtnClearSavedCutups.Location = new System.Drawing.Point(444, 419);
            this.BtnClearSavedCutups.Name = "BtnClearSavedCutups";
            this.BtnClearSavedCutups.Size = new System.Drawing.Size(114, 23);
            this.BtnClearSavedCutups.TabIndex = 10;
            this.BtnClearSavedCutups.Text = "Clear Saved";
            this.BtnClearSavedCutups.UseVisualStyleBackColor = true;
            this.BtnClearSavedCutups.Click += new System.EventHandler(this.BtnClearSavedCutups_Click);
            // 
            // BtnSaveLoadedCutups
            // 
            this.BtnSaveLoadedCutups.Location = new System.Drawing.Point(12, 70);
            this.BtnSaveLoadedCutups.Name = "BtnSaveLoadedCutups";
            this.BtnSaveLoadedCutups.Size = new System.Drawing.Size(114, 23);
            this.BtnSaveLoadedCutups.TabIndex = 11;
            this.BtnSaveLoadedCutups.Text = "Save Loaded";
            this.BtnSaveLoadedCutups.UseVisualStyleBackColor = true;
            this.BtnSaveLoadedCutups.Click += new System.EventHandler(this.BtnSaveLoadedCutups_Click);
            // 
            // btnClearLoadedCutups
            // 
            this.btnClearLoadedCutups.Location = new System.Drawing.Point(12, 99);
            this.btnClearLoadedCutups.Name = "btnClearLoadedCutups";
            this.btnClearLoadedCutups.Size = new System.Drawing.Size(114, 23);
            this.btnClearLoadedCutups.TabIndex = 12;
            this.btnClearLoadedCutups.Text = "Clear Loaded";
            this.btnClearLoadedCutups.UseVisualStyleBackColor = true;
            this.btnClearLoadedCutups.Click += new System.EventHandler(this.btnClearLoadedCutups_Click);
            // 
            // BtnRandomSaved
            // 
            this.BtnRandomSaved.Location = new System.Drawing.Point(444, 448);
            this.BtnRandomSaved.Name = "BtnRandomSaved";
            this.BtnRandomSaved.Size = new System.Drawing.Size(114, 23);
            this.BtnRandomSaved.TabIndex = 13;
            this.BtnRandomSaved.Text = "Randomize Saved";
            this.BtnRandomSaved.UseVisualStyleBackColor = true;
            this.BtnRandomSaved.Click += new System.EventHandler(this.BtnRandomSaved_Click);
            // 
            // SoloCutupTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 531);
            this.Controls.Add(this.BtnRandomSaved);
            this.Controls.Add(this.btnClearLoadedCutups);
            this.Controls.Add(this.BtnSaveLoadedCutups);
            this.Controls.Add(this.BtnClearSavedCutups);
            this.Controls.Add(this.LblLoadedWords);
            this.Controls.Add(this.BtnRandomCutups);
            this.Controls.Add(this.TxtNumberCutups);
            this.Controls.Add(this.BtnGetCutups);
            this.Controls.Add(this.LblSavedCutps);
            this.Controls.Add(this.ListSaved);
            this.Controls.Add(this.LblCutupResults);
            this.Controls.Add(this.ListCutups);
            this.Controls.Add(this.BtnLoadCutupFile);
            this.Controls.Add(this.BtnLoadTextFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SoloCutupTool";
            this.Text = "SoloCutupTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadTextFile;
        private System.Windows.Forms.Button BtnLoadCutupFile;
        private System.Windows.Forms.ListBox ListCutups;
        private System.Windows.Forms.Label LblCutupResults;
        private System.Windows.Forms.ListBox ListSaved;
        private System.Windows.Forms.Label LblSavedCutps;
        private System.Windows.Forms.Button BtnGetCutups;
        private System.Windows.Forms.TextBox TxtNumberCutups;
        private System.Windows.Forms.Button BtnRandomCutups;
        private System.Windows.Forms.Label LblLoadedWords;
        private System.Windows.Forms.Button BtnClearSavedCutups;
        private System.Windows.Forms.Button BtnSaveLoadedCutups;
        private System.Windows.Forms.Button btnClearLoadedCutups;
        private System.Windows.Forms.Button BtnRandomSaved;
    }
}

