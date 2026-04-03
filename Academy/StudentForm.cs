using DBTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
		Dictionary<string, int> d_groups;
		public StudentForm()
		{
			InitializeComponent();

			d_groups = MainForm.connector.GetDictionary("Groups");
			cbGroups.Items.AddRange(d_groups.Keys.ToArray());
		}
	}
}
