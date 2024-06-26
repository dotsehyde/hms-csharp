﻿namespace HMS
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            label1 = new Label();
            menuPanel = new Panel();
            btnDash = new Button();
            button1 = new Button();
            invBtn = new Button();
            appointmentBtn = new Button();
            logoutBtn = new Button();
            patientBtn = new Button();
            patientPanel = new Panel();
            PupdateBtn = new Button();
            PdelBtn = new Button();
            PtxtDob = new DateTimePicker();
            Pgender = new ComboBox();
            patientListView = new ListView();
            label9 = new Label();
            PtxtAddress = new TextBox();
            label8 = new Label();
            PtxtPhone = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            PtxtAge = new TextBox();
            label4 = new Label();
            PtxtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            addPatientBtn = new Button();
            patientClearBtn = new Button();
            appointmentPanel = new Panel();
            AupdateBtn = new Button();
            AdelBtn = new Button();
            AtxtDName = new TextBox();
            Atime = new DateTimePicker();
            Adate = new DateTimePicker();
            Astatus = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            AtxtPName = new TextBox();
            appListView = new ListView();
            button2 = new Button();
            button3 = new Button();
            invPanel = new Panel();
            invListView = new ListView();
            invAddBtn = new Button();
            IupdateBtn = new Button();
            IdelBtn = new Button();
            label20 = new Label();
            label21 = new Label();
            label24 = new Label();
            invTxtSup = new TextBox();
            label25 = new Label();
            invTxtPrice = new TextBox();
            label26 = new Label();
            invTxtQuan = new TextBox();
            label27 = new Label();
            invTxtName = new TextBox();
            invClearBtn = new Button();
            reportPanel = new Panel();
            rUpdateBtn = new Button();
            rDelBtn = new Button();
            rResult = new ComboBox();
            rType = new ComboBox();
            rDate = new DateTimePicker();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            rDoctor = new TextBox();
            label33 = new Label();
            rPatient = new TextBox();
            label34 = new Label();
            label35 = new Label();
            reportListView = new ListView();
            addReportBtn = new Button();
            clearReportBtn = new Button();
            dashPnl = new Panel();
            pictureBox1 = new PictureBox();
            label36 = new Label();
            panel5 = new Panel();
            lblRCount = new Label();
            label28 = new Label();
            panel4 = new Panel();
            lblICount = new Label();
            label23 = new Label();
            panel3 = new Panel();
            lblACount = new Label();
            label22 = new Label();
            panel2 = new Panel();
            lblPCount = new Label();
            label10 = new Label();
            menuPanel.SuspendLayout();
            patientPanel.SuspendLayout();
            appointmentPanel.SuspendLayout();
            invPanel.SuspendLayout();
            reportPanel.SuspendLayout();
            dashPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 31);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management System";
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.WhiteSmoke;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(btnDash);
            menuPanel.Controls.Add(button1);
            menuPanel.Controls.Add(invBtn);
            menuPanel.Controls.Add(appointmentBtn);
            menuPanel.Controls.Add(logoutBtn);
            menuPanel.Controls.Add(patientBtn);
            menuPanel.Location = new Point(25, 56);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(219, 600);
            menuPanel.TabIndex = 1;
            // 
            // btnDash
            // 
            btnDash.FlatStyle = FlatStyle.System;
            btnDash.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDash.Location = new Point(15, 12);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(189, 43);
            btnDash.TabIndex = 5;
            btnDash.Text = "Dashboard";
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(15, 253);
            button1.Name = "button1";
            button1.Size = new Size(189, 43);
            button1.TabIndex = 4;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // invBtn
            // 
            invBtn.FlatStyle = FlatStyle.System;
            invBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invBtn.Location = new Point(15, 189);
            invBtn.Name = "invBtn";
            invBtn.Size = new Size(189, 43);
            invBtn.TabIndex = 3;
            invBtn.Text = "Inventory";
            invBtn.UseVisualStyleBackColor = true;
            invBtn.Click += invBtn_Click;
            // 
            // appointmentBtn
            // 
            appointmentBtn.FlatStyle = FlatStyle.System;
            appointmentBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentBtn.Location = new Point(15, 128);
            appointmentBtn.Name = "appointmentBtn";
            appointmentBtn.Size = new Size(189, 43);
            appointmentBtn.TabIndex = 2;
            appointmentBtn.Text = "Appointment";
            appointmentBtn.UseVisualStyleBackColor = true;
            appointmentBtn.Click += appointmentBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Red;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = SystemColors.ButtonHighlight;
            logoutBtn.Location = new Point(15, 545);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(189, 43);
            logoutBtn.TabIndex = 1;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // patientBtn
            // 
            patientBtn.FlatStyle = FlatStyle.System;
            patientBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientBtn.Location = new Point(15, 69);
            patientBtn.Name = "patientBtn";
            patientBtn.Size = new Size(189, 43);
            patientBtn.TabIndex = 0;
            patientBtn.Text = "Patients";
            patientBtn.UseVisualStyleBackColor = true;
            patientBtn.Click += patientBtn_Click;
            // 
            // patientPanel
            // 
            patientPanel.BackColor = SystemColors.Control;
            patientPanel.Controls.Add(PupdateBtn);
            patientPanel.Controls.Add(PdelBtn);
            patientPanel.Controls.Add(PtxtDob);
            patientPanel.Controls.Add(Pgender);
            patientPanel.Controls.Add(patientListView);
            patientPanel.Controls.Add(label9);
            patientPanel.Controls.Add(PtxtAddress);
            patientPanel.Controls.Add(label8);
            patientPanel.Controls.Add(PtxtPhone);
            patientPanel.Controls.Add(label7);
            patientPanel.Controls.Add(label6);
            patientPanel.Controls.Add(label5);
            patientPanel.Controls.Add(PtxtAge);
            patientPanel.Controls.Add(label4);
            patientPanel.Controls.Add(PtxtFullName);
            patientPanel.Controls.Add(label3);
            patientPanel.Controls.Add(label2);
            patientPanel.Controls.Add(addPatientBtn);
            patientPanel.Controls.Add(patientClearBtn);
            patientPanel.Location = new Point(260, 56);
            patientPanel.Name = "patientPanel";
            patientPanel.Size = new Size(965, 600);
            patientPanel.TabIndex = 4;
            patientPanel.Visible = false;
            patientPanel.Paint += patientPanel_Paint;
            // 
            // PupdateBtn
            // 
            PupdateBtn.BackColor = Color.DodgerBlue;
            PupdateBtn.FlatStyle = FlatStyle.Flat;
            PupdateBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PupdateBtn.ForeColor = SystemColors.ButtonHighlight;
            PupdateBtn.Location = new Point(671, 444);
            PupdateBtn.Name = "PupdateBtn";
            PupdateBtn.Size = new Size(189, 43);
            PupdateBtn.TabIndex = 24;
            PupdateBtn.Text = "Update Patient";
            PupdateBtn.UseVisualStyleBackColor = false;
            PupdateBtn.Visible = false;
            PupdateBtn.Click += PupdateBtn_Click;
            // 
            // PdelBtn
            // 
            PdelBtn.BackColor = Color.Red;
            PdelBtn.FlatStyle = FlatStyle.Flat;
            PdelBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PdelBtn.ForeColor = SystemColors.ButtonHighlight;
            PdelBtn.Location = new Point(25, 546);
            PdelBtn.Name = "PdelBtn";
            PdelBtn.Size = new Size(189, 43);
            PdelBtn.TabIndex = 23;
            PdelBtn.Text = "Delete";
            PdelBtn.UseVisualStyleBackColor = false;
            PdelBtn.Visible = false;
            PdelBtn.Click += PdelBtn_Click;
            // 
            // PtxtDob
            // 
            PtxtDob.CustomFormat = "dd/MMM/yyyy";
            PtxtDob.Location = new Point(669, 192);
            PtxtDob.Name = "PtxtDob";
            PtxtDob.Size = new Size(278, 27);
            PtxtDob.TabIndex = 22;
            // 
            // Pgender
            // 
            Pgender.FormattingEnabled = true;
            Pgender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            Pgender.Location = new Point(671, 251);
            Pgender.Name = "Pgender";
            Pgender.Size = new Size(276, 28);
            Pgender.TabIndex = 21;
            // 
            // patientListView
            // 
            patientListView.FullRowSelect = true;
            patientListView.GridLines = true;
            patientListView.Location = new Point(11, 43);
            patientListView.Name = "patientListView";
            patientListView.Size = new Size(514, 486);
            patientListView.TabIndex = 20;
            patientListView.UseCompatibleStateImageBehavior = false;
            patientListView.SelectedIndexChanged += patientListView_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(588, 349);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 18;
            label9.Text = "Address: ";
            // 
            // PtxtAddress
            // 
            PtxtAddress.Location = new Point(669, 344);
            PtxtAddress.Name = "PtxtAddress";
            PtxtAddress.Size = new Size(278, 27);
            PtxtAddress.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(531, 300);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 16;
            label8.Text = "Phone Number: ";
            // 
            // PtxtPhone
            // 
            PtxtPhone.Location = new Point(669, 295);
            PtxtPhone.Name = "PtxtPhone";
            PtxtPhone.Size = new Size(278, 27);
            PtxtPhone.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(588, 249);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 14;
            label7.Text = "Gender: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(547, 195);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 12;
            label6.Text = "Date of Birth: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(614, 148);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 10;
            label5.Text = "Age: ";
            // 
            // PtxtAge
            // 
            PtxtAge.Location = new Point(669, 147);
            PtxtAge.Name = "PtxtAge";
            PtxtAge.Size = new Size(278, 27);
            PtxtAge.TabIndex = 9;
            PtxtAge.KeyPress += PtxtAge_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(568, 98);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 8;
            label4.Text = "Full Name: ";
            // 
            // PtxtFullName
            // 
            PtxtFullName.Location = new Point(669, 97);
            PtxtFullName.Name = "PtxtFullName";
            PtxtFullName.Size = new Size(278, 27);
            PtxtFullName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(711, 53);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 6;
            label3.Text = "Patient Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 5;
            label2.Text = "Patient List";
            // 
            // addPatientBtn
            // 
            addPatientBtn.BackColor = Color.Green;
            addPatientBtn.FlatStyle = FlatStyle.Flat;
            addPatientBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPatientBtn.ForeColor = SystemColors.ButtonHighlight;
            addPatientBtn.Location = new Point(563, 544);
            addPatientBtn.Name = "addPatientBtn";
            addPatientBtn.Size = new Size(189, 43);
            addPatientBtn.TabIndex = 4;
            addPatientBtn.Text = "Add Patient";
            addPatientBtn.UseVisualStyleBackColor = false;
            addPatientBtn.Click += addPatientBtn_Click;
            // 
            // patientClearBtn
            // 
            patientClearBtn.BackColor = Color.Red;
            patientClearBtn.FlatStyle = FlatStyle.Flat;
            patientClearBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientClearBtn.ForeColor = SystemColors.ButtonHighlight;
            patientClearBtn.Location = new Point(758, 544);
            patientClearBtn.Name = "patientClearBtn";
            patientClearBtn.Size = new Size(189, 43);
            patientClearBtn.TabIndex = 1;
            patientClearBtn.Text = "Clear";
            patientClearBtn.UseVisualStyleBackColor = false;
            patientClearBtn.Click += patientClearBtn_Click;
            // 
            // appointmentPanel
            // 
            appointmentPanel.Controls.Add(AupdateBtn);
            appointmentPanel.Controls.Add(AdelBtn);
            appointmentPanel.Controls.Add(AtxtDName);
            appointmentPanel.Controls.Add(Atime);
            appointmentPanel.Controls.Add(Adate);
            appointmentPanel.Controls.Add(Astatus);
            appointmentPanel.Controls.Add(label16);
            appointmentPanel.Controls.Add(label17);
            appointmentPanel.Controls.Add(label18);
            appointmentPanel.Controls.Add(label19);
            appointmentPanel.Controls.Add(label11);
            appointmentPanel.Controls.Add(label12);
            appointmentPanel.Controls.Add(label13);
            appointmentPanel.Controls.Add(label14);
            appointmentPanel.Controls.Add(label15);
            appointmentPanel.Controls.Add(AtxtPName);
            appointmentPanel.Controls.Add(appListView);
            appointmentPanel.Controls.Add(button2);
            appointmentPanel.Controls.Add(button3);
            appointmentPanel.Location = new Point(250, 43);
            appointmentPanel.Name = "appointmentPanel";
            appointmentPanel.Size = new Size(956, 613);
            appointmentPanel.TabIndex = 5;
            // 
            // AupdateBtn
            // 
            AupdateBtn.BackColor = Color.DodgerBlue;
            AupdateBtn.FlatStyle = FlatStyle.Flat;
            AupdateBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AupdateBtn.ForeColor = SystemColors.ButtonHighlight;
            AupdateBtn.Location = new Point(677, 423);
            AupdateBtn.Name = "AupdateBtn";
            AupdateBtn.Size = new Size(189, 43);
            AupdateBtn.TabIndex = 43;
            AupdateBtn.Text = "Update Appointment";
            AupdateBtn.UseVisualStyleBackColor = false;
            AupdateBtn.Visible = false;
            AupdateBtn.Click += AupdateBtn_Click;
            // 
            // AdelBtn
            // 
            AdelBtn.BackColor = Color.Red;
            AdelBtn.FlatStyle = FlatStyle.Flat;
            AdelBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdelBtn.ForeColor = SystemColors.ButtonHighlight;
            AdelBtn.Location = new Point(31, 543);
            AdelBtn.Name = "AdelBtn";
            AdelBtn.Size = new Size(189, 43);
            AdelBtn.TabIndex = 42;
            AdelBtn.Text = "Delete";
            AdelBtn.UseVisualStyleBackColor = false;
            AdelBtn.Visible = false;
            AdelBtn.Click += AdelBtn_Click;
            // 
            // AtxtDName
            // 
            AtxtDName.Location = new Point(666, 130);
            AtxtDName.Name = "AtxtDName";
            AtxtDName.Size = new Size(278, 27);
            AtxtDName.TabIndex = 41;
            // 
            // Atime
            // 
            Atime.Format = DateTimePickerFormat.Time;
            Atime.Location = new Point(665, 238);
            Atime.Name = "Atime";
            Atime.Size = new Size(278, 27);
            Atime.TabIndex = 40;
            // 
            // Adate
            // 
            Adate.Location = new Point(666, 187);
            Adate.Name = "Adate";
            Adate.Size = new Size(278, 27);
            Adate.TabIndex = 39;
            // 
            // Astatus
            // 
            Astatus.FormattingEnabled = true;
            Astatus.Items.AddRange(new object[] { "COMPLETED", "PENDING", "CANCELLED" });
            Astatus.Location = new Point(669, 288);
            Astatus.Name = "Astatus";
            Astatus.Size = new Size(275, 28);
            Astatus.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(543, -40);
            label16.Name = "label16";
            label16.Size = new Size(143, 23);
            label16.TabIndex = 23;
            label16.Text = "Add Patient Form";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(81, -40);
            label17.Name = "label17";
            label17.Size = new Size(94, 23);
            label17.TabIndex = 22;
            label17.Text = "Patient List";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(709, 35);
            label18.Name = "label18";
            label18.Size = new Size(154, 23);
            label18.TabIndex = 37;
            label18.Text = "Appointment Form";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(171, 26);
            label19.Name = "label19";
            label19.Size = new Size(141, 23);
            label19.TabIndex = 36;
            label19.Text = "Appointment List";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(597, 288);
            label11.Name = "label11";
            label11.Size = new Size(61, 23);
            label11.TabIndex = 33;
            label11.Text = "Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(605, 232);
            label12.Name = "label12";
            label12.Size = new Size(51, 23);
            label12.TabIndex = 31;
            label12.Text = "Time:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(605, 184);
            label13.Name = "label13";
            label13.Size = new Size(55, 23);
            label13.TabIndex = 29;
            label13.Text = "Date: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(592, 131);
            label14.Name = "label14";
            label14.Size = new Size(66, 23);
            label14.TabIndex = 27;
            label14.Text = "Doctor:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(585, 83);
            label15.Name = "label15";
            label15.Size = new Size(73, 23);
            label15.TabIndex = 25;
            label15.Text = "Patient: ";
            // 
            // AtxtPName
            // 
            AtxtPName.Location = new Point(666, 79);
            AtxtPName.Name = "AtxtPName";
            AtxtPName.Size = new Size(278, 27);
            AtxtPName.TabIndex = 24;
            // 
            // appListView
            // 
            appListView.FullRowSelect = true;
            appListView.GridLines = true;
            appListView.Location = new Point(13, 56);
            appListView.Name = "appListView";
            appListView.Size = new Size(566, 465);
            appListView.TabIndex = 21;
            appListView.UseCompatibleStateImageBehavior = false;
            appListView.SelectedIndexChanged += appListView_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(559, 543);
            button2.Name = "button2";
            button2.Size = new Size(189, 43);
            button2.TabIndex = 20;
            button2.Text = "Add Appointment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(754, 543);
            button3.Name = "button3";
            button3.Size = new Size(189, 43);
            button3.TabIndex = 19;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // invPanel
            // 
            invPanel.Controls.Add(invListView);
            invPanel.Controls.Add(invAddBtn);
            invPanel.Controls.Add(IupdateBtn);
            invPanel.Controls.Add(IdelBtn);
            invPanel.Controls.Add(label20);
            invPanel.Controls.Add(label21);
            invPanel.Controls.Add(label24);
            invPanel.Controls.Add(invTxtSup);
            invPanel.Controls.Add(label25);
            invPanel.Controls.Add(invTxtPrice);
            invPanel.Controls.Add(label26);
            invPanel.Controls.Add(invTxtQuan);
            invPanel.Controls.Add(label27);
            invPanel.Controls.Add(invTxtName);
            invPanel.Controls.Add(invClearBtn);
            invPanel.Location = new Point(253, 46);
            invPanel.Name = "invPanel";
            invPanel.Size = new Size(954, 606);
            invPanel.TabIndex = 6;
            // 
            // invListView
            // 
            invListView.FullRowSelect = true;
            invListView.GridLines = true;
            invListView.Location = new Point(10, 63);
            invListView.Name = "invListView";
            invListView.Size = new Size(548, 455);
            invListView.TabIndex = 58;
            invListView.UseCompatibleStateImageBehavior = false;
            invListView.SelectedIndexChanged += invListView_SelectedIndexChanged;
            // 
            // invAddBtn
            // 
            invAddBtn.BackColor = Color.Green;
            invAddBtn.FlatStyle = FlatStyle.Flat;
            invAddBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invAddBtn.ForeColor = SystemColors.ButtonHighlight;
            invAddBtn.Location = new Point(556, 540);
            invAddBtn.Name = "invAddBtn";
            invAddBtn.Size = new Size(189, 43);
            invAddBtn.TabIndex = 57;
            invAddBtn.Text = "Add Inventory";
            invAddBtn.UseVisualStyleBackColor = false;
            invAddBtn.Click += invAddBtn_Click;
            // 
            // IupdateBtn
            // 
            IupdateBtn.BackColor = Color.DodgerBlue;
            IupdateBtn.FlatStyle = FlatStyle.Flat;
            IupdateBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IupdateBtn.ForeColor = SystemColors.ButtonHighlight;
            IupdateBtn.Location = new Point(669, 417);
            IupdateBtn.Name = "IupdateBtn";
            IupdateBtn.Size = new Size(189, 43);
            IupdateBtn.TabIndex = 56;
            IupdateBtn.Text = "Update Inventory";
            IupdateBtn.UseVisualStyleBackColor = false;
            IupdateBtn.Visible = false;
            IupdateBtn.Click += IupdateBtn_Click;
            // 
            // IdelBtn
            // 
            IdelBtn.BackColor = Color.Red;
            IdelBtn.FlatStyle = FlatStyle.Flat;
            IdelBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdelBtn.ForeColor = SystemColors.ButtonHighlight;
            IdelBtn.Location = new Point(50, 540);
            IdelBtn.Name = "IdelBtn";
            IdelBtn.Size = new Size(189, 43);
            IdelBtn.TabIndex = 55;
            IdelBtn.Text = "Delete";
            IdelBtn.UseVisualStyleBackColor = false;
            IdelBtn.Visible = false;
            IdelBtn.Click += IdelBtn_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(704, 64);
            label20.Name = "label20";
            label20.Size = new Size(125, 23);
            label20.TabIndex = 54;
            label20.Text = "Inventory Form";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(180, 21);
            label21.Name = "label21";
            label21.Size = new Size(112, 23);
            label21.TabIndex = 53;
            label21.Text = "Inventory List";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(577, 256);
            label24.Name = "label24";
            label24.Size = new Size(76, 23);
            label24.TabIndex = 48;
            label24.Text = "Supplier:";
            // 
            // invTxtSup
            // 
            invTxtSup.Location = new Point(661, 257);
            invTxtSup.Name = "invTxtSup";
            invTxtSup.Size = new Size(278, 27);
            invTxtSup.TabIndex = 47;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(567, 206);
            label25.Name = "label25";
            label25.Size = new Size(88, 23);
            label25.TabIndex = 46;
            label25.Text = "Unit Price:";
            // 
            // invTxtPrice
            // 
            invTxtPrice.Location = new Point(661, 206);
            invTxtPrice.Name = "invTxtPrice";
            invTxtPrice.Size = new Size(278, 27);
            invTxtPrice.TabIndex = 45;
            invTxtPrice.KeyPress += invTxtPrice_KeyPress;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(575, 158);
            label26.Name = "label26";
            label26.Size = new Size(80, 23);
            label26.TabIndex = 44;
            label26.Text = "Quantity:";
            // 
            // invTxtQuan
            // 
            invTxtQuan.Location = new Point(661, 158);
            invTxtQuan.Name = "invTxtQuan";
            invTxtQuan.Size = new Size(278, 27);
            invTxtQuan.TabIndex = 43;
            invTxtQuan.KeyPress += invTxtQuan_KeyPress;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(593, 114);
            label27.Name = "label27";
            label27.Size = new Size(60, 23);
            label27.TabIndex = 42;
            label27.Text = "Name:";
            // 
            // invTxtName
            // 
            invTxtName.Location = new Point(661, 108);
            invTxtName.Name = "invTxtName";
            invTxtName.Size = new Size(278, 27);
            invTxtName.TabIndex = 41;
            // 
            // invClearBtn
            // 
            invClearBtn.BackColor = Color.Red;
            invClearBtn.FlatStyle = FlatStyle.Flat;
            invClearBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invClearBtn.ForeColor = SystemColors.ButtonHighlight;
            invClearBtn.Location = new Point(759, 540);
            invClearBtn.Name = "invClearBtn";
            invClearBtn.Size = new Size(189, 43);
            invClearBtn.TabIndex = 38;
            invClearBtn.Text = "Clear";
            invClearBtn.UseVisualStyleBackColor = false;
            invClearBtn.Click += invClearBtn_Click;
            // 
            // reportPanel
            // 
            reportPanel.Controls.Add(rUpdateBtn);
            reportPanel.Controls.Add(rDelBtn);
            reportPanel.Controls.Add(rResult);
            reportPanel.Controls.Add(rType);
            reportPanel.Controls.Add(rDate);
            reportPanel.Controls.Add(label29);
            reportPanel.Controls.Add(label30);
            reportPanel.Controls.Add(label31);
            reportPanel.Controls.Add(label32);
            reportPanel.Controls.Add(rDoctor);
            reportPanel.Controls.Add(label33);
            reportPanel.Controls.Add(rPatient);
            reportPanel.Controls.Add(label34);
            reportPanel.Controls.Add(label35);
            reportPanel.Controls.Add(reportListView);
            reportPanel.Controls.Add(addReportBtn);
            reportPanel.Controls.Add(clearReportBtn);
            reportPanel.Location = new Point(250, 60);
            reportPanel.Name = "reportPanel";
            reportPanel.Size = new Size(975, 596);
            reportPanel.TabIndex = 7;
            // 
            // rUpdateBtn
            // 
            rUpdateBtn.BackColor = Color.DodgerBlue;
            rUpdateBtn.FlatStyle = FlatStyle.Flat;
            rUpdateBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rUpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            rUpdateBtn.Location = new Point(669, 406);
            rUpdateBtn.Name = "rUpdateBtn";
            rUpdateBtn.Size = new Size(189, 43);
            rUpdateBtn.TabIndex = 38;
            rUpdateBtn.Text = "Update Report";
            rUpdateBtn.UseVisualStyleBackColor = false;
            rUpdateBtn.Visible = false;
            rUpdateBtn.Click += rUpdateBtn_Click;
            // 
            // rDelBtn
            // 
            rDelBtn.BackColor = Color.Red;
            rDelBtn.FlatStyle = FlatStyle.Flat;
            rDelBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rDelBtn.ForeColor = SystemColors.ButtonHighlight;
            rDelBtn.Location = new Point(35, 531);
            rDelBtn.Name = "rDelBtn";
            rDelBtn.Size = new Size(189, 43);
            rDelBtn.TabIndex = 37;
            rDelBtn.Text = "Delete";
            rDelBtn.UseVisualStyleBackColor = false;
            rDelBtn.Visible = false;
            rDelBtn.Click += rDelBtn_Click;
            // 
            // rResult
            // 
            rResult.FormattingEnabled = true;
            rResult.Items.AddRange(new object[] { "POSITIVE", "NEGATIVE", "FAILED", "PASS" });
            rResult.Location = new Point(683, 318);
            rResult.Name = "rResult";
            rResult.Size = new Size(278, 28);
            rResult.TabIndex = 36;
            // 
            // rType
            // 
            rType.FormattingEnabled = true;
            rType.Items.AddRange(new object[] { "HEART SCAN", "LUNG SCAN", "HIV/AIDS TEST", "MALARIA TEST" });
            rType.Location = new Point(683, 266);
            rType.Name = "rType";
            rType.Size = new Size(278, 28);
            rType.TabIndex = 35;
            // 
            // rDate
            // 
            rDate.Location = new Point(678, 213);
            rDate.Name = "rDate";
            rDate.Size = new Size(279, 27);
            rDate.TabIndex = 34;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(613, 318);
            label29.Name = "label29";
            label29.Size = new Size(60, 23);
            label29.TabIndex = 33;
            label29.Text = "Result:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(537, 267);
            label30.Name = "label30";
            label30.Size = new Size(140, 23);
            label30.TabIndex = 31;
            label30.Text = "Report/Test Type:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(623, 213);
            label31.Name = "label31";
            label31.Size = new Size(50, 23);
            label31.TabIndex = 29;
            label31.Text = "Date:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(606, 165);
            label32.Name = "label32";
            label32.Size = new Size(66, 23);
            label32.TabIndex = 27;
            label32.Text = "Doctor:";
            // 
            // rDoctor
            // 
            rDoctor.Location = new Point(678, 164);
            rDoctor.Name = "rDoctor";
            rDoctor.Size = new Size(278, 27);
            rDoctor.TabIndex = 26;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(599, 118);
            label33.Name = "label33";
            label33.Size = new Size(68, 23);
            label33.TabIndex = 25;
            label33.Text = "Patient:";
            // 
            // rPatient
            // 
            rPatient.Location = new Point(678, 114);
            rPatient.Name = "rPatient";
            rPatient.Size = new Size(278, 27);
            rPatient.TabIndex = 24;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(728, 73);
            label34.Name = "label34";
            label34.Size = new Size(104, 23);
            label34.TabIndex = 23;
            label34.Text = "Report Form";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(227, 7);
            label35.Name = "label35";
            label35.Size = new Size(98, 23);
            label35.TabIndex = 22;
            label35.Text = "Reports List";
            // 
            // reportListView
            // 
            reportListView.FullRowSelect = true;
            reportListView.GridLines = true;
            reportListView.Location = new Point(22, 39);
            reportListView.Name = "reportListView";
            reportListView.Size = new Size(513, 465);
            reportListView.TabIndex = 21;
            reportListView.UseCompatibleStateImageBehavior = false;
            reportListView.SelectedIndexChanged += reportListView_SelectedIndexChanged;
            // 
            // addReportBtn
            // 
            addReportBtn.BackColor = Color.Green;
            addReportBtn.FlatStyle = FlatStyle.Flat;
            addReportBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addReportBtn.ForeColor = SystemColors.ButtonHighlight;
            addReportBtn.Location = new Point(567, 526);
            addReportBtn.Name = "addReportBtn";
            addReportBtn.Size = new Size(189, 43);
            addReportBtn.TabIndex = 20;
            addReportBtn.Text = "Add Report";
            addReportBtn.UseVisualStyleBackColor = false;
            addReportBtn.Click += addReportBtn_Click;
            // 
            // clearReportBtn
            // 
            clearReportBtn.BackColor = Color.Red;
            clearReportBtn.FlatStyle = FlatStyle.Flat;
            clearReportBtn.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearReportBtn.ForeColor = SystemColors.ButtonHighlight;
            clearReportBtn.Location = new Point(762, 526);
            clearReportBtn.Name = "clearReportBtn";
            clearReportBtn.Size = new Size(189, 43);
            clearReportBtn.TabIndex = 19;
            clearReportBtn.Text = "Clear";
            clearReportBtn.UseVisualStyleBackColor = false;
            clearReportBtn.Click += clearReportBtn_Click;
            // 
            // dashPnl
            // 
            dashPnl.Controls.Add(pictureBox1);
            dashPnl.Controls.Add(label36);
            dashPnl.Controls.Add(panel5);
            dashPnl.Controls.Add(panel4);
            dashPnl.Controls.Add(panel3);
            dashPnl.Controls.Add(panel2);
            dashPnl.Location = new Point(250, 43);
            dashPnl.Name = "dashPnl";
            dashPnl.Size = new Size(975, 626);
            dashPnl.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(402, 347);
            label36.Name = "label36";
            label36.Size = new Size(171, 41);
            label36.TabIndex = 3;
            label36.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblRCount);
            panel5.Controls.Add(label28);
            panel5.Location = new Point(751, 466);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 111);
            panel5.TabIndex = 3;
            // 
            // lblRCount
            // 
            lblRCount.AutoSize = true;
            lblRCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRCount.Location = new Point(39, 12);
            lblRCount.Name = "lblRCount";
            lblRCount.Size = new Size(121, 41);
            lblRCount.TabIndex = 4;
            lblRCount.Text = "label36";
            lblRCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(46, 66);
            label28.Name = "label28";
            label28.Size = new Size(92, 31);
            label28.TabIndex = 3;
            label28.Text = "Reports";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblICount);
            panel4.Controls.Add(label23);
            panel4.Location = new Point(497, 466);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 111);
            panel4.TabIndex = 2;
            // 
            // lblICount
            // 
            lblICount.AutoSize = true;
            lblICount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblICount.Location = new Point(44, 13);
            lblICount.Name = "lblICount";
            lblICount.Size = new Size(121, 41);
            lblICount.TabIndex = 3;
            lblICount.Text = "label36";
            lblICount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(41, 70);
            label23.Name = "label23";
            label23.Size = new Size(109, 31);
            label23.TabIndex = 2;
            label23.Text = "Inventory";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblACount);
            panel3.Controls.Add(label22);
            panel3.Location = new Point(259, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 106);
            panel3.TabIndex = 1;
            // 
            // lblACount
            // 
            lblACount.AutoSize = true;
            lblACount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblACount.Location = new Point(21, 5);
            lblACount.Name = "lblACount";
            lblACount.Size = new Size(121, 41);
            lblACount.TabIndex = 2;
            lblACount.Text = "label36";
            lblACount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(18, 68);
            label22.Name = "label22";
            label22.Size = new Size(160, 31);
            label22.TabIndex = 1;
            label22.Text = "Appointments";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblPCount);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(21, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 104);
            panel2.TabIndex = 0;
            // 
            // lblPCount
            // 
            lblPCount.AutoSize = true;
            lblPCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPCount.Location = new Point(38, 7);
            lblPCount.Name = "lblPCount";
            lblPCount.Size = new Size(121, 41);
            lblPCount.TabIndex = 1;
            lblPCount.Text = "label36";
            lblPCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(47, 64);
            label10.Name = "label10";
            label10.Size = new Size(95, 31);
            label10.TabIndex = 0;
            label10.Text = "Patients";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 695);
            ControlBox = false;
            Controls.Add(dashPnl);
            Controls.Add(menuPanel);
            Controls.Add(label1);
            Controls.Add(reportPanel);
            Controls.Add(patientPanel);
            Controls.Add(invPanel);
            Controls.Add(appointmentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS";
            menuPanel.ResumeLayout(false);
            patientPanel.ResumeLayout(false);
            patientPanel.PerformLayout();
            appointmentPanel.ResumeLayout(false);
            appointmentPanel.PerformLayout();
            invPanel.ResumeLayout(false);
            invPanel.PerformLayout();
            reportPanel.ResumeLayout(false);
            reportPanel.PerformLayout();
            dashPnl.ResumeLayout(false);
            dashPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel menuPanel;
        private Button logoutBtn;
        private Button patientBtn;
        private Button invBtn;
        private Button appointmentBtn;
        private Panel patientPanel;
        private Button patientClearBtn;
        private Button addPatientBtn;
        private Label label2;
        private TextBox PtxtAge;
        private TextBox PtxtFullName;
        private Label label3;
        private Button button1;
        private Label label9;
        private TextBox PtxtAddress;
        private Label label8;
        private TextBox PtxtPhone;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel appointmentPanel;
        private Label label18;
        private Label label19;
        private Label label11;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private Label label14;
        private TextBox textBox10;
        private Label label15;
        private TextBox AtxtPName;
        private Label label16;
        private Label label17;
        private ListView appListView;
        private Button button2;
        private Button button3;
        private Panel invPanel;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox textBox12;
        private Label label23;
        private TextBox textBox13;
        private Label label24;
        private TextBox invTxtSup;
        private Label label25;
        private TextBox invTxtPrice;
        private Label label26;
        private TextBox invTxtQuan;
        private Label label27;
        private TextBox invTxtName;
        private TextBox rPatient;
        private TextBox rDoctor;
        private ListView listView3;
        private Button rUpdateBtn;
        private Button invClearBtn;
        private Panel reportPanel;
        private Label label29;
        private TextBox textBox19;
        private Label label30;
        private Label label31;
        private Label label32;
        private TextBox textBox22;
        private Label label33;
        private TextBox textBox23;
        private Label label34;
        private Label label35;
        private ListView reportListView;
        private Button addReportBtn;
        private Button clearReportBtn;
        private ListView patientListView;
        private ComboBox Pgender;
        private DateTimePicker PtxtDob;
        private Button PdelBtn;
        private Button PupdateBtn;
        private ComboBox Astatus;
        private DateTimePicker Adate;
        private DateTimePicker Atime;
        private TextBox AtxtDName;
        private Button AupdateBtn;
        private Button AdelBtn;
        private Button IupdateBtn;
        private Button IdelBtn;
        private ListView invListView;
        private Button invAddBtn;
        private DateTimePicker rDate;
        private ComboBox rResult;
        private ComboBox rType;
        private Button rDelBtn;
        private Panel dashPnl;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label lblRCount;
        private Label label28;
        private Label lblICount;
        private Label lblACount;
        private Label lblPCount;
        private Label label10;
        private Button btnDash;
        private Label label36;
        private PictureBox pictureBox1;
    }
}