using Project_ENTITIES.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ENTITIES.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreateDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
