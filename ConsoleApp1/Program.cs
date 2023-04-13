namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam>exams = new List<Exam>();
            bool check = false;

            do
            {
                Console.WriteLine("student nameni yaz");
                string Stdname = Console.ReadLine();
                Console.WriteLine("student point yaz")
                int point = int.Parse(Console.ReadLine());
                Console.WriteLine("subjecti yaz");
                string Subject = Console.ReadLine();
                Console.WriteLine("starttime yaz");
                DateTime startdate =DateTime.Parse(Console.ReadLine());
                Console.WriteLine("endtime yaz");
                DateTime enddate =DateTime.Parse(Console.ReadLine());
                Exam exam = new Exam()
                {
                    Studentname=Stdname,
                    Point=point,
                    Subject=Subject,
                    Startdata=startdate,
                    Enddata=enddate,

                };

                exams.Add(exam);
                var Point = exams.FindAll(x => x.Point>50);
                Point.ForEach(x =>
                {
                    Console.WriteLine(x.Point, x.Studentname, x.Subject, x.Duration);
                });
                var longDurationexams = exams.FindAll(x => x.Duration>TimeSpan.FromHours(1));

            }while(check=true);
            longDurationexams.Foreach(x =>
            {

                Console.WriteLine(x.Point, x.Studentname, x.Subject, x.Duration);
            });

            }
        }
    }
}