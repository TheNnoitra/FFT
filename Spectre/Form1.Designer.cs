namespace Spectre
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LBL9 = new System.Windows.Forms.Label();
            this.Chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartAFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Os = new System.Windows.Forms.Button();
            this.OsY = new System.Windows.Forms.Button();
            this.OsZ = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLSKZ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLPF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChartVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBLSKZV = new System.Windows.Forms.Label();
            this.LBLvibroskorost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVA)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL9
            // 
            this.LBL9.AutoSize = true;
            this.LBL9.Location = new System.Drawing.Point(1154, 586);
            this.LBL9.Name = "LBL9";
            this.LBL9.Size = new System.Drawing.Size(0, 13);
            this.LBL9.TabIndex = 9;
            // 
            // Chart4
            // 
            this.Chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea1.Name = "ChartArea1";
            this.Chart4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart4.Legends.Add(legend1);
            this.Chart4.Location = new System.Drawing.Point(12, 12);
            this.Chart4.Name = "Chart4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "График виброускорения";
            this.Chart4.Series.Add(series1);
            this.Chart4.Size = new System.Drawing.Size(1058, 138);
            this.Chart4.TabIndex = 11;
            this.Chart4.Text = "График столбца 1";
            // 
            // ChartFFT
            // 
            this.ChartFFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea2.Name = "ChartArea1";
            this.ChartFFT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartFFT.Legends.Add(legend2);
            this.ChartFFT.Location = new System.Drawing.Point(12, 469);
            this.ChartFFT.Name = "ChartFFT";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Фазный спектр";
            this.ChartFFT.Series.Add(series2);
            this.ChartFFT.Size = new System.Drawing.Size(1058, 148);
            this.ChartFFT.TabIndex = 14;
            this.ChartFFT.Text = "График столбца 1";
            // 
            // ChartAFT
            // 
            this.ChartAFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea3.Name = "ChartArea1";
            this.ChartAFT.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartAFT.Legends.Add(legend3);
            this.ChartAFT.Location = new System.Drawing.Point(12, 312);
            this.ChartAFT.Name = "ChartAFT";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Амплитудный спектр";
            this.ChartAFT.Series.Add(series3);
            this.ChartAFT.Size = new System.Drawing.Size(1058, 151);
            this.ChartAFT.TabIndex = 15;
            this.ChartAFT.Text = "График столбца 1";
            // 
            // Os
            // 
            this.Os.Location = new System.Drawing.Point(1157, 312);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(75, 23);
            this.Os.TabIndex = 16;
            this.Os.Text = "Ось X";
            this.Os.UseVisualStyleBackColor = true;
            this.Os.Click += new System.EventHandler(this.OsX_Click);
            // 
            // OsY
            // 
            this.OsY.Location = new System.Drawing.Point(1157, 341);
            this.OsY.Name = "OsY";
            this.OsY.Size = new System.Drawing.Size(75, 23);
            this.OsY.TabIndex = 17;
            this.OsY.Text = "Ось Y";
            this.OsY.UseVisualStyleBackColor = true;
            this.OsY.Click += new System.EventHandler(this.OsY_Click);
            // 
            // OsZ
            // 
            this.OsZ.Location = new System.Drawing.Point(1157, 370);
            this.OsZ.Name = "OsZ";
            this.OsZ.Size = new System.Drawing.Size(75, 23);
            this.OsZ.TabIndex = 18;
            this.OsZ.Text = "Ось Z";
            this.OsZ.UseVisualStyleBackColor = true;
            this.OsZ.Click += new System.EventHandler(this.OsZ_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1157, 433);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Сбросить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1076, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "СКЗ виброускорения:";
            // 
            // LBLSKZ
            // 
            this.LBLSKZ.AutoSize = true;
            this.LBLSKZ.Location = new System.Drawing.Point(1076, 34);
            this.LBLSKZ.Name = "LBLSKZ";
            this.LBLSKZ.Size = new System.Drawing.Size(0, 13);
            this.LBLSKZ.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1153, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Кол-во измер.";
            // 
            // LBLPF
            // 
            this.LBLPF.AutoSize = true;
            this.LBLPF.Location = new System.Drawing.Point(1079, 106);
            this.LBLPF.Name = "LBLPF";
            this.LBLPF.Size = new System.Drawing.Size(0, 13);
            this.LBLPF.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1079, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Пик-фактор";
            // 
            // ChartVA
            // 
            this.ChartVA.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea4.Name = "ChartArea1";
            this.ChartVA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartVA.Legends.Add(legend4);
            this.ChartVA.Location = new System.Drawing.Point(12, 158);
            this.ChartVA.Name = "ChartVA";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "График виброскорости";
            this.ChartVA.Series.Add(series4);
            this.ChartVA.Size = new System.Drawing.Size(1058, 148);
            this.ChartVA.TabIndex = 29;
            this.ChartVA.Text = "График столбца 1";
            // 
            // LBLSKZV
            // 
            this.LBLSKZV.AutoSize = true;
            this.LBLSKZV.Location = new System.Drawing.Point(1076, 191);
            this.LBLSKZV.Name = "LBLSKZV";
            this.LBLSKZV.Size = new System.Drawing.Size(0, 13);
            this.LBLSKZV.TabIndex = 31;
            // 
            // LBLvibroskorost
            // 
            this.LBLvibroskorost.AutoSize = true;
            this.LBLvibroskorost.Location = new System.Drawing.Point(1076, 169);
            this.LBLvibroskorost.Name = "LBLvibroskorost";
            this.LBLvibroskorost.Size = new System.Drawing.Size(111, 13);
            this.LBLvibroskorost.TabIndex = 30;
            this.LBLvibroskorost.Text = "СКЗ виброскорости:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 631);
            this.Controls.Add(this.LBLSKZV);
            this.Controls.Add(this.LBLvibroskorost);
            this.Controls.Add(this.ChartVA);
            this.Controls.Add(this.LBLPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBLSKZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.OsZ);
            this.Controls.Add(this.OsY);
            this.Controls.Add(this.Os);
            this.Controls.Add(this.ChartAFT);
            this.Controls.Add(this.ChartFFT);
            this.Controls.Add(this.Chart4);
            this.Controls.Add(this.LBL9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL9;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAFT;
        private System.Windows.Forms.Button Os;
        private System.Windows.Forms.Button OsY;
        private System.Windows.Forms.Button OsZ;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLSKZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVA;
        private System.Windows.Forms.Label LBLSKZV;
        private System.Windows.Forms.Label LBLvibroskorost;
    }
}

