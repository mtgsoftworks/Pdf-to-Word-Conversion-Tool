using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System.Diagnostics;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.IO;
using wordeaktar = Microsoft.Office.Interop.Word;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pdf_to_Word_Conversion_Tool
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.Multiselect = false;
         
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            textbox_pdf.Text = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialLabel6.Text = "Version: " + ProductVersion;
            ProgressBar1.Value = 0;
            this.MaximizeBox = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_pdf.Text != string.Empty & textbox_docx.Text != string.Empty)
                {
                    //pdf dosyasının içindeki yazı okunuyor
                    PDDocument doc = null;
                    doc = PDDocument.load(textbox_pdf.Text);
                    PDFTextStripper textstrip = new PDFTextStripper();
                    string strPDFText = textstrip.getText(doc);

                    ProgressBar1.Value += 40;

                    doc.close();

                    //Dosyanın nereye kaydedileceği belirleniyor
                    string registrationpath = textbox_docx.Text;
                    var wordDoc = DocX.Create(registrationpath);

                    wordDoc.InsertParagraph(strPDFText);

                    wordDoc.Save();

                    ProgressBar1.Value += 30;

                    Process.Start("WINWORD.EXE", registrationpath);

                    ProgressBar1.Value += 30;

                    MessageBox.Show("İşlem Tamamlandı", "Pdf to Word Conversion Tool",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    ProgressBar1.Value = 0;
                }
               
                else
                {
                    MessageBox.Show("Lütfen İlgili Tüm Alanları Doldurun", "Pdf to Word Conversion Tool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pdf to Word Conversion Tool");
            }
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.Multiselect = false;

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            textbox_pdf.Text = openFileDialog1.FileName;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yolu Seç";
            saveFileDialog1.Filter = "Word Dosyası |*.docx";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            textbox_docx.Text = saveFileDialog1.FileName.ToString();
        }
    }
}
