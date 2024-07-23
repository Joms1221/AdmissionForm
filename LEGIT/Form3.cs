using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace LEGIT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();





        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            string Counter = (File.ReadAllText("studentsid.txt"));
            int counterint = (Convert.ToInt32(Counter));
            counterint++;
            int students = counterint;
            string firstName = Fname.Text;
            string lastname = Lastname.Text;
            string middlename = Middleinitial.Text;
            string birthDate = Birthday.Value.ToString("yyyy-MM-dd");
            string gender = male.Checked ? "Male" : "Female";
            string number = Phonenumber.Text;
            string email = Emailadd.Text;
            string address = Completeadd.Text;
            string zipcode = Zipcode.Text;
            string contact = Emergency.Text;
            File.AppendAllText($"studentsid.txt ",students + Environment.NewLine);
            string studentdata = $"{firstName} , {lastname} , {middlename} , {birthDate} , {gender} , {number},{email} , {address} , {zipcode} , {contact}";
            File.AppendAllText("student_data.txt", studentdata + Environment.NewLine);
            string basicInfo = $"{students},{firstName}, {address},{contact},{number},{zipcode},";
            File.AppendAllText("Students_Data.txt", basicInfo + Environment.NewLine);
            MessageBox.Show("Saved Successfully");


            File.Delete("studentsid.txt");
            File.AppendAllText($"studentsid.txt" , Convert.ToString(counterint));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //back-button
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
