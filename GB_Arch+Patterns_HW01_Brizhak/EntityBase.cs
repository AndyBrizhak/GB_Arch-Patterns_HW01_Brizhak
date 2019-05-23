using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator IdGenerator;

        public long Id { get; private set; }

        public EntityBase(IIdGenerator IdGenerator)
        {
            //Id = CalculateId();
            IdGenerator = this.IdGenerator ?? throw new ArgumentNullException();
            Id = IdGenerator.CalculateId();
        }

        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}
    }
}
