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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.LBLUSK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVA)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL9
            // 
            this.LBL9.AutoSize = true;
            this.LBL9.Location = new System.Drawing.Point(1147, 404);
            this.LBL9.Name = "LBL9";
            this.LBL9.Size = new System.Drawing.Size(0, 13);
            this.LBL9.TabIndex = 9;
            // 
            // Chart4
            // 
            this.Chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea13.Name = "ChartArea1";
            this.Chart4.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.Chart4.Legends.Add(legend13);
            this.Chart4.Location = new System.Drawing.Point(12, 12);
            this.Chart4.Name = "Chart4";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Ось Х";
            this.Chart4.Series.Add(series13);
            this.Chart4.Size = new System.Drawing.Size(1058, 138);
            this.Chart4.TabIndex = 11;
            this.Chart4.Text = "График столбца 1";
            // 
            // ChartFFT
            // 
            this.ChartFFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea14.Name = "ChartArea1";
            this.ChartFFT.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.ChartFFT.Legends.Add(legend14);
            this.ChartFFT.Location = new System.Drawing.Point(12, 469);
            this.ChartFFT.Name = "ChartFFT";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Фазный спектр";
            this.ChartFFT.Series.Add(series14);
            this.ChartFFT.Size = new System.Drawing.Size(1058, 148);
            this.ChartFFT.TabIndex = 14;
            this.ChartFFT.Text = "График столбца 1";
            // 
            // ChartAFT
            // 
            this.ChartAFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea15.Name = "ChartArea1";
            this.ChartAFT.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.ChartAFT.Legends.Add(legend15);
            this.ChartAFT.Location = new System.Drawing.Point(12, 312);
            this.ChartAFT.Name = "ChartAFT";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Амплитудный спектр";
            this.ChartAFT.Series.Add(series15);
            this.ChartAFT.Size = new System.Drawing.Size(1058, 151);
            this.ChartAFT.TabIndex = 15;
            this.ChartAFT.Text = "График столбца 1";
            // 
            // Os
            // 
            this.Os.Location = new System.Drawing.Point(1157, 37);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(75, 23);
            this.Os.TabIndex = 16;
            this.Os.Text = "Ось X";
            this.Os.UseVisualStyleBackColor = true;
            this.Os.Click += new System.EventHandler(this.OsX_Click);
            // 
            // OsY
            // 
            this.OsY.Location = new System.Drawing.Point(1157, 66);
            this.OsY.Name = "OsY";
            this.OsY.Size = new System.Drawing.Size(75, 23);
            this.OsY.TabIndex = 17;
            this.OsY.Text = "Ось Y";
            this.OsY.UseVisualStyleBackColor = true;
            this.OsY.Click += new System.EventHandler(this.OsY_Click);
            // 
            // OsZ
            // 
            this.OsZ.Location = new System.Drawing.Point(1157, 95);
            this.OsZ.Name = "OsZ";
            this.OsZ.Size = new System.Drawing.Size(75, 23);
            this.OsZ.TabIndex = 18;
            this.OsZ.Text = "Ось Z";
            this.OsZ.UseVisualStyleBackColor = true;
            this.OsZ.Click += new System.EventHandler(this.OsZ_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1157, 158);
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
            this.label1.Location = new System.Drawing.Point(1083, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "СКЗ";
            // 
            // LBLSKZ
            // 
            this.LBLSKZ.AutoSize = true;
            this.LBLSKZ.Location = new System.Drawing.Point(1083, 127);
            this.LBLSKZ.Name = "LBLSKZ";
            this.LBLSKZ.Size = new System.Drawing.Size(0, 13);
            this.LBLSKZ.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1146, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Кол-во измер.";
            // 
            // LBLPF
            // 
            this.LBLPF.AutoSize = true;
            this.LBLPF.Location = new System.Drawing.Point(1077, 88);
            this.LBLPF.Name = "LBLPF";
            this.LBLPF.Size = new System.Drawing.Size(0, 13);
            this.LBLPF.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1077, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Пик-фактор";
            // 
            // ChartVA
            // 
            this.ChartVA.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea16.Name = "ChartArea1";
            this.ChartVA.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.ChartVA.Legends.Add(legend16);
            this.ChartVA.Location = new System.Drawing.Point(12, 158);
            this.ChartVA.Name = "ChartVA";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Ускор.";
            this.ChartVA.Series.Add(series16);
            this.ChartVA.Size = new System.Drawing.Size(1058, 148);
            this.ChartVA.TabIndex = 29;
            this.ChartVA.Text = "График столбца 1";
            // 
            // LBLUSK
            // 
            this.LBLUSK.AutoSize = true;
            this.LBLUSK.Location = new System.Drawing.Point(1083, 242);
            this.LBLUSK.Name = "LBLUSK";
            this.LBLUSK.Size = new System.Drawing.Size(0, 13);
            this.LBLUSK.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1077, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "СКЗ ускорения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 631);
            this.Controls.Add(this.LBLUSK);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label LBLUSK;
        private System.Windows.Forms.Label label5;
    }
}

