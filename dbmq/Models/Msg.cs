using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;




namespace dbmq.Models
{
    public class Msg
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime data { get; set; }
        public String host { get; set; }
        public String msg { get; set; }

        public Msg()
        {
            this.host = Environment.MachineName;
        }

        public Msg (string msg)
            :this()
        {
            this.msg = msg;            
        }
    }
}



