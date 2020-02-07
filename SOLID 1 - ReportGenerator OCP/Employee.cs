namespace ReportGenerator
{
    public class Employee
    {
        public Employee() : this("", 0,0)
        {
        }

        public Employee(string name, uint salary, int age)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }

        private string name_;
        private uint salary_;
        private int age_;

        public string Name {
            get
            {
                return name_;
            }
            set
            {
                name_ = value;
            }
        }
        public uint Salary 
        {
            get
            {
                return salary_;
            }
            private set
            {
                salary_ = value;
            }
        }

        public int Age
        {
            get
            {
                return age_;
            }
            set
            {
                age_ = value;
            }
        }
    }
}