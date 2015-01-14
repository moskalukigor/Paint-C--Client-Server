namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartDrawning = new System.Windows.Forms.Button();
            this.btnPt1 = new System.Windows.Forms.Button();
            this.btnPt2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(260, 237);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnStartDrawning
            // 
            this.btnStartDrawning.Location = new System.Drawing.Point(83, 255);
            this.btnStartDrawning.Name = "btnStartDrawning";
            this.btnStartDrawning.Size = new System.Drawing.Size(107, 23);
            this.btnStartDrawning.TabIndex = 1;
            this.btnStartDrawning.Text = "Start drawning";
            this.btnStartDrawning.UseVisualStyleBackColor = true;
            // 
            // btnPt1
            // 
            this.btnPt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPt1.Location = new System.Drawing.Point(196, 255);
            this.btnPt1.Name = "btnPt1";
            this.btnPt1.Size = new System.Drawing.Size(31, 23);
            this.btnPt1.TabIndex = 3;
            this.btnPt1.Text = "pt1";
            this.btnPt1.UseVisualStyleBackColor = true;
            this.btnPt1.Click += new System.EventHandler(this.btnPt1_Click);
            // 
            // btnPt2
            // 
            this.btnPt2.Location = new System.Drawing.Point(233, 255);
            this.btnPt2.Name = "btnPt2";
            this.btnPt2.Size = new System.Drawing.Size(31, 23);
            this.btnPt2.TabIndex = 4;
            this.btnPt2.Text = "pt2";
            this.btnPt2.UseVisualStyleBackColor = true;
            this.btnPt2.Click += new System.EventHandler(this.btnPt2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.btnPt2);
            this.Controls.Add(this.btnPt1);
            this.Controls.Add(this.btnStartDrawning);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button btnStartDrawning;
        private System.Windows.Forms.Button btnPt1;
        private System.Windows.Forms.Button btnPt2;
    }
}

