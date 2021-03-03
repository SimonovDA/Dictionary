using Dictionary.Web.Models;

namespace Dictionary.Data.Models
{
    public class User : BaseEntry
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User()
        {

        }
        public User(string name, int age) : base()
        {
            Name = name;
            Age = age;
        }

        public static User CreatingUser(WebUser user)
        {
            return new User(user.Name, user.Age);
        }
    }
}
