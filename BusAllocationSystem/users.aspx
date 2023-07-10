<%@ Page Title="Users" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="BusAllocationSystem.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="content" style="margin-top:5%; background: rgba(255, 255, 255, 0.7);">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary" style="background: linear-gradient(60deg, #EEEEEE, #ffffff); ">
                  <!--<h4 class="card-title ">Simple Table</h4>
                  <p class="card-category"> Here is a subtitle for this table</p>-->

                    <table class="table">
                      
                      <tbody>
                          <tr>
                           <td>
                            <asp:Label ID="Label5" runat="server" Style="color:#08285b; float:left; margin-top:3%; font-size:12px;" Text="Start Date:"></asp:Label>

                            <asp:TextBox type="date" class="form-control" style="padding-bottom:7%;" id="startday" data-date-format="DD-MMMM-YYYY" runat="server" name="startday" ></asp:TextBox>

                          </td>
                          <td>
                            <asp:Label ID="Label2" runat="server" Style="color:#08285b; float:left; margin-top:3%; font-size:12px;" Text="End Date:"></asp:Label>

                            <asp:TextBox type="date" class="form-control" style="padding-bottom:7%;" id="endday" data-date-format="DD-MMMM-YYYY" runat="server" name="startday" ></asp:TextBox>

                          </td>
                          <td class="text-primary">
                            <asp:Button ID="searchtable" runat="server" class="btn btn-primary btn-block" Style="margin-top:0%; float:left; font-size:12px;" OnClick="submit_Click" Text="Search" />
                            
                          </td>
                        </tr>

                          </tbody>
                          </table>


                </div>


                <div class="card-body">
                  <div class="table-responsive" style="height:500px; overflow-y: scroll;">
                      <div id="showtable" runat="server"></div>
                    
                  </div>
                </div>
              </div>
            </div>
            
          </div>
        </div>
      </div>
</asp:Content>
