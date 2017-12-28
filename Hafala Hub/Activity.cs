using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafala_Hub
{
    public class Activity
    {
        public int ID { get; private set; }
        public string header { get; private set; }
        public string summary { get; private set; }
        public int severity { get; private set; }
        public string inserter { get; private set; }
        public string leaders { get; private set; }
        public string startDateTime { get; private set; }
        public string endDateTime { get; private set; }
        public char started { get; private set; }
        public char paused { get; private set; }
        public char stopped { get; private set; }

        public Activity(int ID, string Header, string Summary, int Severity, string Inserter, string Leaders, string StartDateTime, string EndDateTime, char Started, char Paused, char Stopped)
        {
            this.ID = ID;
            this.header = Header;
            this.summary = Summary;
            this.severity = Severity;
            this.inserter = inserter;
            this.leaders = Leaders;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.started = Started;
            this.paused = Paused;
            this.stopped = Stopped;
        }

        public string StartDateTime { get => startDateTime; set => startDateTime = value; }
        public string EndDateTime { get => endDateTime; set => endDateTime = value; }


        /*public double getActivityProgress()
        {
            double progressPrecent = 0.0;

            DateTime currTime = DateTime.Now;

            int startEndDiff = this.endDateTime.Second - this.startDateTime.Second;
            int elapsedTime = currTime.Second - this.startDateTime.Second;


            progressPrecent = elapsedTime / startEndDiff;


            /*Convet to precent*/
            /*progressPrecent *= 100;

            return progressPrecent;
        }*/
    }
}
