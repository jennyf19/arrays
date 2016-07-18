using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Markup;

namespace arrays
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
           /* string[] values = new string[5];
            values[0] = TextBox1.Text;
            values[1] = TextBox2.Text;
            values[2] = TextBox3.Text;
            values[3] = TextBox4.Text;
            values[4] = TextBox5.Text;*/
            
            //resultLabel.Text = values[2];
            //resultLabel.Text = values.Length.ToString();
            
            string[] values = new string[5] {"Brio", "Jenny", "stormy", "zelda", "pooky"};
            ViewState.Add("MyValues", values);
            resultLabel.Text = "Values Added ...";
        }
        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            string[] values = (string[])ViewState["MyValues"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];
            TextBox5.Text = values[4];

            resultLabel.Text = "Values retreived...";
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}