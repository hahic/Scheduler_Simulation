using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Common;
using Alogrithm;
using System.Linq;

namespace Scheduler_TermProject_V1
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
            GridView_GetData();
        }

        private void SubForm_Activated(object sender, EventArgs e)
        {
            label_title.Text = Text;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                DataStorge dataStorge = new DataStorge();
                List<Process> list = GridView_PutData();

                dataStorge.SaveProcesses(list);
            }
            catch
            {
                MessageBox.Show("프로세스 데이터를 Excel 파일을 저장할 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tb_processId.Text) && !String.IsNullOrWhiteSpace(tb_arriveTime.Text) && !String.IsNullOrWhiteSpace(tb_serviceTime.Text) && !String.IsNullOrWhiteSpace(tb_priority.Text) && !String.IsNullOrWhiteSpace(tb_timeQuantum.Text))
                {
                    Process process = new Process();

                    process.PID = Convert.ToString(tb_processId.Text);
                    process.arrivalTime = Convert.ToInt32(tb_arriveTime.Text);
                    process.serviceTime = Convert.ToInt32(tb_serviceTime.Text);
                    process.priority = Convert.ToDouble(tb_priority.Text);
                    process.timeQuantum = Convert.ToInt32(tb_timeQuantum.Text);

                    dgv_data.Rows.Add(process.PID, process.arrivalTime, process.serviceTime, process.priority, process.timeQuantum);
                }
                else
                {
                    MessageBox.Show("입력하지 않은 데이터가 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"해당 데이터를 추가할 수 없습니다.({ex.Message})", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tb_processId.Text = "";
                tb_arriveTime.Text = "";
                tb_serviceTime.Text = "";
                tb_priority.Text = "";
                tb_timeQuantum.Text = "";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow row in dgv_data.SelectedRows)
                    dgv_data.Rows.RemoveAt(row.Index);
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"해당 프로세스를 삭제할 수 없습니다. ({ex.Message})", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            List<Process> processes = GridView_PutData();

            try
            {
                if(processes.Count != 0)
                {
                    int timeQuantum = processes[0].timeQuantum;
                   
                    if (label_title.Text.Equals("FCFS"))
                    {
                        FCFS scheduler = new FCFS();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("HRN"))
                    {
                        HRN scheduler = new HRN();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("nonPreemptive"))
                    {
                        NonPreemptivePriority scheduler = new NonPreemptivePriority();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("Preemptive"))
                    {
                        PreemptivePriority scheduler = new PreemptivePriority();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("RoundRobin"))
                    {
                        RoundRobin scheduler = new RoundRobin(timeQuantum);

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("SJF"))
                    {
                        SJF scheduler = new SJF();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                    else if (label_title.Text.Equals("SRT"))
                    {
                        SRT scheduler = new SRT();

                        foreach (Process process in processes)
                            scheduler.AddProcess(process);

                        scheduler.Scheduling();
                        scheduler.CalculateAvgData();

                        label_avgWaitingTime.Text = scheduler.GetAvgWaitingTime();
                        label_avgReturnTime.Text = scheduler.GetAvgReturnTime();
                        label_avgResponseTime.Text = scheduler.GetAvgResponseTime();

                        Chart_PutData(scheduler.GetGantData());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"스케줄러를 실행하던 도중 에러가 발생했습니다. ({ex.Message})", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridView_GetData()
        {
            try
            {
                DataStorge dataStorge = new DataStorge();
                List<Process> list = dataStorge.GetProcesses();

                foreach (Process p in list)
                    dgv_data.Rows.Add(p.PID, p.arrivalTime, p.serviceTime, p.priority, p.timeQuantum);
            }
            catch
            {
                MessageBox.Show("Excel 파일을 불러올 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Process> GridView_PutData()
        {
            List<Process> result = new List<Process>();

            try
            {
                foreach (DataGridViewRow row in dgv_data.Rows)
                {
                    Process process = new Process();

                    process.PID = Convert.ToString(row.Cells[0].Value);
                    process.arrivalTime = Convert.ToInt32(row.Cells[1].Value);
                    process.serviceTime = Convert.ToInt32(row.Cells[2].Value);
                    process.priority = Convert.ToDouble(row.Cells[3].Value);
                    process.timeQuantum = Convert.ToInt32(row.Cells[4].Value);

                    result.Add(process);
                }
            }
            catch
            {
                result = new List<Process>();
            }

            return result;
        }

        private bool Chart_PutData(List<GantData> gantDatas)
        {
            bool result = true;

            foreach (var gant in gantDatas)
                Console.WriteLine($@"PID: {gant.PID} / arrivalTime: {gant.arrivalTime} / startTime: {gant.startTime} / runTime: {gant.runTime}");

            try
            {
                chart_gant.Series.Clear();          // 차트 초기화

                if (gantDatas.Count != 0)
                {
                    // 간트 차트 데이터 시작 시간별로 오름차순 정렬
                    gantDatas.Sort((x, y) => x.startTime.CompareTo(y.startTime));

                    // 프로세스 별로 간트 차트 데이터를 분류
                    var query = from GantData in gantDatas
                                orderby GantData.startTime ascending
                                group GantData by GantData.PID into element
                                select new
                                {
                                    pid = element.Key,
                                    datas = element
                                };

                    int count = 0;
                    foreach (var data in query)
                    {
                        chart_gant.Series.Add(data.pid);

                        chart_gant.Series[data.pid].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
                        foreach (var d in data.datas)
                            chart_gant.Series[data.pid].Points.AddXY(count, d.startTime, d.startTime + d.runTime);

                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("차트에 보여질 데이터가 없습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("차트를 생성하는 도중 에러가 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }
    }
}
