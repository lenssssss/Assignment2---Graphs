namespace Assignment2___Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempratureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(913, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.m1DataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.m4DataGridViewTextBoxColumn,
            this.m5DataGridViewTextBoxColumn,
            this.m6DataGridViewTextBoxColumn,
            this.m7DataGridViewTextBoxColumn,
            this.m8DataGridViewTextBoxColumn,
            this.m9DataGridViewTextBoxColumn,
            this.m10DataGridViewTextBoxColumn,
            this.m11DataGridViewTextBoxColumn,
            this.m12DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tempratureBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 327);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(913, 150);
            this.dataGridView.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(806, 483);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(119, 31);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // m1DataGridViewTextBoxColumn
            // 
            this.m1DataGridViewTextBoxColumn.DataPropertyName = "M1";
            this.m1DataGridViewTextBoxColumn.HeaderText = "M1";
            this.m1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m1DataGridViewTextBoxColumn.Name = "m1DataGridViewTextBoxColumn";
            this.m1DataGridViewTextBoxColumn.Width = 125;
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "M2";
            this.m2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.Width = 125;
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "M3";
            this.m3DataGridViewTextBoxColumn.HeaderText = "M3";
            this.m3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            this.m3DataGridViewTextBoxColumn.Width = 125;
            // 
            // m4DataGridViewTextBoxColumn
            // 
            this.m4DataGridViewTextBoxColumn.DataPropertyName = "M4";
            this.m4DataGridViewTextBoxColumn.HeaderText = "M4";
            this.m4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m4DataGridViewTextBoxColumn.Name = "m4DataGridViewTextBoxColumn";
            this.m4DataGridViewTextBoxColumn.Width = 125;
            // 
            // m5DataGridViewTextBoxColumn
            // 
            this.m5DataGridViewTextBoxColumn.DataPropertyName = "M5";
            this.m5DataGridViewTextBoxColumn.HeaderText = "M5";
            this.m5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m5DataGridViewTextBoxColumn.Name = "m5DataGridViewTextBoxColumn";
            this.m5DataGridViewTextBoxColumn.Width = 125;
            // 
            // m6DataGridViewTextBoxColumn
            // 
            this.m6DataGridViewTextBoxColumn.DataPropertyName = "M6";
            this.m6DataGridViewTextBoxColumn.HeaderText = "M6";
            this.m6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m6DataGridViewTextBoxColumn.Name = "m6DataGridViewTextBoxColumn";
            this.m6DataGridViewTextBoxColumn.Width = 125;
            // 
            // m7DataGridViewTextBoxColumn
            // 
            this.m7DataGridViewTextBoxColumn.DataPropertyName = "M7";
            this.m7DataGridViewTextBoxColumn.HeaderText = "M7";
            this.m7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m7DataGridViewTextBoxColumn.Name = "m7DataGridViewTextBoxColumn";
            this.m7DataGridViewTextBoxColumn.Width = 125;
            // 
            // m8DataGridViewTextBoxColumn
            // 
            this.m8DataGridViewTextBoxColumn.DataPropertyName = "M8";
            this.m8DataGridViewTextBoxColumn.HeaderText = "M8";
            this.m8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m8DataGridViewTextBoxColumn.Name = "m8DataGridViewTextBoxColumn";
            this.m8DataGridViewTextBoxColumn.Width = 125;
            // 
            // m9DataGridViewTextBoxColumn
            // 
            this.m9DataGridViewTextBoxColumn.DataPropertyName = "M9";
            this.m9DataGridViewTextBoxColumn.HeaderText = "M9";
            this.m9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m9DataGridViewTextBoxColumn.Name = "m9DataGridViewTextBoxColumn";
            this.m9DataGridViewTextBoxColumn.Width = 125;
            // 
            // m10DataGridViewTextBoxColumn
            // 
            this.m10DataGridViewTextBoxColumn.DataPropertyName = "M10";
            this.m10DataGridViewTextBoxColumn.HeaderText = "M10";
            this.m10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m10DataGridViewTextBoxColumn.Name = "m10DataGridViewTextBoxColumn";
            this.m10DataGridViewTextBoxColumn.Width = 125;
            // 
            // m11DataGridViewTextBoxColumn
            // 
            this.m11DataGridViewTextBoxColumn.DataPropertyName = "M11";
            this.m11DataGridViewTextBoxColumn.HeaderText = "M11";
            this.m11DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m11DataGridViewTextBoxColumn.Name = "m11DataGridViewTextBoxColumn";
            this.m11DataGridViewTextBoxColumn.Width = 125;
            // 
            // m12DataGridViewTextBoxColumn
            // 
            this.m12DataGridViewTextBoxColumn.DataPropertyName = "M12";
            this.m12DataGridViewTextBoxColumn.HeaderText = "M12";
            this.m12DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.m12DataGridViewTextBoxColumn.Name = "m12DataGridViewTextBoxColumn";
            this.m12DataGridViewTextBoxColumn.Width = 125;
            // 
            // tempratureBindingSource
            // 
            this.tempratureBindingSource.DataSource = typeof(Assignment2___Graphs.Temprature);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 544);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Line Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempratureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m12DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tempratureBindingSource;
    }
}

