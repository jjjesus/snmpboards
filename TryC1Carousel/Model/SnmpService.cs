using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TryC1Carousel.Model
{
    public class SnmpService
    {
        private BackgroundWorker _bw;

        public SnmpService()
        {
            this._bw = new BackgroundWorker();
            this._bw.DoWork += new DoWorkEventHandler(doBackgroundWork);
        }
        public void Run()
        {
            this._bw.RunWorkerAsync();
        }
        private void doBackgroundWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(3000);
                doSnmp();
            }
        }
        private void doSnmp()
        {
            // Do SNMP stuff here
            Debug.WriteLine("SNMP stuff");
        }

        public void Dispose()
        {
        }
    }
}
