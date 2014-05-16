using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BootstrapDualListbox.Asp.net
{
    [DefaultProperty("Options"),
   ParseChildren(true, "Options"), PersistChildren(false)]
    public partial class DualListbox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //keeps the selected options after postbacks 
            if (hfSelectedValues.Value != string.Empty)
            {
                if (dlbGeneric.Items.Count > 0)
                    SetSelectedValues(ConvertValuesToList(hfSelectedValues.Value));
            }
        }
        public List<string> ConvertValuesToList(string values)
        {
            List<string> valuesList = new List<string>();
            valuesList.AddRange(Regex.Split(values, ","));
            return valuesList;
        }
        [Category("Behavior"), Description("The items collection"),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
     PersistenceMode(PersistenceMode.InnerDefaultProperty),
     DefaultValue(null), MergableProperty(false), Bindable(false)]
        public List<ListItem> Options
        {
            set
            {
                dlbGeneric.Items.AddRange(value.ToArray());

            }
        }
        public string AvailableListLabel
        {
            get
            {
                return hfnonSelectedListLabel.Value;

            }
            set
            {
                hfnonSelectedListLabel.Value = value;
            }
        }
        public string SelectedLisLabel
        {
            get
            {
                return hfselectedListLabel.Value;

            }
            set
            {
                hfselectedListLabel.Value = value;
            }
        }
        public string DataValueField
        {
            get
            {
                var val = ViewState["dataValueField"] != null ? ViewState["dataValueField"].ToString() : "";
                return val;
            }
            set
            {
                ViewState["dataValueField"] = value;
            }
        }
        public string DataTextField
        {
            get
            {
                var val = ViewState["dataTextField"] != null ? ViewState["dataTextField"].ToString() : "";
                return val;
            }
            set
            {
                ViewState["dataTextField"] = value;
            }
        }
        public object DataSource { get; set; }
        public void BindData()
        {
            dlbGeneric.DataSource = this.DataSource;
            dlbGeneric.DataValueField = ViewState["dataValueField"] != null ? ViewState["dataValueField"].ToString() : "";
            dlbGeneric.DataTextField = ViewState["dataTextField"] != null ? ViewState["dataTextField"].ToString() : "";
            dlbGeneric.DataBind();
        }
        public void SetSelectedValues(List<string> values)
        {
            if (dlbGeneric.Items.Count > 0)
                foreach (var val in values)
                {
                    dlbGeneric.Items.FindByValue(val).Selected = true;
                }
        }
        public List<string> GetSelectedValues()
        {
            List<string> selectedValues = new List<string>();
            foreach (ListItem item in dlbGeneric.Items)
            {
                if (item.Selected)
                    selectedValues.Add(item.Value);
            }
            return selectedValues;
        }
        public void ClearSelectedValues()
        {
            dlbGeneric.ClearSelection();
        }
    }
}