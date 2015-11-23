using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Data.Models
{
    public class 单位表 : BaseModel
    {
        public int 上级ID { get; set; }
        public string 代码 { get; set; }
        public string 名称 { get; set; }
        public string 拼音 { get; set; }
    }
}
