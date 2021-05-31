using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueAndRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwapDouble_Click(object sender, EventArgs e)
        {
            string str = "";
            double a = double.Parse(lblDoubleA.Text);
            double b = double.Parse(lblDoubleB.Text);

            str += "original \tA : " + a + ", \tB : " + b + "\n";
            swapDouble(a, b);
            str += "result \tA : " + a + ", \tB : " + b;
            MessageBox.Show(str);
        }

        

        private void btnSwapString_Click(object sender, EventArgs e)
        {
            String str = "";
            string a = lblStringA.Text;
            string b = lblStringB.Text;

            str += "original \tA : " + a + ", \tB : " + b + "\n";
            swapString(a, b);
            str += "result \tA : " + a + ", \tB : " + b;
            MessageBox.Show(str);

        }

        private void btnSwapStringRef_Click(object sender, EventArgs e)
        {
            String str = "";
            string a = lblStringA.Text;
            string b = lblStringB.Text;

            str += "original \tA : " + a + ", \tB : " + b + "\n";
            swapStringRef(ref a, ref b);
            str += "result \tA : " + a + ", \tB : " + b;
            MessageBox.Show(str);
        }

        private void btnSwapStudent_Click(object sender, EventArgs e)
        {
            String str = "";
            Student a = new Student(lblStudentA.Text);
            Student b = new Student(lblStudentB.Text);
            str += "original \tA : " + a.Name + ", \tB : " + b.Name + "\n";
            swapStudent(a, b);
            str += "result \tA : " + a.Name + ", \tB : " + b.Name + "\n";
            MessageBox.Show(str);
        }

        private void swapDouble(double a, double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
        }

        private void swapString(string a, string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        private void swapStringRef(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        private void swapStudent(Student a, Student b)
        {
            Student tmp = a;
            a = b;
            b = tmp;
        }
    }

}
