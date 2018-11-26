using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace IDS.Source
{
    class SnoopProcess
    {
        public string name { set; get; }
        public int id { get; set; }

        public SnoopProcess(Process p)
        {
            name = p.ProcessName;
        }

        public override string ToString()
        {
            return name;
        }
    }

    static class ProcessSnoop
    {
        static private Thread counterThread;
        static volatile private Boolean running;
        static volatile private Boolean cancel;
        static private PerformanceCounter cpuCounter;
        static private PerformanceCounter memCounter;
        static public Process[] processList;
        static public Process processToMonitor { get; set; }

        static public void updateProcessList()
        {
            processList = Process.GetProcesses();
        }

        static public void runAsync()
        {
            if (!running)
            {
                counterThread = new Thread(ProcessSnoop.asyncMonitor);
                counterThread.IsBackground = true;
                counterThread.Start();
            }
        }

        static public void cancelAsync()
        {
            if (running && counterThread != null)
            {
                cancel = true;
            }
        }

        static private void asyncMonitor()
        {
            if (processToMonitor == null)
            {
                running = false;
                return;
            }
 
            cpuCounter = new PerformanceCounter("Process", "% Processor Time", processToMonitor.ProcessName);
            cpuCounter = new PerformanceCounter("Process", "Working Set", processToMonitor.ProcessName);
            updateCounters();

            while (!cancel)
            {
                Thread.Sleep(100);
                updateCounters();
            }

            cancel = false;
            running = false;
        }


        static private void updateCounters()
        {
            cpuCounter.NextValue();
            memCounter.NextSample();
        }

    }
}
