<%@ Page Title="Manage Bus Stop Allocation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="manageBusstopAllocation.aspx.cs" Inherits="BusAllocationSystem.manageBusstopAllocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="content">
      <div class="row">
           <div id="showInfoMessage" class="col-md-12 alert alert-success" runat="server"></div>
          <div id="showErrorMessage" class="col-md-12 alert alert-danger" runat="server"></div>
        <div class="col-md-12">
          <div class="card card-primary">
            <div class="card-header">
              <h3 class="card-title">Bus Stop Info</h3>

              
            </div>
            <div class="card-body">
                <div class="form-group">
                <label for="inputStatus">Buses</label><br/>
                    <asp:DropDownList class="form-control custom-select" ID="busList" runat="server" Enabled="true" >
                </asp:DropDownList>
                
              </div>
              <div class="form-group">
                <label for="inputStatus">Bus Stops</label><br/>
                    <asp:DropDownList class="form-control custom-select" ID="busstopList" runat="server" Enabled="true" >
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
          <asp:Button type="submit" value="Submit" class="btn btn-info float-right fs-15" runat="server" OnClick="submit_Click" Text="Submit" />
        </div>
      </div>
    </section>
</asp:Content>
