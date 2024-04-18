namespace Model
{
    public class Person : BaseEntity
    {
        public Address Address { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string PassWord { get; set; }
        public int MyProperty { get; set; }
        public int Phone { get; set; }
        public string UserName { get; set; }
    }
}