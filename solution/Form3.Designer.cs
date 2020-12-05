namespace projectv44
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new projectv44.studentsDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorlabel = new System.Windows.Forms.Label();
            this.allylabel = new System.Windows.Forms.Label();
            this.rivallabel = new System.Windows.Forms.Label();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableAdapter = new projectv44.studentsDataSetTableAdapters.studentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.majorlabel);
            this.groupBox1.Controls.Add(this.allylabel);
            this.groupBox1.Controls.Add(this.rivallabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 190);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(363, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 23);
            this.button9.TabIndex = 66;
            this.button9.Text = "Upload Picture";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Major", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.studentBindingSource, "Major", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentBindingSource, "Major", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.studentBindingSource, "Major", true));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Carry",
            "Support",
            "Roam",
            "Jungle",
            "Midlaner"});
            this.comboBox3.Location = new System.Drawing.Point(106, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 21);
            this.comboBox3.TabIndex = 65;
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
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Rival", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(363, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 21);
            this.comboBox2.TabIndex = 64;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Ally", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Battle_Name", true));
            this.textBox2.Location = new System.Drawing.Point(106, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 59;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Name", true));
            this.textBox7.Location = new System.Drawing.Point(106, 17);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 20);
            this.textBox7.TabIndex = 57;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Picture", true));
            this.textBox6.Location = new System.Drawing.Point(106, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(416, 20);
            this.textBox6.TabIndex = 56;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Picture path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Battle Name:";
            // 
            // majorlabel
            // 
            this.majorlabel.AutoSize = true;
            this.majorlabel.Location = new System.Drawing.Point(16, 63);
            this.majorlabel.Name = "majorlabel";
            this.majorlabel.Size = new System.Drawing.Size(36, 13);
            this.majorlabel.TabIndex = 36;
            this.majorlabel.Text = "Major:";
            // 
            // allylabel
            // 
            this.allylabel.AutoSize = true;
            this.allylabel.Location = new System.Drawing.Point(303, 17);
            this.allylabel.Name = "allylabel";
            this.allylabel.Size = new System.Drawing.Size(26, 13);
            this.allylabel.TabIndex = 46;
            this.allylabel.Text = "Ally:";
            // 
            // rivallabel
            // 
            this.rivallabel.AutoSize = true;
            this.rivallabel.Location = new System.Drawing.Point(303, 63);
            this.rivallabel.Name = "rivallabel";
            this.rivallabel.Size = new System.Drawing.Size(34, 13);
            this.rivallabel.TabIndex = 47;
            this.rivallabel.Text = "Rival:";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.studentsDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Back to Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(549, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 219);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 214);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Roster";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.battleNameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.allyDataGridViewTextBoxColumn,
            this.rivalDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // battleNameDataGridViewTextBoxColumn
            // 
            this.battleNameDataGridViewTextBoxColumn.DataPropertyName = "Battle_Name";
            this.battleNameDataGridViewTextBoxColumn.HeaderText = "Battle_Name";
            this.battleNameDataGridViewTextBoxColumn.Name = "battleNameDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // allyDataGridViewTextBoxColumn
            // 
            this.allyDataGridViewTextBoxColumn.DataPropertyName = "Ally";
            this.allyDataGridViewTextBoxColumn.HeaderText = "Ally";
            this.allyDataGridViewTextBoxColumn.Name = "allyDataGridViewTextBoxColumn";
            // 
            // rivalDataGridViewTextBoxColumn
            // 
            this.rivalDataGridViewTextBoxColumn.DataPropertyName = "Rival";
            this.rivalDataGridViewTextBoxColumn.HeaderText = "Rival";
            this.rivalDataGridViewTextBoxColumn.Name = "rivalDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Search by Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 66;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 67;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(393, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 68;
            this.button5.Text = "Go to Top";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(393, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "Go to Bottom";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(266, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 70;
            this.button7.Text = "Expel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(266, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 71;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(789, 25);
            this.searchToolStrip.TabIndex = 72;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.param1ToolStripLabel.Text = "Param1:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 525);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label majorlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label allylabel;
        private System.Windows.Forms.Label rivallabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentsDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn battleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
    }
}