using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace DHTServer
{
    public partial class MainService : ServiceBase
    {
        private string localpath;
        private string configpath;
        public MainService()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 服务启动
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            localpath = AppDomain.CurrentDomain.BaseDirectory;  //程序所在文件夹
            configpath = string.Format(@"{0}\config.json", localpath);
        }

        protected override void OnStop()
        {
        }
    }
}
