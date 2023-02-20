using System.Net.WebSockets;

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

        public Statistics GetStatisticsWithForeach()
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

        public Statistics GetStatisticsWithFor()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            for (var i=0; i<grades.Count; i++)
            {
                statistics1.Max = Math.Max(statistics1.Max, grades[i]);
                statistics1.Min = Math.Min(statistics1.Min, grades[i]);
                statistics1.Average = statistics1.Average + grades[i];
            }

            statistics1.Average = statistics1.Average / this.grades.Count;

            return statistics1;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics2.Max = Math.Max(statistics2.Max, grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, grades[index]);
                statistics2.Average = statistics2.Average + grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics2.Average = statistics2.Average / this.grades.Count;

            return statistics2;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;

            var index = 0;
            while (index < this.grades.Count)
            {
                statistics3.Max = Math.Max(statistics3.Max, grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, grades[index]);
                statistics3.Average = statistics3.Average + grades[index];
                index++;
            } 

            statistics3.Average = statistics3.Average / this.grades.Count;

            return statistics3;
        }
    }
}
