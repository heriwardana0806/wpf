using CobaWpf.Context;
using CobaWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Program
{
    class StudentController
    {
        private static Student student;

        public object TeacherId { get; private set; }

        public void ManageStudent()
        {
            var result = 0;

            Student student = new Student();
            CobaWpf.Context.MyContext _context = new CobaWpf.Context.MyContext();
            Console.WriteLine("=========== Students Data ============");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");
            //int Id_Teacher = Convert.ToInt16(Console.ReadLine());

            switch (chance)
            {
                case 1:

                    Console.Write("Insert Name of Student : ");
                    student.Name = Console.ReadLine();
                    Console.Write("Insert Class : ");
                    student.Class = Console.ReadLine();
                    Console.Write("Insert Id Teacher : ");
                    int Id_Teacher = Convert.ToInt16(Console.ReadLine());

                    if (Id_Teacher == null)
                    {
                        Console.Write("Insert Your Id Teacher: ");
                        Console.ReadLine();

                    }
                    else {
                        var getTeacher = _context.Teachers.Find(Id_Teacher);
                        if (getTeacher == null)
                        {
                            Console.WriteLine("Id is not enable :" + Id_Teacher);
                            Console.Read();

                        }
                        else
                        {
                            student.TeacherId = getTeacher.TeacherId;
                            _context.Students.Add(student);
                            result = _context.SaveChanges();
                            if (result > 0)
                            {
                                Console.Write("Insert Successfully");
                                Console.Read();
                            }
                            else
                            {
                                Console.Write("Insert Failed");
                                Console.Read();
                            }

                        }

                    }

                    break;
                case 2:
                    // input id untuk dicari
                    Console.Write("Insert Id to Update Data : ");
                    int id = Convert.ToInt16(Console.ReadLine());

                    // mencari data sesuai dengan id di database
                    var get = _context.Students.Find(id);

                    // pengecekan data di database
                    if (get == null)
                    {
                        // jika tidak ada, maka akan menampilkan seperti berikut
                        Console.Write("Sorry, your data is not found");
                        Console.Read();
                    }
                    else
                    {
                        // jika ada, maka akan meminta inputan nama dan akan disimpan di database
                        Console.Write("Insert Name of Student : ");
                        get.Name = Console.ReadLine();
                        Console.Write("Insert Class of Student : ");
                        get.Class = Console.ReadLine();
                        Console.Write("Insert Id Teacher : ");
                        get.TeacherId = Convert.ToInt16(Console.ReadLine());

                        //if(TeacherId == null)
                        //{

                        //}

                        result = _context.SaveChanges();
                        if (result > 0)
                        {
                            Console.Write("Update Successfully");
                            Console.Read();
                        }
                        else
                        {
                            Console.Write("Update Failed");
                            Console.Read();
                        }
                    }
                    break;
                case 3:
                    // input id untuk dicari
                    Console.Write("Insert Id to Update Data : ");

                    // mencari data sesuai dengan id di database
                    var getData = _context.Students.Find(Convert.ToInt16(Console.ReadLine()));

                    // pengecekan data di database
                    if (getData == null)
                    {
                        // jika tidak ada, maka akan menampilkan seperti berikut
                        Console.Write("Sorry, your data is not found");
                        Console.Read();
                    }
                    else
                    {
                        _context.Students.Remove(getData);

                        result = _context.SaveChanges();
                        if (result > 0)
                        {
                            Console.Write("Delete Successfully");
                            Console.Read();
                        }
                        else
                        {
                            Console.Write("Delete Failed");
                            Console.Read();
                        }
                    }
                    break;
                case 4:
                    var getDatatoDisplay = _context.Students.ToList();

                    if (getDatatoDisplay.Count == 0)
                    {
                        Console.Write("No Data in your Database");
                        Console.Read();
                    }
                    else
                    {
                        foreach (var tampilin in getDatatoDisplay)
                        {
                            Console.WriteLine("============================");
                            Console.WriteLine("Name      : " + tampilin.Name);
                            Console.WriteLine("Class : " + tampilin.Class);
                            Console.WriteLine("Class : " + tampilin.TeacherId);
                            Console.WriteLine("============================");
                        }
                        Console.Write("Total Student " + getDatatoDisplay.Count);
                        Console.Read();
                    }
                    break;
                default:
                    Console.Write("Something Wrong, Please try again next time.");
                    break;
            }

        }

    }
}
