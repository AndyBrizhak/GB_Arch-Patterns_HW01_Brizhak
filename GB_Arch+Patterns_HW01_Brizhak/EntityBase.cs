using System;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public abstract class EntityBase
    {
        private readonly IIdGenerator idGenerator;

        public long Id { get; private set; }

        public EntityBase(IIdGenerator IdGenerator)
        {
            //Id = CalculateId();
            idGenerator = IdGenerator ?? throw new ArgumentNullException();
            Id = IdGenerator.CalculateId();
        }

        //private long CalculateId()
        //{
        //    long id = DateTime.Now.Ticks;
        //    return id;
        //}
    }
}
