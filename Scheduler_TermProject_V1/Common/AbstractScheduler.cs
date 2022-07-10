using System;
using System.IO;
using System.Collections.Generic;

namespace Common
{
    // 프로세스 정보 구조체
    struct Process
    {
        public String PID;
        public int arrivalTime;
        public int serviceTime;
        public double priority;
        public int timeQuantum;

        public Process(String PID, int arrivalTime, int serviceTime, int priority = 0, int timeQuantum = 0)
        {
            this.PID = PID;
            this.arrivalTime = arrivalTime;
            this.serviceTime = serviceTime;
            this.priority = priority;
            this.timeQuantum = timeQuantum;
        }
    }

    // 간트 차트 데이터 구조체
    struct GantData
    {
        public String PID;
        public int arrivalTime;
        public int startTime;
        public int runTime;

        public GantData(String PID, int arrivalTime, int startTime, int runTime)
        {
            this.PID = PID;
            this.arrivalTime = arrivalTime;
            this.startTime = startTime;
            this.runTime = runTime;
        }
    }

    // 간트 차트 구조체
    class GantChart
    {
        protected const string ProcesserLatency = "Sleep";      // 아무 프로세스도 수행하지 않는 상태를 나타냄
        protected List<GantData> gant;

        public GantChart()
        {
            gant = new List<GantData>();
        }

        // 간트 차트 데이터 추가 함수(process.serviceTime == runTime)
        public void AddGantData(Process process, int startTime)
        {
            if(gant.Count != 0 && gant[gant.Count-1].PID == process.PID)
            {
                GantData g = gant[gant.Count - 1];
                g.runTime += process.serviceTime;
                gant[gant.Count - 1] = g;
            }
            else
                gant.Add(new GantData(process.PID, process.arrivalTime, startTime, process.serviceTime));
        }

        // 간트 차트 데이터 추가 함수
        public void AddGantData(Process process, int startTime, int runnigTime)
        {
            if (gant.Count != 0 && gant[gant.Count - 1].PID == process.PID)
            {
                GantData g = gant[gant.Count - 1];
                g.runTime += runnigTime;
                gant[gant.Count - 1] = g;
            }
            else
                gant.Add(new GantData(process.PID, process.arrivalTime, startTime, runnigTime));
        }

        // 간트 차트 데이터 추가 함수(Sleep상태 추가)
        public void AddGantData(int startTime, int runTime)
        {
            gant.Add(new GantData(ProcesserLatency, 0, startTime, runTime));
        }

        public List<GantData> GetGantData()
        {
            List<GantData> result = new List<GantData>();

            try
            {
                result = this.gant;
            }
            catch(Exception ex)
            {
                result = new List<GantData>();
            }

            return result;
        }
    }


    // 스케줄링 알고리즘의 추상 클래스
    abstract class AbstractScheduler : GantChart
    {
        protected List<Process> processList;

        protected double avgWaitingTime;
        protected double avgReturnTime;
        protected double avgResponseTime;

        public AbstractScheduler()
        {
            processList = new List<Process>();
            avgWaitingTime = 0;
            avgReturnTime = 0;
            avgResponseTime = 0;
        }

        // 프로세스 추가 함수
        public void AddProcess(Process process)
        {
            processList.Add(process);
            processList.Sort(new ProcessComparer());
        }

        // 프로세스 리스트 졍렬을 위한 클래스
        class ProcessComparer : IComparer<Process>
        {
            public int Compare(Process x, Process y)
            {
                return x.arrivalTime.CompareTo(y.arrivalTime);
            }
        }

        public bool FileLoad()
        {
            bool result = true;

            try
            {
                DataStorge dataStorge = new DataStorge();
                List<Process> processes = dataStorge.GetProcesses();

                foreach(Process p in processes)
                    processList.Add(p);

                processList.Sort(new ProcessComparer());        //프로세스 리스트를 도착시간 순서로 정렬
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool FileLoad(string fileLocation, string fileName)
        {
            bool result = true;

            try
            {
                DataStorge dataStorge = new DataStorge(fileLocation, fileName);
                List<Process> processes = dataStorge.GetProcesses();

                foreach (Process p in processes)
                    processList.Add(p);

                processList.Sort(new ProcessComparer());        //프로세스 리스트를 도착시간 순서로 정렬
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool ProcessListIsEmpty()
        {
            return (processList.Count == 0);
        }

        public abstract void Scheduling(); //스케줄링(간트차트 생성)을 수행하는 함수

        public abstract void CalculateAvgData(); //간트차트를 이용하여 평균 데이터를 계산 함수

        public string GetAvgWaitingTime()
        {
            string result = "NULL";

            try
            {
                result = avgWaitingTime.ToString("0.##");
            }
            catch
            {
                result = "NULL";
            }

            return result;
        }

        public string GetAvgReturnTime()
        {
            string result = "NULL";

            try
            {
                result = avgReturnTime.ToString("0.##");
            }
            catch
            {
                result = "NULL";
            }

            return result;
        }

        public string GetAvgResponseTime()
        {
            string result = "NULL";

            try
            {
                result = avgResponseTime.ToString("0.##");
            }
            catch
            {
                result = "NULL";
            }

            return result;
        }

        public int GetProcessCount()
        {
            int result = 0;

            try
            {
                result = this.processList.Count;
            }
            catch(Exception ex)
            {
                result = 0;
            }

            return result;
        }
    }

    //비선점 스케줄링 알고리즘의 평균 데이터 계산 함수를 구현한 클래스
    abstract class NonPreemptiveScheduler : AbstractScheduler
    {
        public override void CalculateAvgData()
        {
            for (int i = 0; i < gant.Count; i++)
            {
                if (gant[i].PID == GantChart.ProcesserLatency) continue;
                avgWaitingTime += (gant[i].startTime - gant[i].arrivalTime);
                avgReturnTime += (gant[i].startTime + gant[i].runTime - gant[i].arrivalTime);
            }
            avgReturnTime /= processList.Count;
            avgWaitingTime /= processList.Count;
            avgResponseTime = avgWaitingTime;
        }
    }

    //선점 스케줄링 알고리즘의 평균 데이터 계산 함수를 구현한 클래스
    abstract class PreemptiveScheduler : AbstractScheduler
    {
        public override void CalculateAvgData()
        {
            int sum = 0;
            for(int i= 0; i < processList.Count; i++)
            {
                for(int j = 0; j < gant.Count; j++)
                {
                    if(processList[i].PID == gant[j].PID)
                    {
                        avgResponseTime += gant[j].startTime - gant[j].arrivalTime;
                        break;
                    }
                }
                for(int j = gant.Count - 1; j >= 0; j--)
                {
                    if (processList[i].PID == gant[j].PID)
                    {
                        avgReturnTime += gant[j].startTime + gant[j].runTime - gant[j].arrivalTime;
                        break;
                    }
                }
                sum += processList[i].serviceTime;
            }
            avgWaitingTime = avgReturnTime - sum;

            avgReturnTime /= processList.Count;
            avgWaitingTime /= processList.Count;
            avgResponseTime /= processList.Count;
        }
    }
}
