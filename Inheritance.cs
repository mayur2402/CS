using System;
namespace Online
{
	public class Person	//parent class
	{
		int id;
		string name,address,phone;
		public Person()
		{
			id=0;
			name=null;
			address=null;
			phone=null;
		}
		public void AcceptPerson()
		{
			Console.WriteLine("Enter id ");
			id=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Full Name ");
			name=Console.ReadLine();
			Console.WriteLine("Enter address ");
			address=Console.ReadLine();
			Console.WriteLine("Enter phone number ");
			phone=Console.ReadLine();
		}
		public void DisplayPerson()
		{
			Console.WriteLine("ID="+id);
			Console.WriteLine("Name="+name);
			Console.WriteLine("Address="+address);
			Console.WriteLine("Phone="+phone);
		}
	}
	public class Student : Person	//child class of person 
	{
		int Class;
		float mark,fee;
		public Student()
		{
			Class = 0;
			mark = 0.0f;
			fee = 0.0f;
		}
		public void AcceptStudent()
		{
			base.AcceptPerson();	//call to the base class AcceptPerson method
			Console.WriteLine("Enter Class ");
			Class = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Percentage ");
			mark = float.Parse(Console.ReadLine());
			Console.WriteLine("Enter Fee ");
			fee = float.Parse(Console.ReadLine());
		}
		public void DisplayStudent()
		{
			base.DisplayPerson();	//call to the base class DisplayPerson method
			Console.WriteLine("Class="+Class);
			Console.WriteLine("Percentage="+mark);
			Console.WriteLine("Fee="+fee);
		}
	}
	public class Staff : Person		//child class of person
	{
		float salary;
		public Staff()
		{
			salary=0.0f;
		}
		public void AcceptStaff()
		{
			base.AcceptPerson();	//call to the base class AcceptPerson method
			Console.WriteLine("Enter Salary");
			salary=float.Parse(Console.ReadLine());
		}
		public void DisplayStaff()
		{
			base.DisplayPerson();	//call to the base class DisplayPerson method
			Console.WriteLine("Salary ="+salary);
		}
		
	}
	public class Teaching : Staff		//child class of Staff which is also child class of person
	{
		string subject;
		public Teaching()
		{
			subject=null;
		}
		public void AcceptTeaching()
		{
			base.AcceptStaff();	//call to the base class AcceptStaff method 
			Console.WriteLine("Enter Subject");
			subject=Console.ReadLine();
		}
		public void DisplayTeaching()
		{
			base.DisplayStaff();	//call to the base class DisplayStaff method
			Console.WriteLine("Subject ="+subject);
		}
	}
	public class NonTeaching : Staff	//child class of Staff which is also child class of person
	{
		string department;
		public NonTeaching()
		{
			department=null;
		}
		public void AcceptNonTeaching()
		{
			base.AcceptStaff();	//call to the base class AcceptStaff method
			Console.WriteLine("Enter Department");
			department=Console.ReadLine();
		}
		public void DisplayNonTeaching()
		{
			base.DisplayStaff();	//call to the base class DisplayStaff method
			Console.WriteLine("Department ="+department);
		}
	}
	public class Final
	{
		static void Main()
		{
			int choice;
			Console.WriteLine("1.Student\n2.Teaching\n3.Non-Teaching");
			Console.WriteLine("Enter your choice");
			choice=int.Parse(Console.ReadLine());
			switch(choice)
			{
				case 1:
					Student s=new Student();
					s.AcceptStudent();
					s.DisplayPerson();
					break;
				case 2:
					Teaching t=new Teaching();
					t.AcceptTeaching();
					t.DisplayTeaching();
					break;
				case 3:
					NonTeaching n=new NonTeaching();
					n.AcceptNonTeaching();
					n.DisplayNonTeaching();
					break;
				default :
					break;
			}
		}
	}
}
