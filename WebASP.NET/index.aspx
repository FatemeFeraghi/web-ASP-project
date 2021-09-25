<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebASP.NET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web ASP</title>

    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: saddlebrown;
        }

        .auto-style2 {
            width: 430px;
        }

        .auto-style3 {
            width: 400px;
        }

        .auto-style4 {
            width: 100px;
            height: 50px;
        }

        .auto-style5 {
            margin-left: 0px;
            margin-top: 0px;
        }

        .auto-style6 {
            width: 270px;
        }

        .auto-style7 {
            width: 270px;
            height: 50px;
        }

        .auto-style8 {
            margin-top: 0px;
            border-radius: 30px;
        }

        .auto-style9 {
            width: 580px;
            height: 730px;
        }

        .auto-style10 {
            width: 100px;
        }

        .auto-style11 {
            width: 500px;
        }

        .auto-style12 {
            height: 120px;
        }

        .style-panel {
            border-radius: 30px;
        }

        .radius-box {
            border-radius: 5px;
        }

        .auto-style15 {
            margin-top: 0px;
            border-radius: 30px;
        }

    </style>
</head>
<body style="background-color: antiquewhite">


    <form id="form1" runat="server" class="auto-style9">

        <div>
            <h1 class="auto-style1">P I Z Z A - H U R T S !</h1>
        </div>
        <hr class="auto-style2" />

        <br />

        <table class="auto-style11">
            <tr style="vertical-align: top">
                <td class="auto-style12">

                    <asp:Panel ID="panPizza" CssClass="style-panel" BackColor="#cc6600"
                        runat="server" GroupingText="Pizza Information" Height="100%" Width="450px">

                        <table class="auto-style3">
                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblCustomer" runat="server" AccessKey="c" AssociatedControlID="txtCustomer" Text="Customer"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:TextBox ID="txtCustomer" runat="server" CssClass="radius-box" Width="200px"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblTelephone" runat="server" CssClass="radius-box" AccessKey="c" AssociatedControlID="TextPhone" Text="TelePhone"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:TextBox ID="TextPhone" TextMode="Phone" CssClass="radius-box" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblDelivery" runat="server" Text="To deliver?"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:CheckBox ID="chkDelivery" runat="server" OnCheckedChanged="chkDelivery_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style4">
                                    <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label>
                                </td>

                                <td class="auto-style7">
                                    <asp:TextBox ID="txtAddress" TextMode="MultiLine" CssClass="radius-box" runat="server" Width="200px" Height="45px"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblPizza" runat="server" Text="Pizza"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:DropDownList ID="cboPizza" CssClass="radius-box" runat="server" OnSelectedIndexChanged="cboPizza_SelectedIndexChanged" Width="200px"  AutoPostBack="true"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblPizzaSize" runat="server" Text="Pizza Size"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:ListBox ID="lstPizzaSize" runat="server" CssClass="radius-box" AutoPostBack="true" Width="200px"></asp:ListBox>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblToppings" runat="server" Text="Toppings"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:CheckBoxList ID="chklstToppings" runat="server" AutoPostBack="true"></asp:CheckBoxList>
                                </td>
                            </tr>

                            <tr>
                                <td class="auto-style10">
                                    <asp:Label ID="lblPizzaCrust" runat="server" Text="Pizza Crust"></asp:Label>
                                </td>

                                <td class="auto-style6">
                                    <asp:RadioButtonList ID="radlstCrust" runat="server" AutoPostBack="true"></asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                        <br /><br /><br />
                    </asp:Panel>
                </td>



                <td class="auto-style12">
<%--Literal is used to show text, render all the data from the server and passes the content directly to the client browser and it doesn't need to go to the server all the time and the data will be saved on the client browser--%>
                    <asp:Panel ID="panPricing" runat="server" GroupingText="Pricing" Height="250px" Width="250px" BackColor="#cc6600" CssClass="auto-style8">
                        <asp:Image ID="imgHurtz" ImageUrl="~/image.png" Width="90px" Height="80px" CssClass="auto-style5" runat="server" />
                        <asp:Literal ID="litPricing" runat="server"></asp:Literal>
                        <asp:Button ID="btnOrder" runat="server" Text="Order Now" OnClick="btnOrder_Click" />
                    </asp:Panel>
                    <br />

                    <asp:Panel ID="panelOrder" runat="server" CssClass="auto-style15" GroupingText="Order Information" BackColor="#cc6600">
                        <asp:Literal ID="litOrder" runat="server"></asp:Literal>
                    </asp:Panel>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

        </table>
        <br />
        <div>
        </div>
    </form>


</body>
</html>
