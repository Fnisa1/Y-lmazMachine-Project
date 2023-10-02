namespace yılmazmachine
{
    partial class dk541
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dk541));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitmminchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anatabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yilmazmachineDataSet = new yılmazmachine.yilmazmachineDataSet();
            this.anatabloTableAdapter = new yılmazmachine.yilmazmachineDataSetTableAdapters.anatabloTableAdapter();
            this.tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yilmazmachineDataSet1 = new yılmazmachine.yilmazmachineDataSet1();
            this.tTableAdapter = new yılmazmachine.yilmazmachineDataSet1TableAdapters.tTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.stockCodeDataGridViewTextBoxColumn,
            this.unitmminchDataGridViewTextBoxColumn,
            this.frameXDataGridViewTextBoxColumn,
            this.frameYDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anatabloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "Stock Code";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "Stock Code";
            this.stockCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitmminchDataGridViewTextBoxColumn
            // 
            this.unitmminchDataGridViewTextBoxColumn.DataPropertyName = "Unit (mm/inch)";
            this.unitmminchDataGridViewTextBoxColumn.HeaderText = "Unit (mm/inch)";
            this.unitmminchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitmminchDataGridViewTextBoxColumn.Name = "unitmminchDataGridViewTextBoxColumn";
            this.unitmminchDataGridViewTextBoxColumn.Width = 125;
            // 
            // frameXDataGridViewTextBoxColumn
            // 
            this.frameXDataGridViewTextBoxColumn.DataPropertyName = "Frame X";
            this.frameXDataGridViewTextBoxColumn.HeaderText = "Frame X";
            this.frameXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frameXDataGridViewTextBoxColumn.Name = "frameXDataGridViewTextBoxColumn";
            this.frameXDataGridViewTextBoxColumn.Width = 125;
            // 
            // frameYDataGridViewTextBoxColumn
            // 
            this.frameYDataGridViewTextBoxColumn.DataPropertyName = "Frame Y";
            this.frameYDataGridViewTextBoxColumn.HeaderText = "Frame Y";
            this.frameYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frameYDataGridViewTextBoxColumn.Name = "frameYDataGridViewTextBoxColumn";
            this.frameYDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // anatabloBindingSource
            // 
            this.anatabloBindingSource.DataMember = "anatablo";
            this.anatabloBindingSource.DataSource = this.yilmazmachineDataSet;
            // 
            // yilmazmachineDataSet
            // 
            this.yilmazmachineDataSet.DataSetName = "yilmazmachineDataSet";
            this.yilmazmachineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anatabloTableAdapter
            // 
            this.anatabloTableAdapter.ClearBeforeFill = true;
            // 
            // tBindingSource
            // 
            this.tBindingSource.DataMember = "t";
            this.tBindingSource.DataSource = this.yilmazmachineDataSet1;
            // 
            // yilmazmachineDataSet1
            // 
            this.yilmazmachineDataSet1.DataSetName = "yilmazmachineDataSet1";
            this.yilmazmachineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTableAdapter
            // 
            this.tTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(486, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(140, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Günlük Toplam Ürün   : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(140, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Makine Adı   :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(356, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "DK 541";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(936, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 60);
            this.label5.TabIndex = 8;
            this.label5.Text = "tarihsaat";
            // 
            // dk541
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dk541";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dk541_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yilmazmachineDataSet yilmazmachineDataSet;
        private System.Windows.Forms.BindingSource anatabloBindingSource;
        private yilmazmachineDataSetTableAdapters.anatabloTableAdapter anatabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitmminchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private yilmazmachineDataSet1 yilmazmachineDataSet1;
        private System.Windows.Forms.BindingSource tBindingSource;
        private yilmazmachineDataSet1TableAdapters.tTableAdapter tTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
    }
}