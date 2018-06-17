﻿namespace ChartJS
{
	partial class MainPage
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
			Wisej.Web.Ext.ChartJS.LineDataSet lineDataSet1 = new Wisej.Web.Ext.ChartJS.LineDataSet();
			Wisej.Web.Ext.ChartJS.LineOptions lineOptions1 = new Wisej.Web.Ext.ChartJS.LineOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX1 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.BarDataSet barDataSet1 = new Wisej.Web.Ext.ChartJS.BarDataSet();
			Wisej.Web.Ext.ChartJS.BarOptions barOptions1 = new Wisej.Web.Ext.ChartJS.BarOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX2 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.RadarDataSet radarDataSet1 = new Wisej.Web.Ext.ChartJS.RadarDataSet();
			Wisej.Web.Ext.ChartJS.RadarOptions radarOptions1 = new Wisej.Web.Ext.ChartJS.RadarOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX3 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.PolarAreaDataSet polarAreaDataSet1 = new Wisej.Web.Ext.ChartJS.PolarAreaDataSet();
			Wisej.Web.Ext.ChartJS.PolarAreaOptions polarAreaOptions1 = new Wisej.Web.Ext.ChartJS.PolarAreaOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX4 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.DoughnutDataSet doughnutDataSet1 = new Wisej.Web.Ext.ChartJS.DoughnutDataSet();
			Wisej.Web.Ext.ChartJS.DoughnutOptions doughnutOptions1 = new Wisej.Web.Ext.ChartJS.DoughnutOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX5 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.PieDataSet pieDataSet1 = new Wisej.Web.Ext.ChartJS.PieDataSet();
			Wisej.Web.Ext.ChartJS.PieOptions pieOptions1 = new Wisej.Web.Ext.ChartJS.PieOptions();
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX6 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.chartJS2 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.chartJS4 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.chartJS6 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.chartJS5 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.chartJS3 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.flowLayoutPanel2 = new Wisej.Web.FlowLayoutPanel();
			this.button1 = new Wisej.Web.Button();
			this.panel1 = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.trackBar = new Wisej.Web.TrackBar();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.chartJS1);
			this.flowLayoutPanel1.Controls.Add(this.chartJS2);
			this.flowLayoutPanel1.Controls.Add(this.chartJS4);
			this.flowLayoutPanel1.Controls.Add(this.chartJS6);
			this.flowLayoutPanel1.Controls.Add(this.chartJS5);
			this.flowLayoutPanel1.Controls.Add(this.chartJS3);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(67, 241);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1114, 640);
			this.flowLayoutPanel1.TabIndex = 15;
			// 
			// chartJS1
			// 
			this.chartJS1.AppearanceKey = "chartjs";
			lineDataSet1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
			lineDataSet1.BorderColor = System.Drawing.Color.Crimson;
			lineDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12};
			lineDataSet1.Fill = true;
			lineDataSet1.Label = "Data Set";
			this.chartJS1.DataSets.Add(lineDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS1, 100);
			this.chartJS1.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS1.Location = new System.Drawing.Point(10, 10);
			this.chartJS1.Margin = new Wisej.Web.Padding(10);
			this.chartJS1.MinimumSize = new System.Drawing.Size(300, 300);
			this.chartJS1.Name = "chartJS1";
			lineOptions1.Legend.Display = false;
			optionScalesAxesX1.ScaleLabel.Display = false;
			lineOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX1};
			this.chartJS1.Options = lineOptions1;
			this.chartJS1.Size = new System.Drawing.Size(537, 300);
			this.chartJS1.TabIndex = 3;
			this.chartJS1.Text = "Line Chart";
			this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// chartJS2
			// 
			this.chartJS2.AppearanceKey = "chartjs";
			this.chartJS2.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Bar;
			barDataSet1.BackgroundColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(123)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(118))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(224)))), ((int)(((byte)(208))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))))};
			barDataSet1.BorderColor = null;
			barDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12};
			barDataSet1.HoverBackgroundColor = null;
			barDataSet1.Label = "Data Set";
			this.chartJS2.DataSets.Add(barDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS2, 100);
			this.flowLayoutPanel1.SetFlowBreak(this.chartJS2, true);
			this.chartJS2.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS2.Location = new System.Drawing.Point(567, 10);
			this.chartJS2.Margin = new Wisej.Web.Padding(10);
			this.chartJS2.MinimumSize = new System.Drawing.Size(300, 300);
			this.chartJS2.Name = "chartJS2";
			optionScalesAxesX2.ScaleLabel.Display = false;
			barOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX2};
			barOptions1.Title.Text = "Bar Chart";
			this.chartJS2.Options = barOptions1;
			this.chartJS2.Size = new System.Drawing.Size(537, 300);
			this.chartJS2.TabIndex = 4;
			this.chartJS2.Text = "Bar Chart";
			this.chartJS2.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// chartJS4
			// 
			this.chartJS4.AppearanceKey = "chartjs";
			this.chartJS4.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Radar;
			radarDataSet1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
			radarDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12};
			radarDataSet1.Label = "Data Set";
			this.chartJS4.DataSets.Add(radarDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS4, 100);
			this.chartJS4.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS4.Location = new System.Drawing.Point(10, 330);
			this.chartJS4.Margin = new Wisej.Web.Padding(10);
			this.chartJS4.MinimumSize = new System.Drawing.Size(200, 200);
			this.chartJS4.Name = "chartJS4";
			optionScalesAxesX3.Display = false;
			optionScalesAxesX3.ScaleLabel.Display = false;
			radarOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX3};
			this.chartJS4.Options = radarOptions1;
			this.chartJS4.Size = new System.Drawing.Size(258, 300);
			this.chartJS4.TabIndex = 6;
			this.chartJS4.Text = "Radar Chart";
			this.chartJS4.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// chartJS6
			// 
			this.chartJS6.AppearanceKey = "chartjs";
			this.chartJS6.ChartType = Wisej.Web.Ext.ChartJS.ChartType.PolarArea;
			polarAreaDataSet1.BackgroundColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(123)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(118))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(224)))), ((int)(((byte)(208))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))))};
			polarAreaDataSet1.BorderColor = null;
			polarAreaDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        0};
			polarAreaDataSet1.HoverBackgroundColor = null;
			polarAreaDataSet1.Label = "Data Set";
			this.chartJS6.DataSets.Add(polarAreaDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS6, 100);
			this.chartJS6.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS6.Location = new System.Drawing.Point(288, 330);
			this.chartJS6.Margin = new Wisej.Web.Padding(10);
			this.chartJS6.MinimumSize = new System.Drawing.Size(200, 200);
			this.chartJS6.Name = "chartJS6";
			polarAreaOptions1.Legend.Display = false;
			optionScalesAxesX4.Display = false;
			optionScalesAxesX4.ScaleLabel.Display = false;
			polarAreaOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX4};
			this.chartJS6.Options = polarAreaOptions1;
			this.chartJS6.Size = new System.Drawing.Size(258, 300);
			this.chartJS6.TabIndex = 8;
			this.chartJS6.Text = "Polar Area Chart";
			this.chartJS6.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// chartJS5
			// 
			this.chartJS5.AppearanceKey = "chartjs";
			this.chartJS5.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Doughnut;
			doughnutDataSet1.BackgroundColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(123)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(118))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(224)))), ((int)(((byte)(208))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))))};
			doughnutDataSet1.BorderColor = null;
			doughnutDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        0};
			doughnutDataSet1.HoverBackgroundColor = null;
			doughnutDataSet1.Label = "Data Set";
			this.chartJS5.DataSets.Add(doughnutDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS5, 100);
			this.chartJS5.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS5.Location = new System.Drawing.Point(566, 330);
			this.chartJS5.Margin = new Wisej.Web.Padding(10);
			this.chartJS5.MinimumSize = new System.Drawing.Size(200, 200);
			this.chartJS5.Name = "chartJS5";
			doughnutOptions1.Legend.Display = false;
			optionScalesAxesX5.Display = false;
			optionScalesAxesX5.ScaleLabel.Display = false;
			doughnutOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX5};
			doughnutOptions1.Title.Text = "Doughnut Chart";
			this.chartJS5.Options = doughnutOptions1;
			this.chartJS5.Size = new System.Drawing.Size(259, 300);
			this.chartJS5.TabIndex = 7;
			this.chartJS5.Text = "Doughnut Chart";
			this.chartJS5.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// chartJS3
			// 
			this.chartJS3.AppearanceKey = "chartjs";
			this.chartJS3.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Pie;
			pieDataSet1.BackgroundColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(123)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(118))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(130)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(224)))), ((int)(((byte)(208))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))))};
			pieDataSet1.BorderColor = null;
			pieDataSet1.Data = new object[] {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12};
			pieDataSet1.HoverBackgroundColor = null;
			pieDataSet1.Label = "Data Set";
			this.chartJS3.DataSets.Add(pieDataSet1);
			this.flowLayoutPanel1.SetFillWeight(this.chartJS3, 100);
			this.chartJS3.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
			this.chartJS3.Location = new System.Drawing.Point(845, 330);
			this.chartJS3.Margin = new Wisej.Web.Padding(10);
			this.chartJS3.MinimumSize = new System.Drawing.Size(200, 200);
			this.chartJS3.Name = "chartJS3";
			pieOptions1.Legend.Display = false;
			optionScalesAxesX6.Display = false;
			optionScalesAxesX6.ScaleLabel.Display = false;
			pieOptions1.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX6};
			this.chartJS3.Options = pieOptions1;
			this.chartJS3.Size = new System.Drawing.Size(259, 300);
			this.chartJS3.TabIndex = 5;
			this.chartJS3.Text = "Pie Chart";
			this.chartJS3.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel2.Controls.Add(this.button1);
			this.flowLayoutPanel2.Controls.Add(this.panel1);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(67, 40);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Padding = new Wisej.Web.Padding(0, 15, 0, 0);
			this.flowLayoutPanel2.Size = new System.Drawing.Size(1114, 169);
			this.flowLayoutPanel2.TabIndex = 16;
			this.flowLayoutPanel2.WrapContents = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.button1.AppearanceKey = "button-ok";
			this.flowLayoutPanel2.SetFillWeight(this.button1, 100);
			this.button1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(3, 18);
			this.button1.Margin = new Wisej.Web.Padding(3, 3, 20, 3);
			this.button1.MinimumSize = new System.Drawing.Size(150, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(645, 128);
			this.button1.TabIndex = 1;
			this.button1.Text = "Randomize";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar);
			this.panel1.Location = new System.Drawing.Point(671, 18);
			this.panel1.MaximumSize = new System.Drawing.Size(440, 128);
			this.panel1.MinimumSize = new System.Drawing.Size(440, 128);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 128);
			this.panel1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.Location = new System.Drawing.Point(12, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 82);
			this.label1.TabIndex = 10;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// trackBar
			// 
			this.trackBar.Location = new System.Drawing.Point(26, 86);
			this.trackBar.Maximum = 5000;
			this.trackBar.Name = "trackBar";
			this.trackBar.Size = new System.Drawing.Size(387, 34);
			this.trackBar.TabIndex = 11;
			this.trackBar.TickFrequency = 200;
			this.trackBar.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBar.Value = 300;
			// 
			// MainPage
			// 
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(0, 50);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1230, 874);
			this.Load += new System.EventHandler(this.ChartsPage_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS1;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS2;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS4;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS6;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS5;
		private Wisej.Web.Ext.ChartJS.ChartJS chartJS3;
		private Wisej.Web.FlowLayoutPanel flowLayoutPanel2;
		private Wisej.Web.Button button1;
		private Wisej.Web.Panel panel1;
		private Wisej.Web.Label label1;
		private Wisej.Web.TrackBar trackBar;
	}
}