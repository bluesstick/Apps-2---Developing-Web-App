using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RentMyWrox;

namespace WebApplication1.Admin
{
    public partial class ManageItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            string itemNumber = tbItemNumber.Text;
            double cost = double.Parse(tbCost.Text);
            DateTime acquiredDate = DateTime.Parse(tbAcquiredDate.Text);
            byte[] uploadedFileContent = fuPicture.FileBytes;
        }
    }
}