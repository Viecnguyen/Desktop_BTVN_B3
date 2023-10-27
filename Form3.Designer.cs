namespace Bài_tập_về_nhà_buổi_3
{
    partial class Form3
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
            this.labela = new System.Windows.Forms.Label();
            this.txtboxa = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.txtboxb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonuscln = new System.Windows.Forms.RadioButton();
            this.radioButtonusc = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonkq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(164, 59);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(59, 25);
            this.labela.TabIndex = 0;
            this.labela.Text = "Số a:";
            // 
            // txtboxa
            // 
            this.txtboxa.Location = new System.Drawing.Point(226, 47);
            this.txtboxa.Multiline = true;
            this.txtboxa.Name = "txtboxa";
            this.txtboxa.Size = new System.Drawing.Size(93, 54);
            this.txtboxa.TabIndex = 1;
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(164, 130);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(59, 25);
            this.labelb.TabIndex = 2;
            this.labelb.Text = "Số b:";
            // 
            // txtboxb
            // 
            this.txtboxb.Location = new System.Drawing.Point(226, 118);
            this.txtboxb.Multiline = true;
            this.txtboxb.Name = "txtboxb";
            this.txtboxb.Size = new System.Drawing.Size(93, 54);
            this.txtboxb.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButtonusc);
            this.groupBox1.Controls.Add(this.radioButtonuscln);
            this.groupBox1.Location = new System.Drawing.Point(415, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // radioButtonuscln
            // 
            this.radioButtonuscln.AutoSize = true;
            this.radioButtonuscln.Location = new System.Drawing.Point(39, 30);
            this.radioButtonuscln.Name = "radioButtonuscln";
            this.radioButtonuscln.Size = new System.Drawing.Size(88, 24);
            this.radioButtonuscln.TabIndex = 0;
            this.radioButtonuscln.TabStop = true;
            this.radioButtonuscln.Text = "USCLN";
            this.radioButtonuscln.UseVisualStyleBackColor = true;
            // 
            // radioButtonusc
            // 
            this.radioButtonusc.AutoSize = true;
            this.radioButtonusc.Location = new System.Drawing.Point(39, 72);
            this.radioButtonusc.Name = "radioButtonusc";
            this.radioButtonusc.Size = new System.Drawing.Size(68, 24);
            this.radioButtonusc.TabIndex = 1;
            this.radioButtonusc.TabStop = true;
            this.radioButtonusc.Text = "USC";
            this.radioButtonusc.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(226, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 124);
            this.listBox1.TabIndex = 6;
            // 
            // buttonkq
            // 
            this.buttonkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkq.Location = new System.Drawing.Point(169, 194);
            this.buttonkq.Name = "buttonkq";
            this.buttonkq.Size = new System.Drawing.Size(150, 48);
            this.buttonkq.TabIndex = 7;
            this.buttonkq.Text = "Kết quả:";
            this.buttonkq.UseVisualStyleBackColor = true;
            this.buttonkq.Click += new System.EventHandler(this.buttonkq_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkq);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxb);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.txtboxa);
            this.Controls.Add(this.labela);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox txtboxa;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox txtboxb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonusc;
        private System.Windows.Forms.RadioButton radioButtonuscln;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonkq;
    }
}