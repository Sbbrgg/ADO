namespace Academy
{
	partial class HumanForm
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
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.TBLastName = new System.Windows.Forms.TextBox();
			this.TBFirstName = new System.Windows.Forms.TextBox();
			this.TBMiddleName = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLastName.Location = new System.Drawing.Point(85, 12);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(110, 25);
			this.labelLastName.TabIndex = 0;
			this.labelLastName.Text = "Фамилия:";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFirstName.Location = new System.Drawing.Point(142, 53);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(53, 25);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "Имя";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMiddleName.Location = new System.Drawing.Point(90, 93);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(105, 25);
			this.labelMiddleName.TabIndex = 2;
			this.labelMiddleName.Text = "Отчество";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBirthDate.Location = new System.Drawing.Point(29, 135);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(166, 25);
			this.labelBirthDate.TabIndex = 3;
			this.labelBirthDate.Text = "Дата рождения";
			// 
			// TBLastName
			// 
			this.TBLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TBLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.TBLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TBLastName.Location = new System.Drawing.Point(210, 6);
			this.TBLastName.Name = "TBLastName";
			this.TBLastName.Size = new System.Drawing.Size(236, 31);
			this.TBLastName.TabIndex = 4;
			// 
			// TBFirstName
			// 
			this.TBFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TBFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.TBFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TBFirstName.Location = new System.Drawing.Point(210, 47);
			this.TBFirstName.Name = "TBFirstName";
			this.TBFirstName.Size = new System.Drawing.Size(236, 31);
			this.TBFirstName.TabIndex = 5;
			// 
			// TBMiddleName
			// 
			this.TBMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.TBMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.TBMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBMiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TBMiddleName.Location = new System.Drawing.Point(210, 87);
			this.TBMiddleName.Name = "TBMiddleName";
			this.TBMiddleName.Size = new System.Drawing.Size(236, 31);
			this.TBMiddleName.TabIndex = 6;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(210, 135);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(236, 31);
			this.dtpBirthDate.TabIndex = 7;
			// 
			// pbPhoto
			// 
			this.pbPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPhoto.Location = new System.Drawing.Point(452, 6);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(188, 234);
			this.pbPhoto.TabIndex = 8;
			this.pbPhoto.TabStop = false;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBrowse.Location = new System.Drawing.Point(452, 246);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(188, 40);
			this.buttonBrowse.TabIndex = 9;
			this.buttonBrowse.Text = "Обзор";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			// 
			// tbEmail
			// 
			this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbEmail.Location = new System.Drawing.Point(210, 172);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(236, 31);
			this.tbEmail.TabIndex = 10;
			// 
			// tbPhone
			// 
			this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbPhone.Location = new System.Drawing.Point(210, 209);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(236, 31);
			this.tbPhone.TabIndex = 11;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelEmail.Location = new System.Drawing.Point(123, 172);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(72, 25);
			this.labelEmail.TabIndex = 12;
			this.labelEmail.Text = "E-mail";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPhone.Location = new System.Drawing.Point(12, 209);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(183, 25);
			this.labelPhone.TabIndex = 13;
			this.labelPhone.Text = "Номер телефона";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(512, 325);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(188, 40);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(318, 325);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(188, 40);
			this.buttonOk.TabIndex = 15;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// HumanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 377);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.pbPhoto);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.TBMiddleName);
			this.Controls.Add(this.TBFirstName);
			this.Controls.Add(this.TBLastName);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "HumanForm";
			this.ShowInTaskbar = false;
			this.Text = "HumanForm";
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.TextBox TBLastName;
		private System.Windows.Forms.TextBox TBFirstName;
		private System.Windows.Forms.TextBox TBMiddleName;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.PictureBox pbPhoto;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
	}
}