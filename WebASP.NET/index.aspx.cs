using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebASP.NET
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panelOrder.Visible = panPricing.Visible = false;


            //Add option to select pizza at position 0
            //Now vegeterian is on that location

            //If the page is not being loaded for the first time
            if (!Page.IsPostBack)
            {
                txtAddress.Visible = lblAddress.Visible = false;

                //cboPizza.Items.Insert(0, "--Select a Pizza--");
                cboPizza.Items.Add(new ListItem("Vegeterian", "10"));
                cboPizza.Items.Add(new ListItem("Hawaiian", "12"));
                cboPizza.Items.Add(new ListItem("All Dressed", "8"));
                cboPizza.Items.Add(new ListItem("Chicken Alfredo", "10"));

                lstPizzaSize.Items.Add(new ListItem("Small", "1"));
                lstPizzaSize.Items.Add(new ListItem("Medium", "1.5"));
                lstPizzaSize.Items.Add(new ListItem("Large", "2"));

                lstPizzaSize.SelectedIndex = 0;

                chklstToppings.Items.Add(new ListItem("Bacon", "3"));
                chklstToppings.Items.Add(new ListItem("Mushroom", "1.5"));
                chklstToppings.Items.Add(new ListItem("Extra Cheese", "2"));
                chklstToppings.Items.Add(new ListItem("Olive", "2.5"));

                radlstCrust.Items.Add(new ListItem("Normal"));
                radlstCrust.Items.Add(new ListItem("Thin"));
                radlstCrust.Items.Add(new ListItem("Thick"));

                radlstCrust.SelectedIndex = 0;
            }

            if (cboPizza.SelectedIndex > 0)
            {
                calculatePrice();
                panPricing.Visible = true;
            }
        }


        private void calculatePrice()
        {
            decimal basePrice = 0, delivery = 0, total = 0, toppings = 0, subTotal = 0, tax = 0;

            basePrice = Convert.ToDecimal(cboPizza.SelectedItem.Value) * Convert.ToDecimal(lstPizzaSize.SelectedItem.Value);

            litPricing.Text = "<br/>Base Price: $" + basePrice + "</br>";

            if (chkDelivery.Checked)
            {
                delivery = 3;
                litPricing.Text += "Delivery Price: $" + delivery + "</br>";
            }

            foreach (ListItem item in chklstToppings.Items)
            {
                //If an item is selected, add the value to the toppings else 0
                //Ternary operation
                //+= recursion
                toppings += (item.Selected) ? Convert.ToDecimal(item.Value) : 0;
            }

            litPricing.Text += "Topping Price: $" + toppings + "</br>";

            subTotal = basePrice + delivery + toppings;
            litPricing.Text += "Sub Total Price: $" + subTotal + "</br>";

            tax = Math.Round(subTotal * Convert.ToDecimal(0.15),2);
            litPricing.Text += "Tax: $" + tax + "</br>";

            total = Math.Round(tax + subTotal,2);
            litPricing.Text += "Total Price: $" + total + "</br>";

        }


        protected void btnOrder_Click(object sender, EventArgs e)
        {
            panelOrder.Visible = true;

            litOrder.Text = "Sir/Miss " + txtCustomer.Text +
                ", </br>Your order for a " +
                lstPizzaSize.SelectedItem.Text +
                "</br>" + cboPizza.SelectedItem.Text +
                "Pizza</br> With toppings of: <ul> ";

            foreach (ListItem item in chklstToppings.Items)
            {
                litOrder.Text += item.Selected ? "<li>" + item.Text + "</li>" : "";
            }

            litOrder.Text += "</ul> On a " + radlstCrust.SelectedItem.Text + " crust </br>";
            litOrder.Text += chkDelivery.Checked ? "Will be delivered at </br>" + txtAddress.Text : "The Pizza will be picked up.";
        }

        protected void cboPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {

            txtAddress.Visible = lblAddress.Visible = chkDelivery.Checked;
           // txtAddress.Visible = lblAddress.Visible = chkDelivery.Checked ? true : false;

        }
    }
}