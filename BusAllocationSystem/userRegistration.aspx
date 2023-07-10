<%@ Page Title="User Registration" Language="C#" MasterPageFile="~/login.Master" AutoEventWireup="true" CodeBehind="userRegistration.aspx.cs" Inherits="BusAllocationSystem.userRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
              <div class="form-group col-md-12">
                <label for="inputName">First Name</label>
                <asp:TextBox type="text" id="firstName" class="form-control" placeholder="Enter first name" required="true" runat="server" />
              </div>
                
                <div class="form-group col-md-12">
                <label for="inputName">Last Name</label>
                <asp:TextBox type="text" id="lastName" class="form-control" placeholder="Enter last name" required="true" runat="server" />
              </div>
                
                <div class="form-group col-md-12">
                <label for="inputName">Email Address</label>
                <asp:TextBox type="Email" id="emailAddress" class="form-control" placeholder="Enter email address" required="true" runat="server" />
              </div>

              <div class="form-group col-md-12">
                <label for="inputDescription">Address</label>
                <asp:TextBox type="multi" id="address" class="form-control" rows="4" placeholder="Enter address" required="true" runat="server" />
              </div>

              <div class="form-group col-md-12">
                <label>Password</label>
                <asp:TextBox type="password" id="pwd" class="form-control" placeholder="Enter password" required="true" runat="server" />
              </div>

              <div class="form-group col-md-12">
                <label>Confirm Password</label>
                <asp:TextBox type="password" id="cpwd" class="form-control" placeholder="Confirm password" required="true" runat="server" />
              </div>
              
            </div>
            <!-- /.card-body -->
          </div>
          <!-- /.card -->
        </div>
        
      </div>
      <div class="row">
        <div class="col-12">
          <a href="./login.aspx" class="btn btn-secondary">Back</a>
          <asp:Button type="submit" value="Save Changes" class="btn btn-info float-right fs-15" runat="server" OnClick="submit_Click" Text="Submit" />
        </div>
      </div>

        
    </section>
</asp:Content>
