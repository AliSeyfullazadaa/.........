namespace FromCodeNov25_28
{
    internal class Program
    {
        private static Student student;

        static void Main(string[] args)
        {
            Group group = new Group();
            group.Limit = 3;
            Console.WriteLine("1 - add student.");
            Console.WriteLine("0 - Close.");

            string value=Console.ReadLine();

            if(value=="1")
            {
                Console.Write("Name daxil edin: ");
                string name =Console.ReadLine();

                Console.Write("Surname daxil edin: ");
                string surname = Console.ReadLine();

                while(true)
                {
                    Student student = new Student(name,surname);
                    bool status = group.AddStudent(student);

                    CheckStaus(status);

                    Console.WriteLine("1 - add student.");
                    Console.WriteLine("0 - Close.");
                    value=Console.ReadLine();
                }
            }
           

            
            

            




        }

        static void CheckStaus(bool status)
        {
            if (status)
                Console.WriteLine("Elave olundu.");
            else
                Console.WriteLine("Elave olunmadi.");
        }
    }
}