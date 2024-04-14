namespace arbaco
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdname = new System.Windows.Forms.TextBox();
            this.stdid = new System.Windows.Forms.TextBox();
            this.stdage = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.fmale = new System.Windows.Forms.RadioButton();
            this.courselist = new System.Windows.Forms.ListBox();
            this.extracurricular = new System.Windows.Forms.CheckBox();
            this.sumit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(88, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "student name:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(88, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "student id:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(88, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "student age:";
            // 
            // stdname
            // 
            this.stdname.Location = new System.Drawing.Point(262, 50);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(100, 22);
            this.stdname.TabIndex = 3;
            // 
            // stdid
            // 
            this.stdid.Location = new System.Drawing.Point(262, 121);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(100, 22);
            this.stdid.TabIndex = 3;
            // 
            // stdage
            // 
            this.stdage.Location = new System.Drawing.Point(262, 204);
            this.stdage.Name = "stdage";
            this.stdage.Size = new System.Drawing.Size(100, 22);
            this.stdage.TabIndex = 3;
            // 
            // male
            // 
            this.male.Location = new System.Drawing.Point(113, 279);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(82, 48);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fmale
            // 
            this.fmale.Location = new System.Drawing.Point(246, 279);
            this.fmale.Name = "fmale";
            this.fmale.Size = new System.Drawing.Size(88, 45);
            this.fmale.TabIndex = 4;
            this.fmale.TabStop = true;
            this.fmale.Text = " fmale";
            this.fmale.UseVisualStyleBackColor = true;
            this.fmale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // courselist
            // 
            this.courselist.FormattingEnabled = true;
            this.courselist.ItemHeight = 16;
            this.courselist.Items.AddRange(new object[] {
            "java",
            "c# programing",
            "hmtl",
            "forex"});
            this.courselist.Location = new System.Drawing.Point(113, 352);
            this.courselist.Name = "courselist";
            this.courselist.Size = new System.Drawing.Size(108, 116);
            this.courselist.TabIndex = 5;
            // 
            // extracurricular
            // 
            this.extracurricular.AutoSize = true;
            this.extracurricular.Location = new System.Drawing.Point(321, 374);
            this.extracurricular.Name = "extracurricular";
            this.extracurricular.Size = new System.Drawing.Size(125, 21);
            this.extracurricular.TabIndex = 6;
            this.extracurricular.Text = "extra-curricular";
            this.extracurricular.UseVisualStyleBackColor = true;
            // 
            // sumit
            // 
            this.sumit.Location = new System.Drawing.Point(79, 493);
            this.sumit.Name = "sumit";
            this.sumit.Size = new System.Drawing.Size(90, 72);
            this.sumit.TabIndex = 7;
            this.sumit.Text = "sumit";
            this.sumit.UseVisualStyleBackColor = true;
            this.sumit.Click += new System.EventHandler(this.sumit_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(184, 493);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(90, 72);
            this.clear.TabIndex = 7;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(300, 493);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 72);
            this.exit.TabIndex = 7;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultlabel.Location = new System.Drawing.Point(98, 593);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(292, 153);
            this.resultlabel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arbaco.Properties.Resources.WhatsApp_Image_2023_11_27_at_19_46_07_aa52d08a;
            this.pictureBox1.Location = new System.Drawing.Point(132, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 755);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sumit);
            this.Controls.Add(this.extracurricular);
            this.Controls.Add(this.courselist);
            this.Controls.Add(this.fmale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.stdage);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stdname;
        private System.Windows.Forms.TextBox stdid;
        private System.Windows.Forms.TextBox stdage;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton fmale;
        private System.Windows.Forms.ListBox courselist;
        private System.Windows.Forms.CheckBox extracurricular;
        private System.Windows.Forms.Button sumit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

