
namespace Data_Entry
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
            this.labelEnterData1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEnterData2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxResult1 = new System.Windows.Forms.TextBox();
            this.buttonAverage1 = new System.Windows.Forms.Button();
            this.buttonAverage2 = new System.Windows.Forms.Button();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterData1
            // 
            this.labelEnterData1.AutoSize = true;
            this.labelEnterData1.Location = new System.Drawing.Point(40, 104);
            this.labelEnterData1.Name = "labelEnterData1";
            this.labelEnterData1.Size = new System.Drawing.Size(70, 13);
            this.labelEnterData1.TabIndex = 0;
            this.labelEnterData1.Text = "Enter Data 1:";
            this.labelEnterData1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelEnterData2
            // 
            this.labelEnterData2.AutoSize = true;
            this.labelEnterData2.Location = new System.Drawing.Point(40, 130);
            this.labelEnterData2.Name = "labelEnterData2";
            this.labelEnterData2.Size = new System.Drawing.Size(70, 13);
            this.labelEnterData2.TabIndex = 4;
            this.labelEnterData2.Text = "Enter Data 2:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(351, 540);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(432, 540);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ColumnID,
            this.ColumnData1,
            this.ColumnData2,
            this.ColumnDate});
            this.dataGridView1.Location = new System.Drawing.Point(43, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 244);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxResult1
            // 
            this.textBoxResult1.AcceptsTab = true;
            this.textBoxResult1.Location = new System.Drawing.Point(113, 445);
            this.textBoxResult1.Name = "textBoxResult1";
            this.textBoxResult1.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult1.TabIndex = 23;
            this.textBoxResult1.Text = "0";
            this.textBoxResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAverage1
            // 
            this.buttonAverage1.Location = new System.Drawing.Point(90, 471);
            this.buttonAverage1.Name = "buttonAverage1";
            this.buttonAverage1.Size = new System.Drawing.Size(146, 23);
            this.buttonAverage1.TabIndex = 24;
            this.buttonAverage1.Text = "Calculate Average Data  1";
            this.buttonAverage1.UseVisualStyleBackColor = true;
            this.buttonAverage1.Click += new System.EventHandler(this.buttonAverage1_Click);
            // 
            // buttonAverage2
            // 
            this.buttonAverage2.Location = new System.Drawing.Point(285, 471);
            this.buttonAverage2.Name = "buttonAverage2";
            this.buttonAverage2.Size = new System.Drawing.Size(146, 23);
            this.buttonAverage2.TabIndex = 26;
            this.buttonAverage2.Text = "Calculate Average Data  2";
            this.buttonAverage2.UseVisualStyleBackColor = true;
            this.buttonAverage2.Click += new System.EventHandler(this.buttonAverage2_Click);
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.AcceptsTab = true;
            this.textBoxResult2.Location = new System.Drawing.Point(308, 445);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult2.TabIndex = 25;
            this.textBoxResult2.Text = "0";
            this.textBoxResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(411, 152);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 27;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Number
            // 
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 40;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 40;
            // 
            // ColumnData1
            // 
            this.ColumnData1.HeaderText = "Data 1";
            this.ColumnData1.Name = "ColumnData1";
            this.ColumnData1.Width = 110;
            // 
            // ColumnData2
            // 
            this.ColumnData2.HeaderText = "Data 2";
            this.ColumnData2.Name = "ColumnData2";
            this.ColumnData2.Width = 110;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data Entry";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonAverage2);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.buttonAverage1);
            this.Controls.Add(this.textBoxResult1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelEnterData2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEnterData1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Data Entry Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterData1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEnterData2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxResult1;
        private System.Windows.Forms.Button buttonAverage1;
        private System.Windows.Forms.Button buttonAverage2;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.Label label1;
    }
}

