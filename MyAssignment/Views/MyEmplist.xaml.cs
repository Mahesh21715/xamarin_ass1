using MyAssignment.Models;
using MyAssignment.ViewModel;
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
    public partial class MyEmplist : ContentPage
    {
        public MyEmplist()
        {
            InitializeComponent();

            BindingContext = new MyEmplistViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyEmplistModel;
            await Navigation.PushAsync(new MyEmpDetailsPage(mydetails.id,mydetails.email, mydetails.first_name, mydetails.last_name, mydetails.image, mydetails.type,mydetails.address, mydetails.manager, mydetails.department, mydetails.contact, mydetails.gender));
        }
    }
}