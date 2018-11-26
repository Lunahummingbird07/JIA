<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="JIA.AddMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Add Member </title>
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
				<em class="fa fa-toggle-off">&nbsp;</em> Member <span data-toggle="collapse" href="#sub-item-3" class="icon pull-right"><em class="fa fa-plus"></em></span>
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
						<span class="fa fa-arrow-right">&nbsp;</span>  Birthday
					</a></li>
					<li><a class="" href="SearchMemberSince.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span>  Member Since
					</a></li>
                    <li><a class="" href="SeminarAttended.aspx">
						<span class="fa fa-arrow-right">&nbsp;</span>  Semiar Attended
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
		<div class="panel panel-default">
					<div class="panel-heading">Personal Information</div>
					    <div class="panel-body">
						        <div class="col-md-6">
								        <div class="form-group">
                                            <asp:Label ID="Label23" runat="server" Text="First Name">First Name</asp:Label>
                                            <asp:TextBox ID="TextBox3" CssClass="form-control"  runat="server"></asp:TextBox>
                                            <asp:TextBox ID="TextBox2"  CssClass="form-control" Visible="false" Text='<%#Eval("Person_ID") %>' runat="server"></asp:TextBox>
								        </div>
								        <div class="form-group">
                                            <asp:Label ID="Label24"  runat="server" Text="Last Name">Last Name</asp:Label>
                                            <asp:TextBox ID="TextBox4" CssClass="form-control"  runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label22"  runat="server" Text="Nickname">Nickname</asp:Label>
                                            <asp:TextBox ID="TextBox7" CssClass="form-control"  runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label26"  runat="server" Text="Mobile 1">Mobile 1</asp:Label>
                                            <asp:TextBox ID="TextBox9" CssClass="form-control"   runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label27"  runat="server" Text="Mobile 2">Mobile 2</asp:Label>
                                            <asp:TextBox ID="TextBox10" CssClass="form-control"  runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label31"  runat="server" Text="Member Since">Member Since</asp:Label>
                                            <asp:TextBox ID="TextBox14" CssClass="form-control"   runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label32"  runat="server" Text="City">City</asp:Label>
                                            <asp:TextBox ID="TextBox15" CssClass="form-control"   runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label33"  runat="server" Text="Address">Address</asp:Label>
                                            <asp:TextBox ID="TextBox16" CssClass="form-control"  runat="server"></asp:TextBox>
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label2"  runat="server" Text="Spouse Name">Spouse Name</asp:Label>
                                            <asp:TextBox ID="TextBox19" CssClass="form-control"  runat="server"></asp:TextBox>
								        </div>

                                     <div class="form-group">
                                            <asp:Label ID="Label3"  runat="server" Text="Education">Education</asp:Label>
                                            <asp:TextBox ID="TextBox22" CssClass="form-control"  runat="server"></asp:TextBox>

								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label4"  runat="server" Text="Education Level">Education Level</asp:Label>
                                            <asp:TextBox ID="TextBox23" CssClass="form-control"   runat="server"></asp:TextBox>
                                        
								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label36"  runat="server" Text="Cell Leader">Cell Leader</asp:Label>
                                            <asp:TextBox ID="TextBox26" CssClass="form-control"   runat="server"></asp:TextBox>

								        </div>
                                    <div class="form-group">
                                            <asp:Label ID="Label38"  runat="server" Text="Cell Group Name">Cell Group Name</asp:Label>
                                            <asp:TextBox ID="TextBox27" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
                                        <select id="cellname" name="cellname" class="form-control"  >
                                                        <option value='' selected="selected" hidden="hidden"></option>
											            <option value="YWAV">YWAV</option>
											            <option value="ACTS Male">ACTS Male</option>
											            <option value="ACTS Female">ACTS Female</option>
                                                        <option value="Home Husbands">Home Husbands</option>
                                                        <option value="Home Wives">Home Wives</option>
                                                        <option value="Crossing">Crossing</option>
                                                        <option value="Loma">Loma</option>
                                                        <option value="Seniors">Seniors</option>
										            </select>
								        </div>
                                    <asp:Button ID="Button3" CssClass="btn btn-primary" runat="server" Text="Add"   OnClick="Button2_click" />
						       

						        </div>


								    <div class="col-md-6">
									    <div class="form-group">
										    <div class="form-group">
                                                    <asp:Label ID="Label20" runat="server" Text="Middle Name">Middle Name</asp:Label>
                                                    <asp:TextBox ID="TextBox5" CssClass="form-control"  runat="server"></asp:TextBox>
										    </div>
										    <div class="form-group">
                                                    <asp:Label ID="Label21"  runat="server" Text="Middle Initial">Middle Initial</asp:Label>
                                                    <asp:TextBox ID="TextBox6"  CssClass="form-control"  runat="server"></asp:TextBox>
										    </div>
                                            <div class="form-group">
                                                    <asp:Label ID="Label25"  runat="server" Text="Birthday">Birthday</asp:Label>
                                                    <asp:TextBox ID="TextBox8"  CssClass="form-control"  runat="server"></asp:TextBox>
										            
                                            </div> 
                                            <div class="form-group">
                                                    <asp:Label ID="Label28"  runat="server" Text="Email">Email</asp:Label>
                                                    <asp:TextBox ID="TextBox11"  CssClass="form-control"  runat="server"></asp:TextBox>
                                            </div>  
                                            
                                            <div class="form-group">
                                                <asp:Label ID="Label29" runat="server" Text="Gender"></asp:Label>
												<select id="gender" name="gender" class="form-control"  >
                                                        <option value='' selected="selected" hidden="hidden"></option>
											            <option value="Male">Male</option>
											            <option value="Female">Female</option>
										            </select>
										    </div>   
                                            <div class="form-group">
                                                <asp:Label ID="Label30" runat="server" Text="Marital Status">Marital Status</asp:Label>
                                                <div class="form-group">
										            <select id="mstat" name="mstat" class="form-control"  >
                                                        <option value='' selected="selected" hidden="hidden"></option>
											            <option value="Married">Married</option>
											            <option value="Widow">Widow</option>
											            <option value="Single">Single</option>
										            </select>
									            </div>

                                            </div>
                                            <div class="form-group">
                                                    <asp:Label ID="Label34"  runat="server" Text="Barangay">Barangay</asp:Label>
                                                    <asp:TextBox ID="TextBox17"  CssClass="form-control"  runat="server"></asp:TextBox>
                                            </div> 
                                            <div class="form-group">
                                                    <asp:Label ID="Label35"  runat="server" Text="Province">Province</asp:Label>
                                                    <asp:TextBox ID="TextBox18"  CssClass="form-control"  runat="server"></asp:TextBox>
                                            </div>
                                                <div class="form-group">
                                                    <asp:Label ID="Label7"  runat="server" Text="KeyID">KeyID</asp:Label>
                                                    <asp:TextBox ID="TextBox1"  CssClass="form-control"  runat="server"></asp:TextBox>
                                            </div>
									        <div class="form-group">
                                                <asp:Label ID="Label37"  runat="server" Text="Anniversary">Anniversary</asp:Label>
                                                <asp:TextBox ID="TextBox21"  CssClass="form-control" runat="server"></asp:TextBox>
                                             </div> 
                                        
                                            <div class="form-group">
                                                <asp:Label ID="Label5"  runat="server" Text="Course">Course</asp:Label>
                                                <asp:TextBox ID="TextBox24"  CssClass="form-control"  runat="server"></asp:TextBox>
                                             </div>
                                            <div class="form-group">
                                                <asp:Label ID="Label39"  runat="server" Text="Profession">Profession</asp:Label>
                                                <asp:TextBox ID="TextBox25"  CssClass="form-control" runat="server"></asp:TextBox>
                                             </div>
                                            <div class="form-group">
                                                <asp:Label ID="Label6"  runat="server" Text="Cell Group Facilitator">Cell Group Facilitator</asp:Label>
                                                <asp:TextBox ID="TextBox28"  CssClass="form-control"  runat="server"></asp:TextBox>
                                             </div>
								    </div>
						</div>


                    
	        </div><!-- /.col-->
		
		</div>
	</form>
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

