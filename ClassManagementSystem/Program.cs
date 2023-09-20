using ClassManagementSystem;

Console.WriteLine("Welcome to add students to course.");
Course math = new Course("Math");
Course phys = new Course("phys");
Course ceit = new Course("ceit");

while (true)
{
    Console.WriteLine("Enter 1 to  Add students.");
    Console.WriteLine("Enter 2 to Exit app.");
    int user_choice = Convert.ToInt32(Console.ReadLine());

    if (user_choice == 1){ AddToCourse(); }
    if (user_choice == 2)
    {
        break;
    }
    Console.WriteLine("Add more student(y/n)\n");
    char add_more = Console.ReadKey().KeyChar;
    if (add_more == 'y' || add_more == 'Y'){AddToCourse();}
    else if(add_more == 'n' || add_more == 'N') { break; }
}

void AddToCourse()
{
    Console.WriteLine(" Enter name: ");
    string user_name = Console.ReadLine();
    Console.WriteLine(" Enter surname: ");
    string user_surname = Console.ReadLine();
    Console.WriteLine(" Enter gender: ");
    string user_gender = Console.ReadLine();

    Students student = new Students(user_name, user_surname, user_gender);
    student.SuccessMessage();

    Console.WriteLine("Which course student will register?");
    Console.WriteLine("1.Math\n" + "2.phys\n" + "3.ceit");
    int user_course = Convert.ToInt32(Console.ReadLine());
    if (user_course == 1) { math.Capacity--; Console.WriteLine("{0} registered {1} course. remaining capacity {2}", student.Name, math.Name, math.Capacity); }
    else if (user_course == 2) { phys.Capacity--; Console.WriteLine("{0} registered {1} course and remaining capacity {2}", student.Name, phys.Name, phys.Capacity); }
    else if (user_course == 3) { ceit.Capacity--; Console.WriteLine("{0} registered {1} course and remaining capacity {2}", student.Name, ceit.Name, ceit.Capacity); }

}







