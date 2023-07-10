<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BusAllocationSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <section class="content">
      <div class="container-fluid">
        <!-- Small boxes (Stat box) -->
        <div class="row">
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-info">
              <div class="inner">
                <h3><asp:Label ID="usersCount" runat="server"></asp:Label></h3>

                <p>Users</p>
              </div>
              <div class="icon">
                <i class="fa fa-users"></i>
              </div>
              <a href="#" class="small-box-footer">Users count <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-success">
              <div class="inner">
                <h3><asp:Label ID="busesCount" runat="server"></asp:Label></h3>

                <p>Buses</p>
              </div>
              <div class="icon">
                <i class="fa fa-bus"></i>
              </div>
              <a href="#" class="small-box-footer">Buses count <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-warning">
              <div class="inner">
                <h3><asp:Label ID="busStopsCount" runat="server"></asp:Label></h3>

                <p>Bus Stops</p>
              </div>
              <div class="icon">
                <i class="fa fa-bus"></i>
              </div>
              <a href="#" class="small-box-footer">Bus Stops count info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->

         <div class="row">
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-info">
              <div class="inner">
                <h3><asp:Label ID="availableBusesCount" runat="server"></asp:Label></h3>

                <p>Avalable Buses</p>
              </div>
              <div class="icon">
                <i class="fa fa-bus"></i>
              </div>
              <a href="#" class="small-box-footer">Available Buses Count info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-success">
              <div class="inner">
                <h3><asp:Label ID="occupiedBusesCount" runat="server"></asp:Label></h3>

                <p>Occupied Buses</p>
              </div>
              <div class="icon">
                <i class="fa fa-bus"></i>
              </div>
              <a href="#" class="small-box-footer">Occupied Buses count info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-4">
            <!-- small box -->
            <div class="small-box bg-warning">
              <div class="inner">
                <h3><asp:Label ID="driversCount" runat="server"></asp:Label></h3>

                <p>Drivers</p>
              </div>
              <div class="icon">
                <i class="fa fa-users"></i>
              </div>
              <a href="#" class="small-box-footer">Drivers Count info <i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        
      </div><!-- /.container-fluid -->
    </section>

</asp:Content>
