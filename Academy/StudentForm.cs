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
		public StudentForm()
		{
			InitializeComponent();

			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");
			cbGroups.DataSource = groups;
			cbGroups.DisplayMember = "group_name";
			cbGroups.ValueMember = "group_id";
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			DataBase.Connector.Insert
				(
					"Students",
					"last_name,first_name,middle_name,birth_date,email,phone,[group]",
					$"{TBLastName.Text},{TBFirstName.Text},{TBMiddleName.Text},{dtpBirthDate.Value.ToString("yyyy-MM-dd")},{tbEmail.Text},{tbPhone.Text},{cbGroups.SelectedValue}"
				);
		}
	}
}
