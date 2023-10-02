namespace yılmazmachine
{
    partial class sk500
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sk500));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieceSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anatablo2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yilmazmachineDataSet3 = new yılmazmachine.yilmazmachineDataSet3();
            this.anatablo2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yilmazmachineDataSet2 = new yılmazmachine.yilmazmachineDataSet2();
            this.anatablo2TableAdapter = new yılmazmachine.yilmazmachineDataSet2TableAdapters.anatablo2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anatablo2TableAdapter1 = new yılmazmachine.yilmazmachineDataSet3TableAdapters.anatablo2TableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yilmazmachineDataSet1 = new yılmazmachine.yilmazmachineDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatablo2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatablo2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet2)).BeginInit();
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
            this.pieceSizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anatablo2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(305, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // pieceSizeDataGridViewTextBoxColumn
            // 
            this.pieceSizeDataGridViewTextBoxColumn.DataPropertyName = "Piece Size";
            this.pieceSizeDataGridViewTextBoxColumn.HeaderText = "Piece Size";
            this.pieceSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pieceSizeDataGridViewTextBoxColumn.Name = "pieceSizeDataGridViewTextBoxColumn";
            this.pieceSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // anatablo2BindingSource1
            // 
            this.anatablo2BindingSource1.DataMember = "anatablo2";
            this.anatablo2BindingSource1.DataSource = this.yilmazmachineDataSet3;
            // 
            // yilmazmachineDataSet3
            // 
            this.yilmazmachineDataSet3.DataSetName = "yilmazmachineDataSet3";
            this.yilmazmachineDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anatablo2BindingSource
            // 
            this.anatablo2BindingSource.DataMember = "anatablo2";
            this.anatablo2BindingSource.DataSource = this.yilmazmachineDataSet2;
            // 
            // yilmazmachineDataSet2
            // 
            this.yilmazmachineDataSet2.DataSetName = "yilmazmachineDataSet2";
            this.yilmazmachineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anatablo2TableAdapter
            // 
            this.anatablo2TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Makine Adı  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(274, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "SK 500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Günlük Toplam Ürün  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(404, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(936, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 60);
            this.label5.TabIndex = 5;
            this.label5.Text = "tarihsaat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // anatablo2TableAdapter1
            // 
            this.anatablo2TableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yilmazmachineDataSet1
            // 
            this.yilmazmachineDataSet1.DataSetName = "yilmazmachineDataSet";
            this.yilmazmachineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sk500
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
            this.Name = "sk500";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.sk500_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatablo2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anatablo2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yilmazmachineDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private yilmazmachineDataSet2 yilmazmachineDataSet2;
        private System.Windows.Forms.BindingSource anatablo2BindingSource;
        private yilmazmachineDataSet2TableAdapters.anatablo2TableAdapter anatablo2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pieceSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private yilmazmachineDataSet3 yilmazmachineDataSet3;
        private System.Windows.Forms.BindingSource anatablo2BindingSource1;
        private yilmazmachineDataSet3TableAdapters.anatablo2TableAdapter anatablo2TableAdapter1;
        private System.Windows.Forms.Timer timer1;
        private yilmazmachineDataSet yilmazmachineDataSet1;
    }
}