<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CasCadeDropDownApp_SqlServer.UI.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Content/custom.css" rel="stylesheet" />

    
      <br />
        
         <div class="row">
        <div class="col-md-6 ">
          <div class="panel panel-
              ">
            <div class="panel-heading panel-bg-color">
                <h4 >#1 Cascade DropDown Without Databse Using List</h4>
            </div>
            <div class="panel-body">
             
                <label class="col-md-5 control-label mt-5"> Select Division </label>
                        <div class="col-md-8">
                            <asp:DropDownList ID="ddl_division" runat="server" class="form-control mt-5" AutoPostBack="true"  OnSelectedIndexChanged="ddl_division_SelectedIndexChanged">
                             
                            </asp:DropDownList>
                          
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Divison cannot be blank" ControlToValidate="ddl_division" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                         </div>

                        <label class="col-md-5 control-label mt-5"> Select District </label>
                        <div class="col-md-8">
                          <asp:DropDownList ID="ddl_district" runat="server" AutoPostBack="true"  class="form-control mt-5" OnSelectedIndexChanged="ddl_district_SelectedIndexChanged"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="District cannot be blank" ControlToValidate="ddl_district" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                         </div>

                 <label class="col-md-5 control-label mt-5"> Select Sub-District </label>
                        <div class="col-md-8">
                           <asp:DropDownList ID="ddl_sub_district" runat="server" class="form-control mt-5" ></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Sub-District cannot be blank" ControlToValidate="ddl_sub_district" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                         </div>
                   
                          <div class="col-md-2 col-md-offset-5 mt-5">
                             <asp:Button ID="btn_search" runat="server" Text="Show" class="btn btn-success" />
                          </div>
            </div>

              
                    </div>

            <div class="panel panel-default">
            <div class="panel-heading">
                <div class="panel-body">
                    
                    </div>
                </div>
                  
          </div>
        </div>
    </div>
 

    
</asp:Content>
