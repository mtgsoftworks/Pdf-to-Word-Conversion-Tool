namespace Pdf_to_Word_Conversion_Tool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.textbox_pdf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox_docx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Dosya Yolu (.pdf):";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(158, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Kayıt Yolu (.docx)";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Depth = 0;
            this.ProgressBar1.Location = new System.Drawing.Point(48, 221);
            this.ProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(554, 5);
            this.ProgressBar1.TabIndex = 13;
            // 
            // textbox_pdf
            // 
            this.textbox_pdf.Depth = 0;
            this.textbox_pdf.Hint = "";
            this.textbox_pdf.Location = new System.Drawing.Point(227, 103);
            this.textbox_pdf.MaxLength = 32767;
            this.textbox_pdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_pdf.Name = "textbox_pdf";
            this.textbox_pdf.PasswordChar = '\0';
            this.textbox_pdf.SelectedText = "";
            this.textbox_pdf.SelectionLength = 0;
            this.textbox_pdf.SelectionStart = 0;
            this.textbox_pdf.Size = new System.Drawing.Size(375, 28);
            this.textbox_pdf.TabIndex = 14;
            this.textbox_pdf.TabStop = false;
            this.textbox_pdf.UseSystemPasswordChar = false;
            // 
            // textbox_docx
            // 
            this.textbox_docx.Depth = 0;
            this.textbox_docx.Hint = "";
            this.textbox_docx.Location = new System.Drawing.Point(227, 152);
            this.textbox_docx.MaxLength = 32767;
            this.textbox_docx.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_docx.Name = "textbox_docx";
            this.textbox_docx.PasswordChar = '\0';
            this.textbox_docx.SelectedText = "";
            this.textbox_docx.SelectionLength = 0;
            this.textbox_docx.SelectionStart = 0;
            this.textbox_docx.Size = new System.Drawing.Size(375, 28);
            this.textbox_docx.TabIndex = 15;
            this.textbox_docx.TabStop = false;
            this.textbox_docx.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(262, 280);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(144, 36);
            this.materialFlatButton1.TabIndex = 17;
            this.materialFlatButton1.Text = "İşlemi Başlat";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(632, 103);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 24);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Aç";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(632, 152);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(32, 24);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Aç";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(23, 402);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 24);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Version:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.textbox_docx);
            this.Controls.Add(this.textbox_pdf);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pdf to Word Conversion Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBar1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_pdf;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_docx;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

