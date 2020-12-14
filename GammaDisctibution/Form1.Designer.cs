namespace GammaDisctibution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Задания", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1 пример"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2 пример"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3 пример"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4 пример"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5 пример"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.introTab = new System.Windows.Forms.TabPage();
            this.intro_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pdfViewer_function = new Spire.PdfViewer.Forms.PdfViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pdfViewer_distribution = new Spire.PdfViewer.Forms.PdfViewer();
            this.funcsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.charts_dgv = new System.Windows.Forms.DataGridView();
            this.DelCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.density = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.o1_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.k1_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x_limit1_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.D1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.M1_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1_density = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1_distribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.distribution_groupBox = new System.Windows.Forms.GroupBox();
            this.yDistributionValue_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.xDistributionValue_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.x_distribution_Runner = new System.Windows.Forms.TrackBar();
            this.density_groupBox = new System.Windows.Forms.GroupBox();
            this.yDensityValue_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.xDensityValue_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.x_density_Runner = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.o2_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.k2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x_limit2_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.D2_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.M2_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chart2_density = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chart2_distribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exTabs = new System.Windows.Forms.TabControl();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.introTab.SuspendLayout();
            this.intro_tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.funcsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charts_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_density)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_distribution)).BeginInit();
            this.countTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.distribution_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_distribution_Runner)).BeginInit();
            this.density_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_density_Runner)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2_density)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2_distribution)).BeginInit();
            this.exTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bindingSource)).BeginInit();
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
            this.tabControl.Controls.Add(this.funcsTab);
            this.tabControl.Controls.Add(this.countTab);
            this.tabControl.Controls.Add(this.exTab);
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
            this.introTab.Text = "Введение";
            this.toolTip1.SetToolTip(this.introTab, "Краткое обучение");
            this.introTab.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.pdfViewer_function);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 648);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Гамма функция";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pdfViewer_function
            // 
            this.pdfViewer_function.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer_function.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer_function.IgnoreCase = false;
            this.pdfViewer_function.IsToolBarVisible = true;
            this.pdfViewer_function.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer_function.MultiPagesThreshold = 60;
            this.pdfViewer_function.Name = "pdfViewer_function";
            this.pdfViewer_function.Size = new System.Drawing.Size(1122, 642);
            this.pdfViewer_function.TabIndex = 3;
            this.pdfViewer_function.Text = "pdfViewer1";
            this.pdfViewer_function.Threshold = 60;
            this.pdfViewer_function.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pdfViewer_distribution);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1128, 648);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Гамма распределение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pdfViewer_distribution
            // 
            this.pdfViewer_distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer_distribution.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer_distribution.IgnoreCase = false;
            this.pdfViewer_distribution.IsToolBarVisible = true;
            this.pdfViewer_distribution.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer_distribution.MultiPagesThreshold = 60;
            this.pdfViewer_distribution.Name = "pdfViewer_distribution";
            this.pdfViewer_distribution.Size = new System.Drawing.Size(1122, 642);
            this.pdfViewer_distribution.TabIndex = 0;
            this.pdfViewer_distribution.Text = "pdfViewer1";
            this.pdfViewer_distribution.Threshold = 60;
            this.pdfViewer_distribution.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // funcsTab
            // 
            this.funcsTab.Controls.Add(this.splitContainer1);
            this.funcsTab.Location = new System.Drawing.Point(4, 22);
            this.funcsTab.Name = "funcsTab";
            this.funcsTab.Padding = new System.Windows.Forms.Padding(3);
            this.funcsTab.Size = new System.Drawing.Size(1136, 674);
            this.funcsTab.TabIndex = 0;
            this.funcsTab.Text = "Функции";
            this.toolTip1.SetToolTip(this.funcsTab, "Функции");
            this.funcsTab.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
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
            this.DelCol,
            this.density});
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
            // DelCol
            // 
            this.DelCol.HeaderText = "Del";
            this.DelCol.Name = "DelCol";
            this.DelCol.Width = 35;
            // 
            // density
            // 
            this.density.HeaderText = "Подробнее";
            this.density.Name = "density";
            this.density.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.o1_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.k1_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.x_limit1_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.D1_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.M1_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // o1_textBox
            // 
            this.o1_textBox.Location = new System.Drawing.Point(193, 105);
            this.o1_textBox.Name = "o1_textBox";
            this.o1_textBox.Size = new System.Drawing.Size(54, 20);
            this.o1_textBox.TabIndex = 12;
            this.o1_textBox.Text = "2";
            this.toolTip1.SetToolTip(this.o1_textBox, "Значение Θ");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Θ  ==";
            // 
            // k1_textBox
            // 
            this.k1_textBox.Location = new System.Drawing.Point(57, 108);
            this.k1_textBox.Name = "k1_textBox";
            this.k1_textBox.Size = new System.Drawing.Size(54, 20);
            this.k1_textBox.TabIndex = 10;
            this.k1_textBox.Text = "1";
            this.toolTip1.SetToolTip(this.k1_textBox, "Значение K");
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
            // x_limit1_textBox
            // 
            this.x_limit1_textBox.Location = new System.Drawing.Point(335, 46);
            this.x_limit1_textBox.Name = "x_limit1_textBox";
            this.x_limit1_textBox.Size = new System.Drawing.Size(76, 20);
            this.x_limit1_textBox.TabIndex = 7;
            this.x_limit1_textBox.Text = "20";
            this.toolTip1.SetToolTip(this.x_limit1_textBox, "Ограничение X");
            this.x_limit1_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.toolTip1.SetToolTip(this.trackBar1, "Бегунок для ограничения X");
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // D1_textBox
            // 
            this.D1_textBox.Location = new System.Drawing.Point(95, 53);
            this.D1_textBox.Name = "D1_textBox";
            this.D1_textBox.Size = new System.Drawing.Size(76, 20);
            this.D1_textBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.D1_textBox, "Значение дисперсии");
            this.D1_textBox.TextChanged += new System.EventHandler(this.calculate_params);
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
            // M1_textBox
            // 
            this.M1_textBox.Location = new System.Drawing.Point(95, 27);
            this.M1_textBox.Name = "M1_textBox";
            this.M1_textBox.Size = new System.Drawing.Size(76, 20);
            this.M1_textBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.M1_textBox, "Значение мат.ожидания");
            this.M1_textBox.TextChanged += new System.EventHandler(this.calculate_params);
            this.M1_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.beautyNum);
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
            this.toolTip1.SetToolTip(this.button1, "Добавление функции");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1_density);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Плотность";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1_density
            // 
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.MaximumAutoSize = 90F;
            chartArea1.AxisY.Title = "гамма-функция";
            chartArea1.Name = "ChartArea1";
            this.chart1_density.ChartAreas.Add(chartArea1);
            this.chart1_density.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1_density.Location = new System.Drawing.Point(3, 3);
            this.chart1_density.Name = "chart1_density";
            this.chart1_density.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1_density.Size = new System.Drawing.Size(660, 636);
            this.chart1_density.TabIndex = 1;
            this.chart1_density.Text = "chart1";
            this.toolTip1.SetToolTip(this.chart1_density, "Графики плотностей функций");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1_distribution);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(666, 642);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Распределение";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1_distribution
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1_distribution.ChartAreas.Add(chartArea2);
            this.chart1_distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1_distribution.Location = new System.Drawing.Point(3, 3);
            this.chart1_distribution.Name = "chart1_distribution";
            this.chart1_distribution.Size = new System.Drawing.Size(660, 636);
            this.chart1_distribution.TabIndex = 0;
            this.chart1_distribution.Text = "chart1";
            this.toolTip1.SetToolTip(this.chart1_distribution, "Графики распределения функций");
            // 
            // countTab
            // 
            this.countTab.Controls.Add(this.splitContainer2);
            this.countTab.Location = new System.Drawing.Point(4, 22);
            this.countTab.Name = "countTab";
            this.countTab.Padding = new System.Windows.Forms.Padding(3);
            this.countTab.Size = new System.Drawing.Size(1136, 674);
            this.countTab.TabIndex = 1;
            this.countTab.Text = "Подсчет";
            this.toolTip1.SetToolTip(this.countTab, "Пример на одной функции");
            this.countTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.distribution_groupBox);
            this.splitContainer2.Panel1.Controls.Add(this.density_groupBox);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(1130, 668);
            this.splitContainer2.SplitterDistance = 452;
            this.splitContainer2.TabIndex = 1;
            // 
            // distribution_groupBox
            // 
            this.distribution_groupBox.Controls.Add(this.yDistributionValue_label);
            this.distribution_groupBox.Controls.Add(this.label14);
            this.distribution_groupBox.Controls.Add(this.xDistributionValue_label);
            this.distribution_groupBox.Controls.Add(this.label16);
            this.distribution_groupBox.Controls.Add(this.x_distribution_Runner);
            this.distribution_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.distribution_groupBox.Enabled = false;
            this.distribution_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distribution_groupBox.Location = new System.Drawing.Point(0, 246);
            this.distribution_groupBox.Name = "distribution_groupBox";
            this.distribution_groupBox.Size = new System.Drawing.Size(452, 114);
            this.distribution_groupBox.TabIndex = 14;
            this.distribution_groupBox.TabStop = false;
            this.distribution_groupBox.Text = "Рапределение (X):";
            // 
            // yDistributionValue_label
            // 
            this.yDistributionValue_label.AutoSize = true;
            this.yDistributionValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yDistributionValue_label.Location = new System.Drawing.Point(345, 26);
            this.yDistributionValue_label.Name = "yDistributionValue_label";
            this.yDistributionValue_label.Size = new System.Drawing.Size(20, 25);
            this.yDistributionValue_label.TabIndex = 4;
            this.yDistributionValue_label.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(217, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Значение y:";
            // 
            // xDistributionValue_label
            // 
            this.xDistributionValue_label.AutoSize = true;
            this.xDistributionValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xDistributionValue_label.Location = new System.Drawing.Point(159, 26);
            this.xDistributionValue_label.Name = "xDistributionValue_label";
            this.xDistributionValue_label.Size = new System.Drawing.Size(23, 25);
            this.xDistributionValue_label.TabIndex = 2;
            this.xDistributionValue_label.Text = "4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(31, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Значение x:";
            // 
            // x_distribution_Runner
            // 
            this.x_distribution_Runner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.x_distribution_Runner.LargeChange = 1;
            this.x_distribution_Runner.Location = new System.Drawing.Point(3, 66);
            this.x_distribution_Runner.Maximum = 19;
            this.x_distribution_Runner.Name = "x_distribution_Runner";
            this.x_distribution_Runner.Size = new System.Drawing.Size(446, 45);
            this.x_distribution_Runner.TabIndex = 0;
            this.toolTip1.SetToolTip(this.x_distribution_Runner, "Бегунок для назначения X распределения");
            this.x_distribution_Runner.Value = 4;
            this.x_distribution_Runner.Scroll += new System.EventHandler(this.change_xRunner);
            // 
            // density_groupBox
            // 
            this.density_groupBox.Controls.Add(this.yDensityValue_label);
            this.density_groupBox.Controls.Add(this.label13);
            this.density_groupBox.Controls.Add(this.xDensityValue_label);
            this.density_groupBox.Controls.Add(this.label11);
            this.density_groupBox.Controls.Add(this.x_density_Runner);
            this.density_groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.density_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.density_groupBox.Location = new System.Drawing.Point(0, 132);
            this.density_groupBox.Name = "density_groupBox";
            this.density_groupBox.Size = new System.Drawing.Size(452, 114);
            this.density_groupBox.TabIndex = 13;
            this.density_groupBox.TabStop = false;
            this.density_groupBox.Text = "Плотность (X):";
            // 
            // yDensityValue_label
            // 
            this.yDensityValue_label.AutoSize = true;
            this.yDensityValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yDensityValue_label.Location = new System.Drawing.Point(345, 26);
            this.yDensityValue_label.Name = "yDensityValue_label";
            this.yDensityValue_label.Size = new System.Drawing.Size(20, 25);
            this.yDensityValue_label.TabIndex = 4;
            this.yDensityValue_label.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(217, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Значение y:";
            // 
            // xDensityValue_label
            // 
            this.xDensityValue_label.AutoSize = true;
            this.xDensityValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xDensityValue_label.Location = new System.Drawing.Point(159, 26);
            this.xDensityValue_label.Name = "xDensityValue_label";
            this.xDensityValue_label.Size = new System.Drawing.Size(23, 25);
            this.xDensityValue_label.TabIndex = 2;
            this.xDensityValue_label.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(31, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Значение x:";
            // 
            // x_density_Runner
            // 
            this.x_density_Runner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.x_density_Runner.LargeChange = 1;
            this.x_density_Runner.Location = new System.Drawing.Point(3, 66);
            this.x_density_Runner.Maximum = 20;
            this.x_density_Runner.Minimum = 1;
            this.x_density_Runner.Name = "x_density_Runner";
            this.x_density_Runner.Size = new System.Drawing.Size(446, 45);
            this.x_density_Runner.TabIndex = 0;
            this.toolTip1.SetToolTip(this.x_density_Runner, "Бегунок для назначения X плотности");
            this.x_density_Runner.Value = 4;
            this.x_density_Runner.Scroll += new System.EventHandler(this.change_xRunner);
            this.x_density_Runner.ValueChanged += new System.EventHandler(this.change_xRunner);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.o2_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.k2_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.x_limit2_textBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Controls.Add(this.D2_textBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.M2_textBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Входные параметры";
            // 
            // o2_textBox
            // 
            this.o2_textBox.Location = new System.Drawing.Point(193, 105);
            this.o2_textBox.Name = "o2_textBox";
            this.o2_textBox.Size = new System.Drawing.Size(54, 20);
            this.o2_textBox.TabIndex = 12;
            this.o2_textBox.Text = "2";
            this.toolTip1.SetToolTip(this.o2_textBox, "Значение Θ");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Θ ==";
            // 
            // k2_textBox
            // 
            this.k2_textBox.Location = new System.Drawing.Point(57, 108);
            this.k2_textBox.Name = "k2_textBox";
            this.k2_textBox.Size = new System.Drawing.Size(54, 20);
            this.k2_textBox.TabIndex = 10;
            this.k2_textBox.Text = "1";
            this.toolTip1.SetToolTip(this.k2_textBox, "Значение K");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "K ==";
            // 
            // x_limit2_textBox
            // 
            this.x_limit2_textBox.Location = new System.Drawing.Point(335, 46);
            this.x_limit2_textBox.Name = "x_limit2_textBox";
            this.x_limit2_textBox.Size = new System.Drawing.Size(76, 20);
            this.x_limit2_textBox.TabIndex = 7;
            this.x_limit2_textBox.Text = "20";
            this.x_limit2_textBox.TextChanged += new System.EventHandler(this.change_x_limit2_textBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Лимит X:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(280, 19);
            this.trackBar2.Maximum = 80;
            this.trackBar2.Minimum = 2;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(132, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 20;
            this.trackBar2.ValueChanged += new System.EventHandler(this.change_x_lim2);
            // 
            // D2_textBox
            // 
            this.D2_textBox.Location = new System.Drawing.Point(95, 53);
            this.D2_textBox.Name = "D2_textBox";
            this.D2_textBox.Size = new System.Drawing.Size(76, 20);
            this.D2_textBox.TabIndex = 5;
            this.D2_textBox.TextChanged += new System.EventHandler(this.calculate_params);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Дисперсия:";
            // 
            // M2_textBox
            // 
            this.M2_textBox.Location = new System.Drawing.Point(95, 27);
            this.M2_textBox.Name = "M2_textBox";
            this.M2_textBox.Size = new System.Drawing.Size(76, 20);
            this.M2_textBox.TabIndex = 3;
            this.M2_textBox.TextChanged += new System.EventHandler(this.calculate_params);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Мат.ожидание:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(674, 668);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.switch_runners);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart2_density);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(666, 642);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Плотность";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chart2_density
            // 
            chartArea3.AxisX.Title = "x";
            chartArea3.AxisY.MaximumAutoSize = 90F;
            chartArea3.AxisY.Title = "гамма-функция";
            chartArea3.Name = "ChartArea1";
            this.chart2_density.ChartAreas.Add(chartArea3);
            this.chart2_density.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2_density.Location = new System.Drawing.Point(3, 3);
            this.chart2_density.Name = "chart2_density";
            this.chart2_density.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Series21_mean";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Series21_runner";
            this.chart2_density.Series.Add(series1);
            this.chart2_density.Series.Add(series2);
            this.chart2_density.Size = new System.Drawing.Size(660, 636);
            this.chart2_density.TabIndex = 1;
            this.chart2_density.Text = "chart2";
            this.toolTip1.SetToolTip(this.chart2_density, "График плотности функции");
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart2_distribution);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(666, 642);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Распределение";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart2_distribution
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2_distribution.ChartAreas.Add(chartArea4);
            this.chart2_distribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2_distribution.Location = new System.Drawing.Point(3, 3);
            this.chart2_distribution.Name = "chart2_distribution";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Name = "Series22_mean";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.LimeGreen;
            series4.Name = "Series22_runner";
            this.chart2_distribution.Series.Add(series3);
            this.chart2_distribution.Series.Add(series4);
            this.chart2_distribution.Size = new System.Drawing.Size(660, 636);
            this.chart2_distribution.TabIndex = 0;
            this.chart2_distribution.Text = "chart1";
            this.toolTip1.SetToolTip(this.chart2_distribution, "График распределения функции");
            // 
            // exTab
            // 
            this.exTab.Controls.Add(this.splitContainer3);
            this.exTab.Location = new System.Drawing.Point(4, 22);
            this.exTab.Name = "exTab";
            this.exTab.Size = new System.Drawing.Size(1136, 674);
            this.exTab.TabIndex = 3;
            this.exTab.Text = "Примеры";
            this.toolTip1.SetToolTip(this.exTab, "Примеры для закрепления");
            this.exTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.exTabs);
            this.splitContainer3.Size = new System.Drawing.Size(1136, 674);
            this.splitContainer3.SplitterDistance = 176;
            this.splitContainer3.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Задания";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "ex1tab";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.Tag = "ex2tab";
            listViewItem3.Group = listViewGroup1;
            listViewItem3.Tag = "ex3tab";
            listViewItem4.Group = listViewGroup1;
            listViewItem4.Tag = "ex4tab";
            listViewItem5.Group = listViewGroup1;
            listViewItem5.Tag = "ex5tab";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(176, 674);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Задания";
            // 
            // exTabs
            // 
            this.exTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exTabs.Location = new System.Drawing.Point(0, 0);
            this.exTabs.Name = "exTabs";
            this.exTabs.SelectedIndex = 0;
            this.exTabs.Size = new System.Drawing.Size(956, 674);
            this.exTabs.TabIndex = 0;
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
            // chart_bindingSource
            // 
            this.chart_bindingSource.DataSource = typeof(GammaDisctibution.Models.Charts);
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
            this.intro_tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.funcsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charts_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1_density)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1_distribution)).EndInit();
            this.countTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.distribution_groupBox.ResumeLayout(false);
            this.distribution_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_distribution_Runner)).EndInit();
            this.density_groupBox.ResumeLayout(false);
            this.density_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_density_Runner)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2_density)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2_distribution)).EndInit();
            this.exTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage funcsTab;
        private System.Windows.Forms.TabPage countTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource chart_bindingSource;
        private System.Windows.Forms.DataGridView charts_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage introTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox D1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox M1_textBox;
        private System.Windows.Forms.TextBox x_limit1_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox o1_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k1_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl intro_tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer_function;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer_distribution;
        private System.Windows.Forms.TabPage exTab;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox o2_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox k2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x_limit2_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox D2_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox M2_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox density_groupBox;
        private System.Windows.Forms.Label xDensityValue_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar x_density_Runner;
        private System.Windows.Forms.Label yDensityValue_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_density;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_distribution;
        private System.Windows.Forms.GroupBox distribution_groupBox;
        private System.Windows.Forms.Label yDistributionValue_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label xDistributionValue_label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar x_distribution_Runner;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2_density;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2_distribution;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DelCol;
        private System.Windows.Forms.DataGridViewButtonColumn density;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl exTabs;
    }
}

