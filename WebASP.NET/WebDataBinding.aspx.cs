using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; //Call the library to create DataTable

namespace WebASP.NET
{
    public partial class WebDataBinding : System.Web.UI.Page
    {
        static DataTable myTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            myTable = CreateTable();

            if (!Page.IsPostBack)
            {
                lstCourses.DataTextField = "Number";
            }
        }

        private static DataTable CreateTable()
        {
            //Create the table (DB)
            DataTable myTable = new DataTable("Courses");

            //Creating columns of the table
            myTable.Columns.Add("Number", typeof(string));
            myTable.Columns.Add("Title", typeof(string));
            myTable.Columns.Add("Duration", typeof(Int32));
            myTable.Columns.Add("Teacher", typeof(string));

            //Creating Rows
            DataRow myRow = myTable.NewRow();
            myRow["Number"] = "420-P16-AS";
            myRow["Title"] = "Structured Programming";
            myRow["Duration"] = 70;
            myRow["Teacher"] = "Quang Hoang Cao";
            myTable.Rows.Add(myRow);

            myRow = myTable.NewRow();
            myRow["Number"] = "420-P25-AS";
            myRow["Title"] = "Advance OOP Programming";
            myRow["Duration"] = 80;
            myRow["Teacher"] = "Fode Toré";
            myTable.Rows.Add(myRow);

            myRow = myTable.NewRow();
            myRow["Number"] = "420-P16-AS";
            myRow["Title"] = "Web Development";
            myRow["Duration"] = 90;
            myRow["Teacher"] = "Jean Fronçois";
            myTable.Rows.Add(myRow);

            myRow = myTable.NewRow();
            myRow["Number"] = "420-P11-AS";
            myRow["Title"] = "DataBase";
            myRow["Duration"] = 70;
            myRow["Teacher"] = "Kaveh Bakhtiyari";
            myTable.Rows.Add(myRow);

            return myTable;
        }

        protected void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in myTable.Rows)
            {
                if(row["Number"].ToString() == lstCourses.SelectedItem.Text)
                {
                    txtNumber.Text = row["Number"].ToString();
                    txtTitle.Text = row["Title"].ToString();
                    txtDuration.Text = row["Duration"].ToString();
                    txtTeacher.Text = row["Teacher"].ToString();
                    break;
                }
            }

            
        }

        protected void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cboTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //To load the data from the table
            DataTable tb = myTable.Clone();

            //Show the data on GridView

        }

        protected void gridViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}