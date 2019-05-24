
namespace GB_Arch_Patterns_HW01_Brizhak
{
    
    public class Customer : EntityBase
    {
        
        public string Description { get; set; }

        
        public Customer(IIdGenerator idGenerator) : base (idGenerator)
        {
            
        }
       
    }
}
