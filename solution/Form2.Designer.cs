namespace projectv44
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.piclabel = new System.Windows.Forms.Label();
            this.pictext = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new projectv44.studentsDataSet();
            this.rivallabel = new System.Windows.Forms.Label();
            this.allylabel = new System.Windows.Forms.Label();
            this.majorbox = new System.Windows.Forms.ComboBox();
            this.majorlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rivaltext = new System.Windows.Forms.ComboBox();
            this.allytext = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new projectv44.studentsDataSetTableAdapters.studentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // piclabel
            // 
            this.piclabel.AutoSize = true;
            this.piclabel.Enabled = false;
            this.piclabel.Location = new System.Drawing.Point(12, 150);
            this.piclabel.Name = "piclabel";
            this.piclabel.Size = new System.Drawing.Size(83, 13);
            this.piclabel.TabIndex = 49;
            this.piclabel.Text = "Picture location:";
            // 
            // pictext
            // 
            this.pictext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Picture", true));
            this.pictext.Enabled = false;
            this.pictext.Location = new System.Drawing.Point(105, 147);
            this.pictext.Name = "pictext";
            this.pictext.Size = new System.Drawing.Size(447, 20);
            this.pictext.TabIndex = 48;
            this.pictext.TextChanged += new System.EventHandler(this.pictext_TextChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rivallabel
            // 
            this.rivallabel.AutoSize = true;
            this.rivallabel.Enabled = false;
            this.rivallabel.Location = new System.Drawing.Point(340, 66);
            this.rivallabel.Name = "rivallabel";
            this.rivallabel.Size = new System.Drawing.Size(34, 13);
            this.rivallabel.TabIndex = 47;
            this.rivallabel.Text = "Rival:";
            // 
            // allylabel
            // 
            this.allylabel.AutoSize = true;
            this.allylabel.Enabled = false;
            this.allylabel.Location = new System.Drawing.Point(340, 21);
            this.allylabel.Name = "allylabel";
            this.allylabel.Size = new System.Drawing.Size(26, 13);
            this.allylabel.TabIndex = 46;
            this.allylabel.Text = "Ally:";
            // 
            // majorbox
            // 
            this.majorbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Major", true));
            this.majorbox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentBindingSource, "Major", true));
            this.majorbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Major", true));
            this.majorbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.studentBindingSource, "Major", true));
            this.majorbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorbox.Enabled = false;
            this.majorbox.FormattingEnabled = true;
            this.majorbox.Items.AddRange(new object[] {
            "Carry",
            "Support",
            "Roam",
            "Jungle",
            "Midlaner"});
            this.majorbox.Location = new System.Drawing.Point(105, 62);
            this.majorbox.Name = "majorbox";
            this.majorbox.Size = new System.Drawing.Size(148, 21);
            this.majorbox.TabIndex = 39;
            // 
            // majorlabel
            // 
            this.majorlabel.AutoSize = true;
            this.majorlabel.Enabled = false;
            this.majorlabel.Location = new System.Drawing.Point(14, 65);
            this.majorlabel.Name = "majorlabel";
            this.majorlabel.Size = new System.Drawing.Size(36, 13);
            this.majorlabel.TabIndex = 36;
            this.majorlabel.Text = "Major:";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Enabled = false;
            this.namelabel.Location = new System.Drawing.Point(14, 21);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(38, 13);
            this.namelabel.TabIndex = 35;
            this.namelabel.Text = "Name:";
            // 
            // nametext
            // 
            this.nametext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Name", true));
            this.nametext.Enabled = false;
            this.nametext.Location = new System.Drawing.Point(105, 18);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(148, 20);
            this.nametext.TabIndex = 32;
            this.nametext.TextChanged += new System.EventHandler(this.nametext_TextChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(700, 258);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 23);
            this.button10.TabIndex = 59;
            this.button10.Text = "Back to Main Menu";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(455, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 54;
            this.button5.Text = "Upload Picture";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "New Enrollment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(600, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 227);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rivaltext);
            this.groupBox1.Controls.Add(this.allytext);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nametext);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.majorlabel);
            this.groupBox1.Controls.Add(this.majorbox);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.allylabel);
            this.groupBox1.Controls.Add(this.rivallabel);
            this.groupBox1.Controls.Add(this.piclabel);
            this.groupBox1.Controls.Add(this.pictext);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 239);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // rivaltext
            // 
            this.rivaltext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Rival", true));
            this.rivaltext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rivaltext.Enabled = false;
            this.rivaltext.FormattingEnabled = true;
            this.rivaltext.Location = new System.Drawing.Point(404, 62);
            this.rivaltext.Name = "rivaltext";
            this.rivaltext.Size = new System.Drawing.Size(148, 21);
            this.rivaltext.TabIndex = 58;
            this.rivaltext.SelectedIndexChanged += new System.EventHandler(this.rivaltext_SelectedIndexChanged);
            // 
            // allytext
            // 
            this.allytext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Ally", true));
            this.allytext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allytext.Enabled = false;
            this.allytext.FormattingEnabled = true;
            this.allytext.Location = new System.Drawing.Point(404, 20);
            this.allytext.Name = "allytext";
            this.allytext.Size = new System.Drawing.Size(148, 21);
            this.allytext.TabIndex = 57;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Battle_Name", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Battle Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.studentsDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label piclabel;
        private System.Windows.Forms.TextBox pictext;
        private System.Windows.Forms.Label rivallabel;
        private System.Windows.Forms.Label allylabel;
        private System.Windows.Forms.ComboBox majorbox;
        private System.Windows.Forms.Label majorlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentsDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ComboBox allytext;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.ComboBox rivaltext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}