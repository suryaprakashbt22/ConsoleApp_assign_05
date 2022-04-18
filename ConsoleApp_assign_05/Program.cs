using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using Empclass = ConsoleApp_employeeclass_for_arraylist; //This is the Namespace of the previously created project viz. "Employee management system" and is used in this project.

namespace ConsoleApp_assign_05
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int N=int.Parse(Console.ReadLine());
            int[] arr1 = new int[N];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2=new int[N];
            Array.Copy(arr1, 0, arr2, 0, arr2.Length);
            Console.WriteLine("Elements copied in the new array::");
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Array.Sort(arr1);
            Console.WriteLine("First Array after sorting::");
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After Reversing Array 01::");
            Array.Reverse(arr1);
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Now clearing the Array from first to last index::");
            Array.Clear(arr1,0,arr1.Length);
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

            var arrayList1 = new ArrayList();
            Empclass.Manager m1 = new Empclass.Manager("SP", "Manager", 1000); // Creating new Employee Object using reference to the previous project!
            Empclass.MarketingExecutive m2 = new Empclass.MarketingExecutive("B", "Marketing Executive", 1000000.0, 10);
            Empclass.Manager m3 = new Empclass.Manager("C", "Manager", 1000000.0);

            arrayList1.Add(m1);
            arrayList1.Add(m2);
            arrayList1.Add(m3);

            Console.WriteLine("Printing the Array List!");
            
            foreach (var element in arrayList1)
            {
                Empclass.Employee temp = (Empclass.Employee)element;
                temp.CalculateSalary();
                temp.printDetails();
                Console.WriteLine("Detail of the type of the object stored ::{0}",element);
                Console.WriteLine();
            }
            //Console.ReadLine();

            Console.WriteLine("Implementing Linked List Now :: ");

            LinkedList<Empclass.Employee> emplinkedlist= new LinkedList<Empclass.Employee>();
            emplinkedlist.AddLast(m1);
            emplinkedlist.AddLast(m2);
            emplinkedlist.AddLast(m3);
            Empclass.Manager m4 = new Empclass.Manager("D", "Manager", 15000);
            Console.WriteLine("\nAdding an element to the front of the Linked List!\n");
            emplinkedlist.AddFirst(m4);
            int cntOfEmployeesInLinkedlist = 0;
            foreach(var element in emplinkedlist)
            {
                Empclass.Employee temp = (Empclass.Employee)element;
                temp.CalculateSalary();
                temp.printDetails();
                cntOfEmployeesInLinkedlist++;
                Console.WriteLine("Detail of the type of the object stored ::{0}", element);
                Console.WriteLine();
            }
            Console.WriteLine("No. of Elements in Linked List = {0}", cntOfEmployeesInLinkedlist);
            Console.ReadLine();
            
        }
    }
}
