using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ResistayDll.DlDb;
using ResistayDll.DLInterfaces;
using ResistayDLL.Bl;
using ResistayDLL.Utilities;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using TheArtOfDevHtmlRenderer.Adapters;
using static Guna.UI2.Native.WinApi;


namespace Resistay.UI
{
    public partial class FeesPayment : Form
    {
        Student student;
        IFees FeesDb = new FeesDb();
        private string ConnectionString = @"Data Source=DESKTOP-KOU2P2U\SQLEXPRESS01;Initial Catalog=Resistay;Integrated Security=True;";

        public FeesPayment()
        {
            InitializeComponent();
        }
        public FeesPayment(Student student) : this()
        {
            this.student = student;
            List<string> ChallanLists = FeesDb.GetFeesChallanNumberofStudent(student.GetName(),ConnectionString);
            ChallanCombo2.DataSource = ChallanLists;
            ChallansCombos.DataSource = ChallanLists;
            LoadTranscationHistory();
        }


        private void LoadTranscationHistory()
        {
            List<Fees> Feeslist = FeesDb.GetAllTranscationHistoryofStudent(student.GetName(), ConnectionString);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ChallanNumber", typeof(string));
            dataTable.Columns.Add("PidDate", typeof(string));
            dataTable.Columns.Add("Fees Amount", typeof(int));
            

            for (int i = 0; i < Feeslist.Count; i++)
            {
                if (Feeslist[i].GetFeeAmount() > 0)
                {
                    dataTable.Rows.Add(Feeslist[i].GetChallanNumber(), Feeslist[i].GetPayDate(), Feeslist[i].GetFeeAmount());

                }
            }

            FeesTranscationHistory.DataSource = dataTable;

        

        
        }


        private void ChallanLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerteChallanBtn_Click(object sender, EventArgs e)
        {
            string imagePath = "D:\\Computer science\\OOP\\Business Application Project\\Hostel Management\\image-removebg-preview (1).png";
            string receiptContent = GenerateReceipt();
            if (FeesDb.GetFeesByChallans(ChallanCombo2.Text, ConnectionString).GetFeeAmount()>0)
            {
                GeneratePDF(receiptContent, imagePath);
            }
            else
            {
                MessageBox.Show("There is no dues pending for this Challan Number");
            }
            
        }
        private string GenerateReceipt()
        {
            string receiptContent = "";
            if (student != null)
            {
                receiptContent += "\t\tResistay\t\t\t\t" + Environment.NewLine;
                receiptContent += "Student Name: " + "\t\t\t " + student.GetName() + Environment.NewLine;
                receiptContent += "Student CNIC: " + "\t\t\t " + student.GetCnic() + Environment.NewLine;
                receiptContent += "Hostel Name: " + "\t\t\t " + student.GetHostel().GetHostelName() + Environment.NewLine;
                receiptContent += "Room Number: " + "\t\t\t " + student.GetRoom().GetNumber() + Environment.NewLine;
                receiptContent += "Challan Number: " + "\t\t " + ChallanCombo2.Text + Environment.NewLine;
                receiptContent += "Fees amount: " + "\t\t\t " + FeesDb.GetFeesByChallans(ChallanCombo2.Text, ConnectionString).GetFeeAmount() + Environment.NewLine;
                receiptContent += "Due Date: " + "\t\t\t " + FeesDb.GetFeesByChallans(ChallanCombo2.Text, ConnectionString).GetDueDate() + Environment.NewLine;
                 

            }


            return receiptContent;
        }
        private void GeneratePDF(string receiptContent, string imagePath)
        {
            
            Bitmap bitmap = new Bitmap(imagePath);

            
            int newImageWidth = 200; 
            int newImageHeight = 200;

         
            Bitmap resizedImage = new Bitmap(newImageWidth, newImageHeight);

          
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
           
                graphics.DrawImage(bitmap, 0, 0, newImageWidth, newImageHeight);
            }

   
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
              
                graphics.Clear(Color.White);

             
                PointF imagePosition = new PointF(5, 5);

         
                graphics.DrawImage(resizedImage, imagePosition);

            
                using (Font font = new Font("Arial", 12))
                {
                    
                    PointF textPosition = new PointF(10, bitmap.Height - 220);

                    
                    graphics.DrawString(receiptContent, font, Brushes.Black, textPosition);
                }
            }

            
            bitmap.Save("challan.png", ImageFormat.Png);

         
            MessageBox.Show("Challan generated successfully.");
        }

         





        private void ChallansCombos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FeesPayment_Load(object sender, EventArgs e)
        {
             

        }

        private void PayFeesBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FeesPaid.Text) && int.TryParse(FeesPaid.Text, out int paidAmount) && paidAmount > 0)
            {
                int remainingAmount = FeesDb.GetFeesByChallans(ChallansCombos.Text, ConnectionString).GetFeeAmount() - paidAmount;
                if (remainingAmount >= 0)
                {
                    FeesDb.UpdateFeesandDate(remainingAmount, PaidFeesDate.Text, student.GetName(), ChallansCombos.Text, ConnectionString);
                    MessageBox.Show("Paid");
                }
                else
                {
                    MessageBox.Show("You entered an amount greater than the remaining fees.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input or amount entered.");
            }
            LoadTranscationHistory();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FeesPaymentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
