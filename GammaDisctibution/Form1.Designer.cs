﻿namespace GammaDisctibution
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.introTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.charts_dgv = new System.Windows.Forms.DataGridView();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chart_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.o_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.k_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countTab = new System.Windows.Forms.TabPage();
            this.intro_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gamma_webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl.SuspendLayout();
            this.introTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charts_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.intro_tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.introTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.countTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1144, 700);
            this.tabControl.TabIndex = 1;
            // 
            // introTab
            // 
            this.introTab.Controls.Add(this.intro_tabControl);
            this.introTab.Location = new System.Drawing.Point(4, 22);
            this.introTab.Name = "introTab";
            this.introTab.Size = new System.Drawing.Size(1136, 674);
            this.introTab.TabIndex = 2;
            this.introTab.Text = "Introducing";
            this.introTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.charts_dgv);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 668);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 0;
            // 
            // charts_dgv
            // 
            this.charts_dgv.AutoGenerateColumns = false;
            this.charts_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charts_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.kvalueDataGridViewTextBoxColumn,
            this.ovalueDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.DelCol});
            this.charts_dgv.DataSource = this.chart_bindingSource;
            this.charts_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charts_dgv.Location = new System.Drawing.Point(0, 184);
            this.charts_dgv.Name = "charts_dgv";
            this.charts_dgv.Size = new System.Drawing.Size(452, 484);
            this.charts_dgv.TabIndex = 1;
            this.charts_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.charts_dgv_CellEndEdit);
            this.charts_dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.charts_dgv_CellEndEdit);
            this.charts_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.charts_dgv_CellFormatting);
            this.charts_dgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.charts_dgv_CellMouseUp);
            this.charts_dgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.charts_dgv_CellValidating);
            this.charts_dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.charts_dgv_RowsAdded);
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "#";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.Width = 25;
            // 
            // kvalueDataGridViewTextBoxColumn
            // 
            this.kvalueDataGridViewTextBoxColumn.DataPropertyName = "k_value";
            this.kvalueDataGridViewTextBoxColumn.HeaderText = "K";
            this.kvalueDataGridViewTextBoxColumn.Name = "kvalueDataGridViewTextBoxColumn";
            this.kvalueDataGridViewTextBoxColumn.Width = 50;
            // 
            // ovalueDataGridViewTextBoxColumn
            // 
            this.ovalueDataGridViewTextBoxColumn.DataPropertyName = "o_value";
            this.ovalueDataGridViewTextBoxColumn.HeaderText = "O";
            this.ovalueDataGridViewTextBoxColumn.Name = "ovalueDataGridViewTextBoxColumn";
            this.ovalueDataGridViewTextBoxColumn.Width = 50;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "";
            this.colorDataGridViewTextBoxColumn.MaxInputLength = 1;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 30;
            // 
            // DelCol
            // 
            this.DelCol.HeaderText = "Del";
            this.DelCol.Name = "DelCol";
            this.DelCol.Width = 35;
            // 
            // chart_bindingSource
            // 
            this.chart_bindingSource.DataSource = typeof(GammaDisctibution.Models.Charts);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.o_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.k_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input values";
            // 
            // o_textBox
            // 
            this.o_textBox.Location = new System.Drawing.Point(193, 105);
            this.o_textBox.Name = "o_textBox";
            this.o_textBox.Size = new System.Drawing.Size(54, 20);
            this.o_textBox.TabIndex = 12;
            this.o_textBox.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "O ==";
            // 
            // k_textBox
            // 
            this.k_textBox.Location = new System.Drawing.Point(57, 108);
            this.k_textBox.Name = "k_textBox";
            this.k_textBox.Size = new System.Drawing.Size(54, 20);
            this.k_textBox.TabIndex = 10;
            this.k_textBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "K ==";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(335, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "20";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Лимит X:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(280, 19);
            this.trackBar1.Maximum = 80;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(132, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.calculate_params);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дисперсия:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.calculate_params);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.beautyNum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мат.ожидание:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.Size = new System.Drawing.Size(674, 668);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // countTab
            // 
            this.countTab.Location = new System.Drawing.Point(4, 22);
            this.countTab.Name = "countTab";
            this.countTab.Padding = new System.Windows.Forms.Padding(3);
            this.countTab.Size = new System.Drawing.Size(1136, 674);
            this.countTab.TabIndex = 1;
            this.countTab.Text = "Counting";
            this.countTab.UseVisualStyleBackColor = true;
            // 
            // intro_tabControl
            // 
            this.intro_tabControl.Controls.Add(this.tabPage2);
            this.intro_tabControl.Controls.Add(this.tabPage3);
            this.intro_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intro_tabControl.Location = new System.Drawing.Point(0, 0);
            this.intro_tabControl.Name = "intro_tabControl";
            this.intro_tabControl.SelectedIndex = 0;
            this.intro_tabControl.Size = new System.Drawing.Size(1136, 674);
            this.intro_tabControl.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gamma_webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 648);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Гамма функция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1128, 648);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Гамма распределение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gamma_webBrowser
            // 
            this.gamma_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamma_webBrowser.Location = new System.Drawing.Point(3, 3);
            this.gamma_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.gamma_webBrowser.Name = "gamma_webBrowser";
            this.gamma_webBrowser.Size = new System.Drawing.Size(1122, 642);
            this.gamma_webBrowser.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 724);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.introTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charts_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.intro_tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage countTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource chart_bindingSource;
        private System.Windows.Forms.DataGridView charts_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage introTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox o_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DelCol;
        private System.Windows.Forms.TabControl intro_tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser gamma_webBrowser;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

