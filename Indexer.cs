using System;
namespace Online
{
	public class Customer
	{
		int id;
		double salary;
		string name,location,job;
		public Customer(int id,string name,double salary,string location,string job)
		{
			this.id=id;
			this.name=name;
			this.salary=salary;
			this.location=location;
			this.job=job;
		}
		public object this[int index]
		{
			get
			{
				if(index==0)
				return id;
				else if(index==1)
				return name;
				else if(index==2)
				return salary;
				else if(index==3)
				return location;
				else if(index==4)
				return job;
				else
				return null;
			}
			set
			{
				if(index==0)
//				id=value; Cannot implicitly convert type `object' to `int'
				id=(int)value;	//value type is same as return type of method
				else if(index==1)
				name=(string)value;
				else if(index==2)
				salary=(double)value;
				else if(index==3)
				location=(string)value;
				else if(index==4)
				job=(string)value;
			}
		}
	}
	class Indexer
	{
		static void Main()
		{
			Customer cust = new Customer(100,"Aniket",30000,"Pune","Manager");
			Console.WriteLine("Customer Id = "+cust[0]);
			Console.WriteLine("Customer Name = "+cust[1]);
			Console.WriteLine("Customer Salary = "+cust[2]);
			Console.WriteLine("Customer Location = "+cust[3]);
			Console.WriteLine("Customer Job = "+cust[4]);
		}
	}
}
