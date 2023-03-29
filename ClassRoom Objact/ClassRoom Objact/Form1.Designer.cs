namespace ClassRoom_Objact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Save = new Button();
            tbGPA = new TextBox();
            tbBirth = new TextBox();
            tbName = new TextBox();
            GpaMax = new TextBox();
            Namemin = new TextBox();
            GpaMin = new TextBox();
            Namemax = new TextBox();
            GpaAvg = new TextBox();
            Alldataname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Namelabel = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            AllAgebox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 77);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 127);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "ปีเกิด";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 175);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "GPA";
            // 
            // Save
            // 
            Save.Location = new Point(145, 225);
            Save.Name = "Save";
            Save.Size = new Size(131, 65);
            Save.TabIndex = 3;
            Save.Text = "Add";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // tbGPA
            // 
            tbGPA.Location = new Point(122, 172);
            tbGPA.Name = "tbGPA";
            tbGPA.Size = new Size(188, 27);
            tbGPA.TabIndex = 4;
            // 
            // tbBirth
            // 
            tbBirth.Location = new Point(122, 124);
            tbBirth.Name = "tbBirth";
            tbBirth.Size = new Size(188, 27);
            tbBirth.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(122, 77);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 27);
            tbName.TabIndex = 6;
            // 
            // GpaMax
            // 
            GpaMax.Location = new Point(109, 37);
            GpaMax.Name = "GpaMax";
            GpaMax.Size = new Size(188, 27);
            GpaMax.TabIndex = 7;
            // 
            // Namemin
            // 
            Namemin.Location = new Point(362, 84);
            Namemin.Name = "Namemin";
            Namemin.Size = new Size(188, 27);
            Namemin.TabIndex = 8;
            // 
            // GpaMin
            // 
            GpaMin.Location = new Point(109, 81);
            GpaMin.Name = "GpaMin";
            GpaMin.Size = new Size(188, 27);
            GpaMin.TabIndex = 8;
            // 
            // Namemax
            // 
            Namemax.Location = new Point(362, 37);
            Namemax.Name = "Namemax";
            Namemax.Size = new Size(188, 27);
            Namemax.TabIndex = 9;
            // 
            // GpaAvg
            // 
            GpaAvg.Location = new Point(109, 126);
            GpaAvg.Name = "GpaAvg";
            GpaAvg.Size = new Size(188, 27);
            GpaAvg.TabIndex = 9;
            // 
            // Alldataname
            // 
            Alldataname.Location = new Point(109, 213);
            Alldataname.Multiline = true;
            Alldataname.Name = "Alldataname";
            Alldataname.Size = new Size(408, 226);
            Alldataname.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 40);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "GPA MAX";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 88);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 13;
            label5.Text = "GPA MIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 129);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 14;
            label6.Text = "GPA AVG";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 213);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 15;
            label7.Text = "รายชื่อทั้งหมด";
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(330, 40);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(26, 20);
            Namelabel.TabIndex = 17;
            Namelabel.Text = "ชื่อ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(330, 88);
            label10.Name = "label10";
            label10.Size = new Size(26, 20);
            label10.TabIndex = 18;
            label10.Text = "ชื่อ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(AllAgebox);
            groupBox1.Controls.Add(Namemax);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Alldataname);
            groupBox1.Controls.Add(GpaMax);
            groupBox1.Controls.Add(Namelabel);
            groupBox1.Controls.Add(Namemin);
            groupBox1.Controls.Add(GpaMin);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(GpaAvg);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(353, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 456);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "ShowData";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 173);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 20;
            label8.Text = "อายุรวม";
            // 
            // AllAgebox
            // 
            AllAgebox.Location = new Point(109, 170);
            AllAgebox.Name = "AllAgebox";
            AllAgebox.Size = new Size(188, 27);
            AllAgebox.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 526);
            Controls.Add(groupBox1);
            Controls.Add(tbName);
            Controls.Add(tbBirth);
            Controls.Add(tbGPA);
            Controls.Add(Save);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Save;
        private TextBox tbGPA;
        private TextBox tbBirth;
        private TextBox tbName;
        private TextBox GpaMax;
        private TextBox Namemin;
        private TextBox GpaMin;
        private TextBox Namemax;
        private TextBox GpaAvg;
        private TextBox Alldataname;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label Namelabel;
        private Label label10;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox AllAgebox;
    }
}