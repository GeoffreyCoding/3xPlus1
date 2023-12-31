﻿namespace _3xPlus1
{
    partial class CollatzConjecture
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbc_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl_Graphs = new System.Windows.Forms.Panel();
            this.cht_Collatz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pn_Settings = new System.Windows.Forms.Panel();
            this.CLB_ChartFormat = new System.Windows.Forms.CheckedListBox();
            this.pn_UI = new System.Windows.Forms.Panel();
            this.btn_ClearGraph = new System.Windows.Forms.Button();
            this.rtb_NumbersChosen = new System.Windows.Forms.RichTextBox();
            this.tb_Number = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbc_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnl_Graphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Collatz)).BeginInit();
            this.pn_Settings.SuspendLayout();
            this.pn_UI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Main
            // 
            this.tbc_Main.Controls.Add(this.tabPage1);
            this.tbc_Main.Controls.Add(this.tabPage2);
            this.tbc_Main.Location = new System.Drawing.Point(21, 36);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(1325, 581);
            this.tbc_Main.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl_Graphs);
            this.tabPage1.Controls.Add(this.pn_Settings);
            this.tabPage1.Controls.Add(this.pn_UI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Collatz Conjecture";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_Graphs
            // 
            this.pnl_Graphs.Controls.Add(this.cht_Collatz);
            this.pnl_Graphs.Location = new System.Drawing.Point(0, 0);
            this.pnl_Graphs.Name = "pnl_Graphs";
            this.pnl_Graphs.Size = new System.Drawing.Size(1039, 409);
            this.pnl_Graphs.TabIndex = 2;
            // 
            // cht_Collatz
            // 
            chartArea2.Name = "ChartArea1";
            this.cht_Collatz.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_Collatz.Legends.Add(legend2);
            this.cht_Collatz.Location = new System.Drawing.Point(4, -2);
            this.cht_Collatz.Name = "cht_Collatz";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cht_Collatz.Series.Add(series2);
            this.cht_Collatz.Size = new System.Drawing.Size(1035, 412);
            this.cht_Collatz.TabIndex = 3;
            this.cht_Collatz.Text = "chart1";
            // 
            // pn_Settings
            // 
            this.pn_Settings.BackColor = System.Drawing.Color.Gray;
            this.pn_Settings.Controls.Add(this.CLB_ChartFormat);
            this.pn_Settings.Location = new System.Drawing.Point(1045, 2);
            this.pn_Settings.Name = "pn_Settings";
            this.pn_Settings.Size = new System.Drawing.Size(272, 410);
            this.pn_Settings.TabIndex = 1;
            // 
            // CLB_ChartFormat
            // 
            this.CLB_ChartFormat.BackColor = System.Drawing.Color.Gray;
            this.CLB_ChartFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB_ChartFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLB_ChartFormat.FormattingEnabled = true;
            this.CLB_ChartFormat.Items.AddRange(new object[] {
            "Line",
            "Benfords Law"});
            this.CLB_ChartFormat.Location = new System.Drawing.Point(18, 128);
            this.CLB_ChartFormat.Name = "CLB_ChartFormat";
            this.CLB_ChartFormat.Size = new System.Drawing.Size(239, 132);
            this.CLB_ChartFormat.TabIndex = 0;
            // 
            // pn_UI
            // 
            this.pn_UI.BackColor = System.Drawing.Color.Gray;
            this.pn_UI.Controls.Add(this.btn_ClearGraph);
            this.pn_UI.Controls.Add(this.rtb_NumbersChosen);
            this.pn_UI.Controls.Add(this.tb_Number);
            this.pn_UI.Controls.Add(this.btn_Calc);
            this.pn_UI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_UI.Location = new System.Drawing.Point(0, 410);
            this.pn_UI.Name = "pn_UI";
            this.pn_UI.Size = new System.Drawing.Size(1317, 142);
            this.pn_UI.TabIndex = 0;
            // 
            // btn_ClearGraph
            // 
            this.btn_ClearGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ClearGraph.Location = new System.Drawing.Point(1063, 20);
            this.btn_ClearGraph.Name = "btn_ClearGraph";
            this.btn_ClearGraph.Size = new System.Drawing.Size(239, 107);
            this.btn_ClearGraph.TabIndex = 3;
            this.btn_ClearGraph.Text = "Clear All";
            this.btn_ClearGraph.UseVisualStyleBackColor = true;
            this.btn_ClearGraph.Click += new System.EventHandler(this.btn_ClearGraph_Click);
            // 
            // rtb_NumbersChosen
            // 
            this.rtb_NumbersChosen.Location = new System.Drawing.Point(66, 20);
            this.rtb_NumbersChosen.Name = "rtb_NumbersChosen";
            this.rtb_NumbersChosen.Size = new System.Drawing.Size(483, 107);
            this.rtb_NumbersChosen.TabIndex = 2;
            this.rtb_NumbersChosen.Text = "";
            // 
            // tb_Number
            // 
            this.tb_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Number.Location = new System.Drawing.Point(650, 20);
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(344, 38);
            this.tb_Number.TabIndex = 1;
            this.tb_Number.Text = "Enter a starting value";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Calc.Location = new System.Drawing.Point(650, 81);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(344, 46);
            this.btn_Calc.TabIndex = 0;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1317, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock Ticker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CollatzConjecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc_Main);
            this.Name = "CollatzConjecture";
            this.Size = new System.Drawing.Size(1367, 652);
            this.tbc_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnl_Graphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Collatz)).EndInit();
            this.pn_Settings.ResumeLayout(false);
            this.pn_UI.ResumeLayout(false);
            this.pn_UI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnl_Graphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Collatz;
        private System.Windows.Forms.Panel pn_Settings;
        private System.Windows.Forms.CheckedListBox CLB_ChartFormat;
        private System.Windows.Forms.Panel pn_UI;
        private System.Windows.Forms.Button btn_ClearGraph;
        private System.Windows.Forms.RichTextBox rtb_NumbersChosen;
        private System.Windows.Forms.TextBox tb_Number;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
