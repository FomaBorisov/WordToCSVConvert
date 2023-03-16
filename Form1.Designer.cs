namespace WordToCSVConvert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectWordFile = new Button();
            btnSelectCsvFil = new Button();
            lblWordFilePath = new Label();
            lblCsvFolderPath = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // btnSelectWordFile
            // 
            btnSelectWordFile.Location = new Point(53, 73);
            btnSelectWordFile.Name = "btnSelectWordFile";
            btnSelectWordFile.Size = new Size(192, 29);
            btnSelectWordFile.TabIndex = 0;
            btnSelectWordFile.Text = "Выбрать Word файл";
            btnSelectWordFile.UseVisualStyleBackColor = true;
            btnSelectWordFile.Click += BtnSelectWordFile_Click;
            // 
            // btnSelectCsvFil
            // 
            btnSelectCsvFil.Location = new Point(53, 177);
            btnSelectCsvFil.Name = "btnSelectCsvFil";
            btnSelectCsvFil.Size = new Size(192, 29);
            btnSelectCsvFil.TabIndex = 1;
            btnSelectCsvFil.Text = "Выбрать CSV файл";
            btnSelectCsvFil.UseVisualStyleBackColor = true;
            btnSelectCsvFil.Click += BtnSelectCsvFolder_Click;
            // 
            // lblWordFilePath
            // 
            lblWordFilePath.AutoSize = true;
            lblWordFilePath.Location = new Point(270, 77);
            lblWordFilePath.Name = "lblWordFilePath";
            lblWordFilePath.Size = new Size(87, 20);
            lblWordFilePath.TabIndex = 2;
            lblWordFilePath.Text = "Word файл:";
            // 
            // lblCsvFolderPath
            // 
            lblCsvFolderPath.AutoSize = true;
            lblCsvFolderPath.Location = new Point(270, 181);
            lblCsvFolderPath.Name = "lblCsvFolderPath";
            lblCsvFolderPath.Size = new Size(77, 20);
            lblCsvFolderPath.TabIndex = 3;
            lblCsvFolderPath.Text = "CSV файл:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(53, 281);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(192, 29);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Конвертировать";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += BtnConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(lblCsvFolderPath);
            Controls.Add(lblWordFilePath);
            Controls.Add(btnSelectCsvFil);
            Controls.Add(btnSelectWordFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectWordFile;
        private Button btnSelectCsvFil;
        private Label lblWordFilePath;
        private Label lblCsvFolderPath;
        private Button btnConvert;
    }
}