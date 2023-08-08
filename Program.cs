namespace BTThem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxEmpoyees = 100;
            Employee[] employees = new Employee[MaxEmpoyees];
            Console.WriteLine("Nhập số lượng nhân viên");
            int n = int .Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine($"Nhập thông tin cho nhân viên thứ {i + 1}:");
                Console.Write("ID: ");
                employees[i].Id = int.Parse(Console.ReadLine());

                Console.Write("Tên: ");
                employees[i].Name = Console.ReadLine();

                Console.Write("Tuổi: ");
                employees[i].Age = int.Parse(Console.ReadLine());

                Console.Write("Lương: ");
                employees[i].Salary = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine("Danh sách nhân viên:");
            foreach (Employee emp in employees)
            {
                if (emp != null)
                {
                    Console.WriteLine($"ID: {emp.Id}, Tên: {emp.Name}, Tuổi: {emp.Age}, Lương: {emp.Salary}");
                }
            }

            // Sắp xếp mảng theo lương giảm dần
            Array.Sort(employees, (emp1, emp2) => emp2.Salary.CompareTo(emp1.Salary));

            Console.WriteLine("\nDanh sách sau khi sắp xếp theo lương giảm dần:");
            foreach (Employee emp in employees)
            {
                if (emp != null)
                {
                    Console.WriteLine($"ID: {emp.Id}, Tên: {emp.Name}, Tuổi: {emp.Age}, Lương: {emp.Salary}");
                }
            }

            // Tìm kiếm thông tin nhân viên theo tên
            Console.Write("\nNhập tên nhân viên cần tìm: ");
            string searchName = Console.ReadLine();

            Employee foundEmployee = Array.Find(employees, emp => emp != null && emp.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (foundEmployee != null)
            {
                Console.WriteLine($"Nhân viên có tên {searchName}:");
                Console.WriteLine($"ID: {foundEmployee.Id}, Tên: {foundEmployee.Name}, Tuổi: {foundEmployee.Age}, Lương: {foundEmployee.Salary}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nhân viên có tên {searchName}");
            }
        }
    }
}