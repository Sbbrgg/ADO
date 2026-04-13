namespace Academy
{
	partial class TeacherForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbRate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
			// 
			// tbRate
			// 
			this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbRate.Location = new System.Drawing.Point(191, 240);
			this.tbRate.Name = "tbRate";
			this.tbRate.Size = new System.Drawing.Size(272, 31);
			this.tbRate.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(122, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Rate:";
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 345);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbRate);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.buttonOK, 0);
			this.Controls.SetChildIndex(this.tbLastName, 0);
			this.Controls.SetChildIndex(this.tbFirstName, 0);
			this.Controls.SetChildIndex(this.tbMiddleName, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.pbPhoto, 0);
			this.Controls.SetChildIndex(this.tbEmail, 0);
			this.Controls.SetChildIndex(this.tbPhone, 0);
			this.Controls.SetChildIndex(this.tbRate, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbRate;
		private System.Windows.Forms.Label label1;
	}
}