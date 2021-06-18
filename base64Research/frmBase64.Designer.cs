
namespace base64Research
{
    partial class frmBase64
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase64));
            this.txtSrcArray = new System.Windows.Forms.TextBox();
            this.txtDstArray = new System.Windows.Forms.TextBox();
            this.btnShowSrcArray = new System.Windows.Forms.Button();
            this.btnDstArray = new System.Windows.Forms.Button();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnToBase64 = new System.Windows.Forms.Button();
            this.btnFromBase64 = new System.Windows.Forms.Button();
            this.txtCompareArrays = new System.Windows.Forms.Button();
            this.pbSrc = new System.Windows.Forms.PictureBox();
            this.btnSavePictureToStream = new System.Windows.Forms.Button();
            this.pbDst = new System.Windows.Forms.PictureBox();
            this.btnRestorePicture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDstToFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDst)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrcArray
            // 
            this.txtSrcArray.Location = new System.Drawing.Point(31, 117);
            this.txtSrcArray.Multiline = true;
            this.txtSrcArray.Name = "txtSrcArray";
            this.txtSrcArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSrcArray.Size = new System.Drawing.Size(265, 160);
            this.txtSrcArray.TabIndex = 0;
            // 
            // txtDstArray
            // 
            this.txtDstArray.Location = new System.Drawing.Point(583, 198);
            this.txtDstArray.Multiline = true;
            this.txtDstArray.Name = "txtDstArray";
            this.txtDstArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDstArray.Size = new System.Drawing.Size(264, 79);
            this.txtDstArray.TabIndex = 1;
            // 
            // btnShowSrcArray
            // 
            this.btnShowSrcArray.Location = new System.Drawing.Point(63, 283);
            this.btnShowSrcArray.Name = "btnShowSrcArray";
            this.btnShowSrcArray.Size = new System.Drawing.Size(180, 28);
            this.btnShowSrcArray.TabIndex = 2;
            this.btnShowSrcArray.Text = "Показать первый массив";
            this.btnShowSrcArray.UseVisualStyleBackColor = true;
            this.btnShowSrcArray.Click += new System.EventHandler(this.btnShowSrcArray_Click);
            // 
            // btnDstArray
            // 
            this.btnDstArray.Location = new System.Drawing.Point(636, 283);
            this.btnDstArray.Name = "btnDstArray";
            this.btnDstArray.Size = new System.Drawing.Size(180, 28);
            this.btnDstArray.TabIndex = 3;
            this.btnDstArray.Text = "Показать второй массив";
            this.btnDstArray.UseVisualStyleBackColor = true;
            this.btnDstArray.Click += new System.EventHandler(this.btnDstArray_Click);
            // 
            // txtBase64
            // 
            this.txtBase64.Location = new System.Drawing.Point(314, 316);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64.Size = new System.Drawing.Size(263, 123);
            this.txtBase64.TabIndex = 4;
            // 
            // btnToBase64
            // 
            this.btnToBase64.Location = new System.Drawing.Point(249, 283);
            this.btnToBase64.Name = "btnToBase64";
            this.btnToBase64.Size = new System.Drawing.Size(180, 28);
            this.btnToBase64.TabIndex = 5;
            this.btnToBase64.Text = "Перегнать в Base64";
            this.btnToBase64.UseVisualStyleBackColor = true;
            this.btnToBase64.Click += new System.EventHandler(this.btnToBase64_Click);
            // 
            // btnFromBase64
            // 
            this.btnFromBase64.Location = new System.Drawing.Point(450, 283);
            this.btnFromBase64.Name = "btnFromBase64";
            this.btnFromBase64.Size = new System.Drawing.Size(180, 28);
            this.btnFromBase64.TabIndex = 6;
            this.btnFromBase64.Text = "Вытянуть из Base64";
            this.btnFromBase64.UseVisualStyleBackColor = true;
            this.btnFromBase64.Click += new System.EventHandler(this.btnFromBase64_Click);
            // 
            // txtCompareArrays
            // 
            this.txtCompareArrays.Location = new System.Drawing.Point(829, 285);
            this.txtCompareArrays.Name = "txtCompareArrays";
            this.txtCompareArrays.Size = new System.Drawing.Size(123, 25);
            this.txtCompareArrays.TabIndex = 7;
            this.txtCompareArrays.Text = "Сравнить массивы";
            this.txtCompareArrays.UseVisualStyleBackColor = true;
            this.txtCompareArrays.Click += new System.EventHandler(this.txtCompareArrays_Click);
            // 
            // pbSrc
            // 
            this.pbSrc.Image = ((System.Drawing.Image)(resources.GetObject("pbSrc.Image")));
            this.pbSrc.Location = new System.Drawing.Point(75, 28);
            this.pbSrc.Name = "pbSrc";
            this.pbSrc.Size = new System.Drawing.Size(35, 32);
            this.pbSrc.TabIndex = 8;
            this.pbSrc.TabStop = false;
            // 
            // btnSavePictureToStream
            // 
            this.btnSavePictureToStream.Location = new System.Drawing.Point(39, 73);
            this.btnSavePictureToStream.Name = "btnSavePictureToStream";
            this.btnSavePictureToStream.Size = new System.Drawing.Size(242, 25);
            this.btnSavePictureToStream.TabIndex = 9;
            this.btnSavePictureToStream.Text = "Сохранить картинку";
            this.btnSavePictureToStream.UseVisualStyleBackColor = true;
            this.btnSavePictureToStream.Click += new System.EventHandler(this.btnSavePictureToStream_Click);
            // 
            // pbDst
            // 
            this.pbDst.Location = new System.Drawing.Point(583, 22);
            this.pbDst.Name = "pbDst";
            this.pbDst.Size = new System.Drawing.Size(246, 139);
            this.pbDst.TabIndex = 10;
            this.pbDst.TabStop = false;
            // 
            // btnRestorePicture
            // 
            this.btnRestorePicture.Location = new System.Drawing.Point(583, 167);
            this.btnRestorePicture.Name = "btnRestorePicture";
            this.btnRestorePicture.Size = new System.Drawing.Size(246, 25);
            this.btnRestorePicture.TabIndex = 11;
            this.btnRestorePicture.Text = "Воссоздать картинку";
            this.btnRestorePicture.UseVisualStyleBackColor = true;
            this.btnRestorePicture.Click += new System.EventHandler(this.btnRestorePicture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDstToFile
            // 
            this.btnDstToFile.Location = new System.Drawing.Point(829, 324);
            this.btnDstToFile.Name = "btnDstToFile";
            this.btnDstToFile.Size = new System.Drawing.Size(122, 27);
            this.btnDstToFile.TabIndex = 13;
            this.btnDstToFile.Text = "Сохранить в файл";
            this.btnDstToFile.UseVisualStyleBackColor = true;
            this.btnDstToFile.Click += new System.EventHandler(this.btnDstToFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDstToFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestorePicture);
            this.Controls.Add(this.pbDst);
            this.Controls.Add(this.btnSavePictureToStream);
            this.Controls.Add(this.pbSrc);
            this.Controls.Add(this.txtCompareArrays);
            this.Controls.Add(this.btnFromBase64);
            this.Controls.Add(this.btnToBase64);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.btnDstArray);
            this.Controls.Add(this.btnShowSrcArray);
            this.Controls.Add(this.txtDstArray);
            this.Controls.Add(this.txtSrcArray);
            this.Name = "frmBase64";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBase64_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrcArray;
        private System.Windows.Forms.TextBox txtDstArray;
        private System.Windows.Forms.Button btnShowSrcArray;
        private System.Windows.Forms.Button btnDstArray;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Button btnToBase64;
        private System.Windows.Forms.Button btnFromBase64;
        private System.Windows.Forms.Button txtCompareArrays;
        private System.Windows.Forms.PictureBox pbSrc;
        private System.Windows.Forms.Button btnSavePictureToStream;
        private System.Windows.Forms.PictureBox pbDst;
        private System.Windows.Forms.Button btnRestorePicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDstToFile;
        private System.Windows.Forms.Button button2;
    }
}

