using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
using ResistayDLL.Bl;

namespace Resistay.UI
{
    public partial class SalaryReieve : Form
    {
        private RT rt;
        ISalary SalaryDb = new SalaryDb();
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True";
        public SalaryReieve()
        {
            InitializeComponent();
        }
        private void LoadChecks()
        {
            List<Salary> Checklist = SalaryDb.GetAllRecievedChecks(rt.GetName(),ConnectionString);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CheckNumbers", typeof(string));
            dataTable.Columns.Add("Amount", typeof(int));
            dataTable.Columns.Add("IssueDate", typeof(string));
            dataTable.Columns.Add("RecievedDate", typeof(string));



            for (int i = 0; i < Checklist.Count; i++)
            {
                if (Checklist[i].GetCheckAmunt() > 0)
                {
                    dataTable.Rows.Add(Checklist[i].GetCheckNumber(), Checklist[i].GetCheckAmunt(), Checklist[i].GetIssueDate(), Checklist[i].GetRecievedDate());

                }
            }

            RecievableChecks.DataSource = dataTable;
        }
        public SalaryReieve(RT rt) : this()
        {
            this.rt = rt;
            List<string> checkLists = SalaryDb.GetCheckNumber(rt.GetName(), ConnectionString);
            CheckCombo2.DataSource = checkLists;
            LoadChecks();

        }

        private void GenerteCheckBtn_Click(object sender, EventArgs e)
        {
            SalaryDb.UpdateSalaryandDate(RecieveDate.Text,rt.GetName(),CheckCombo2.Text,ConnectionString);
            string imagePath1 = "D:\\Computer science\\OOP\\Business Application Project\\Hostel Management\\image-removebg-preview (1).png";
            string imagepath2 = "D:\\Computer science\\OOP\\Business Application Project\\Hostel Management\\Signature.png";
            string receiptContent = GenerateReceipt();
            GenerateCheck(receiptContent,imagePath1,imagepath2);
            LoadChecks();


        }
        private void GenerateCheck(string receiptContent, string firstImagePath, string secondImagePath)
        {
        
            Bitmap firstBitmap = new Bitmap(firstImagePath);

  
            Bitmap secondBitmap = new Bitmap(secondImagePath);

       
            int checkWidth = 670; 
            int checkHeight = 250;

      
            Bitmap checkBitmap = new Bitmap(checkWidth, checkHeight);

          
            checkBitmap.SetResolution(72, 72);

            
            using (Graphics graphics = Graphics.FromImage(checkBitmap))
            {
                
                graphics.Clear(Color.White);

               
                int firstImageWidth = 100; 
                int firstImageHeight = 100; 
                int firstImageX = 5; 
                int firstImageY = 5; 

            
                graphics.DrawImage(firstBitmap, firstImageX, firstImageY, firstImageWidth, firstImageHeight);

               
                int secondImageWidth = 70; 
                int secondImageHeight = 70;
                int secondImageX = 450;
                int secondImageY = 200; 

                
                graphics.DrawImage(secondBitmap, secondImageX, secondImageY, secondImageWidth, secondImageHeight);

              
                using (Font font = new Font("Arial", 12))
                {
                 
                    float textX = 10; 
                    float textY = checkHeight - 150; 

              
                    graphics.DrawString(receiptContent, font, Brushes.Black, textX, textY);
                }
            }

       
            checkBitmap.Save("check.png", ImageFormat.Png);

      
            MessageBox.Show("Check generated successfully.");
        }
        private string GenerateReceipt()
        {
            string receiptContent = "";
            if (rt != null)
            {
                receiptContent += "\t\t\t\tResistay\t\t\t\t" + Environment.NewLine;
                receiptContent += "Resident Tutor Name: " + "\t\t\t\t " + rt.GetName() + Environment.NewLine;
                receiptContent += "Resident Tutor CNIC: " + "\t\t\t\t " + rt.GetCnic() + Environment.NewLine;
                receiptContent += "Hostel Name: " + "\t\t\t\t\t " + rt.GetHostel().GetHostelName() + Environment.NewLine;
                 receiptContent += "Check Number: " + "\t\t\t\t\t " + CheckCombo2.Text + Environment.NewLine;
                receiptContent += "Check Amount: " + "\t\t\t\t\t " + SalaryDb.GetAmountByChallans(CheckCombo2.Text,ConnectionString).GetCheckAmunt() + Environment.NewLine;
                receiptContent += "Issue Date: " + "\t\t\t\t\t " + SalaryDb.GetAmountByChallans(CheckCombo2.Text, ConnectionString).GetIssueDate() + Environment.NewLine;
                receiptContent += "Recieve Date: " + "\t\t\t\t\t" + SalaryDb.GetAmountByChallans(CheckCombo2.Text, ConnectionString).GetRecievedDate() + Environment.NewLine;
                receiptContent += "\n\t\t\t\t\t\t\tWarden Signature:\t\t\t\t" + Environment.NewLine;


            }
            return receiptContent;
        }
            private void SalaryReieve_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
