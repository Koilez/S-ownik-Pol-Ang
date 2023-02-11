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
            this.buttonPoland = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.labelNameSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textPoland = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.labelNameEnglish = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelNamePoland = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.History = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPoland
            // 
            this.buttonPoland.BackColor = System.Drawing.Color.Transparent;
            this.buttonPoland.Location = new System.Drawing.Point(644, 53);
            this.buttonPoland.Name = "buttonPoland";
            this.buttonPoland.Size = new System.Drawing.Size(134, 29);
            this.buttonPoland.TabIndex = 24;
            this.buttonPoland.Text = "Poland";
            this.buttonPoland.UseVisualStyleBackColor = false;
            this.buttonPoland.Click += new System.EventHandler(this.buttonPoland_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.Peru;
            this.buttonEnglish.Location = new System.Drawing.Point(472, 53);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(134, 29);
            this.buttonEnglish.TabIndex = 23;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = false;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // labelNameSearch
            // 
            this.labelNameSearch.AutoSize = true;
            this.labelNameSearch.Location = new System.Drawing.Point(472, 23);
            this.labelNameSearch.Name = "labelNameSearch";
            this.labelNameSearch.Size = new System.Drawing.Size(53, 20);
            this.labelNameSearch.TabIndex = 22;
            this.labelNameSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(567, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(211, 27);
            this.textBoxSearch.TabIndex = 21;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(309, 343);
            this.dataGridView1.TabIndex = 20;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(226, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 47);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // textPoland
            // 
            this.textPoland.Location = new System.Drawing.Point(39, 69);
            this.textPoland.Name = "textPoland";
            this.textPoland.Size = new System.Drawing.Size(125, 27);
            this.textPoland.TabIndex = 13;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(226, 191);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 47);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(226, 69);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(125, 27);
            this.textEnglish.TabIndex = 14;
            // 
            // labelNameEnglish
            // 
            this.labelNameEnglish.AutoSize = true;
            this.labelNameEnglish.Location = new System.Drawing.Point(68, 30);
            this.labelNameEnglish.Name = "labelNameEnglish";
            this.labelNameEnglish.Size = new System.Drawing.Size(54, 20);
            this.labelNameEnglish.TabIndex = 15;
            this.labelNameEnglish.Text = "Polskie";
            // 
            // buttonTest
            // 
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTest.Location = new System.Drawing.Point(36, 116);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(127, 47);
            this.buttonTest.TabIndex = 17;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelNamePoland
            // 
            this.labelNamePoland.AutoSize = true;
            this.labelNamePoland.Location = new System.Drawing.Point(250, 30);
            this.labelNamePoland.Name = "labelNamePoland";
            this.labelNamePoland.Size = new System.Drawing.Size(77, 20);
            this.labelNamePoland.TabIndex = 16;
            this.labelNamePoland.Text = "Angielskie";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(36, 191);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 47);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 20;
            this.listHistory.Location = new System.Drawing.Point(36, 314);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(395, 124);
            this.listHistory.TabIndex = 26;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.History.Location = new System.Drawing.Point(182, 269);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(75, 28);
            this.History.TabIndex = 27;
            this.History.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.History);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPoland);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.labelNameSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textPoland);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.labelNameEnglish);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelNamePoland);
            this.Name = "Form1";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPoland;
        private Button buttonEnglish;
        private Label labelNameSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
        private Button buttonSave;
        private TextBox textPoland;
        private Button buttonClear;
        private TextBox textEnglish;
        private Label labelNameEnglish;
        private Button buttonTest;
        private Label labelNamePoland;
        private Button buttonDelete;
        private ListBox listHistory;
        private Label History;
    }
}