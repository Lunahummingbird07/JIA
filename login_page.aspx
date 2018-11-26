<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="JIA.login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<title>Login</title>
	<link href="css/bootstrap.min.css" rel="stylesheet"/>
	<link href="css/datepicker3.css" rel="stylesheet"/>
	<link href="css/styles.css" rel="stylesheet"/>
	<!--[if lt IE 9]>
	<script src="js/html5shiv.js"></script>
	<script src="js/respond.min.js"></script>
	<![endif]-->
</head>
<body>
		<form role="form" runat="server">
   <div class="row">
		<div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
			<div class="login-panel panel panel-default">
				<div class="panel-heading">Log in</div>
				<div class="panel-body">
                        <fieldset>
							<div class="form-group">
                                <asp:TextBox ID="TextBox1" runat="server" Visible="true" placeholder="Username" CssClass="form-control" ></asp:TextBox>
							</div>
							<div class="form-group">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" CssClass="form-control" type="password" ></asp:TextBox>
                                
							</div>
                            <div class="form-group">
                                <select id="account" name="account" class="form-control"  >
                                    <option value='' selected="selected" hidden="hidden">------ Choose Account------</option>
									<option value="Admin">Admin</option>
									<option value="Member">Member</option>
								</select>
                            </div>

                            <div class="form-group">
                                <asp:Button ID="Button2" class="btn btn-sm btn-default"  runat="server" Text="Register" OnClick="Button2_Click" />
                                   <br/>
                                <br/>
                                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Login" OnClick="Button1_Click" />

                            </div>
                        </fieldset>
                    
				</div>
			</div>
            
		</div><!-- /.col-->
	</div><!-- /.row -->	
</form>
	
            




<script src="js/jquery-1.11.1.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
</body>
</html>
