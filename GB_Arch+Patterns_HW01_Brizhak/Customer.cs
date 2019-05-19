using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace GB_Arch_Patterns_HW01_Brizhak
{
    //public class Customer
    public class Customer : EntityBase
    {
        public long Id { get; set; }
        public string Description { get; set; }

        public Customer()
        {
            //Id = CalculateId();
            //Id = IdHelper.CalculateId();
        }



        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}
    }
}
