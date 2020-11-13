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
    public partial class Tables_Setup : Form
    {
        int id_room;
        string status;
        public Tables_Setup()
        {
            InitializeComponent();
        }

        private void Tables_Setup_Load(object sender, EventArgs e)
        {
            WelcomePanel.Dock = DockStyle.Fill;
            drawRooms();
        }

        private void drawRooms()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                Conection.MasterConnectio.connect.Open();
                SqlCommand cmd = new SqlCommand("show_Room", Conection.MasterConnectio.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Search", txtroom.Text);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read ())
                {
                    Button b = new Button();
                    Panel panelC1 = new Panel();
                    b.Text = rdr["Room"].ToString();
                    b.Name = rdr["Id_room"].ToString();
                    b.Dock = DockStyle.Fill;
                    b.BackColor = Color.Transparent;
                    b.Font = new System.Drawing.Font ("Microsoft Sans Serif", 12);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43);
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Tag = rdr["Status"].ToString();

                    panelC1.Size = new System.Drawing.Size(290, 58);
                    panelC1.Name = rdr["Id_room"].ToString();
                    string status;
                    status = rdr["Status"].ToString();
                    if (status == "ERASED")
                    {
                        b.Text = rdr["Room"].ToString() + " - Erased";
                        b.ForeColor = Color.FromArgb(231, 63, 67);
                    }
                    else
                    {
                        b.ForeColor = Color.White;
                    }
                    panelC1.Controls.Add(b);
                    flowLayoutPanel1.Controls.Add(panelC1);
                    b.Click += new EventHandler(buttonChange);

                }
                Conection.MasterConnectio.connect.Close();

            }
            catch (Exception ex)
            {
                Conection.MasterConnectio.connect.Close();
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void buttonChange(System.Object sender , EventArgs e)
        {
            WelcomePanel.Visible = false;
            WelcomePanel.Dock = DockStyle.None;
            TablePanel.Visible = true;
            TablePanel.Dock = DockStyle.Fill;
            id_room = Convert.ToInt32(((Button) sender).Name);
            status = Convert.ToString(((Button)sender).Tag);

            foreach (Panel panelC2 in flowLayoutPanel1.Controls)
            {
                if (panelC2 is Panel)
                {
                    foreach (Button boton in panelC2.Controls)
                    {
                        if (boton is Button)
                        {
                            boton.BackColor = Color.Transparent;
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modules.Tables_Rooms.Rooms frm = new Modules.Tables_Rooms.Rooms();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
        }
        public void frm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            drawRooms();
        }
    }
}
