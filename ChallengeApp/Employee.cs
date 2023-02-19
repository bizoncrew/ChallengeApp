namespace ChallengeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }

        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            if(grade <= float.MaxValue)
            {
                this.AddGrade((float)grade);
            }
            else
            {
                Console.WriteLine("Doble is not float");
            }
        }

        public void AddGrade(int grade)
        {
            int valueInint = (int)grade;
            if(valueInint >= 0 && valueInint <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Int is not float");
            }
        }

        public void AddGrade(long grade)
        {
            long valueInLong = (long)grade;
            if (valueInLong >= 0 && valueInLong <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Long is not a float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}
