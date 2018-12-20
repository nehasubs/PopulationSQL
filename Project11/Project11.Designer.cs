namespace Populations_of_Cities
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label populationLabel;
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationDBDataSet = new Populations_of_Cities.PopulationDBDataSet();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.populationDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new Populations_of_Cities.PopulationDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new Populations_of_Cities.PopulationDBDataSetTableAdapters.TableAdapterManager();
            cityLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(479, 47);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(458, 99);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(79, 17);
            populationLabel.TabIndex = 2;
            populationLabel.Text = "Population:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(582, 44);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 1;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.populationDBDataSet;
            // 
            // populationDBDataSet
            // 
            this.populationDBDataSet.DataSetName = "PopulationDBDataSet";
            this.populationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(582, 96);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 22);
            this.populationTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(322, 449);
            this.dataGridView1.TabIndex = 4;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sort in Ascending order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "get lowest pop.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get total pop.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 61);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sort alphabetically";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(547, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 61);
            this.button6.TabIndex = 10;
            this.button6.Text = "Sort in Decending order";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(632, 301);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 54);
            this.button7.TabIndex = 11;
            this.button7.Text = "get highest pop.";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(482, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 54);
            this.button5.TabIndex = 16;
            this.button5.Text = "Get average pop.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // populationDBDataSetBindingSource
            // 
            this.populationDBDataSetBindingSource.DataSource = this.populationDBDataSet;
            this.populationDBDataSetBindingSource.Position = 0;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = Populations_of_Cities.PopulationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Name = "Form1";
            this.Text = "Populations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PopulationDBDataSet populationDBDataSet;
        private System.Windows.Forms.BindingSource populationDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private PopulationDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
    }
}

