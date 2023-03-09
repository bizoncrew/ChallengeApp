
namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
            public List<float> grades = new List<float>();

            public Supervisor(string name, string surname)

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
                    throw new Exception("invalid grade value");
                }
            }

            public void AddGrade(char grade)
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        this.grades.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        this.grades.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        this.grades.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        this.grades.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");
                }
            }

            public void AddGrade(string grade)
            {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6" or "6-":
                    this.grades.Add(95);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "+5" or "5+":
                    this.grades.Add(85);
                    break;
                case "-5" or "5-":
                    this.grades.Add(75);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "+4" or "4+":
                    this.grades.Add(65);
                    break;
                case "-4" or "-4":
                    this.grades.Add(55);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "+3" or "3+":
                    this.grades.Add(45);
                    break;
                case "-3" or "3-":
                    this.grades.Add(35);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "+2" or "2+":
                    this.grades.Add(25);
                    break;
                case "-2" or "2-":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                    }
                    else if (char.TryParse(grade, out char character))
                    {
                        this.AddGrade(character);
                    }
                    else
                    {
                        throw new Exception("string is not float");
                    }
                    break;
            }
            }

            public void AddGrade(double grade)
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

            public void AddGrade(int grade)
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
            }

            public void AddGrade(long grade)
            {
                float gradeAsFloat = (float)grade;
                this.AddGrade(gradeAsFloat);
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
                //statistics.Average /=this.grades.Count;  jest to to samo co linijka wyżej

                switch (statistics.Average)
                {
                    case var average when average > 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average > 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average > 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average > 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
                return statistics;
            }
    }
}
