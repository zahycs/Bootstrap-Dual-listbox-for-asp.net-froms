<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BootstrapDualListbox.Asp.net.Default" %>

<%@ Register Src="~/DualListbox.ascx" TagPrefix="uc1" TagName="DualListbox" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bootstrap Dual Listbox Demo</title>
</head>
<body>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-duallistbox.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <form id="form1" runat="server">
     <div class="row">
        <div class="col-md-8">
            <section id="Demo">

                <div>
                    <h4>Two Dual list box shown : </h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>

                </div>
                 <div>
                    <h5>options are binded from form code behind , and you can get or Set the selected values using GetSelectedValues() and SetSelectedValues() </h5>
                     </div>
                  <div class="form-group">
                      <uc1:DualListbox runat="server" DataTextField="Name" DataValueField="Id" SelectedLisLabel="Selected from Group A" AvailableListLabel="Group A"  id="dlbGroupA" />
                  </div>
                 <div>
                    
                    <hr />
                 <h5>options are added into aspx page  </h5>

                </div>
                 <div class="form-group">
                     <uc1:DualListbox runat="server" ID="DualListbox1">
                         <asp:ListItem Value="1">option1</asp:ListItem>
                           <asp:ListItem Value="2">option2</asp:ListItem>
                          <asp:ListItem Value="3" Selected="True">option3</asp:ListItem>
                          <asp:ListItem Value="4">option4</asp:ListItem>
                     </uc1:DualListbox>
                  </div>
                 <div class="form-group">

                  </div>
            </section>
        </div>
    </div>
    </form>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery.bootstrap-duallistbox.js"></script>
    <script src="Scripts/asp.net-duallistbox-multiple-instances.js"></script>
    <script src="Scripts/App/Default.aspx.js"></script>
</body>
</html>
