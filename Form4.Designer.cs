namespace Bài_tập_về_nhà_buổi_3
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonin = new System.Windows.Forms.Button();
            this.buttonholot = new System.Windows.Forms.Button();
            this.buttonten = new System.Windows.Forms.Button();
            this.buttondemtu = new System.Windows.Forms.Button();
            this.buttonhoa = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttondung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ và Tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 47);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(130, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(494, 124);
            this.listBox1.TabIndex = 3;
            // 
            // buttonin
            // 
            this.buttonin.Location = new System.Drawing.Point(130, 301);
            this.buttonin.Name = "buttonin";
            this.buttonin.Size = new System.Drawing.Size(86, 113);
            this.buttonin.TabIndex = 4;
            this.buttonin.Text = "In Lời giới thiệu";
            this.buttonin.UseVisualStyleBackColor = true;
            // 
            // buttonholot
            // 
            this.buttonholot.Location = new System.Drawing.Point(235, 301);
            this.buttonholot.Name = "buttonholot";
            this.buttonholot.Size = new System.Drawing.Size(98, 51);
            this.buttonholot.TabIndex = 5;
            this.buttonholot.Text = "Họ lót";
            this.buttonholot.UseVisualStyleBackColor = true;
            // 
            // buttonten
            // 
            this.buttonten.Location = new System.Drawing.Point(235, 363);
            this.buttonten.Name = "buttonten";
            this.buttonten.Size = new System.Drawing.Size(98, 51);
            this.buttonten.TabIndex = 6;
            this.buttonten.Text = "Tên";
            this.buttonten.UseVisualStyleBackColor = true;
            // 
            // buttondemtu
            // 
            this.buttondemtu.Location = new System.Drawing.Point(351, 301);
            this.buttondemtu.Name = "buttondemtu";
            this.buttondemtu.Size = new System.Drawing.Size(153, 51);
            this.buttondemtu.TabIndex = 7;
            this.buttondemtu.Text = "Đếm từ";
            this.buttondemtu.UseVisualStyleBackColor = true;
            // 
            // buttonhoa
            // 
            this.buttonhoa.Location = new System.Drawing.Point(351, 363);
            this.buttonhoa.Name = "buttonhoa";
            this.buttonhoa.Size = new System.Drawing.Size(153, 51);
            this.buttonhoa.TabIndex = 8;
            this.buttonhoa.Text = "Hoa Đầu từ";
            this.buttonhoa.UseVisualStyleBackColor = true;
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(526, 301);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(98, 51);
            this.buttonxoa.TabIndex = 9;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            // 
            // buttondung
            // 
            this.buttondung.Location = new System.Drawing.Point(526, 363);
            this.buttondung.Name = "buttondung";
            this.buttondung.Size = new System.Drawing.Size(98, 51);
            this.buttondung.TabIndex = 10;
            this.buttondung.Text = "Dừng";
            this.buttondung.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondung);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonhoa);
            this.Controls.Add(this.buttondemtu);
            this.Controls.Add(this.buttonten);
            this.Controls.Add(this.buttonholot);
            this.Controls.Add(this.buttonin);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonin;
        private System.Windows.Forms.Button buttonholot;
        private System.Windows.Forms.Button buttonten;
        private System.Windows.Forms.Button buttondemtu;
        private System.Windows.Forms.Button buttonhoa;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttondung;
    }
}