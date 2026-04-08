using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Academy
{
	internal partial class HumanForm : Form
	{
		//protected DBTools.Connector connector;
		protected Models.Human human;
		protected HumanForm()
		{
			InitializeComponent();
			//connector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["Pv_521_Import"].ConnectionString);
			if (human != null)
			{
				TBLastName.Text = human.last_name;
				TBFirstName.Text = human.first_name;
				TBMiddleName.Text = human.middle_name;
				dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
				tbEmail.Text = human.email;
				tbPhone.Text = human.phone;
			}
		}
		protected void Extract()
		{
			if (human != null)
			{
				TBLastName.Text = human.last_name;
				TBFirstName.Text = human.first_name;
				TBMiddleName.Text = human.middle_name;
				dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
				tbEmail.Text = human.email;
				tbPhone.Text = human.phone;
			}
		}

		protected virtual void buttonOk_Click(object sender, EventArgs e)
		{
			human = new Models.Human
				(
					TBLastName.Text,
					TBFirstName.Text,
					TBMiddleName.Text,
					dtpBirthDate.Value.ToString("yyyy-MM-dd"),
					tbEmail.Text,
					tbPhone.Text,
					pbPhoto.Image
				);
		}
	}
}
