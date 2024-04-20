using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HMS
{
    public partial class Homepage : Form
    {
        // Initialize the form
        public Homepage()
        {
            InitializeComponent();
            InitState();
        }

        // Handler for the logout button click
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                LoginForm l = new LoginForm();
                this.Close();
                l.Show();
            }
        }

        // Handler for the patient button click
        private void patientBtn_Click(object sender, EventArgs e)
        {
            TogglePanel(patientPanel);
        }

        // Handler for the appointment button click
        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            TogglePanel(appointmentPanel);
        }

        // Handler for the inventory button click
        private void invBtn_Click(object sender, EventArgs e)
        {
            TogglePanel(invPanel);
        }

        // Method to toggle the visibility of panels
        private void TogglePanel(Panel p)
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel && panel != menuPanel)
                {
                    panel.Visible = (panel == p);
                }
            }
        }


        // Initialize the state of the form
        private void InitState()
        {
            // Set the visibility of panels
            appointmentPanel.Visible = false;
            patientPanel.Visible = false;
            invPanel.Visible = false;
            reportPanel.Visible = false;
            Astatus.Text = "PENDING";
            Pgender.Text = "MALE";
            rResult.Text = "POSITIVE";
            rType.Text = "HEART SCAN";
            GetPatientData();
            GetAppointmentData();
            GetInventoryData();
            GetReportData();
        }

        private void GetPatientData()
        {
            try
            {
                patientListView.View = View.Details;
                patientListView.GridLines = true;
                patientListView.Columns.Add("ID", 50);
                patientListView.Columns.Add("Name", 120);
                patientListView.Columns.Add("Age", 50);
                patientListView.Columns.Add("Date of Birth", 100);
                patientListView.Columns.Add("Gender", 80);
                patientListView.Columns.Add("Phone", 90);
                patientListView.Columns.Add("Address", 120);
                //db CONNECTION
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("select * from Patient", conn);
                SqlDataReader da;
                da = comm.ExecuteReader();

                while (da.Read())
                {
                    var item1 = patientListView.Items.Add(da[0].ToString());
                    item1.SubItems.Add(da[1].ToString());
                    item1.SubItems.Add(da[2].ToString());
                    var df = DateTime.Parse(da[3].ToString());
                    item1.SubItems.Add(df.ToString("dd/MMM/yyyy"));
                    item1.SubItems.Add(da[4].ToString());
                    item1.SubItems.Add(da[5].ToString());
                    item1.SubItems.Add(da[6].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }

        }

        private void GetAppointmentData()
        {
            try
            {
                appListView.View = View.Details;
                appListView.GridLines = true;
                appListView.Columns.Add("ID", 50);
                appListView.Columns.Add("Patient", 120);
                appListView.Columns.Add("Doctor", 120);
                appListView.Columns.Add("Date", 100);
                appListView.Columns.Add("Time", 80);
                appListView.Columns.Add("Status", 90);
                //db CONNECTION
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("select * from Appointment", conn);
                SqlDataReader da;
                da = comm.ExecuteReader();

                while (da.Read())
                {
                    var item1 = appListView.Items.Add(da[0].ToString());
                    item1.SubItems.Add(da[1].ToString());
                    item1.SubItems.Add(da[4].ToString());
                    var df = DateTime.Parse(da[2].ToString());
                    item1.SubItems.Add(df.ToString("dd/MMM/yyyy"));
                    item1.SubItems.Add(da[3].ToString());
                    item1.SubItems.Add(da[5].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }

        }

        private void GetInventoryData()
        {
            try
            {
                invListView.View = View.Details;
                invListView.GridLines = true;
                invListView.Columns.Add("ID", 50);
                invListView.Columns.Add("Name", 120);
                invListView.Columns.Add("Quantity", 80);
                invListView.Columns.Add("Unit Price", 100);
                invListView.Columns.Add("Supplier", 120);
                //db CONNECTION
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("select * from Inventory", conn);
                SqlDataReader da;
                da = comm.ExecuteReader();

                while (da.Read())
                {
                    var item1 = invListView.Items.Add(da[0].ToString());
                    item1.SubItems.Add(da[1].ToString());
                    item1.SubItems.Add(da[2].ToString());
                    item1.SubItems.Add(da[3].ToString());
                    item1.SubItems.Add(da[4].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }

        }

        private void GetReportData()
        {
            try
            {
                reportListView.View = View.Details;
                reportListView.GridLines = true;
                reportListView.Columns.Add("ID", 50);
                reportListView.Columns.Add("Patient", 120);
                reportListView.Columns.Add("Doctor", 120);
                reportListView.Columns.Add("Date", 100);
                reportListView.Columns.Add("Type", 120);
                reportListView.Columns.Add("Result", 100);

                //db CONNECTION
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("select * from Report", conn);
                SqlDataReader da;
                da = comm.ExecuteReader();

                while (da.Read())
                {
                    var item1 = reportListView.Items.Add(da[0].ToString());
                    item1.SubItems.Add(da[1].ToString());
                    item1.SubItems.Add(da[3].ToString());
                    item1.SubItems.Add(DateTime.Parse(da[2].ToString()).ToString("dd/MMM/yyy"));
                    item1.SubItems.Add(da[4].ToString());
                    item1.SubItems.Add(da[5].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }

        }

        private void invPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TogglePanel(reportPanel);
        }

        //PATIENT FUNCTIONS
        private String patientSelId = "";
        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String name = PtxtFullName.Text;
                String age = PtxtAge.Text;
                String Dob = PtxtDob.Text;
                String gender = Pgender.SelectedItem.ToString();
                String phone = PtxtPhone.Text;
                String address = PtxtAddress.Text;

                if (name == "" || age == "" || Dob == "" || gender == "" || phone == "" || address == "")
                {
                    MessageBox.Show("All Fields are required.");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Patient (Name,Age,Dob,Gender,Phone,Address) values (@Name,@Age,@Dob,@Gender,@Phone,@Address)", conn);
                comm.Parameters.AddWithValue("@Name", name);
                comm.Parameters.AddWithValue("@Age", age);
                comm.Parameters.AddWithValue("@Gender", gender);
                comm.Parameters.AddWithValue("@Dob", Dob);
                comm.Parameters.AddWithValue("@Phone", phone);
                comm.Parameters.AddWithValue("@Address", address);
                comm.ExecuteNonQuery();
                MessageBox.Show("Patient added successfully");
                patientListView.Clear();
                GetPatientData();
                PtxtAddress.Text = PtxtFullName.Text = PtxtAge.Text = PtxtPhone.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void patientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientClearBtn_Click(object sender, EventArgs e)
        {
            PtxtAddress.Text = PtxtFullName.Text = PtxtAge.Text = PtxtPhone.Text = "";
        }
        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (patientListView.SelectedItems.Count > 0)
            {
                patientSelId = patientListView.SelectedItems[0].Text;
                PdelBtn.Visible = true;
                PupdateBtn.Visible = true;
                addPatientBtn.Visible = false;

                var sItems = patientListView.SelectedItems[0].SubItems;
                PtxtFullName.Text = sItems[1].Text;
                PtxtAge.Text = sItems[2].Text;
                PtxtDob.Value = DateTime.Parse(sItems[3].Text);
                Pgender.Text = sItems[4].Text;
                PtxtPhone.Text = sItems[5].Text;
                PtxtAddress.Text = sItems[6].Text;
            }


            else
            {
                PdelBtn.Visible = false;
                PupdateBtn.Visible = false;
                addPatientBtn.Visible = true;
                patientSelId = "";
            }
        }

        private void PdelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                    conn.Open();
                    SqlCommand comm = new SqlCommand("delete from Patient where Id=@Id", conn);
                    comm.Parameters.AddWithValue("@Id", patientSelId);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted Successfully");
                    patientListView.Clear();
                    GetPatientData();
                    conn.Close();
                    PdelBtn.Visible = false;
                    PupdateBtn.Visible = false;
                    addPatientBtn.Visible = true;
                    patientSelId = "";
                    PtxtAddress.Text = PtxtFullName.Text = PtxtAge.Text = PtxtPhone.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void PupdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String name = PtxtFullName.Text;
                String age = PtxtAge.Text;
                String Dob = PtxtDob.Text;
                String gender = Pgender.SelectedItem.ToString();
                String phone = PtxtPhone.Text;
                String address = PtxtAddress.Text;

                if (name == "" || age == "" || Dob == "" || gender == "" || phone == "" || address == "")
                {
                    MessageBox.Show("All Fields are required.");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("update Patient SET Name=@Name,Age=@Age,Dob=@Dob,Gender=@Gender,Phone=@Phone,Address=@Address WHERE Id=@Id", conn);
                comm.Parameters.AddWithValue("@Name", name);
                comm.Parameters.AddWithValue("@Age", age);
                comm.Parameters.AddWithValue("@Gender", gender);
                comm.Parameters.AddWithValue("@Dob", Dob);
                comm.Parameters.AddWithValue("@Phone", phone);
                comm.Parameters.AddWithValue("@Address", address);
                comm.Parameters.AddWithValue("@Id", patientSelId);
                comm.ExecuteNonQuery();
                MessageBox.Show("Patient updated successfully");
                patientListView.Clear();
                GetPatientData();
                PtxtAddress.Text = PtxtFullName.Text = PtxtAge.Text = PtxtPhone.Text = "";
                conn.Close();
                PdelBtn.Visible = false;
                PupdateBtn.Visible = false;
                addPatientBtn.Visible = true;
                patientSelId = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        //APPOINTMENT FUNCTIONS
        private String appointmentSelId = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //Add apppointment
            try
            {
                String patient = AtxtPName.Text;
                String doctor = AtxtDName.Text;
                String time = Atime.Text;
                String date = Adate.Text;
                String status = Astatus.SelectedItem.ToString();

                if (patient == "" || doctor == "" || time == "" || date == "" || status == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Appointment (PatientName,DoctorName,Date,Time,Status) values (@PatientName,@DoctorName,@Date,@Time,@Status)", conn);
                comm.Parameters.AddWithValue("@PatientName", patient);
                comm.Parameters.AddWithValue("@DoctorName", doctor);
                comm.Parameters.AddWithValue("@Date", date);
                comm.Parameters.AddWithValue("@Time", time);
                comm.Parameters.AddWithValue("@Status", status);
                comm.ExecuteNonQuery();
                MessageBox.Show("Appointment added successfully");
                appListView.Clear();
                GetAppointmentData();
                AtxtPName.Text = AtxtDName.Text = Atime.Text = Adate.Text = "";
                Astatus.Text = "PENDING";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Appointment Clear Button
            AtxtPName.Text = AtxtDName.Text = Atime.Text = Adate.Text = "";
            Astatus.Text = "PENDING";
        }

        private void appListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appListView.SelectedItems.Count > 0)
            {
                appointmentSelId = appListView.SelectedItems[0].Text;
                AdelBtn.Visible = true;
                AupdateBtn.Visible = true;
                button2.Visible = false;

                var sItems = appListView.SelectedItems[0].SubItems;
                AtxtPName.Text = sItems[1].Text;
                AtxtDName.Text = sItems[2].Text;
                Adate.Value = DateTime.Parse(sItems[3].Text);
                Atime.Value = DateTime.Parse(sItems[4].Text);
                Astatus.Text = sItems[5].Text;


            }
            else
            {
                AdelBtn.Visible = false;
                AupdateBtn.Visible = false;
                button2.Visible = true;
                appointmentSelId = "";
            }
        }

        private void AdelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                    conn.Open();
                    SqlCommand comm = new SqlCommand("delete from Appointment where Id=@Id", conn);
                    comm.Parameters.AddWithValue("@Id", appointmentSelId);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Appointment Deleted Successfully");
                    appListView.Clear();
                    GetAppointmentData();
                    conn.Close();
                    AdelBtn.Visible = false;
                    AupdateBtn.Visible = false;
                    button2.Visible = true;
                    appointmentSelId = "";
                    AtxtPName.Text = AtxtDName.Text = Atime.Text = Adate.Text = "";
                    Astatus.Text = "PENDING";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void AupdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String patient = AtxtPName.Text;
                String doctor = AtxtDName.Text;
                String time = Atime.Text;
                String date = Adate.Text;
                String status = Astatus.SelectedItem.ToString();
                if (patient == "" || doctor == "" || time == "" || date == "" || status == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("update Appointment SET PatientName=@PatientName,DoctorName=@DoctorName,Date=@Date,Time=@Time,Status=@Status where Id=@Id", conn);
                comm.Parameters.AddWithValue("@PatientName", patient);
                comm.Parameters.AddWithValue("@DoctorName", doctor);
                comm.Parameters.AddWithValue("@Date", date);
                comm.Parameters.AddWithValue("@Time", time);
                comm.Parameters.AddWithValue("@Status", status);
                comm.Parameters.AddWithValue("@Id", appointmentSelId);
                comm.ExecuteNonQuery();
                MessageBox.Show("Appointment updated successfully");
                appListView.Clear();
                GetAppointmentData();
                AtxtPName.Text = AtxtDName.Text = Atime.Text = Adate.Text = "";
                Astatus.Text = "PENDING";
                AdelBtn.Visible = false;
                AupdateBtn.Visible = false;
                button2.Visible = true;
                appointmentSelId = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        // INVENTORY FUNCTIONS
        private String invSelId = "";
        private void invAddBtn_Click(object sender, EventArgs e)
        {
            //Add inventory
            try
            {
                String name = invTxtName.Text;
                String quantity = invTxtQuan.Text;
                String price = invTxtPrice.Text;
                String supplier = invTxtSup.Text;

                if (name == "" || quantity == "" || price == "" || supplier == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Inventory (Name,Quantity,UnitPrice,Supplier) values (@Name,@Quantity,@UnitPrice,@Supplier)", conn);
                comm.Parameters.AddWithValue("@Name", name);
                comm.Parameters.AddWithValue("@Quantity", quantity);
                comm.Parameters.AddWithValue("@UnitPrice", price);
                comm.Parameters.AddWithValue("@Supplier", supplier);
                comm.ExecuteNonQuery();
                MessageBox.Show("Inventory added successfully");
                invListView.Clear();
                GetInventoryData();
                invTxtName.Text = invTxtPrice.Text = invTxtQuan.Text = invTxtSup.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void invClearBtn_Click(object sender, EventArgs e)
        {
            invTxtName.Text = invTxtPrice.Text = invTxtQuan.Text = invTxtSup.Text = "";
        }

        private void invListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invListView.SelectedItems.Count > 0)
            {
                invSelId = invListView.SelectedItems[0].Text;
                IdelBtn.Visible = !false;
                IupdateBtn.Visible = !false;
                invAddBtn.Visible = !true;

                var sItems = invListView.SelectedItems[0].SubItems;
                invTxtName.Text = sItems[1].Text;
                invTxtQuan.Text = sItems[2].Text;
                invTxtPrice.Text = sItems[3].Text;
                invTxtSup.Text = sItems[4].Text;
            }


            else
            {
                IdelBtn.Visible = false;
                IupdateBtn.Visible = false;
                invAddBtn.Visible = true;
                invSelId = "";
            }
        }

        private void IdelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this inventory?", "Delete Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                    conn.Open();
                    SqlCommand comm = new SqlCommand("delete from Inventory where Id=@Id", conn);
                    comm.Parameters.AddWithValue("@Id", invSelId);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Inventory Deleted Successfully");
                    invListView.Clear();
                    GetInventoryData();
                    conn.Close();
                    IdelBtn.Visible = false;
                    IupdateBtn.Visible = false;
                    invAddBtn.Visible = true;
                    invSelId = "";
                    invTxtName.Text = invTxtPrice.Text = invTxtQuan.Text = invTxtSup.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void IupdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String name = invTxtName.Text;
                String quantity = invTxtQuan.Text;
                String price = invTxtPrice.Text;
                String supplier = invTxtSup.Text;

                if (name == "" || quantity == "" || price == "" || supplier == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("update Inventory SET Name=@Name,Quantity=@Quantity,UnitPrice=@UnitPrice,Supplier=@Supplier where Id=@Id", conn);
                comm.Parameters.AddWithValue("@Name", name);
                comm.Parameters.AddWithValue("@Quantity", quantity);
                comm.Parameters.AddWithValue("@UnitPrice", price);
                comm.Parameters.AddWithValue("@Supplier", supplier);
                comm.Parameters.AddWithValue("@Id", invSelId);
                comm.ExecuteNonQuery();
                MessageBox.Show("Inventory updated successfully");
                invListView.Clear();
                GetInventoryData();
                IdelBtn.Visible = false;
                IupdateBtn.Visible = false;
                invAddBtn.Visible = true;
                invSelId = "";
                invTxtName.Text = invTxtPrice.Text = invTxtQuan.Text = invTxtSup.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        //REPORT FUNCTIONS
        private String reportSelId = "";
        private void addReportBtn_Click(object sender, EventArgs e)
        {
            //Add inventory
            try
            {
                String patient = rPatient.Text;
                String doctor = rDoctor.Text;
                String rtype = rType.Text;
                String date = rDate.Text;
                String result = rResult.Text;

                if (patient == "" || doctor == "" || rtype == "" || date == "" || result == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("insert into Report (PatientName,Date,DoctorName,ReportType,Results) values (@PatientName,@Date,@DoctorName,@ReportType,@Results)", conn);
                comm.Parameters.AddWithValue("@PatientName", patient);
                comm.Parameters.AddWithValue("@Date", date);
                comm.Parameters.AddWithValue("@DoctorName", doctor);
                comm.Parameters.AddWithValue("@Results", result);
                comm.Parameters.AddWithValue("@ReportType", rtype);
                comm.ExecuteNonQuery();
                MessageBox.Show("Report added successfully");
                reportListView.Clear();
                GetReportData();
                rPatient.Text = rDoctor.Text = rDate.Text = "";
                rResult.Text = "POSITIVE";
                rType.Text = "HEART SCAN";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }
        private void clearReportBtn_Click(object sender, EventArgs e)
        {
            rPatient.Text = rDoctor.Text = rDate.Text = "";
            rResult.Text = "POSITIVE";
            rType.Text = "HEART SCAN";

        }

        private void rDelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this report?", "Delete Report", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                    conn.Open();
                    SqlCommand comm = new SqlCommand("delete from Report where Id=@Id", conn);
                    comm.Parameters.AddWithValue("@Id", reportSelId);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Report Deleted Successfully");
                    reportListView.Clear();
                    GetReportData();
                    conn.Close();
                    rUpdateBtn.Visible = false;
                    rDelBtn.Visible = false;
                    addReportBtn.Visible = true;
                    reportSelId = "";
                    rPatient.Text = rDoctor.Text = rDate.Text = "";
                    rResult.Text = "POSITIVE";
                    rType.Text = "HEART SCAN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }

        private void rUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String patient = rPatient.Text;
                String doctor = rDoctor.Text;
                String rtype = rType.Text;
                String date = rDate.Text;
                String result = rResult.Text;

                if (patient == "" || doctor == "" || rtype == "" || date == "" || result == "")
                {
                    MessageBox.Show("All Fields are required.", "Error!");
                    return;
                }

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SI0VT1I;Initial Catalog=HMS;Integrated Security=True;Encrypt=False");
                conn.Open();
                SqlCommand comm = new SqlCommand("update Report SET PatientName=@PatientName,Date=@Date,DoctorName=@DoctorName,Results=@Results,ReportType=@ReportType where Id=@Id", conn);
                comm.Parameters.AddWithValue("@PatientName", patient);
                comm.Parameters.AddWithValue("@Date", date);
                comm.Parameters.AddWithValue("@DoctorName", doctor);
                comm.Parameters.AddWithValue("@Results", result);
                comm.Parameters.AddWithValue("@ReportType", rtype);
                comm.Parameters.AddWithValue("@Id", reportSelId);
                comm.ExecuteNonQuery();
                MessageBox.Show("Report updated successfully");
                reportListView.Clear();
                GetReportData();
                conn.Close();
                rUpdateBtn.Visible = false;
                rDelBtn.Visible = false;
                addReportBtn.Visible = true;
                reportSelId = "";
                rPatient.Text = rDoctor.Text = rDate.Text = "";
                rResult.Text = "POSITIVE";
                rType.Text = "HEART SCAN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured!");
            }
        }
        private void reportListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportListView.SelectedItems.Count > 0)
            {
                reportSelId = reportListView.SelectedItems[0].Text;
                rUpdateBtn.Visible = !false;
                rDelBtn.Visible = !false;
                addReportBtn.Visible = !true;

                var sItems = reportListView.SelectedItems[0].SubItems;
                rPatient.Text = sItems[1].Text;
                rDoctor.Text = sItems[2].Text;
                rDate.Value = DateTime.Parse(sItems[3].Text);
                rType.Text = sItems[4].Text;
                rResult.Text = sItems[5].Text;
            }


            else
            {
                rUpdateBtn.Visible = false;
                rDelBtn.Visible = false;
                addReportBtn.Visible = true;
                reportSelId = "";
            }
        }
        //COMMON VALIDATIONS
        private void PtxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void invTxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void invTxtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
    }
}
