using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s = string.Empty;
            int currentHour = DateTime.Now.Hour;
            if (currentHour < 12)
            {
                s = "Good morning!";
            }
            else if (currentHour < 18)
            {
                s = "Good afternoon!";
            }
            else
            {
                s = "Good evening!";
            }   
            Stephen.Text = "Night Night";
        }
    }
}
