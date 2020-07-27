<%@ control language="C#" autoeventwireup="true" inherits="Portlets_Staff_Question_Reply, App_Web_lfrsztys" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<style type="text/css">
    .auto-style1 {
        color: #800000;
    }
    .auto-style2 {
        color: #CC0000;
    }
</style>

<p>
    Cán bộ trả lời:
    <asp:TextBox ID="TextBox_Staff" runat="server"></asp:TextBox>
</p>
<p>
    Mã số trả lời&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_MaCauTraLoi" runat="server"></asp:TextBox>
&nbsp; Mã câu hỏi&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style2">* (Nhập mã câu hỏi)</span></p>
<p>
    Thời gian hẹn lịch sinh viên:&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<span class="auto-style1">* (Chọn thời gian)</span>&nbsp;<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
</p>
<p>
    Nội dung câu hỏi</p>
<FCKeditorV2:FCKeditor ID="FCKeditor_noidung_cauhoi" runat="server">
</FCKeditorV2:FCKeditor>
<p>
    Nội dung trả lời sinh viên</p>
<FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server">
</FCKeditorV2:FCKeditor>
<p>
    Trạng thái
</p>
<asp:CheckBox ID="CheckBox_HoanThanh" runat="server" Text="Hoàn thành" />
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gửi" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Thoát" />
</p>

