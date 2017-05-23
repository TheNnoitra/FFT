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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BTNOpen = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.Chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVA)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNOpen
            // 
            this.BTNOpen.Location = new System.Drawing.Point(1076, 12);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Size = new System.Drawing.Size(75, 23);
            this.BTNOpen.TabIndex = 0;
            this.BTNOpen.Text = "Открыть";
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // LBL9
            // 
            this.LBL9.AutoSize = true;
            this.LBL9.Location = new System.Drawing.Point(1077, 465);
            this.LBL9.Name = "LBL9";
            this.LBL9.Size = new System.Drawing.Size(0, 13);
            this.LBL9.TabIndex = 9;
            // 
            // Chart4
            // 
            this.Chart4.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea5.Name = "ChartArea1";
            this.Chart4.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Chart4.Legends.Add(legend5);
            this.Chart4.Location = new System.Drawing.Point(12, 12);
            this.Chart4.Name = "Chart4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Ось Х";
            this.Chart4.Series.Add(series5);
            this.Chart4.Size = new System.Drawing.Size(1058, 138);
            this.Chart4.TabIndex = 11;
            this.Chart4.Text = "График столбца 1";
            // 
            // ChartFFT
            // 
            this.ChartFFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea6.Name = "ChartArea1";
            this.ChartFFT.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ChartFFT.Legends.Add(legend6);
            this.ChartFFT.Location = new System.Drawing.Point(12, 469);
            this.ChartFFT.Name = "ChartFFT";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Фазный спектр";
            this.ChartFFT.Series.Add(series6);
            this.ChartFFT.Size = new System.Drawing.Size(1058, 148);
            this.ChartFFT.TabIndex = 14;
            this.ChartFFT.Text = "График столбца 1";
            // 
            // ChartAFT
            // 
            this.ChartAFT.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea7.Name = "ChartArea1";
            this.ChartAFT.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.ChartAFT.Legends.Add(legend7);
            this.ChartAFT.Location = new System.Drawing.Point(12, 312);
            this.ChartAFT.Name = "ChartAFT";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Амплитудный спектр";
            this.ChartAFT.Series.Add(series7);
            this.ChartAFT.Size = new System.Drawing.Size(1058, 151);
            this.ChartAFT.TabIndex = 15;
            this.ChartAFT.Text = "График столбца 1";
            // 
            // Os
            // 
            this.Os.Location = new System.Drawing.Point(1076, 66);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(75, 23);
            this.Os.TabIndex = 16;
            this.Os.Text = "Ось X";
            this.Os.UseVisualStyleBackColor = true;
            this.Os.Click += new System.EventHandler(this.OsX_Click);
            // 
            // OsY
            // 
            this.OsY.Location = new System.Drawing.Point(1076, 95);
            this.OsY.Name = "OsY";
            this.OsY.Size = new System.Drawing.Size(75, 23);
            this.OsY.TabIndex = 17;
            this.OsY.Text = "Ось Y";
            this.OsY.UseVisualStyleBackColor = true;
            this.OsY.Click += new System.EventHandler(this.OsY_Click);
            // 
            // OsZ
            // 
            this.OsZ.Location = new System.Drawing.Point(1076, 124);
            this.OsZ.Name = "OsZ";
            this.OsZ.Size = new System.Drawing.Size(75, 23);
            this.OsZ.TabIndex = 18;
            this.OsZ.Text = "Ось Z";
            this.OsZ.UseVisualStyleBackColor = true;
            this.OsZ.Click += new System.EventHandler(this.OsZ_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1076, 250);
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
            this.label1.Location = new System.Drawing.Point(1076, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "СКЗ";
            // 
            // LBLSKZ
            // 
            this.LBLSKZ.AutoSize = true;
            this.LBLSKZ.Location = new System.Drawing.Point(1076, 418);
            this.LBLSKZ.Name = "LBLSKZ";
            this.LBLSKZ.Size = new System.Drawing.Size(0, 13);
            this.LBLSKZ.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1076, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Кол-во измер.";
            // 
            // LBLPF
            // 
            this.LBLPF.AutoSize = true;
            this.LBLPF.Location = new System.Drawing.Point(1077, 371);
            this.LBLPF.Name = "LBLPF";
            this.LBLPF.Size = new System.Drawing.Size(0, 13);
            this.LBLPF.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1077, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Пик-фактор";
            // 
            // ChartVA
            // 
            this.ChartVA.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            chartArea8.Name = "ChartArea1";
            this.ChartVA.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.ChartVA.Legends.Add(legend8);
            this.ChartVA.Location = new System.Drawing.Point(12, 158);
            this.ChartVA.Name = "ChartVA";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Ускор.";
            this.ChartVA.Series.Add(series8);
            this.ChartVA.Size = new System.Drawing.Size(1058, 148);
            this.ChartVA.TabIndex = 29;
            this.ChartVA.Text = "График столбца 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 688);
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
            this.Controls.Add(this.BTNOpen);
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

        private System.Windows.Forms.Button BTNOpen;
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
    }
}

