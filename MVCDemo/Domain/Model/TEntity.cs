using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Model
{
    public abstract class TEntity
    {
        public virtual int Id { set; get; }

        public virtual string ProcessId { set; get; }

        public virtual string Remark { set; get; }
    }
}
