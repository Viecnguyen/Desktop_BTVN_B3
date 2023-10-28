namespace Bài_tập_về_nhà_buổi_3
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttoncompare = new System.Windows.Forms.Button();
            this.buttonconcat = new System.Windows.Forms.Button();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttoncompare2 = new System.Windows.Forms.Button();
            this.buttonindexof = new System.Windows.Forms.Button();
            this.buttonsubstring = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH XỬ LÝ CHUỖI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập vào chuỗi thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập vào chuỗi thứ hai:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(143, 102);
            this.txtS1.Multiline = true;
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(526, 43);
            this.txtS1.TabIndex = 3;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(143, 192);
            this.txtS2.Multiline = true;
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(526, 43);
            this.txtS2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(143, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(526, 144);
            this.listBox1.TabIndex = 6;
            // 
            // buttoncompare
            // 
            this.buttoncompare.Location = new System.Drawing.Point(143, 425);
            this.buttoncompare.Name = "buttoncompare";
            this.buttoncompare.Size = new System.Drawing.Size(118, 38);
            this.buttoncompare.TabIndex = 7;
            this.buttoncompare.Text = "Compare";
            this.buttoncompare.UseVisualStyleBackColor = true;
            this.buttoncompare.Click += new System.EventHandler(this.buttoncompare_Click);
            // 
            // buttonconcat
            // 
            this.buttonconcat.Location = new System.Drawing.Point(280, 425);
            this.buttonconcat.Name = "buttonconcat";
            this.buttonconcat.Size = new System.Drawing.Size(118, 38);
            this.buttonconcat.TabIndex = 8;
            this.buttonconcat.Text = "Concat";
            this.buttonconcat.UseVisualStyleBackColor = true;
            this.buttonconcat.Click += new System.EventHandler(this.buttonconcat_Click);
            // 
            // buttoninsert
            // 
            this.buttoninsert.Location = new System.Drawing.Point(418, 425);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(118, 38);
            this.buttoninsert.TabIndex = 9;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(551, 425);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(118, 38);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttoncompare2
            // 
            this.buttoncompare2.Location = new System.Drawing.Point(143, 469);
            this.buttoncompare2.Name = "buttoncompare2";
            this.buttoncompare2.Size = new System.Drawing.Size(118, 38);
            this.buttoncompare2.TabIndex = 11;
            this.buttoncompare2.Text = "COMPARE";
            this.buttoncompare2.UseVisualStyleBackColor = true;
            this.buttoncompare2.Click += new System.EventHandler(this.buttoncompare2_Click);
            // 
            // buttonindexof
            // 
            this.buttonindexof.Location = new System.Drawing.Point(280, 469);
            this.buttonindexof.Name = "buttonindexof";
            this.buttonindexof.Size = new System.Drawing.Size(118, 38);
            this.buttonindexof.TabIndex = 12;
            this.buttonindexof.Text = "IndexOf";
            this.buttonindexof.UseVisualStyleBackColor = true;
            this.buttonindexof.Click += new System.EventHandler(this.buttonindexof_Click);
            // 
            // buttonsubstring
            // 
            this.buttonsubstring.Location = new System.Drawing.Point(418, 469);
            this.buttonsubstring.Name = "buttonsubstring";
            this.buttonsubstring.Size = new System.Drawing.Size(118, 38);
            this.buttonsubstring.TabIndex = 13;
            this.buttonsubstring.Text = "Substring";
            this.buttonsubstring.UseVisualStyleBackColor = true;
            // 
            // buttonstop
            // 
            this.buttonstop.Location = new System.Drawing.Point(551, 469);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(118, 38);
            this.buttonstop.TabIndex = 14;
            this.buttonstop.Text = "Stop";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonsubstring);
            this.Controls.Add(this.buttonindexof);
            this.Controls.Add(this.buttoncompare2);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.buttonconcat);
            this.Controls.Add(this.buttoncompare);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttoncompare;
        private System.Windows.Forms.Button buttonconcat;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttoncompare2;
        private System.Windows.Forms.Button buttonindexof;
        private System.Windows.Forms.Button buttonsubstring;
        private System.Windows.Forms.Button buttonstop;
    }
}