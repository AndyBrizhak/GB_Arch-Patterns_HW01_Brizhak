using System;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public class DefaultIdGenerator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
