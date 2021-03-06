using System;
using System.Windows.Forms;

namespace MaterialDashSkin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelsensor1 = new System.Windows.Forms.Label();
            this.labelsensor2value = new System.Windows.Forms.Label();
            this.labelsensor2 = new System.Windows.Forms.Label();
            this.labelsensor1value = new System.Windows.Forms.Label();
            this.labelsensor3 = new System.Windows.Forms.Label();
            this.labelsensor3value = new System.Windows.Forms.Label();
            this.labelsensor4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelsensor4value = new System.Windows.Forms.Label();
            this.materialButtongraphplaypause = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonsensor1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonsensor2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonsensor3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonsensor4 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxDatabasePassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxDatabaseLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxsensor1port = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxsensor1baud = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxdatabit1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxparity1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxstopbit1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor2port = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor2baud = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxdatabit2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxparity2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxstopbit2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor3port = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor3baud = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxdatabit3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxparity3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxstopbit3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor4port = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxsensor4baud = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxdatabit4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxparity4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxstopbit4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxDatabaseUrl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxDatabasePort = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(80, 48);
            this.materialTabControl1.Location = new System.Drawing.Point(10, 10);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.Padding = new System.Drawing.Point(10, 10);
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(780, 680);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageKey = "chart-areaspline.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 52);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serials ports graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelsensor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor2value, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor1value, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor3value, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelsensor4value, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialButtongraphplaypause, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.materialButtonsensor1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialButtonsensor2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialButtonsensor3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialButtonsensor4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialSwitch1, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 618);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelsensor1
            // 
            this.labelsensor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsensor1.AutoSize = true;
            this.labelsensor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsensor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelsensor1.Location = new System.Drawing.Point(64, 17);
            this.labelsensor1.Name = "labelsensor1";
            this.labelsensor1.Size = new System.Drawing.Size(63, 13);
            this.labelsensor1.TabIndex = 1;
            this.labelsensor1.Text = "sensor 1 :";
            // 
            // labelsensor2value
            // 
            this.labelsensor2value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelsensor2value.AutoSize = true;
            this.labelsensor2value.Location = new System.Drawing.Point(194, 64);
            this.labelsensor2value.Name = "labelsensor2value";
            this.labelsensor2value.Size = new System.Drawing.Size(0, 13);
            this.labelsensor2value.TabIndex = 4;
            // 
            // labelsensor2
            // 
            this.labelsensor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsensor2.AutoSize = true;
            this.labelsensor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsensor2.Location = new System.Drawing.Point(62, 64);
            this.labelsensor2.Name = "labelsensor2";
            this.labelsensor2.Size = new System.Drawing.Size(67, 13);
            this.labelsensor2.TabIndex = 3;
            this.labelsensor2.Text = "sensor 2 : ";
            // 
            // labelsensor1value
            // 
            this.labelsensor1value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelsensor1value.AutoSize = true;
            this.labelsensor1value.Location = new System.Drawing.Point(194, 17);
            this.labelsensor1value.Name = "labelsensor1value";
            this.labelsensor1value.Size = new System.Drawing.Size(0, 13);
            this.labelsensor1value.TabIndex = 2;
            // 
            // labelsensor3
            // 
            this.labelsensor3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsensor3.AutoSize = true;
            this.labelsensor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsensor3.Location = new System.Drawing.Point(62, 111);
            this.labelsensor3.Name = "labelsensor3";
            this.labelsensor3.Size = new System.Drawing.Size(67, 13);
            this.labelsensor3.TabIndex = 9;
            this.labelsensor3.Text = "sensor 3 : ";
            // 
            // labelsensor3value
            // 
            this.labelsensor3value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelsensor3value.AutoSize = true;
            this.labelsensor3value.Location = new System.Drawing.Point(194, 111);
            this.labelsensor3value.Name = "labelsensor3value";
            this.labelsensor3value.Size = new System.Drawing.Size(0, 13);
            this.labelsensor3value.TabIndex = 10;
            // 
            // labelsensor4
            // 
            this.labelsensor4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsensor4.AutoSize = true;
            this.labelsensor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsensor4.Location = new System.Drawing.Point(64, 158);
            this.labelsensor4.Name = "labelsensor4";
            this.labelsensor4.Size = new System.Drawing.Size(63, 13);
            this.labelsensor4.TabIndex = 13;
            this.labelsensor4.Text = "sensor 4 :";
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.CursorX.Interval = 10D;
            chartArea1.CursorX.IntervalOffset = 1D;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.IsSoftShadows = false;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.AutoFitMinFontSize = 12;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 191);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel1.SetRowSpan(this.chart1, 4);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(760, 372);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // labelsensor4value
            // 
            this.labelsensor4value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelsensor4value.AutoSize = true;
            this.labelsensor4value.Location = new System.Drawing.Point(194, 158);
            this.labelsensor4value.Name = "labelsensor4value";
            this.labelsensor4value.Size = new System.Drawing.Size(0, 13);
            this.labelsensor4value.TabIndex = 14;
            // 
            // materialButtongraphplaypause
            // 
            this.materialButtongraphplaypause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtongraphplaypause.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtongraphplaypause.Depth = 0;
            this.materialButtongraphplaypause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButtongraphplaypause.HighEmphasis = true;
            this.materialButtongraphplaypause.Icon = null;
            this.materialButtongraphplaypause.Location = new System.Drawing.Point(577, 572);
            this.materialButtongraphplaypause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtongraphplaypause.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtongraphplaypause.Name = "materialButtongraphplaypause";
            this.materialButtongraphplaypause.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtongraphplaypause.Size = new System.Drawing.Size(185, 40);
            this.materialButtongraphplaypause.TabIndex = 11;
            this.materialButtongraphplaypause.Text = "play";
            this.materialButtongraphplaypause.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtongraphplaypause.UseAccentColor = false;
            this.materialButtongraphplaypause.UseVisualStyleBackColor = true;
            this.materialButtongraphplaypause.Click += new System.EventHandler(this.materialButtongraphplaypause_Click);
            // 
            // materialButtonsensor1
            // 
            this.materialButtonsensor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonsensor1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonsensor1.Depth = 0;
            this.materialButtonsensor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButtonsensor1.HighEmphasis = true;
            this.materialButtonsensor1.Icon = null;
            this.materialButtonsensor1.Location = new System.Drawing.Point(577, 6);
            this.materialButtonsensor1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonsensor1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonsensor1.Name = "materialButtonsensor1";
            this.materialButtonsensor1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonsensor1.Size = new System.Drawing.Size(185, 35);
            this.materialButtonsensor1.TabIndex = 15;
            this.materialButtonsensor1.Text = "OPEN";
            this.materialButtonsensor1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonsensor1.UseAccentColor = false;
            this.materialButtonsensor1.UseVisualStyleBackColor = true;
            this.materialButtonsensor1.Click += new System.EventHandler(this.materialButtonsensor1_Click);
            // 
            // materialButtonsensor2
            // 
            this.materialButtonsensor2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonsensor2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonsensor2.Depth = 0;
            this.materialButtonsensor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButtonsensor2.HighEmphasis = true;
            this.materialButtonsensor2.Icon = null;
            this.materialButtonsensor2.Location = new System.Drawing.Point(577, 53);
            this.materialButtonsensor2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonsensor2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonsensor2.Name = "materialButtonsensor2";
            this.materialButtonsensor2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonsensor2.Size = new System.Drawing.Size(185, 35);
            this.materialButtonsensor2.TabIndex = 16;
            this.materialButtonsensor2.Text = "OPEN";
            this.materialButtonsensor2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonsensor2.UseAccentColor = false;
            this.materialButtonsensor2.UseVisualStyleBackColor = true;
            this.materialButtonsensor2.Click += new System.EventHandler(this.materialButtonsensor2_Click);
            // 
            // materialButtonsensor3
            // 
            this.materialButtonsensor3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonsensor3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonsensor3.Depth = 0;
            this.materialButtonsensor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButtonsensor3.HighEmphasis = true;
            this.materialButtonsensor3.Icon = null;
            this.materialButtonsensor3.Location = new System.Drawing.Point(577, 100);
            this.materialButtonsensor3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonsensor3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonsensor3.Name = "materialButtonsensor3";
            this.materialButtonsensor3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonsensor3.Size = new System.Drawing.Size(185, 35);
            this.materialButtonsensor3.TabIndex = 17;
            this.materialButtonsensor3.Text = "OPEN";
            this.materialButtonsensor3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonsensor3.UseAccentColor = false;
            this.materialButtonsensor3.UseVisualStyleBackColor = true;
            this.materialButtonsensor3.Click += new System.EventHandler(this.materialButtonsensor3_Click);
            // 
            // materialButtonsensor4
            // 
            this.materialButtonsensor4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonsensor4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonsensor4.Depth = 0;
            this.materialButtonsensor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButtonsensor4.HighEmphasis = true;
            this.materialButtonsensor4.Icon = null;
            this.materialButtonsensor4.Location = new System.Drawing.Point(577, 147);
            this.materialButtonsensor4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonsensor4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonsensor4.Name = "materialButtonsensor4";
            this.materialButtonsensor4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonsensor4.Size = new System.Drawing.Size(185, 35);
            this.materialButtonsensor4.TabIndex = 18;
            this.materialButtonsensor4.Text = "OPEN";
            this.materialButtonsensor4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonsensor4.UseAccentColor = false;
            this.materialButtonsensor4.UseVisualStyleBackColor = true;
            this.materialButtonsensor4.Click += new System.EventHandler(this.materialButtonsensor4_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialSwitch1.Location = new System.Drawing.Point(0, 566);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(191, 52);
            this.materialSwitch1.TabIndex = 20;
            this.materialSwitch1.Text = "Record";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.ImageKey = "database-cog.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 52);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.chart2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.materialButton4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialComboBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(766, 618);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // chart2
            // 
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.DarkGray;
            chartArea2.CursorX.Interval = 10D;
            chartArea2.CursorX.IntervalOffset = 1D;
            chartArea2.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel3.SetColumnSpan(this.chart2, 4);
            this.chart2.IsSoftShadows = false;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.AutoFitMinFontSize = 12;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.DarkGray;
            legend2.IsDockedInsideChartArea = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 63);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Lime;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Yellow;
            series8.Legend = "Legend1";
            series8.Name = "Series4";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(760, 273);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(577, 6);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(144, 36);
            this.materialButton4.TabIndex = 14;
            this.materialButton4.Text = "delete all data";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click_1);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "serie";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(3, 3);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 15;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.ImageKey = "tools.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 52);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel9, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialTextBoxDatabasePassword, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.materialTextBoxDatabaseLogin, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor1port, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor1baud, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxdatabit1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxparity1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxstopbit1, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor2port, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor2baud, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxdatabit2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxparity2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxstopbit2, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor3port, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor3baud, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxdatabit3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxparity3, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxstopbit3, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor4port, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxsensor4baud, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxdatabit4, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxparity4, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialComboBoxstopbit4, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialDivider1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.materialButton2, 5, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialTextBoxDatabaseUrl, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.materialTextBoxDatabasePort, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialButton1, 5, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.098901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 618);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(511, 365);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(37, 19);
            this.materialLabel9.TabIndex = 40;
            this.materialLabel9.Text = "port :";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTextBoxDatabasePassword
            // 
            this.materialTextBoxDatabasePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBoxDatabasePassword.AnimateReadOnly = false;
            this.materialTextBoxDatabasePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.materialTextBoxDatabasePassword, 3);
            this.materialTextBoxDatabasePassword.Depth = 0;
            this.materialTextBoxDatabasePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxDatabasePassword.Hint = "demo";
            this.materialTextBoxDatabasePassword.LeadingIcon = null;
            this.materialTextBoxDatabasePassword.Location = new System.Drawing.Point(130, 483);
            this.materialTextBoxDatabasePassword.MaxLength = 50;
            this.materialTextBoxDatabasePassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDatabasePassword.Multiline = false;
            this.materialTextBoxDatabasePassword.Name = "materialTextBoxDatabasePassword";
            this.materialTextBoxDatabasePassword.Size = new System.Drawing.Size(375, 50);
            this.materialTextBoxDatabasePassword.TabIndex = 39;
            this.materialTextBoxDatabasePassword.Text = "test";
            this.materialTextBoxDatabasePassword.TrailingIcon = null;
            // 
            // materialTextBoxDatabaseLogin
            // 
            this.materialTextBoxDatabaseLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBoxDatabaseLogin.AnimateReadOnly = false;
            this.materialTextBoxDatabaseLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.materialTextBoxDatabaseLogin, 3);
            this.materialTextBoxDatabaseLogin.Depth = 0;
            this.materialTextBoxDatabaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxDatabaseLogin.Hint = "demo";
            this.materialTextBoxDatabaseLogin.LeadingIcon = null;
            this.materialTextBoxDatabaseLogin.Location = new System.Drawing.Point(130, 416);
            this.materialTextBoxDatabaseLogin.MaxLength = 50;
            this.materialTextBoxDatabaseLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDatabaseLogin.Multiline = false;
            this.materialTextBoxDatabaseLogin.Name = "materialTextBoxDatabaseLogin";
            this.materialTextBoxDatabaseLogin.Size = new System.Drawing.Size(375, 50);
            this.materialTextBoxDatabaseLogin.TabIndex = 38;
            this.materialTextBoxDatabaseLogin.Text = "test";
            this.materialTextBoxDatabaseLogin.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 91);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "sensor 2 :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Location = new System.Drawing.Point(3, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "sensor 1 :";
            // 
            // materialComboBoxsensor1port
            // 
            this.materialComboBoxsensor1port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor1port.AutoResize = false;
            this.materialComboBoxsensor1port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor1port.Depth = 0;
            this.materialComboBoxsensor1port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor1port.DropDownHeight = 174;
            this.materialComboBoxsensor1port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor1port.DropDownWidth = 121;
            this.materialComboBoxsensor1port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor1port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor1port.FormattingEnabled = true;
            this.materialComboBoxsensor1port.Hint = "port";
            this.materialComboBoxsensor1port.IntegralHeight = false;
            this.materialComboBoxsensor1port.ItemHeight = 43;
            this.materialComboBoxsensor1port.Location = new System.Drawing.Point(130, 9);
            this.materialComboBoxsensor1port.MaxDropDownItems = 4;
            this.materialComboBoxsensor1port.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor1port.Name = "materialComboBoxsensor1port";
            this.materialComboBoxsensor1port.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor1port.StartIndex = 0;
            this.materialComboBoxsensor1port.TabIndex = 10;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 158);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "sensor 3 :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(3, 225);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "sensor 4 :";
            // 
            // materialComboBoxsensor1baud
            // 
            this.materialComboBoxsensor1baud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor1baud.AutoResize = false;
            this.materialComboBoxsensor1baud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor1baud.Depth = 0;
            this.materialComboBoxsensor1baud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor1baud.DropDownHeight = 174;
            this.materialComboBoxsensor1baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor1baud.DropDownWidth = 121;
            this.materialComboBoxsensor1baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor1baud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor1baud.FormattingEnabled = true;
            this.materialComboBoxsensor1baud.Hint = "baudrate";
            this.materialComboBoxsensor1baud.IntegralHeight = false;
            this.materialComboBoxsensor1baud.ItemHeight = 43;
            this.materialComboBoxsensor1baud.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.materialComboBoxsensor1baud.Location = new System.Drawing.Point(257, 9);
            this.materialComboBoxsensor1baud.MaxDropDownItems = 4;
            this.materialComboBoxsensor1baud.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor1baud.Name = "materialComboBoxsensor1baud";
            this.materialComboBoxsensor1baud.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor1baud.StartIndex = 0;
            this.materialComboBoxsensor1baud.TabIndex = 11;
            // 
            // materialComboBoxdatabit1
            // 
            this.materialComboBoxdatabit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxdatabit1.AutoResize = false;
            this.materialComboBoxdatabit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxdatabit1.Depth = 0;
            this.materialComboBoxdatabit1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxdatabit1.DropDownHeight = 174;
            this.materialComboBoxdatabit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxdatabit1.DropDownWidth = 121;
            this.materialComboBoxdatabit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxdatabit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxdatabit1.FormattingEnabled = true;
            this.materialComboBoxdatabit1.Hint = "data bits";
            this.materialComboBoxdatabit1.IntegralHeight = false;
            this.materialComboBoxdatabit1.ItemHeight = 43;
            this.materialComboBoxdatabit1.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.materialComboBoxdatabit1.Location = new System.Drawing.Point(384, 9);
            this.materialComboBoxdatabit1.MaxDropDownItems = 4;
            this.materialComboBoxdatabit1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxdatabit1.Name = "materialComboBoxdatabit1";
            this.materialComboBoxdatabit1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxdatabit1.StartIndex = 0;
            this.materialComboBoxdatabit1.TabIndex = 16;
            // 
            // materialComboBoxparity1
            // 
            this.materialComboBoxparity1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxparity1.AutoResize = false;
            this.materialComboBoxparity1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxparity1.Depth = 0;
            this.materialComboBoxparity1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxparity1.DropDownHeight = 174;
            this.materialComboBoxparity1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxparity1.DropDownWidth = 121;
            this.materialComboBoxparity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxparity1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxparity1.FormattingEnabled = true;
            this.materialComboBoxparity1.Hint = "parity bit";
            this.materialComboBoxparity1.IntegralHeight = false;
            this.materialComboBoxparity1.ItemHeight = 43;
            this.materialComboBoxparity1.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.materialComboBoxparity1.Location = new System.Drawing.Point(511, 9);
            this.materialComboBoxparity1.MaxDropDownItems = 4;
            this.materialComboBoxparity1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxparity1.Name = "materialComboBoxparity1";
            this.materialComboBoxparity1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxparity1.StartIndex = 0;
            this.materialComboBoxparity1.TabIndex = 17;
            // 
            // materialComboBoxstopbit1
            // 
            this.materialComboBoxstopbit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxstopbit1.AutoResize = false;
            this.materialComboBoxstopbit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxstopbit1.Depth = 0;
            this.materialComboBoxstopbit1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxstopbit1.DropDownHeight = 174;
            this.materialComboBoxstopbit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxstopbit1.DropDownWidth = 121;
            this.materialComboBoxstopbit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxstopbit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxstopbit1.FormattingEnabled = true;
            this.materialComboBoxstopbit1.Hint = "stop bit";
            this.materialComboBoxstopbit1.IntegralHeight = false;
            this.materialComboBoxstopbit1.ItemHeight = 43;
            this.materialComboBoxstopbit1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.materialComboBoxstopbit1.Location = new System.Drawing.Point(640, 9);
            this.materialComboBoxstopbit1.MaxDropDownItems = 4;
            this.materialComboBoxstopbit1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxstopbit1.Name = "materialComboBoxstopbit1";
            this.materialComboBoxstopbit1.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxstopbit1.StartIndex = 0;
            this.materialComboBoxstopbit1.TabIndex = 18;
            // 
            // materialComboBoxsensor2port
            // 
            this.materialComboBoxsensor2port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor2port.AutoResize = false;
            this.materialComboBoxsensor2port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor2port.Depth = 0;
            this.materialComboBoxsensor2port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor2port.DropDownHeight = 174;
            this.materialComboBoxsensor2port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor2port.DropDownWidth = 121;
            this.materialComboBoxsensor2port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor2port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor2port.FormattingEnabled = true;
            this.materialComboBoxsensor2port.Hint = "port";
            this.materialComboBoxsensor2port.IntegralHeight = false;
            this.materialComboBoxsensor2port.ItemHeight = 43;
            this.materialComboBoxsensor2port.Location = new System.Drawing.Point(130, 76);
            this.materialComboBoxsensor2port.MaxDropDownItems = 4;
            this.materialComboBoxsensor2port.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor2port.Name = "materialComboBoxsensor2port";
            this.materialComboBoxsensor2port.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor2port.StartIndex = 0;
            this.materialComboBoxsensor2port.TabIndex = 19;
            // 
            // materialComboBoxsensor2baud
            // 
            this.materialComboBoxsensor2baud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor2baud.AutoResize = false;
            this.materialComboBoxsensor2baud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor2baud.Depth = 0;
            this.materialComboBoxsensor2baud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor2baud.DropDownHeight = 174;
            this.materialComboBoxsensor2baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor2baud.DropDownWidth = 121;
            this.materialComboBoxsensor2baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor2baud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor2baud.FormattingEnabled = true;
            this.materialComboBoxsensor2baud.Hint = "baudrate";
            this.materialComboBoxsensor2baud.IntegralHeight = false;
            this.materialComboBoxsensor2baud.ItemHeight = 43;
            this.materialComboBoxsensor2baud.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.materialComboBoxsensor2baud.Location = new System.Drawing.Point(257, 76);
            this.materialComboBoxsensor2baud.MaxDropDownItems = 4;
            this.materialComboBoxsensor2baud.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor2baud.Name = "materialComboBoxsensor2baud";
            this.materialComboBoxsensor2baud.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor2baud.StartIndex = 0;
            this.materialComboBoxsensor2baud.TabIndex = 20;
            // 
            // materialComboBoxdatabit2
            // 
            this.materialComboBoxdatabit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxdatabit2.AutoResize = false;
            this.materialComboBoxdatabit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxdatabit2.Depth = 0;
            this.materialComboBoxdatabit2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxdatabit2.DropDownHeight = 174;
            this.materialComboBoxdatabit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxdatabit2.DropDownWidth = 121;
            this.materialComboBoxdatabit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxdatabit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxdatabit2.FormattingEnabled = true;
            this.materialComboBoxdatabit2.Hint = "data bits";
            this.materialComboBoxdatabit2.IntegralHeight = false;
            this.materialComboBoxdatabit2.ItemHeight = 43;
            this.materialComboBoxdatabit2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.materialComboBoxdatabit2.Location = new System.Drawing.Point(384, 76);
            this.materialComboBoxdatabit2.MaxDropDownItems = 4;
            this.materialComboBoxdatabit2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxdatabit2.Name = "materialComboBoxdatabit2";
            this.materialComboBoxdatabit2.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxdatabit2.StartIndex = 0;
            this.materialComboBoxdatabit2.TabIndex = 21;
            // 
            // materialComboBoxparity2
            // 
            this.materialComboBoxparity2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxparity2.AutoResize = false;
            this.materialComboBoxparity2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxparity2.Depth = 0;
            this.materialComboBoxparity2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxparity2.DropDownHeight = 174;
            this.materialComboBoxparity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxparity2.DropDownWidth = 121;
            this.materialComboBoxparity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxparity2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxparity2.FormattingEnabled = true;
            this.materialComboBoxparity2.Hint = "parity bit";
            this.materialComboBoxparity2.IntegralHeight = false;
            this.materialComboBoxparity2.ItemHeight = 43;
            this.materialComboBoxparity2.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.materialComboBoxparity2.Location = new System.Drawing.Point(511, 76);
            this.materialComboBoxparity2.MaxDropDownItems = 4;
            this.materialComboBoxparity2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxparity2.Name = "materialComboBoxparity2";
            this.materialComboBoxparity2.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxparity2.StartIndex = 0;
            this.materialComboBoxparity2.TabIndex = 22;
            // 
            // materialComboBoxstopbit2
            // 
            this.materialComboBoxstopbit2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxstopbit2.AutoResize = false;
            this.materialComboBoxstopbit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxstopbit2.Depth = 0;
            this.materialComboBoxstopbit2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxstopbit2.DropDownHeight = 174;
            this.materialComboBoxstopbit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxstopbit2.DropDownWidth = 121;
            this.materialComboBoxstopbit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxstopbit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxstopbit2.FormattingEnabled = true;
            this.materialComboBoxstopbit2.Hint = "stop bit";
            this.materialComboBoxstopbit2.IntegralHeight = false;
            this.materialComboBoxstopbit2.ItemHeight = 43;
            this.materialComboBoxstopbit2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.materialComboBoxstopbit2.Location = new System.Drawing.Point(640, 76);
            this.materialComboBoxstopbit2.MaxDropDownItems = 4;
            this.materialComboBoxstopbit2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxstopbit2.Name = "materialComboBoxstopbit2";
            this.materialComboBoxstopbit2.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxstopbit2.StartIndex = 0;
            this.materialComboBoxstopbit2.TabIndex = 23;
            // 
            // materialComboBoxsensor3port
            // 
            this.materialComboBoxsensor3port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor3port.AutoResize = false;
            this.materialComboBoxsensor3port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor3port.Depth = 0;
            this.materialComboBoxsensor3port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor3port.DropDownHeight = 174;
            this.materialComboBoxsensor3port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor3port.DropDownWidth = 121;
            this.materialComboBoxsensor3port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor3port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor3port.FormattingEnabled = true;
            this.materialComboBoxsensor3port.Hint = "port";
            this.materialComboBoxsensor3port.IntegralHeight = false;
            this.materialComboBoxsensor3port.ItemHeight = 43;
            this.materialComboBoxsensor3port.Location = new System.Drawing.Point(130, 143);
            this.materialComboBoxsensor3port.MaxDropDownItems = 4;
            this.materialComboBoxsensor3port.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor3port.Name = "materialComboBoxsensor3port";
            this.materialComboBoxsensor3port.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor3port.StartIndex = 0;
            this.materialComboBoxsensor3port.TabIndex = 24;
            // 
            // materialComboBoxsensor3baud
            // 
            this.materialComboBoxsensor3baud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor3baud.AutoResize = false;
            this.materialComboBoxsensor3baud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor3baud.Depth = 0;
            this.materialComboBoxsensor3baud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor3baud.DropDownHeight = 174;
            this.materialComboBoxsensor3baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor3baud.DropDownWidth = 121;
            this.materialComboBoxsensor3baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor3baud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor3baud.FormattingEnabled = true;
            this.materialComboBoxsensor3baud.Hint = "baudrate";
            this.materialComboBoxsensor3baud.IntegralHeight = false;
            this.materialComboBoxsensor3baud.ItemHeight = 43;
            this.materialComboBoxsensor3baud.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.materialComboBoxsensor3baud.Location = new System.Drawing.Point(257, 143);
            this.materialComboBoxsensor3baud.MaxDropDownItems = 4;
            this.materialComboBoxsensor3baud.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor3baud.Name = "materialComboBoxsensor3baud";
            this.materialComboBoxsensor3baud.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor3baud.StartIndex = 0;
            this.materialComboBoxsensor3baud.TabIndex = 25;
            // 
            // materialComboBoxdatabit3
            // 
            this.materialComboBoxdatabit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxdatabit3.AutoResize = false;
            this.materialComboBoxdatabit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxdatabit3.Depth = 0;
            this.materialComboBoxdatabit3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxdatabit3.DropDownHeight = 174;
            this.materialComboBoxdatabit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxdatabit3.DropDownWidth = 121;
            this.materialComboBoxdatabit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxdatabit3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxdatabit3.FormattingEnabled = true;
            this.materialComboBoxdatabit3.Hint = "data bits";
            this.materialComboBoxdatabit3.IntegralHeight = false;
            this.materialComboBoxdatabit3.ItemHeight = 43;
            this.materialComboBoxdatabit3.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.materialComboBoxdatabit3.Location = new System.Drawing.Point(384, 143);
            this.materialComboBoxdatabit3.MaxDropDownItems = 4;
            this.materialComboBoxdatabit3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxdatabit3.Name = "materialComboBoxdatabit3";
            this.materialComboBoxdatabit3.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxdatabit3.StartIndex = 0;
            this.materialComboBoxdatabit3.TabIndex = 26;
            // 
            // materialComboBoxparity3
            // 
            this.materialComboBoxparity3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxparity3.AutoResize = false;
            this.materialComboBoxparity3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxparity3.Depth = 0;
            this.materialComboBoxparity3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxparity3.DropDownHeight = 174;
            this.materialComboBoxparity3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxparity3.DropDownWidth = 121;
            this.materialComboBoxparity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxparity3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxparity3.FormattingEnabled = true;
            this.materialComboBoxparity3.Hint = "parity bit";
            this.materialComboBoxparity3.IntegralHeight = false;
            this.materialComboBoxparity3.ItemHeight = 43;
            this.materialComboBoxparity3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.materialComboBoxparity3.Location = new System.Drawing.Point(511, 143);
            this.materialComboBoxparity3.MaxDropDownItems = 4;
            this.materialComboBoxparity3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxparity3.Name = "materialComboBoxparity3";
            this.materialComboBoxparity3.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxparity3.StartIndex = 0;
            this.materialComboBoxparity3.TabIndex = 27;
            // 
            // materialComboBoxstopbit3
            // 
            this.materialComboBoxstopbit3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxstopbit3.AutoResize = false;
            this.materialComboBoxstopbit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxstopbit3.Depth = 0;
            this.materialComboBoxstopbit3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxstopbit3.DropDownHeight = 174;
            this.materialComboBoxstopbit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxstopbit3.DropDownWidth = 121;
            this.materialComboBoxstopbit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxstopbit3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxstopbit3.FormattingEnabled = true;
            this.materialComboBoxstopbit3.Hint = "stop bit";
            this.materialComboBoxstopbit3.IntegralHeight = false;
            this.materialComboBoxstopbit3.ItemHeight = 43;
            this.materialComboBoxstopbit3.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.materialComboBoxstopbit3.Location = new System.Drawing.Point(640, 143);
            this.materialComboBoxstopbit3.MaxDropDownItems = 4;
            this.materialComboBoxstopbit3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxstopbit3.Name = "materialComboBoxstopbit3";
            this.materialComboBoxstopbit3.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxstopbit3.StartIndex = 0;
            this.materialComboBoxstopbit3.TabIndex = 28;
            // 
            // materialComboBoxsensor4port
            // 
            this.materialComboBoxsensor4port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor4port.AutoResize = false;
            this.materialComboBoxsensor4port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor4port.Depth = 0;
            this.materialComboBoxsensor4port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor4port.DropDownHeight = 174;
            this.materialComboBoxsensor4port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor4port.DropDownWidth = 121;
            this.materialComboBoxsensor4port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor4port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor4port.FormattingEnabled = true;
            this.materialComboBoxsensor4port.Hint = "port";
            this.materialComboBoxsensor4port.IntegralHeight = false;
            this.materialComboBoxsensor4port.ItemHeight = 43;
            this.materialComboBoxsensor4port.Location = new System.Drawing.Point(130, 210);
            this.materialComboBoxsensor4port.MaxDropDownItems = 4;
            this.materialComboBoxsensor4port.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor4port.Name = "materialComboBoxsensor4port";
            this.materialComboBoxsensor4port.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor4port.StartIndex = 0;
            this.materialComboBoxsensor4port.TabIndex = 29;
            // 
            // materialComboBoxsensor4baud
            // 
            this.materialComboBoxsensor4baud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxsensor4baud.AutoResize = false;
            this.materialComboBoxsensor4baud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxsensor4baud.Depth = 0;
            this.materialComboBoxsensor4baud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxsensor4baud.DropDownHeight = 174;
            this.materialComboBoxsensor4baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxsensor4baud.DropDownWidth = 121;
            this.materialComboBoxsensor4baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxsensor4baud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxsensor4baud.FormattingEnabled = true;
            this.materialComboBoxsensor4baud.Hint = "baudrate";
            this.materialComboBoxsensor4baud.IntegralHeight = false;
            this.materialComboBoxsensor4baud.ItemHeight = 43;
            this.materialComboBoxsensor4baud.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.materialComboBoxsensor4baud.Location = new System.Drawing.Point(257, 210);
            this.materialComboBoxsensor4baud.MaxDropDownItems = 4;
            this.materialComboBoxsensor4baud.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxsensor4baud.Name = "materialComboBoxsensor4baud";
            this.materialComboBoxsensor4baud.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxsensor4baud.StartIndex = 0;
            this.materialComboBoxsensor4baud.TabIndex = 30;
            // 
            // materialComboBoxdatabit4
            // 
            this.materialComboBoxdatabit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxdatabit4.AutoResize = false;
            this.materialComboBoxdatabit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxdatabit4.Depth = 0;
            this.materialComboBoxdatabit4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxdatabit4.DropDownHeight = 174;
            this.materialComboBoxdatabit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxdatabit4.DropDownWidth = 121;
            this.materialComboBoxdatabit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxdatabit4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxdatabit4.FormatString = "N0";
            this.materialComboBoxdatabit4.Hint = "data bits";
            this.materialComboBoxdatabit4.IntegralHeight = false;
            this.materialComboBoxdatabit4.ItemHeight = 43;
            this.materialComboBoxdatabit4.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.materialComboBoxdatabit4.Location = new System.Drawing.Point(384, 210);
            this.materialComboBoxdatabit4.MaxDropDownItems = 4;
            this.materialComboBoxdatabit4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxdatabit4.Name = "materialComboBoxdatabit4";
            this.materialComboBoxdatabit4.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxdatabit4.StartIndex = 0;
            this.materialComboBoxdatabit4.TabIndex = 31;
            // 
            // materialComboBoxparity4
            // 
            this.materialComboBoxparity4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxparity4.AutoResize = false;
            this.materialComboBoxparity4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxparity4.Depth = 0;
            this.materialComboBoxparity4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxparity4.DropDownHeight = 174;
            this.materialComboBoxparity4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxparity4.DropDownWidth = 121;
            this.materialComboBoxparity4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxparity4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxparity4.FormattingEnabled = true;
            this.materialComboBoxparity4.Hint = "parity bit";
            this.materialComboBoxparity4.IntegralHeight = false;
            this.materialComboBoxparity4.ItemHeight = 43;
            this.materialComboBoxparity4.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.materialComboBoxparity4.Location = new System.Drawing.Point(511, 210);
            this.materialComboBoxparity4.MaxDropDownItems = 4;
            this.materialComboBoxparity4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxparity4.Name = "materialComboBoxparity4";
            this.materialComboBoxparity4.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxparity4.StartIndex = 0;
            this.materialComboBoxparity4.TabIndex = 32;
            // 
            // materialComboBoxstopbit4
            // 
            this.materialComboBoxstopbit4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialComboBoxstopbit4.AutoResize = false;
            this.materialComboBoxstopbit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxstopbit4.Depth = 0;
            this.materialComboBoxstopbit4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxstopbit4.DropDownHeight = 174;
            this.materialComboBoxstopbit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxstopbit4.DropDownWidth = 121;
            this.materialComboBoxstopbit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxstopbit4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxstopbit4.FormattingEnabled = true;
            this.materialComboBoxstopbit4.Hint = "stop bit";
            this.materialComboBoxstopbit4.IntegralHeight = false;
            this.materialComboBoxstopbit4.ItemHeight = 43;
            this.materialComboBoxstopbit4.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.materialComboBoxstopbit4.Location = new System.Drawing.Point(640, 210);
            this.materialComboBoxstopbit4.MaxDropDownItems = 4;
            this.materialComboBoxstopbit4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxstopbit4.Name = "materialComboBoxstopbit4";
            this.materialComboBoxstopbit4.Size = new System.Drawing.Size(121, 49);
            this.materialComboBoxstopbit4.StartIndex = 0;
            this.materialComboBoxstopbit4.TabIndex = 33;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel2.SetColumnSpan(this.materialDivider1, 6);
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDivider1.Location = new System.Drawing.Point(3, 271);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(760, 1);
            this.materialDivider1.TabIndex = 34;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(639, 548);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(123, 64);
            this.materialButton2.TabIndex = 9;
            this.materialButton2.Text = "Save settings";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.materialLabel5, 6);
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(3, 274);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(146, 67);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Database";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(3, 365);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(97, 19);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Server name :";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTextBoxDatabaseUrl
            // 
            this.materialTextBoxDatabaseUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialTextBoxDatabaseUrl.AnimateReadOnly = false;
            this.materialTextBoxDatabaseUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.materialTextBoxDatabaseUrl, 3);
            this.materialTextBoxDatabaseUrl.Depth = 0;
            this.materialTextBoxDatabaseUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxDatabaseUrl.Hint = "http://localhost:";
            this.materialTextBoxDatabaseUrl.LeadingIcon = null;
            this.materialTextBoxDatabaseUrl.Location = new System.Drawing.Point(130, 349);
            this.materialTextBoxDatabaseUrl.MaxLength = 50;
            this.materialTextBoxDatabaseUrl.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDatabaseUrl.Multiline = false;
            this.materialTextBoxDatabaseUrl.Name = "materialTextBoxDatabaseUrl";
            this.materialTextBoxDatabaseUrl.Size = new System.Drawing.Size(375, 50);
            this.materialTextBoxDatabaseUrl.TabIndex = 35;
            this.materialTextBoxDatabaseUrl.Text = "localhost";
            this.materialTextBoxDatabaseUrl.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(3, 432);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(44, 19);
            this.materialLabel7.TabIndex = 36;
            this.materialLabel7.Text = "login :";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(3, 499);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(78, 19);
            this.materialLabel8.TabIndex = 37;
            this.materialLabel8.Text = "password :";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTextBoxDatabasePort
            // 
            this.materialTextBoxDatabasePort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialTextBoxDatabasePort.AnimateReadOnly = false;
            this.materialTextBoxDatabasePort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDatabasePort.Depth = 0;
            this.materialTextBoxDatabasePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBoxDatabasePort.Hint = "64342";
            this.materialTextBoxDatabasePort.LeadingIcon = null;
            this.materialTextBoxDatabasePort.Location = new System.Drawing.Point(638, 349);
            this.materialTextBoxDatabasePort.MaxLength = 50;
            this.materialTextBoxDatabasePort.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDatabasePort.Multiline = false;
            this.materialTextBoxDatabasePort.Name = "materialTextBoxDatabasePort";
            this.materialTextBoxDatabasePort.Size = new System.Drawing.Size(125, 50);
            this.materialTextBoxDatabasePort.TabIndex = 41;
            this.materialTextBoxDatabasePort.Text = "64342";
            this.materialTextBoxDatabasePort.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(639, 481);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(123, 55);
            this.materialButton1.TabIndex = 42;
            this.materialButton1.Text = "TEST";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chart-areaspline.png");
            this.imageList1.Images.SetKeyName(1, "database-cog.png");
            this.imageList1.Images.SetKeyName(2, "tools.png");
            this.imageList1.Images.SetKeyName(3, "card-account-details.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 5;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.DrawerWidth = 225;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo material design by Sullivan Buchs";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelsensor1value;
        private System.Windows.Forms.Label labelsensor1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelsensor2value;
        private System.Windows.Forms.Label labelsensor2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private System.Windows.Forms.Label labelsensor3;
        private System.Windows.Forms.Label labelsensor3value;
        private System.Windows.Forms.Label labelsensor4;
        private MaterialSkin.Controls.MaterialButton materialButtongraphplaypause;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelsensor4value;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButtonsensor1;
        private MaterialSkin.Controls.MaterialButton materialButtonsensor2;
        private MaterialSkin.Controls.MaterialButton materialButtonsensor3;
        private MaterialSkin.Controls.MaterialButton materialButtonsensor4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor1port;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor1baud;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxdatabit1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxparity1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxstopbit1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor2port;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor2baud;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxdatabit2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxparity2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxstopbit2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor3port;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor3baud;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxdatabit3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxparity3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxstopbit3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor4port;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxsensor4baud;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxdatabit4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxparity4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxstopbit4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDatabaseUrl;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDatabasePassword;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDatabaseLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDatabasePort;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}