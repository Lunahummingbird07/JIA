<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuildingFund.aspx.cs" Inherits="JIA.BuildingFund" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Building FUnd </title>
	<link href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/font-awesome.min.css" rel="stylesheet">
	<link href="css/datepicker3.css" rel="stylesheet">
	<link href="css/styles.css" rel="stylesheet">
	
	<!--Custom Font-->
	<link href="https://fonts.googleapis.com/css?family=Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">
	<!--[if lt IE 9]>
	<script src="js/html5shiv.js"></script>
	<script src="js/respond.min.js"></script>
	<![endif]-->



    <style type="text/css">
            div.dataTables_wrapper {
                width: 1600px;
                margin: 0 auto;
            }
        </style>
</head>
<body>
	<nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
		<div class="container-fluid">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#sidebar-collapse"><span class="sr-only">Toggle navigation</span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span></button>
				<a class="navbar-brand" href="#"><span>Jesus Is Alive</span> Community</a>
			</div>
		</div><!-- /.container-fluid -->
	</nav>
	<div id="sidebar-collapse" class="col-sm-3 col-lg-2 sidebar">
		<div class="profile-sidebar">
			<div class="profile-userpic">
				<img src="http://placehold.it/50/30a5ff/fff" class="img-responsive" alt="">
			</div>
			<div class="profile-usertitle">
				<div class="profile-usertitle-name">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
				</div>
				<div class="profile-usertitle-status"><span class="indicator label-success"></span>Online</div>
			</div>
			<div class="clear"></div>
		</div>
		<div class="divider"></div>
		
		<ul class="nav menu"><li class="active">
            <%--<li><a href="PersonInfo.aspx"><em class="fa fa-toggle-off">&nbsp;</em> Personal Information</a></li>--%>

            <li class="parent "><a data-toggle="collapse" href="#sub-item-3">
				<em class="fa fa-toggle-off">&nbsp;</em> Member<span data-toggle="collapse" href="#sub-item-3" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-3">
					<li><a class="" href="PersonInfo.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Search Member
					</a></li>
					<li><a class="" href="AddMember.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Add Member
					</a></li>
					
				</ul>
			</li>
			<%--<li><a href="MainPage.aspx"><em class="fa fa-dashboard">&nbsp;</em> Dashboard</a></li>
			
			<li><a href="chart.aspx"><em class="fa fa-bar-chart">&nbsp;</em> Charts</a></li>--%>

            <%--<li><a href="ListofSeminar.aspx"><em class="fa fa-calendar">&nbsp;</em> Seminar</a></li>--%>
            <li class="parent "><a data-toggle="collapse" href="#sub-item-2">
				<em class="fa fa-calendar">&nbsp;</em> Seminar <span data-toggle="collapse" href="#sub-item-2" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-2">
					<li><a class="" href="ListofSeminar.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Search Seminar
					</a></li>
					<li><a class="" href="AddSeminar.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Add Seminar
					</a></li>
					
				</ul>
			</li>
			<%--<li><a href="CellGroup.aspx"><em class="fa fa-clone">&nbsp;</em> Cell Group</a></li>--%>
			<li class="parent "><a data-toggle="collapse" href="#sub-item-1">
				<em class="fa fa-clone">&nbsp;</em> Cell Group <span data-toggle="collapse" href="#sub-item-1" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-1">
					<li><a class="" href="CellGroup.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Search Cell Group
					</a></li>
					<li><a class="" href="AddCellGroup.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Add Cell Group
					</a></li>
					
				</ul>
			</li>

            <li class="parent "><a data-toggle="collapse" href="#sub-item-5">
				<em class="fa fa-clone">&nbsp;</em> Pledges <span data-toggle="collapse" href="#sub-item-5" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-5">
					<li><a class="" href="ViewPledges.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> View PLedge
					</a></li>
					<li><a class="" href="AddPledges.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Add PLedge
					</a></li>
				</ul>
			</li>

            <li><a href="BuildingFund.aspx"><em class="fa fa-clone">&nbsp;</em> Building Fund</a></li>

            <li class="parent "><a data-toggle="collapse" href="#sub-item-4">
				<em class="fa fa-clone">&nbsp;</em> Reports <span data-toggle="collapse" href="#sub-item-4" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-4">
					<li><a class="" href="SearchBirthday.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span>Birthday
					</a></li>
					<li><a class="" href="SearchMemberSince.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span>Member Since
					</a></li>
                    <li><a class="" href="SeminarAttended.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span>Seminar Attended
					</a></li>
					
				</ul>
			</li>

            <li class="parent "><a data-toggle="collapse" href="#sub-item-6">
				<em class="fa fa-clone">&nbsp;</em> Email/SMS <span data-toggle="collapse" href="#sub-item-6" class="icon pull-right"><em class="fa fa-plus"></em></span>
				</a>
				<ul class="children collapse" id="sub-item-6">
					<li><a class="" href="Email.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> Email
					</a></li>
					<li><a class="" href="SMS.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span> SMS
					</a></li>
					
				</ul>
			</li>


			<li><a href="login_page.aspx"><em class="fa fa-power-off">&nbsp;</em> Logout</a></li>
		</ul>
	</div><!--/.sidebar-->
		
	<div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
		<div class="row">
			<ol class="breadcrumb">
				<li><a href="#">
					<em class="fa fa-home"></em>
				</a></li>
				<li class="active">Forms</li>
			</ol>
		</div><!--/.row-->
		
		<div class="row">
			
		</div><!--/.row-->
				
		<form role="form" runat="server">
		<div class="row">
			<div class="col-lg-12">
				<div class="panel panel-default">
					<div class="panel-heading">Building Fund</div>
					<div class="panel-body">
						<div class="col-md-6">
							
                                                <div class="form-group" style="width:1000px;height:300px;overflow-x:scroll;overflow-y:scroll;" >
                                                    <table id="table1" style="border: 1px solid #000;grid-column-align:start">
                                                         
 
                                                        <tbody>
                                                            
                                                        <tr>
                                                        
                                                    <asp:DataList ID="buildingfundinfo" runat="server">
                                                         <HeaderTemplate>
                                                             <td></td>
                                                                <td> Entry No </td>
                                                                <td>Date Collected</td>
                                                                <td>Amount Collected</td>
                                                                <td>Total Collected</td>
                                                                <td>Date Modified</td>
                                                                
                                                             </HeaderTemplate>
                                                    <itemtemplate>
                                                            <td>
                                                                <asp:Button ID="Button2" CommandArgument='<%# Eval("Entry_No") %>'  class="btn btn-primary" runat="server" Text="Delete" OnClick="Button2_Click" />
                                                                
                                                            </td>
                                                            <td >
                                                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("Entry_No") %>' ></asp:Label>
                                                            </td >
                                                             
                                                            <td >
                                                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("Date_Collected") %>' ></asp:Label>
                                                            </td>
                                                             
                                                            <td >
                                                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("Amount_Collected") %>' ></asp:Label>    
                                                            </td>
                                                             
                                                            <td >
                                                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("Total_Collected") %>' ></asp:Label>
                                                            </td>
                                                             
                                                            <td >
                                                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("Date_Modified") %>' ></asp:Label>
                                                            </td>
                                                         
                                                            
                                                </itemtemplate>
                                            </asp:DataList>
                                                        </tr>
                                                            </tbody>
                                                    </table>
                                                </div>
                                    
								
                                </div>
					    </div>
						</div>
					</div>
				</div><!-- /.panel-->

                
                    
				<div class="panel panel-default">
					<div class="panel-heading">Add Building Fund </div> 
						         <div class="panel-body">
                                     <div class="col-md-6"> 
								        <div class="form-group">
                                            <asp:Label ID="Label24"  runat="server" Text="Amount Collected">Amount Collected</asp:Label>
                                            <asp:TextBox ID="TextBox4" CssClass="form-control" Enabled="true"  Text=" " runat="server"></asp:TextBox>
								            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required"
                                                    ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label22"  runat="server" Text="Date Collected">Date Collected</asp:Label>
                                            <asp:TextBox ID="TextBox7" CssClass="form-control"  Text=" " runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required"
                                                    ControlToValidate="TextBox7" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Calendar1_SelectionChanged" Width="200px">
                                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                                <NextPrevStyle VerticalAlign="Bottom" />
                                                <OtherMonthDayStyle ForeColor="#808080" />
                                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                                <SelectorStyle BackColor="#CCCCCC" />
                                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                <WeekendDayStyle BackColor="#FFFFCC" />
                                            </asp:Calendar>
								        </div>

                                    <asp:Button ID="Button3" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="Button3_click"/>
						        </div>
                                    </div>
						</div>

				</div> 

               
			</form>
	        </div><!-- /.col-->
			<div>
		</div>
	
<script src="js/jquery-1.11.1.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script src="js/chart.min.js"></script>
	<script src="js/chart-data.js"></script>
	<script src="js/easypiechart.js"></script>
	<script src="js/easypiechart-data.js"></script>
	<script src="js/bootstrap-datepicker.js"></script>
	<script src="js/custom.js"></script>
	
</body>
</html>


