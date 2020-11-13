using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RestaurantOsystem.Modules.Tables_Rooms
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            txtroomsetup.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_room();
        }
        private void insert_room()
        {
            try
            {
                Conection.MasterConnectio.connect.Open();
                SqlCommand cmd = new SqlCommand("insert_room", Conection.MasterConnectio.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Room", txtroomsetup.Text);
                cmd.ExecuteNonQuery();
                Conection.MasterConnectio.connect.Close();
                Close();
            }
            catch (Exception ex)
            {
                Conection.MasterConnectio.connect.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
