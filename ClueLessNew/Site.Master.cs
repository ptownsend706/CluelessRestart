using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClueLessNew
{
    public partial class SiteMaster : MasterPage
    {
        string playerName = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlayerTextBox_TextChanged(object sender, EventArgs e)
        {
            playerName = PlayerTextBox.Text;
        }

        protected void JoinGameButton_Click(object sender, EventArgs e)
        {
            
            if (playerName == "")
            {
                ErrorLabel.Text = "Please enter your name.";
            }
            else if (playerName != "")
            {
                ErrorLabel.Text = "";
            }
        }

        protected void gameLogTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}