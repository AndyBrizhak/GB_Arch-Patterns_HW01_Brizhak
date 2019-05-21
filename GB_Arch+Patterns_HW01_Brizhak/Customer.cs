using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace GB_Arch_Patterns_HW01_Brizhak
{
    //public class Customer
    public class Customer /*: EntityBase*/
    {
        //public long Id { get; set; }
        private readonly IIdGenerator _idGenerator;
        public long Id { get; private set; }
        public string Description { get; set; }

        //public Customer()
        public Customer(IIdGenerator idGenerator)
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
