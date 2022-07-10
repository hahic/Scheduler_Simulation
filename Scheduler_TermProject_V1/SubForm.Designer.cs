
namespace Scheduler_TermProject_V1
{
    partial class SubForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm));
            this.label_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_timeQuantum = new System.Windows.Forms.TextBox();
            this.tb_priority = new System.Windows.Forms.TextBox();
            this.tb_serviceTime = new System.Windows.Forms.TextBox();
            this.tb_arriveTime = new System.Windows.Forms.TextBox();
            this.tb_processId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_avgResponseTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_avgReturnTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_avgWaitingTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart_gant = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.processId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeQuantum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("둥근모꼴", 60F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(67, 61);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(936, 108);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Name";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("둥근모꼴", 19F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(55, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "| Process";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_timeQuantum);
            this.panel1.Controls.Add(this.tb_priority);
            this.panel1.Controls.Add(this.tb_serviceTime);
            this.panel1.Controls.Add(this.tb_arriveTime);
            this.panel1.Controls.Add(this.tb_processId);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(61, 280);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 80);
            this.panel1.TabIndex = 4;
            // 
            // tb_timeQuantum
            // 
            this.tb_timeQuantum.Location = new System.Drawing.Point(750, 38);
            this.tb_timeQuantum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_timeQuantum.Name = "tb_timeQuantum";
            this.tb_timeQuantum.Size = new System.Drawing.Size(147, 25);
            this.tb_timeQuantum.TabIndex = 12;
            // 
            // tb_priority
            // 
            this.tb_priority.Location = new System.Drawing.Point(570, 38);
            this.tb_priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_priority.Name = "tb_priority";
            this.tb_priority.Size = new System.Drawing.Size(147, 25);
            this.tb_priority.TabIndex = 11;
            // 
            // tb_serviceTime
            // 
            this.tb_serviceTime.Location = new System.Drawing.Point(393, 38);
            this.tb_serviceTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_serviceTime.Name = "tb_serviceTime";
            this.tb_serviceTime.Size = new System.Drawing.Size(147, 25);
            this.tb_serviceTime.TabIndex = 10;
            // 
            // tb_arriveTime
            // 
            this.tb_arriveTime.Location = new System.Drawing.Point(219, 38);
            this.tb_arriveTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_arriveTime.Name = "tb_arriveTime";
            this.tb_arriveTime.Size = new System.Drawing.Size(147, 25);
            this.tb_arriveTime.TabIndex = 9;
            // 
            // tb_processId
            // 
            this.tb_processId.Location = new System.Drawing.Point(42, 38);
            this.tb_processId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_processId.Name = "tb_processId";
            this.tb_processId.Size = new System.Drawing.Size(147, 25);
            this.tb_processId.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label14.Location = new System.Drawing.Point(570, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "우선 순위";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label13.Location = new System.Drawing.Point(750, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "시간 할당량";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label12.Location = new System.Drawing.Point(219, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "도착 시간";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label1.Location = new System.Drawing.Point(393, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "서비스 시간";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label11.Location = new System.Drawing.Point(42, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "프로세스 ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_avgResponseTime);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label_avgReturnTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label_avgWaitingTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(61, 741);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 76);
            this.panel2.TabIndex = 5;
            // 
            // label_avgResponseTime
            // 
            this.label_avgResponseTime.AutoSize = true;
            this.label_avgResponseTime.Font = new System.Drawing.Font("둥근모꼴", 13F, System.Drawing.FontStyle.Bold);
            this.label_avgResponseTime.Location = new System.Drawing.Point(793, 24);
            this.label_avgResponseTime.Name = "label_avgResponseTime";
            this.label_avgResponseTime.Size = new System.Drawing.Size(58, 22);
            this.label_avgResponseTime.TabIndex = 16;
            this.label_avgResponseTime.Text = "Null";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label10.Location = new System.Drawing.Point(643, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "평균 응답 시간 : ";
            // 
            // label_avgReturnTime
            // 
            this.label_avgReturnTime.AutoSize = true;
            this.label_avgReturnTime.Font = new System.Drawing.Font("둥근모꼴", 13F, System.Drawing.FontStyle.Bold);
            this.label_avgReturnTime.Location = new System.Drawing.Point(512, 24);
            this.label_avgReturnTime.Name = "label_avgReturnTime";
            this.label_avgReturnTime.Size = new System.Drawing.Size(58, 22);
            this.label_avgReturnTime.TabIndex = 14;
            this.label_avgReturnTime.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label8.Location = new System.Drawing.Point(361, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "평균 반환 시간 : ";
            // 
            // label_avgWaitingTime
            // 
            this.label_avgWaitingTime.AutoSize = true;
            this.label_avgWaitingTime.Font = new System.Drawing.Font("둥근모꼴", 13F, System.Drawing.FontStyle.Bold);
            this.label_avgWaitingTime.Location = new System.Drawing.Point(232, 24);
            this.label_avgWaitingTime.Name = "label_avgWaitingTime";
            this.label_avgWaitingTime.Size = new System.Drawing.Size(58, 22);
            this.label_avgWaitingTime.TabIndex = 12;
            this.label_avgWaitingTime.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("둥근모꼴", 10F);
            this.label5.Location = new System.Drawing.Point(82, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "평균 대기 시간 : ";
            // 
            // chart_gant
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_gant.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_gant.Legends.Add(legend1);
            this.chart_gant.Location = new System.Drawing.Point(61, 840);
            this.chart_gant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_gant.Name = "chart_gant";
            this.chart_gant.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Font = new System.Drawing.Font("둥근모꼴", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "P01";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series2.Legend = "Legend1";
            series2.Name = "P02";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series3.Legend = "Legend1";
            series3.Name = "P03";
            series3.YValuesPerPoint = 2;
            this.chart_gant.Series.Add(series1);
            this.chart_gant.Series.Add(series2);
            this.chart_gant.Series.Add(series3);
            this.chart_gant.Size = new System.Drawing.Size(935, 372);
            this.chart_gant.TabIndex = 6;
            this.chart_gant.Text = "Gant Chart";
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processId,
            this.arriveTime,
            this.serviceTime,
            this.priority,
            this.timeQuantum});
            this.dgv_data.Location = new System.Drawing.Point(61, 382);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 27;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(935, 168);
            this.dgv_data.TabIndex = 7;
            // 
            // processId
            // 
            this.processId.HeaderText = "프로세스 ID";
            this.processId.MinimumWidth = 6;
            this.processId.Name = "processId";
            this.processId.ReadOnly = true;
            // 
            // arriveTime
            // 
            this.arriveTime.HeaderText = "도착 시간";
            this.arriveTime.MinimumWidth = 6;
            this.arriveTime.Name = "arriveTime";
            this.arriveTime.ReadOnly = true;
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "서비스 시간";
            this.serviceTime.MinimumWidth = 6;
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.ReadOnly = true;
            // 
            // priority
            // 
            this.priority.HeaderText = "우선 순위";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // timeQuantum
            // 
            this.timeQuantum.HeaderText = "시간 할당량";
            this.timeQuantum.MinimumWidth = 6;
            this.timeQuantum.Name = "timeQuantum";
            this.timeQuantum.ReadOnly = true;
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("둥근모꼴", 14F);
            this.btn_run.Location = new System.Drawing.Point(61, 572);
            this.btn_run.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(157, 58);
            this.btn_run.TabIndex = 8;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("둥근모꼴", 14F);
            this.btn_add.Location = new System.Drawing.Point(675, 572);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(157, 58);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("둥근모꼴", 14F);
            this.btn_delete.Location = new System.Drawing.Point(839, 572);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(157, 58);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("둥근모꼴", 19F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(55, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "| Result";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("둥근모꼴", 14F);
            this.btn_save.Location = new System.Drawing.Point(512, 572);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(157, 58);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1059, 930);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.chart_gant);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.Activated += new System.EventHandler(this.SubForm_Activated);
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_avgWaitingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox tb_timeQuantum;
        private System.Windows.Forms.TextBox tb_priority;
        private System.Windows.Forms.TextBox tb_serviceTime;
        private System.Windows.Forms.TextBox tb_arriveTime;
        private System.Windows.Forms.TextBox tb_processId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_avgResponseTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_avgReturnTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn processId;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeQuantum;
    }
}