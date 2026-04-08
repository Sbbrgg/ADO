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
	public partial class HumanForm : Form
	{
		//protected DBTools.Connector connector;
		protected HumanForm()
		{
			InitializeComponent();

			//connector = new DBTools.Connector(ConfigurationManager.ConnectionStrings["Pv_521_Import"].ConnectionString);
		}

		protected virtual void buttonOk_Click(object sender, EventArgs e)
		{ }
	}
}
