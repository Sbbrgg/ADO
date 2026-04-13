using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Academy.Models
{
	internal class Teacher: Human
	{
		internal decimal rate;
		public Teacher
			(
			int id,
			string last_name, string first_name, string middle_name,
			string birth_date, string email, string phone, Image photo,
			decimal rate
			) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			this.rate = rate;
		}
		public Teacher(Human human, decimal rate) : base(human)
		{
			this.rate = rate;
		}
		public Teacher(object[] values) : base(values)
		{
			this.rate =	Convert.ToInt32(values[9].ToString().Replace(",", ""));
		}
		public override string GetNames()
		{
			return base.GetNames() + ",[rate]";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},{rate}";
		}
		public override string GetCondition()
		{
			return base.GetCondition() + $" AND [rate]={rate}";
		}
		public string GetUpdateString()
		{
			return GetCondition().Replace(" AND ", ",");
		}
	}
}
