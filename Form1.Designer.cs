namespace WindowsFormsApp4._2
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
            this.PersonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonCheck = new System.Windows.Forms.ComboBox();
            this.today = new System.Windows.Forms.Label();
            this.fac = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.foundPerson = new System.Windows.Forms.TextBox();
            this.BirthDatePick = new System.Windows.Forms.DateTimePicker();
            this.show = new System.Windows.Forms.Button();
            this.expBox = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSON";
            // 
            // PersonName
            // 
            this.PersonName.Location = new System.Drawing.Point(50, 84);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(171, 20);
            this.PersonName.TabIndex = 1;
            this.PersonName.TextChanged += new System.EventHandler(this.PersonName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BIRTH DATE";
            // 
            // PersonCheck
            // 
            this.PersonCheck.FormattingEnabled = true;
            this.PersonCheck.Location = new System.Drawing.Point(50, 35);
            this.PersonCheck.Name = "PersonCheck";
            this.PersonCheck.Size = new System.Drawing.Size(171, 21);
            this.PersonCheck.TabIndex = 5;
            this.PersonCheck.SelectedIndexChanged += new System.EventHandler(this.PersonCheck_SelectedIndexChanged);
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.Location = new System.Drawing.Point(290, 158);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(44, 13);
            this.today.TabIndex = 6;
            this.today.Text = "TODAY";
            // 
            // fac
            // 
            this.fac.AutoSize = true;
            this.fac.Location = new System.Drawing.Point(47, 213);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(62, 13);
            this.fac.TabIndex = 8;
            this.fac.Text = "FACULTET";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(293, 270);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 45);
            this.add.TabIndex = 10;
            this.add.Text = "ADD NEW";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(47, 264);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(52, 13);
            this.course.TabIndex = 12;
            this.course.Text = "COURSE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(50, 240);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(171, 21);
            this.courseBox.TabIndex = 14;
            this.courseBox.SelectedIndexChanged += new System.EventHandler(this.courseBox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(50, 295);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 20);
            this.title.TabIndex = 15;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TITLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "EXPERIENCE (YEARS)";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(293, 321);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(100, 48);
            this.find.TabIndex = 19;
            this.find.Text = "FIND";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // foundPerson
            // 
            this.foundPerson.Location = new System.Drawing.Point(513, 132);
            this.foundPerson.Multiline = true;
            this.foundPerson.Name = "foundPerson";
            this.foundPerson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.foundPerson.Size = new System.Drawing.Size(238, 237);
            this.foundPerson.TabIndex = 20;
            this.foundPerson.TextChanged += new System.EventHandler(this.foundPerson_TextChanged);
            // 
            // BirthDatePick
            // 
            this.BirthDatePick.Location = new System.Drawing.Point(50, 132);
            this.BirthDatePick.Name = "BirthDatePick";
            this.BirthDatePick.Size = new System.Drawing.Size(171, 20);
            this.BirthDatePick.TabIndex = 21;
            this.BirthDatePick.ValueChanged += new System.EventHandler(this.BirthDatePick_ValueChanged);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(513, 386);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(107, 52);
            this.show.TabIndex = 22;
            this.show.Text = "SHOW EVERYONE";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(50, 349);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(171, 20);
            this.expBox.TabIndex = 23;
            this.expBox.TextChanged += new System.EventHandler(this.expBox_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(640, 386);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 52);
            this.clear.TabIndex = 24;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.show);
            this.Controls.Add(this.BirthDatePick);
            this.Controls.Add(this.foundPerson);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.course);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fac);
            this.Controls.Add(this.today);
            this.Controls.Add(this.PersonCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PersonName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersonCheck;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Label fac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox foundPerson;
        private System.Windows.Forms.DateTimePicker BirthDatePick;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox expBox;
        private System.Windows.Forms.Button clear;
    }
}

