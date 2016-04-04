using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHTModels.config
{
    public class config
    {
        /// <summary>
        /// key
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public dynamic value { get; set; }

        /// <summary>
        /// 配置项说明
        /// </summary>
        public string remark { get; set; }
    }
}
