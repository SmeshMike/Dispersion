namespace OutForm
{
    partial class MainForm
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
            this.SignGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Start = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NoisePerc = new System.Windows.Forms.TextBox();
            this.NoiseText = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fourea = new System.Windows.Forms.Button();
            this.Paint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GraphNum = new System.Windows.Forms.TextBox();
            this.BeforeFourea = new System.Windows.Forms.Button();
            this.sinPanel1 = new OutForm.Controls.SinPanel();
            this.Count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SignGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // SignGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.SignGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SignGraph.Legends.Add(legend1);
            this.SignGraph.Location = new System.Drawing.Point(12, 12);
            this.SignGraph.Name = "SignGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series0";
            this.SignGraph.Series.Add(series1);
            this.SignGraph.Size = new System.Drawing.Size(1027, 625);
            this.SignGraph.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1048, 409);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(211, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Поiхали";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1048, 614);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(211, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Почистить душу и массивы";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1203, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пошумим";
            // 
            // NoisePerc
            // 
            this.NoisePerc.Location = new System.Drawing.Point(1159, 383);
            this.NoisePerc.Name = "NoisePerc";
            this.NoisePerc.Size = new System.Drawing.Size(100, 20);
            this.NoisePerc.TabIndex = 6;
            this.NoisePerc.Text = "0";
            // 
            // NoiseText
            // 
            this.NoiseText.Location = new System.Drawing.Point(1048, 383);
            this.NoiseText.Name = "NoiseText";
            this.NoiseText.Size = new System.Drawing.Size(100, 20);
            this.NoiseText.TabIndex = 8;
            this.NoiseText.Text = "0";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(1134, 28);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(60, 20);
            this.end.TabIndex = 9;
            this.end.Text = "1024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1131, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество точек";
            // 
            // TextL
            // 
            this.TextL.Location = new System.Drawing.Point(1045, 344);
            this.TextL.Name = "TextL";
            this.TextL.Size = new System.Drawing.Size(103, 20);
            this.TextL.TabIndex = 23;
            this.TextL.Text = "10";
            this.TextL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1045, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "L";
            // 
            // Fourea
            // 
            this.Fourea.Location = new System.Drawing.Point(1048, 467);
            this.Fourea.Name = "Fourea";
            this.Fourea.Size = new System.Drawing.Size(211, 23);
            this.Fourea.TabIndex = 26;
            this.Fourea.Text = "А ещё Фурье";
            this.Fourea.UseVisualStyleBackColor = true;
            this.Fourea.Click += new System.EventHandler(this.Fourea_Click);
            // 
            // Paint
            // 
            this.Paint.Location = new System.Drawing.Point(1048, 559);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(211, 23);
            this.Paint.TabIndex = 27;
            this.Paint.Text = "Построим Дисперсию";
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1214, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "График";
            // 
            // GraphNum
            // 
            this.GraphNum.Location = new System.Drawing.Point(1159, 344);
            this.GraphNum.Name = "GraphNum";
            this.GraphNum.Size = new System.Drawing.Size(100, 20);
            this.GraphNum.TabIndex = 29;
            this.GraphNum.Text = "1";
            this.GraphNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphNum_KeyDown);
            // 
            // BeforeFourea
            // 
            this.BeforeFourea.Location = new System.Drawing.Point(1048, 438);
            this.BeforeFourea.Name = "BeforeFourea";
            this.BeforeFourea.Size = new System.Drawing.Size(211, 23);
            this.BeforeFourea.TabIndex = 30;
            this.BeforeFourea.Text = "Покеж коррелограммы";
            this.BeforeFourea.UseVisualStyleBackColor = true;
            this.BeforeFourea.Click += new System.EventHandler(this.Corr_Click);
            // 
            // sinPanel1
            // 
            this.sinPanel1.Location = new System.Drawing.Point(1048, 12);
            this.sinPanel1.Name = "sinPanel1";
            this.sinPanel1.Size = new System.Drawing.Size(67, 82);
            this.sinPanel1.TabIndex = 15;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(1113, 533);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(146, 20);
            this.Count.TabIndex = 31;
            this.Count.Text = "1";
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1110, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Сколько спектров оставить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 657);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.BeforeFourea);
            this.Controls.Add(this.GraphNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.Fourea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextL);
            this.Controls.Add(this.sinPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.end);
            this.Controls.Add(this.NoiseText);
            this.Controls.Add(this.NoisePerc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.SignGraph);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.SignGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SignGraph;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoisePerc;
        private System.Windows.Forms.TextBox NoiseText;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label3;
        private Controls.SinPanel sinPanel1;
        private System.Windows.Forms.TextBox TextL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Fourea;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GraphNum;
        private System.Windows.Forms.Button BeforeFourea;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label5;
    }
}