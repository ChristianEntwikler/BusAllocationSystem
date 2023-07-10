<%@ Page Title="Manage Bus" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="manageBus.aspx.cs" Inherits="BusAllocationSystem.manageBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
      <div class="row">
           <div id="showInfoMessage" class="col-md-12 alert alert-success" runat="server"></div>
          <div id="showErrorMessage" class="col-md-12 alert alert-danger" runat="server"></div>
        <div class="col-md-12">
          <div class="card card-primary">
            <div class="card-header">
              <h3 class="card-title">Bus Info</h3>

              
            </div>
            <div class="card-body">
              <div class="form-group col-md-6">
                <label for="inputName">Tag Id</label>
                <asp:TextBox type="text" id="tagid" runat="server" class="form-control" placeholder="Enter Tag Id" required="true" readonly="false" ></asp:TextBox>
              </div>
                
                <div class="form-group col-md-6">
                <label for="inputName">Vehicle Plate Number</label>
                <asp:TextBox type="text" id="regno" runat="server" class="form-control" placeholder="Enter Plate Number" required="true"></asp:TextBox>
              </div>
                
                
                <div class="form-group col-md-6">
                <label for="inputName">Number of seats</label>
                 <asp:DropDownList class="form-control custom-select" ID="seatList" runat="server" Enabled="true" >
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
