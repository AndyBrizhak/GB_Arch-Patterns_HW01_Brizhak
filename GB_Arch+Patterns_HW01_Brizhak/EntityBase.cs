using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }

        public EntityBase()
        {
            //Id = CalculateId();
            Id = _idGenerator.CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
