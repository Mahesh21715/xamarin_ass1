using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAssignment.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEmpDetailsPage : ContentPage
    {
        public MyEmpDetailsPage(string id, string email, string fname, string lname, string imgpath, string typ, string addr, string mgnr, string dprt, string contact, string gender)
        {
            InitializeComponent();

            EmpId.Text = id;
            EmpEmail.Text = email;
            EmpFirstName.Text = fname;
            EmpLastName.Text = lname;
            EmpType.Text = typ;
            EmpAddress.Text = addr;
            EmpManager.Text = mgnr;
            EmpDepartment.Text = dprt;
            EmpContact.Text = contact;
            EmpGender.Text = gender;

            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(imgpath)
            };
        }
    }

}