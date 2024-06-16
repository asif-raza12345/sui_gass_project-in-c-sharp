using ModleLayer;
using MySql.Data.MySqlClient;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.IO;
using Mysqlx.Session;
using System.Drawing.Text;

namespace Siu_Gass_DataBaseSystem
{
    public partial class Form1 : Form
    {
        byte[]  image_data;
            
        public Form1()
        {
           
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BillBusiness.SelectAllBillBusiness();
        }
        



        private void btninsertbill_Click(object sender, EventArgs e)
        {
            if (label6.Text != " ") {



                BillClass Bill = BillDetails();
                BillBusiness.AddBusinessDB(Bill);
                MessageBox.Show("New Bill Details added successfully!");

            }
            else
            {
                MessageBox.Show("please select picture");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            customerName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            meterID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            billingPeriod.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            billlingDate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            texes.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            totalBill.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            billMonth.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            serviceCharge.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            status.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            byte[] imageBytes = (byte[])dataGridView1.SelectedRows[0].Cells[10].Value;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
           
        




        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BillClass Bill = BillDetails();
            BillBusiness.UpdateBusinessDB(Bill);
            // updated query 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BillBusiness.SelectAllBillBusiness();
           



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            BillClass Bill = BillDetails();
            BillBusiness.DeleteBusinessDB(Bill);
        }

        private BillClass BillDetails()
        {
            return BillDelete();
        }

        private BillClass BillDelete()
        {
            return new BillClass()
            {
                CustomerID = customerID.Text,
                CustomerName = customerName.Text,
                MaterID = meterID.Text,
                Billingperiod = billingPeriod.Text,
                BillingissueDate = billlingDate.Text,
                BillMonth = billMonth.Text,
                Texes = texes.Text,
                Servicescharges = serviceCharge.Text,
                BillStatus = status.Text,
                TotalBill = totalBill.Text,
                picture = image_data

            };
        }
        private void Browsbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new  OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.jif; *.ping; *.bmp;|*.jpg; *.jpeg; *.jif; *.ping; *.bmp;";
            if(open.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                label6.Text = open.FileName;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                image_data = ms.ToArray();
                
            }
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
