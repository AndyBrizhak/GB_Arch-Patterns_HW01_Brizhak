using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public class Store /*: EntityBase*/
    {
        private readonly IIdGenerator _idGenerator;
        //public long Id { get; set; }
        public long Id { get; private set; }

        //public Store()
        public Store(IIdGenerator idGenerator)
        {
            //Id = CalculateId();
            //Id = IdHelper.CalculateId();
            _idGenerator = idGenerator;
            Id = _idGenerator.CalculateId();
        }


        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}
    }
}
