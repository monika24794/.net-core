using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace shoopingbBuinesslogic
{
    public class Products   
    {
        public float GST {
			get { return 5.0f; }
			private set { }
				}
		private string _pwd;
        public string Pwd {
			set { _pwd = value; }
		}


        private int _prodId;
		private string _prodName; // backing field value
		public int ProductID
		{
			get { return _prodId; }
			set
			{
				if (_prodId != value)
				{
					_prodId = value;

				}
				else
				{
                    Console.WriteLine("product id not valid");
                }
			}
		}
		//only accept aND dispaly It is called auto increament  property
		public double price { get; set; } = 1.6D;
        public string ProductName
		{ 
			get { return _prodName; }
			set { _prodName = value; }
		}
		//asign the default value

		public string unitmeasurment { get; set; } = "unknown";


    }
	 public class Employee
    {
        public static int _count=0;

		 static Employee() 
		{
		    _count = 0;
		}
		public Employee()
        {
            _count = 1;
        }
        public Employee(int id)
        {
            _count++ ; 
        }
		 public Employee(int id, int b)
		{
			_count += id;
			genrateId();
		}
		private static int genrateId()
		{
			_count++;
			return _count;
		}
    }

}
