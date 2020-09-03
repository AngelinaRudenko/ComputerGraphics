namespace Graphics
{
    partial class Graphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.radioButtonRotate = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.radioButtonReflect = new System.Windows.Forms.RadioButton();
            this.radioButtonOX = new System.Windows.Forms.RadioButton();
            this.radioButtonOY = new System.Windows.Forms.RadioButton();
            this.radioButtonXY = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxCoefficient = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBoxGradus = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(24, 39);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Фигуры";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(764, 626);
            this.chart.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView.Location = new System.Drawing.Point(0, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(314, 151);
            this.dataGridView.TabIndex = 2;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.X.DefaultCellStyle = dataGridViewCellStyle1;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Y.DefaultCellStyle = dataGridViewCellStyle2;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Location = new System.Drawing.Point(805, 594);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(199, 71);
            this.buttonDraw.TabIndex = 3;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // radioButtonRotate
            // 
            this.radioButtonRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonRotate.AutoSize = true;
            this.radioButtonRotate.Location = new System.Drawing.Point(860, 486);
            this.radioButtonRotate.Name = "radioButtonRotate";
            this.radioButtonRotate.Size = new System.Drawing.Size(116, 24);
            this.radioButtonRotate.TabIndex = 4;
            this.radioButtonRotate.Text = "Повернуть";
            this.radioButtonRotate.UseVisualStyleBackColor = true;
            this.radioButtonRotate.CheckedChanged += new System.EventHandler(this.radioButtonRotate_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Location = new System.Drawing.Point(0, 3);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(144, 26);
            this.numericUpDown.TabIndex = 5;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(1019, 594);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(199, 71);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(860, 39);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(90, 24);
            this.radioButtonDefault.TabIndex = 7;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Фигура";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioButtonDefault_CheckedChanged);
            // 
            // radioButtonReflect
            // 
            this.radioButtonReflect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonReflect.AutoSize = true;
            this.radioButtonReflect.Location = new System.Drawing.Point(860, 283);
            this.radioButtonReflect.Name = "radioButtonReflect";
            this.radioButtonReflect.Size = new System.Drawing.Size(108, 24);
            this.radioButtonReflect.TabIndex = 8;
            this.radioButtonReflect.Text = "Отразить";
            this.radioButtonReflect.UseVisualStyleBackColor = true;
            this.radioButtonReflect.CheckedChanged += new System.EventHandler(this.radioButtonReflect_CheckedChanged);
            // 
            // radioButtonOX
            // 
            this.radioButtonOX.AutoSize = true;
            this.radioButtonOX.Checked = true;
            this.radioButtonOX.Location = new System.Drawing.Point(20, 13);
            this.radioButtonOX.Name = "radioButtonOX";
            this.radioButtonOX.Size = new System.Drawing.Size(57, 24);
            this.radioButtonOX.TabIndex = 9;
            this.radioButtonOX.TabStop = true;
            this.radioButtonOX.Text = "OX";
            this.radioButtonOX.UseVisualStyleBackColor = true;
            // 
            // radioButtonOY
            // 
            this.radioButtonOY.AutoSize = true;
            this.radioButtonOY.Location = new System.Drawing.Point(20, 56);
            this.radioButtonOY.Name = "radioButtonOY";
            this.radioButtonOY.Size = new System.Drawing.Size(57, 24);
            this.radioButtonOY.TabIndex = 10;
            this.radioButtonOY.Text = "OY";
            this.radioButtonOY.UseVisualStyleBackColor = true;
            // 
            // radioButtonXY
            // 
            this.radioButtonXY.AutoSize = true;
            this.radioButtonXY.Location = new System.Drawing.Point(20, 104);
            this.radioButtonXY.Name = "radioButtonXY";
            this.radioButtonXY.Size = new System.Drawing.Size(56, 24);
            this.radioButtonXY.TabIndex = 11;
            this.radioButtonXY.Text = "XY";
            this.radioButtonXY.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.maskedTextBoxCoefficient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonOX);
            this.panel1.Controls.Add(this.radioButtonXY);
            this.panel1.Controls.Add(this.radioButtonOY);
            this.panel1.Location = new System.Drawing.Point(860, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 147);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // maskedTextBoxCoefficient
            // 
            this.maskedTextBoxCoefficient.Location = new System.Drawing.Point(159, 73);
            this.maskedTextBoxCoefficient.Mask = "####.###";
            this.maskedTextBoxCoefficient.Name = "maskedTextBoxCoefficient";
            this.maskedTextBoxCoefficient.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxCoefficient.TabIndex = 14;
            this.maskedTextBoxCoefficient.Text = "1";
            this.maskedTextBoxCoefficient.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Коэффициент";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.maskedTextBoxGradus);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(860, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 53);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // maskedTextBoxGradus
            // 
            this.maskedTextBoxGradus.Location = new System.Drawing.Point(159, 13);
            this.maskedTextBoxGradus.Mask = "####.###";
            this.maskedTextBoxGradus.Name = "maskedTextBoxGradus";
            this.maskedTextBoxGradus.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxGradus.TabIndex = 16;
            this.maskedTextBoxGradus.Text = "1";
            this.maskedTextBoxGradus.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Градус";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Location = new System.Drawing.Point(860, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 185);
            this.panel3.TabIndex = 14;
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonReflect);
            this.Controls.Add(this.radioButtonDefault);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.radioButtonRotate);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.chart);
            this.Name = "Graphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПР 1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.RadioButton radioButtonRotate;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonReflect;
        private System.Windows.Forms.RadioButton radioButtonOX;
        private System.Windows.Forms.RadioButton radioButtonOY;
        private System.Windows.Forms.RadioButton radioButtonXY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCoefficient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGradus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Panel panel3;
    }
}

