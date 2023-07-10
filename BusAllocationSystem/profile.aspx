<%@ Page Title="pprofile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="BusAllocationSystem.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
      <div class="row">
           
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
                <label for="inputStatus">Bus stop</label> <br/>
                <asp:label id="allocatedBusStop" runat="server"></asp:label>
              </div>
                
                <div class="form-group">
                <label for="inputStatus">Bus Allocated</label> <br/>
                <asp:label id="allocatedBus" runat="server"></asp:label>
              </div>
              
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
        
      </div>
      <div class="row">
        <div class="col-12">
          <a href="./default.aspx" class="btn btn-secondary">Back</a>
        </div>
      </div>
    </section>
</asp:Content>
