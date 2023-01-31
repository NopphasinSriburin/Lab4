namespace LAB4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.BirthYear = new System.Windows.Forms.TextBox();
            this.GBA = new System.Windows.Forms.TextBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GBAMAX = new System.Windows.Forms.TextBox();
            this.GBAMIN = new System.Windows.Forms.TextBox();
            this.GBAAVG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Namemin = new System.Windows.Forms.TextBox();
            this.Namemax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ปีเกิด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GBA";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(67, 37);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(193, 27);
            this.Name1.TabIndex = 3;
            this.Name1.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // BirthYear
            // 
            this.BirthYear.Location = new System.Drawing.Point(67, 75);
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Size = new System.Drawing.Size(193, 27);
            this.BirthYear.TabIndex = 4;
            // 
            // GBA
            // 
            this.GBA.Location = new System.Drawing.Point(67, 116);
            this.GBA.Name = "GBA";
            this.GBA.Size = new System.Drawing.Size(193, 27);
            this.GBA.TabIndex = 5;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(65, 166);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(193, 54);
            this.SAVE.TabIndex = 6;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ข้อมูลทั้งหมด";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "GBA MAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "GBA MIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "GBA Avg";
            // 
            // GBAMAX
            // 
            this.GBAMAX.Location = new System.Drawing.Point(356, 37);
            this.GBAMAX.Name = "GBAMAX";
            this.GBAMAX.Size = new System.Drawing.Size(191, 27);
            this.GBAMAX.TabIndex = 11;
            // 
            // GBAMIN
            // 
            this.GBAMIN.Location = new System.Drawing.Point(356, 79);
            this.GBAMIN.Name = "GBAMIN";
            this.GBAMIN.Size = new System.Drawing.Size(191, 27);
            this.GBAMIN.TabIndex = 12;
            // 
            // GBAAVG
            // 
            this.GBAAVG.Location = new System.Drawing.Point(356, 120);
            this.GBAAVG.Name = "GBAAVG";
            this.GBAAVG.Size = new System.Drawing.Size(191, 27);
            this.GBAAVG.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "อายุรวม";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(356, 166);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(191, 27);
            this.Age.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "รายชื่อ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(356, 213);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(432, 225);
            this.textBox5.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "ชื่อ";
            // 
            // Namemin
            // 
            this.Namemin.Location = new System.Drawing.Point(595, 79);
            this.Namemin.Name = "Namemin";
            this.Namemin.Size = new System.Drawing.Size(193, 27);
            this.Namemin.TabIndex = 20;
            // 
            // Namemax
            // 
            this.Namemax.Location = new System.Drawing.Point(595, 37);
            this.Namemax.Name = "Namemax";
            this.Namemax.Size = new System.Drawing.Size(193, 27);
            this.Namemax.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Namemax);
            this.Controls.Add(this.Namemin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GBAAVG);
            this.Controls.Add(this.GBAMIN);
            this.Controls.Add(this.GBAMAX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.GBA);
            this.Controls.Add(this.BirthYear);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Name1;
        private TextBox BirthYear;
        private TextBox GBA;
        private Button SAVE;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox GBAMAX;
        private TextBox GBAMIN;
        private TextBox GBAAVG;
        private Label label8;
        private TextBox Age;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private Label label11;
        private TextBox Namemin;
        private TextBox Namemax;
    }
}