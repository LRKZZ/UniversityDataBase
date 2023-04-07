namespace university
{
    class Program
    {
        static public void Main(string[] args)
        {
            
            List<Student> list = new List<Student>();
            List<Teacher> listeacher = new List<Teacher>();
            List<Laws> listlaws = new List<Laws>();
            
            string name;
            string department;

            


            
            do
            {
                Console.Clear();
                Console.WriteLine("1. Ввод преподавателя.");
                Console.WriteLine("2. Ввод студентов. ");
                Console.WriteLine("3. Ввод ректора и выдача приказов. ");
                Console.WriteLine("4. Вывести студентов-должников преподавателя по дисциплине. ");
                Console.WriteLine("5. Вывод выбранных приказов: ");
                Console.WriteLine("6. Список должников по фамилии преподавателя. ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите ФИО преподавателя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите кафедру преподавателя: ");
                        department = Console.ReadLine();
                        Console.WriteLine("Введите кол-во дисциплин, которые ведёт преподаватель: ");
                        int departmentcount = Convert.ToInt32(Console.ReadLine());
                        List<string> departmentlist = new List<string>();
                        for (int i = 0; i < departmentcount; i++)
                        {
                            Console.WriteLine("Введите дисциплину: ");
                            departmentlist.Add(Console.ReadLine());
                        }
                        Teacher teacher = new Teacher(name, department, departmentlist);
                        listeacher.Add(teacher);
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите ФИО студента: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите группу: ");
                        string group = Console.ReadLine();
                        Console.WriteLine("Введите кол-во дисциплин студента: ");
                        int idk = Int32.Parse(Console.ReadLine());
                        Dictionary<string, int> lessons = new Dictionary<string, int>();
                        Console.WriteLine("Введите данные в формате: Название, Оценка (через Enter): ");
                        for (int i = 0; i < idk; i++)
                        {
                            lessons.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                        }
                        Student student = new Student(name, group, lessons);
                        list.Add(student);
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите ФИО: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Введите должность: ");
                        string rank = Console.ReadLine();
                        Console.WriteLine("Введите кол-во приказов: ");
                        int lawscount = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < lawscount; i++)
                        {
                            Console.WriteLine("Введите префикс приказа, где 1 - для всех, 2 - для студентов, 3 - для преподавателей: ");
                            string prefix = Console.ReadLine();
                            Console.WriteLine("Введите номер приказа: ");
                            string number = Console.ReadLine();
                            Console.WriteLine("Введите название документа (приказа): ");
                            string nameoflaw = Console.ReadLine();
                            Console.WriteLine("Введите содержимое приказа: ");
                            string content = Console.ReadLine();
                            Laws law = new Laws(prefix, number, nameoflaw, content);
                            listlaws.Add(law);
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите название дисциплины: ");
                        string lesson = Console.ReadLine();
                        foreach(Student student1 in list)
                        {
                            Console.WriteLine($"{student1.name} {student1.group}");
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Вывести приказ для: ");
                        Console.WriteLine("1. Всех");
                        Console.WriteLine("2. Студентов");
                        Console.WriteLine("3. Преподавателей");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                foreach (Laws law in listlaws)
                                {
                                    if (law.prefix == "1")
                                    {
                                        Console.WriteLine($"{law.nameoflaw} {law.number}");
                                    }
                                }
                                Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                                Console.ReadKey();
                                break;
                            case 2:
                                foreach (Laws law in listlaws)
                                {
                                    if (law.prefix == "2")
                                    {
                                        Console.WriteLine($"{law.nameoflaw} {law.number}");
                                    }
                                }
                                Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                                Console.ReadKey();
                                break;
                            case 3:
                                foreach (Laws law in listlaws)
                                {
                                    if (law.prefix == "3")
                                    {
                                        Console.WriteLine($"{law.nameoflaw} {law.number}");
                                    }
                                }
                                Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                                Console.ReadKey();
                                break;
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Введите ФИО преподавателя: ");
                        string FIO = Console.ReadLine();
                        foreach (Teacher teacher1 in listeacher)
                        {
                            if (FIO == teacher1.name)
                            {
                                foreach(string tired in teacher1.departmentlist)
                                {
                                    foreach (Student student2 in list)
                                    {
                                        if (student2.Grade().ContainsKey(tired) && student2.Grade().ContainsValue(2))
                                        {
                                            Console.WriteLine($"{student2.name} {student2.group} {tired}");
                                        }
                                    }
                                } 
                            }
                        }
                        Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить. ");
                        Console.ReadKey();
                        break;

                }
            } while (true);
        }
    }
}