using IMS_system.user_controls;
using IMS_system.user_controls.Controlers;
using IMS_system.user_controls.Main_UC_Forms;
using IMS_system.user_controls.Sub_UC_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Home_Panel_Form uc = new Home_Panel_Form();
            addUsercontrols(uc);
        }

        private void addUsercontrols(UserControl userControl)
        {   
            userControl.Dock = DockStyle.Fill;
            Dash_Panel.Controls.Clear();
            Dash_Panel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Home_Panel_Form uc = new Home_Panel_Form();
            addUsercontrols(uc);
        }

        private void Dash_Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            Customer_Panel_Form uc = new Customer_Panel_Form();
            addUsercontrols(uc);
        }

        private void item_button_Click(object sender, EventArgs e)
        {
            Item_Panel_Form uc = new Item_Panel_Form();
            addUsercontrols(uc);
        }

        private void supplier_button_Click(object sender, EventArgs e)
        {
            Supplier_Panel_Form uc = new Supplier_Panel_Form();
            addUsercontrols(uc);
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            Help_Controler uc = new Help_Controler();
            addUsercontrols(uc);
        }

        private void left_menu_Paint(object sender, PaintEventArgs e)
        {
            Supplier_Panel_Form uc = new Supplier_Panel_Form();
            addUsercontrols(uc);
        }

        private void cus_register_Click(object sender, EventArgs e)
        {
            Registation uc = new Registation();
            addUsercontrols(uc);
        }

        private void manage_customer_Click(object sender, EventArgs e)
        {
            Update_Customer_details uc = new Update_Customer_details();
            addUsercontrols(uc);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Customer_Stetus uc = new Customer_Stetus();
            addUsercontrols(uc);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Search_Result_Form uc = new Search_Result_Form();
            addUsercontrols(uc);
        }

        private void add_item_Click(object sender, EventArgs e)
        {
            Add_New_Item uc = new Add_New_Item();
            addUsercontrols(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_Panel_Form uc = new Home_Panel_Form();
            addUsercontrols(uc);
        }

        private void manage_Click(object sender, EventArgs e)
        {
            Manage_Item_Details uc = new Manage_Item_Details();
            addUsercontrols(uc);
        }

        private void item_print_Click(object sender, EventArgs e)
        {
            Item_Stetus uc = new Item_Stetus();
            addUsercontrols(uc);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Add_New_Employee uc = new Add_New_Employee();
            addUsercontrols(uc);
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            Manage_Employee_Details uc = new Manage_Employee_Details();
            addUsercontrols(uc);
        }

        private void btnStetusEmp_Click(object sender, EventArgs e)
        {
            Employee_Status uc = new Employee_Status();
            addUsercontrols(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Estimate_Bill uc = new Estimate_Bill();
            addUsercontrols(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Create_Invoice uc = new Create_Invoice();
            addUsercontrols(uc);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier_Report uc = new Supplier_Report();
            addUsercontrols(uc);
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            Stock__Report uc = new Stock__Report();
            addUsercontrols(uc);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice_Report uc = new Invoice_Report();
            addUsercontrols(uc);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void employee_button_Click_1(object sender, EventArgs e)
        {
            Employee_Panel_Form uc = new Employee_Panel_Form();
            addUsercontrols(uc);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financial_Panal_Form uc = new Financial_Panal_Form();
            addUsercontrols(uc);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            Sales_Report uc = new Sales_Report();
            addUsercontrols(uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewer_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnManage_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_items_submenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_employee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_supplier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_items_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbl_footer_Click(object sender, EventArgs e)
        {

        }

        private void fb_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
