﻿<%@ control language="C#" autoeventwireup="true" inherits="Portlets_Staff_Mainnv, App_Web_4swpmkzv" %>
<table border="0" width="100%" id="table8" cellspacing="0" cellpadding="0">
    <tr>
        <td width="223" valign="top">
            <table border="0" width="100%" id="table9" cellspacing="0" cellpadding="0">
	            <tr>
		            <td>
		                <img border="0" src="images/top_fr_left.gif" width="223" height="5">
		            </td>
	            </tr>
	            <tr>
		            <td background="images/bg_fr_left.gif">
		                <table border="0" width="100%" id="table12" cellspacing="0" cellpadding="0">
                           
                            <tr>
                                <td bgcolor="#e3ebef"><img border="0" src="images/dot.gif" width="1" height="1">
                                </td>
                            </tr>
                            <tr>
                                <td height="20">
                                    <table border="0" width="100%" id="table29" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td width="40"><p align="center"><img src="images/home.png" width="24" height="24"></td>
                                            <td class="contentnews1" align="left">
                                                <asp:LinkButton ID="lnkHome" runat="server" OnClick="lnkNavigate_Click" Text="Trang của bạn" CssClass="menumain"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>                                                          
                                </td>
                            </tr>
                            <tr>
                                <td bgcolor="#e3ebef"><img border="0" src="images/dot.gif" width="1" height="1" /></td>
                            </tr>
                            <tr>
                                <td bgcolor="#e3ebef"><img border="0" src="images/dot.gif" width="1" height="1">
                                </td>
                            </tr>
                            <tr>
                                <td height="20">
                                    <table border="0" width="100%" id="table27" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td width="40"><p align="center"><img src="images/text_page.png" width="24" height="24" /></p></td>
                                            <td class="contentnews1" align="left">
                                                <asp:LinkButton ID="lnkStudyProgram" runat="server"  OnClick="lnkNavigate_Click" Text="Danh sách câu hỏi sinh viên" CssClass="menumain"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>                                                          
                                </td>
                            </tr>
                            <tr>
                                <td bgcolor="#e3ebef"><img border="0" src="images/dot.gif" width="1" height="1"></td>
                            </tr>
                            <tr>
                                <td height="20">
                                    <table border="0" width="100%" id="table25" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td width="40"><p align="center"><img src="images/pencil.png" width="24" height="24" /></p></td>
                                            <td class="contentnews1" align="left"> 
                                                <asp:LinkButton ID="lnkDangKy" runat="server"  OnClick="lnkNavigate_Click" Text="Trả lời câu hỏi" CssClass="menumain"></asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>                                                        
                                </td>
                            </tr>
                            <tr>
                                <td bgcolor="#e3ebef"><img border="0" src="images/dot.gif" width="1" height="1" /></td>
                            </tr>
                            <tr>
                                <td bgcolor="#e3ebef"><img src="images/dot.gif" alt="" width="1" height="1" border="0">
                                </td>
                            </tr>
                            <tr>
                                <td height="20">
                                    <table border="0" width="100%" id="table21" cellspacing="0" cellpadding="0">
                                        <tr>
                                            <td width="40"><p align="center"><img src="images/favorite.png" width="24" height="24" /></p></td>
                                            <td class="contentnews1" align="left">
                                                <asp:LinkButton ID="lnkThoat" runat="server" OnClick="lnkNavigate_Click" Text="Thoát" CssClass="menumain"> </asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <img border="0" src="images/bottom_fr_left.gif" width="223" height="5">
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;	</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                  <td>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td width="10" valign="top">&nbsp;</td>
        <td valign="top">
            <asp:PlaceHolder ID="plhWorkingArea" runat="server"></asp:PlaceHolder>
        </td>
    </tr>
</table>