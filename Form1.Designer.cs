namespace Bài_tập_về_nhà_buổi_3
{
    partial class Form1
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
            this.txtboxhoten = new System.Windows.Forms.TextBox();
            this.groupboxchonkieuchu = new System.Windows.Forms.GroupBox();
            this.radioButtonthuong = new System.Windows.Forms.RadioButton();
            this.radioButtoninhoa = new System.Windows.Forms.RadioButton();
            this.buttonkq = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupboxchonkieuchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            // 
            // txtboxhoten
            // 
            this.txtboxhoten.Location = new System.Drawing.Point(235, 38);
            this.txtboxhoten.Multiline = true;
            this.txtboxhoten.Name = "txtboxhoten";
            this.txtboxhoten.Size = new System.Drawing.Size(352, 47);
            this.txtboxhoten.TabIndex = 1;
            // 
            // groupboxchonkieuchu
            // 
            this.groupboxchonkieuchu.Controls.Add(this.radioButtoninhoa);
            this.groupboxchonkieuchu.Controls.Add(this.radioButtonthuong);
            this.groupboxchonkieuchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxchonkieuchu.Location = new System.Drawing.Point(62, 118);
            this.groupboxchonkieuchu.Name = "groupboxchonkieuchu";
            this.groupboxchonkieuchu.Size = new System.Drawing.Size(384, 134);
            this.groupboxchonkieuchu.TabIndex = 2;
            this.groupboxchonkieuchu.TabStop = false;
            this.groupboxchonkieuchu.Text = "Chọn kiểu chữ";
            // 
            // radioButtonthuong
            // 
            this.radioButtonthuong.AutoSize = true;
            this.radioButtonthuong.Location = new System.Drawing.Point(58, 41);
            this.radioButtonthuong.Name = "radioButtonthuong";
            this.radioButtonthuong.Size = new System.Drawing.Size(134, 29);
            this.radioButtonthuong.TabIndex = 0;
            this.radioButtonthuong.TabStop = true;
            this.radioButtonthuong.Text = "chữ thường";
            this.radioButtonthuong.UseVisualStyleBackColor = true;
            // 
            // radioButtoninhoa
            // 
            this.radioButtoninhoa.AutoSize = true;
            this.radioButtoninhoa.Location = new System.Drawing.Point(58, 76);
            this.radioButtoninhoa.Name = "radioButtoninhoa";
            this.radioButtoninhoa.Size = new System.Drawing.Size(153, 29);
            this.radioButtoninhoa.TabIndex = 1;
            this.radioButtoninhoa.TabStop = true;
            this.radioButtoninhoa.Text = "CHỮ IN HOA";
            this.radioButtoninhoa.UseVisualStyleBackColor = true;
            this.radioButtoninhoa.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonkq
            // 
            this.buttonkq.Location = new System.Drawing.Point(62, 271);
            this.buttonkq.Name = "buttonkq";
            this.buttonkq.Size = new System.Drawing.Size(135, 42);
            this.buttonkq.TabIndex = 3;
            this.buttonkq.Text = "Kết quả";
            this.buttonkq.UseVisualStyleBackColor = true;
            this.buttonkq.Click += new System.EventHandler(this.buttonkq_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(467, 132);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(120, 120);
            this.buttonxoa.TabIndex = 4;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(204, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 44);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonkq);
            this.Controls.Add(this.groupboxchonkieuchu);
            this.Controls.Add(this.txtboxhoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxchonkieuchu.ResumeLayout(false);
            this.groupboxchonkieuchu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxhoten;
        private System.Windows.Forms.GroupBox groupboxchonkieuchu;
        private System.Windows.Forms.RadioButton radioButtoninhoa;
        private System.Windows.Forms.RadioButton radioButtonthuong;
        private System.Windows.Forms.Button buttonkq;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.ListBox listBox1;
    }
}

