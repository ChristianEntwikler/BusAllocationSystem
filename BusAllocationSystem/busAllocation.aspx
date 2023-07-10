<%@ Page Title="Bus Allocation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="busAllocation.aspx.cs" Inherits="BusAllocationSystem.busAllocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<section class="content">
      <div class="row">
           <div id="showInfoMessage" class="col-md-12 alert alert-success" runat="server"></div>
          <div id="showErrorMessage" class="col-md-12 alert alert-danger" runat="server"></div>
        <div class="col-md-12">
          <div class="card card-primary">
            <div class="card-header">
              <h3 class="card-title">User Info</h3>

              
            </div>
            <div class="card-body">
              <div class="form-group col-md-6">
                <label for="inputName">First Name</label>
                <asp:TextBox type="text" id="firstName" runat="server" class="form-control" placeholder="Enter first name" required="true" readonly="true" ></asp:TextBox>
              </div>
                
                <div class="form-group col-md-6">
                <label for="inputName">Last Name</label>
                <asp:TextBox type="text" id="lastName" runat="server" class="form-control" placeholder="Enter last name" required="true" readonly="true"></asp:TextBox>
              </div>
                
                <div class="form-group col-md-6">
                <label for="inputName">Email Address</label>
                <asp:TextBox type="Email" id="emailAddress" runat="server" class="form-control" placeholder="Enter email address" required="true" readonly="true" ></asp:TextBox>
              </div>

              <div class="form-group col-md-12">
                <label for="inputDescription">Address</label>
                <asp:TextBox type="Multi" id="address" runat="server" class="form-control" rows="4" placeholder="Enter address" required="true" readonly="true" ></asp:TextBox>
              </div>

              <div class="form-group">
                <label for="inputStatus">Bus stop</label> <asp:label id="allocatedBusStop" runat="server"></asp:label><br/>
                 <asp:DropDownList class="form-control custom-select" ID="busstopList" runat="server" Enabled="true" AutoPostBack="True" OnSelectedIndexChanged="busstopList_SelectedIndexChanged" >
                </asp:DropDownList>
              </div>
                
                <div class="form-group">
                <label for="inputStatus">Available Bus</label> <asp:label id="allocatedBus" runat="server"></asp:label><br/>
                <asp:DropDownList class="form-control custom-select" ID="busList" runat="server" Enabled="true" >
                </asp:DropDownList>
              </div>
              
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
        
      </div>
      <div class="row">
        <div class="col-12">
          <a href="./default.aspx" class="btn btn-secondary">Cancel</a>
          <asp:Button type="submit" value="Save Changes" class="btn btn-info float-right fs-15" runat="server" OnClick="submit_Click" Text="Submit" />
        </div>
      </div>
    </section>
</asp:Content>
