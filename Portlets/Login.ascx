<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="Portlets_WebUserControl" %>
<style type="text/css">
    .auto-style2 {
        text-align: center;
    }
</style>

<table style="width: 100%; height: 100%">
    <tr valign="middle">
        <td align="center" style="height: 100%" valign="middle">
            <table cellpadding="0" cellspacing="0" class="loginmodule_table_dl" width="350">
                <tr>
                    <td colspan="2">
                        <table cellpadding="0" cellspacing="0" class="loginmodule_table_Bottom_dl" width="100%">
                            <tr>
                                <td class="loginmodule_header_dl" style="height: 19px">Đăng nhập</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <table cellpadding="0" cellspacing="0" class="loginmodule_table_Bottom_dl" width="100%">
                            <tr class="loginmodule_header_dl">
                                <td style="height: 20px">
                                    <asp:RadioButton ID="rbtnStudent" runat="server" Checked="True" GroupName="Role" Text="Sinh viên" />
                                </td>
                                <td style="height: 20px">
                                    &nbsp;</td>
                                <td style="height: 20px">
                                    <asp:RadioButton ID="rbtnStaff" runat="server" GroupName="Role" Text="Cán bộ-Nhân viên" OnCheckedChanged="rbtnStaff_CheckedChanged" />
                                </td>
                                <td style="height: 20px">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td id="tdError" runat="server" colspan="2" style="width: 100%"></td>
                </tr>
                <tr>
                    <td align="center" style="height: 133px" valign="middle">
                        <table id="Table2" border="0" cellpadding="2" cellspacing="0" width="100%">
                            <tr>
                                <td align="right" style="width: 35%" valign="bottom">
                                    <asp:Label ID="Label2" runat="server" CssClass="bold_text" meta:resourcekey="Label2Resource1">Tên đăng nhập:</asp:Label>
                                </td>
                                <td align="left" style="width: 65%" valign="bottom">
                                    <input id="txtUserName" runat="server" class="Textbox" style="width: 95%" type="text" /> </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 35%" valign="bottom">
                                    <asp:Label ID="Label3" runat="server" CssClass="bold_text" meta:resourcekey="Label3Resource1">Mật mã: </asp:Label>
                                </td>
                                <td align="left" style="width: 65%" valign="bottom">
                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="Textbox" meta:resourcekey="txtPasswordResource1" TextMode="Password" Width="95%"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <table border="0" style="text-align:right;" width="67%">
                                        <tr>
                                            <td align="left">
                                                <asp:CheckBox ID="cbRemember" runat="server" CssClass="normal_text" Enabled="false" meta:resourcekey="cbRememberResource1" Text="Ghi nhớ lần đăng nhập sau" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <table border="0" width="100%">
                                        <tr>
                                            <td align="left" style="color:Blue">&nbsp;</td>
                                            <td class="auto-style2">
                                                <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>




