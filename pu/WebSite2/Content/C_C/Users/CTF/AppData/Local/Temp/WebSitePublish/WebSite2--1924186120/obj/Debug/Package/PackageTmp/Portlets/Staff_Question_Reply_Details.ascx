<%@ control language="C#" autoeventwireup="true" inherits="Portlets_Staff_Question_Reply_Details, App_Web_lfrsztys" %>
<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>

<style type="text/css">
    .auto-style1 {
        color: #CC0000;
    }
</style>

<p class="auto-style1">
    <strong>Chi tiết trả lời.</strong></p>
<tr>

    <td>
        <p>
    Mã câu trả lời&nbsp;
    <asp:TextBox ID="TextBox_MaCauTraLoi" runat="server"></asp:TextBox>
            &nbsp; Mã câu hỏi&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_MaCauHoi" runat="server"></asp:TextBox>
&nbsp;&nbsp; Tên câu hỏi&nbsp;
    <asp:TextBox ID="TextBox_TenCauHoi" runat="server" Width="345px"></asp:TextBox>
</p>
    </td>
</tr>
<tr>
        <td>
            <p>
    Ngày trả lời&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
        </td>
</tr>

<tr>
        <td>
            <p>
                Ngày hẹn sinh viên
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>

        </td>
</tr>
<tr>
        <td>
             Mã sinh viên <asp:TextBox ID="TextBox_StudentID" runat="server"></asp:TextBox>
&nbsp;
</p>
        </td>
</tr>

   
<p>
    Nội dung trả lời </p>
<FCKeditorV2:FCKeditor ID="FCKeditor_Reply_Info" runat="server">
</FCKeditorV2:FCKeditor>
<p>
    Nhân viên trả lời&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Staff" runat="server"></asp:TextBox>
&nbsp;&nbsp; Phòng ban&nbsp;
    <asp:TextBox ID="TextBox_Department" runat="server"></asp:TextBox>
</p>
<p>
    Trạng thái</p>
<p>
<asp:CheckBox ID="CheckBox_HoanThanh" runat="server" Text="Hoàn thành" />
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Cập nhật" />

    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Thoát" />
</p>

<asp:TextBox ID="TextBox_idpre" runat="server"></asp:TextBox>


