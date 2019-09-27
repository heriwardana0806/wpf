using CobaWpf.Context;
using CobaWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaWpf.Controllers
{
    public class TeacherController
    {
        private Teacher teacher;

        public void ManageTeacher()
        {
            var result = 0;

            Teacher teacher = new Teacher();
            MyContext _context = new MyContext();
            Console.WriteLine("=========== Teacher Data ============");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");

            switch (chance)
            {
                case 1:
                    // memasukkan nilai Name, dan Address di Teacher
                    Console.Write("Insert Name of Teacher : ");
                    teacher.TeacherName = Console.ReadLine();
                    Console.Write("Insert Address : ");
                    teacher.Address = Console.ReadLine();

                    _context.Teachers.Add(teacher);
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
                    break;
                case 2:
                    // input id untuk dicari
                    Console.Write("Insert Id to Update Data : ");
                    int id = Convert.ToInt16(Console.ReadLine());

                    // mencari data sesuai dengan id di database
                    var get = _context.Teachers.Find(id);

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
                        Console.Write("Insert Name of Teacher : ");
                        get.TeacherName = Console.ReadLine();
                        Console.Write("Insert Address of Teacher : ");
                        get.Address = Console.ReadLine();

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
                    Console.Write("Insert Id to Delete Data : ");

                    // mencari data sesuai dengan id di database
                    var getData = _context.Teachers.Find(Convert.ToInt16(Console.ReadLine()));

                    // pengecekan data di database
                    if (getData == null)
                    {
                        // jika tidak ada, maka akan menampilkan seperti berikut
                        Console.Write("Sorry, your data is not found");
                        Console.Read();
                    }
                    else
                    {
                        _context.Teachers.Remove(getData);

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
                    var getDatatoDisplay = _context.Teachers.ToList();

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
                            Console.WriteLine("Name    : " +"\t" + tampilin.TeacherName);
                            Console.WriteLine("Address : " + "\t" + tampilin.Address);
                            Console.WriteLine("============================");
                        }
                        Console.Write("Total Teacher " + getDatatoDisplay.Count);
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


