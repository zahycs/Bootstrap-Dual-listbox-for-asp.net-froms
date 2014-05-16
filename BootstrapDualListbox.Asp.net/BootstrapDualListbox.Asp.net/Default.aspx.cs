using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootstrapDualListbox.Asp.net
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dlbGroupA.DataSource = new TestManager().GetItems();
                dlbGroupA.BindData();
                dlbGroupA.SetSelectedValues(new List<string>{"1", "4"});
            }
        }
    }

    public class TestItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class TestManager
    {
        public List<TestItem> GetItems()
        {
            var items = new List<TestItem>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(
                    new TestItem
                    {
                        Id = i + 1,
                        Name = "option" +( i + 1)
                    });

            }
            return items;
        }
    }
}