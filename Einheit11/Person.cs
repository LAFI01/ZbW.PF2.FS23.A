using MyColor = Einheit11.Color;
using SystemColor = System.Drawing;
namespace Einheit11
{
    public class Person
    {
        public int Age { get; set; }
        private string _name;
        private string _firstName;
        private int _age;

        public Person() : this("default", "default", 3)
        {

        }

        public void SetHairColor(string color)
        {
            var c = MyColor.Color.Name;
            var color2 = SystemColor.Color.AliceBlue;
        }

        public Person(string firstName, string name, int age)
        {
            FirstName = firstName;
            Name = name;
            Age = age;
        }

        public string FirstName { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string GetData()
        {
            return Name + " " + FirstName + " " + _age;
        }


    }
}
