﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BoilerEventAppl
{    // boiler class
    class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int t, int p)        {            temp = t;            pressure = p;        }
        public int getTemp()               {            return temp;                              }
        public int getPressure()           {            return pressure;        }
    } 
    // event publisher
    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);
        public event BoilerLogHandler BoilerEventLog;              //Defining event based on the above delegate
        public void LogProcess()
        {
            string remarks = "O. K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)            {                remarks = "Need Maintenance";            }
            OnBoilerEventLog("Logging Info:\n");
            OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }
         protected void OnBoilerEventLog(string message)          {  if (BoilerEventLog != null)  {  BoilerEventLog(message); }  }
    }

    // this class keeps a provision for writing into the log file
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;
        public BoilerInfoLogger(string filename)  {   fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                                                      sw = new StreamWriter(fs);
                                                  }
        public void Logger(string info)           {         sw.WriteLine(info);        }
        public void Close()                       {         sw.Close();    fs.Close(); }
    }

    // The event subscriber
    public class RecordBoilerInfo
    {
        static void Logger(string info)        {            Console.WriteLine(info);        }//end of Logger
        static void Main(string[] args)
        {
            BoilerInfoLogger filelog = new BoilerInfoLogger("e:\\boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new
            DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new
            DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            filelog.Close();
        }//end of main
    }//end of RecordBoilerInfo
}