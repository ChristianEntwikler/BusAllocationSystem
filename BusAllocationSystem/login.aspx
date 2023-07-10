<%@ Page Title="" Language="C#" MasterPageFile="~/login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BusAllocationSystem.login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrap-login100">
				<!-- <form class="login100-form validate-form"> -->
					<span class="login100-form-title p-b-26">
						Welcome
					</span>
					<span class="login100-form-title p-b-48">
						<i class="fa fa-bus"></i>
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is: a@b.c">
						<asp:TextBox class="input100" type="text" id="email" runat="server" required="true"></asp:TextBox>
						<span class="focus-input100" data-placeholder="Email"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<span class="btn-show-pass">
							<i class="zmdi zmdi-eye"></i>
						</span>
						<asp:TextBox class="input100" type="password" id="password" runat="server" required="true" ></asp:TextBox>
						<span class="focus-input100" data-placeholder="Password"></span>
					</div>

					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button class="login100-form-btn" ID="login" runat="server" OnClick="login_Click" text="Login" style='background: linear-gradient(90deg, #bcdef5, #122652);' />
						
                        </div>
					</div>
                    

					<div class="text-center p-t-115" style="margin-top:-13%;">
                        <br/>
                    <asp:Label ID="errorMsg" runat="server" Style="color:#ff0000;"></asp:Label>
                        <br/>
						<span class="txt1">
							Don’t have an account?
						</span>

						<a class="txt2" href="./userRegistration.aspx">
							Sign Up
						</a>
					</div>
				<!-- </form> -->
			</div>

</asp:Content>
