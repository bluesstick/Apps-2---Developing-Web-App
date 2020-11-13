using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Demostrations
{
    public partial class ServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click1(object sender, EventArgs e)
        {
            displayLabel.Text = demoToolBox.Text;
            demoToolBox.Text = string.Empty;
        }
    }
}