using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace RestaurantOsystem.Connection
{
    public partial class Manual_Connection : Form
    {
        private Libraries.AES aes = new Libraries.AES();
        int idtable;
        public Manual_Connection()
        {
            InitializeComponent();
        }
        public void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        string dbcnString;
        public void ReadfromXml()
        {
            try
            { 
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtCnString.Text = (aes.Decrypt(dbcnString, Libraries.Decrypt.appPwdUnique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {

            }
        }
        private void Manual_Connection_Load(object sender, EventArgs e)
        {
            ReadfromXml();

            
        }

        private void btn_GeCoSt_Click(object sender, EventArgs e)
        {
            test_connection();
        }
        private void test_connection()
        {
                SqlConnection con = new SqlConnection();
            try
            {
                
                con.ConnectionString = txtCnString.Text;
                SqlCommand com = new SqlCommand("select * from ROOM", con);
                con.Open();
                idtable = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                SavetoXML(aes.Encrypt(txtCnString.Text, Libraries.Decrypt.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Connection Successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("With out connection", "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
