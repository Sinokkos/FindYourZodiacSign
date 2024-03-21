using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindYourZodiacSign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TextBox bday= new TextBox();

            bday = tbBday.Text; // textbox dan seçtiğim

            int dDay = bday.Text; // Günü öğrenmek için
            string dMonth= bday.Text; // Ayı öğrenmek için

            string Sign = ZodiacSign("mounth", dDay);

            MessageBox.Show($"According to your information, your Zodiac Sign : {Sign} ");
        }

        public static string ZodiacSign(string mounth, int day)

        {

            if ((mounth.ToLower() == "Mart" && day >= 21) || (mounth.ToLower() == "Nisan" && day <= 20))
                return "Aries";
            else if ((mounth.ToLower() == "Nisan" && day >= 21) || (mounth.ToLower() == "Mayıs" && day <= 21))
                return "Taurus";
            else if ((mounth.ToLower() == "Mayıs" && day >= 22) || (mounth.ToLower() == "Haziran" && day <= 21))
                return "Gemini";
            else if ((mounth.ToLower() == "Haziran" && day >= 22) || (mounth.ToLower() == "Temmuz" && day <= 22))
                return "Cancer";
            else if ((mounth.ToLower() == "Temmuz" && day >= 23) || (mounth.ToLower() == "Ağustos" && day <= 22))
                return "Leo";
            else if ((mounth.ToLower() == "Ağustos" && day >= 23) || (mounth.ToLower() == "Eylül" && day <= 22))
                return "Virgo";
            else if ((mounth.ToLower() == "Eylül" && day >= 23) || (mounth.ToLower() == "Ekim" && day <= 22))
                return "Libra";
            else if ((mounth.ToLower() == "Ekim" && day >= 23) || (mounth.ToLower() == "Kasım" && day <= 21))
                return "Scorpio";
            else if ((mounth.ToLower() == "Kasım" && day >= 22) || (mounth.ToLower() == "Aralık" && day <= 21))
                return "Sagittarius";
            else if ((mounth.ToLower() == "Aralık" && day >= 22) || (mounth.ToLower() == "Ocak" && day <= 20))
                return "Capricorn";
            else if ((mounth.ToLower() == "Ocak" && day >= 21) || (mounth.ToLower() == "Şubat" && day <= 18))
                return "Aquarius";
            else if ((mounth.ToLower() == "Şubat" && day >= 19) || (mounth.ToLower() == "Mart" && day <= 20))
                return "Pisces";
            else
                return "Geçersiz Tarih girdiniz...";


        }
    }
}
