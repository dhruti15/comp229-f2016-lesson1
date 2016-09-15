using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp229_f2016_lesson2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch(Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
                case "Products":
                    home.Attributes.Add("class", "active");
                    break;
                case "Services":
                    home.Attributes.Add("class", "active");
                    break;
                case "About":
                    home.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    home.Attributes.Add("class", "active");
                    break;

            }

        }
    }
}