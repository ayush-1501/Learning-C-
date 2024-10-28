

namespace Design.Model
{
    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
    }
}
