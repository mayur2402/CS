using System;
namespace Online
{
	public class Customer
	{
		int _cid;	//generally we use "_" before field name whose property is create
		bool _status;
		string _cname;
		double _balance;
		public Customer(int cid,bool status,string cname,double balance)
		{
			_cid=cid;
			_status=status;
			_cname=cname;
			_balance=balance;
		}
		public int cid
		{
			get
			{
				return _cid;
			}
			set
			{
				if(status==true)
				_cid=value;	//value type is property type here type is int
			}
		}
		public bool status
		{
			get
			{
				return _status;
			}
			set
			{
				_status=value;	//value type is property type here type is bool
			}
		}
		public string cname
		{
			get
			{
				return _cname;
			}
			set
			{
				if(status==true)
				_cname=value;	//value type is property type here type is string
			}
		}
		public double balance
		{
			get
			{
				return _balance;
			}
			set
			{
				if(status==true)
				_balance=value;	//value type is property type here type is double
			}
		}
	}
	class Bank
	{
		static void Main()
		{
			Customer c=new Customer(101,false,"Sagar",80000);
			Console.WriteLine("Customer id ="+c.cid);
			if(c.status==true)
			{
				Console.WriteLine("Account is Active");
			}
			else
			{
				Console.WriteLine("Account is In-Active");
			}
			Console.WriteLine("Customer Name ="+c.cname);
			Console.WriteLine("Account balance ="+c.balance);

			c.cname="Devarshi";	//as status is false and in property we give condition that if status is true then only assign new value so it's not assign new value old value remain
			Console.WriteLine("Customer Name ="+c.cname);
			Console.WriteLine("Account balance ="+c.balance);
		}
	}
}
