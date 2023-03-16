using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

namespace WordToCSVConvert
{
    public partial class Form1 : Form
    {
        private string wordFilePath = "";
        private string csvFilePath = "";
        private string csvFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectWordFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordFilePath = openFileDialog.FileName;
                lblWordFilePath.Text = $"Word файл: {wordFilePath}";
            }
        }

        private void BtnSelectCsvFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                csvFolderPath = folderBrowserDialog.SelectedPath;
                lblCsvFolderPath.Text = $"Папка для сохранения CSV: {csvFolderPath}";
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wordFilePath) || string.IsNullOrEmpty(csvFolderPath))
            {
                MessageBox.Show("Пожалуйста, выберите Word файл и папку для сохранения CSV файла перед конвертацией.");
                return;
            }

            string fileName = Path.GetFileNameWithoutExtension(wordFilePath) + ".csv";
            string fullCsvFilePath = Path.Combine(csvFolderPath, fileName);
            ConvertWordTableToCsv(wordFilePath, fullCsvFilePath);
        }
        private void ConvertWordTableToCsv(string wordFilePath, string csvFilePath)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Open(wordFilePath);

            if (wordDoc.Tables.Count > 0)
            {
                Word.Table wordTable = wordDoc.Tables[1];
                wordTable.Range.Copy();

                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                Excel.Range excelRange = excelWorksheet.Cells[1, 1];
                excelWorksheet.Paste(excelRange);

                if (File.Exists(csvFilePath))
                {
                    File.Delete(csvFilePath);
                }

                excelWorkbook.SaveAs(csvFilePath, Excel.XlFileFormat.xlCSV);
                excelWorkbook.Close();
                excelApp.Quit();

                MessageBox.Show("Таблица была скопирована из Word в Excel и сохранена в виде файла CSV.");
            }
            else
            {
                MessageBox.Show("В документе Word не найдено таблиц.");
            }

            wordDoc.Close();
            wordApp.Quit();
            }
        }
}