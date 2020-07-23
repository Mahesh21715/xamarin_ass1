using MyAssignment.Models;
using MyAssignment.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyAssignment.ViewModel
{
   class MyEmplistViewModel
    {
     public ObservableCollection<MyEmplistModel> EmpList { get; set;} 

        public MyEmplistViewModel()
        {
            EmpList = new ObservableCollection<MyEmplistModel>();

            EmpList.Add(new MyEmplistModel 
            {   
                id="1",
                email="michael.lawson@req.in",
                first_name="Michael",
                last_name="Lawson",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/follettkyle/128.jpg",
                type="Permanent",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="Samuels",
                department="Sales",
                contact="+31-987445",
                gender="Male"
            });

            EmpList.Add(new MyEmplistModel
            {   
                id="2",
                email="lindsay.ferguson@req.in",
                first_name="Lindsay",
                last_name="Ferguson",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/araa3185/128.jpg",
                type="Permanent",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="David",
                department="Marketing",
                contact="+61-98745445",
                gender="Female"
            });

            EmpList.Add(new MyEmplistModel 
            { 
                id="3",
                email="tobias.funke@req.in",
                first_name="Tobias",
                last_name="Funke",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/vivekprvr/128.jpg",
                type="Permanent",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="David",
                department="Sales",
                contact="+1-897913",
                gender="Male"
            });

            EmpList.Add(new MyEmplistModel 
            {
                id="4",
                email="byron.fields@req.in",
                first_name="Byron",
                last_name="Fields",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/russoedu/128.jpg",
                type="Permanent",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="David",
                department="Sales",
                contact="+21-646655",
                gender="Male"
            });

            EmpList.Add(new MyEmplistModel 
            { 
                id="5",
                email="george.edwards@req.in",
                first_name="George",
                last_name="Edwards",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/mrmoiree/128.jpg",
                type="Temporary",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="Samuels",
                department="Engineering",
                contact="+31-663513",
                gender="Male"
            });

            EmpList.Add(new MyEmplistModel 
            {   
                id="6",
                email="rachel.howell@req.in",
                first_name="Rachel",
                last_name="Howell",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/hebertialmeida/128.jpg",
                type="Permanent",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="David",
                department="HR",
                contact="+31-8785646",
                gender="Female" 
            });

            EmpList.Add(new MyEmplistModel 
            {   
                id="7",
                email="rachel.howell@req.in",
                first_name="Fread",
                last_name="Harley",
                image="https://s3.amazonaws.com/uifaces/faces/twitter/hebertialmeida/128.jpg",
                type="Temporary",
                address="777 Brockton Avenue, Abington MA 2351",
                manager="Samuels",
                department="IT",
                contact="+54-9695521",
                gender="Male"
            });
        }
    }
}
