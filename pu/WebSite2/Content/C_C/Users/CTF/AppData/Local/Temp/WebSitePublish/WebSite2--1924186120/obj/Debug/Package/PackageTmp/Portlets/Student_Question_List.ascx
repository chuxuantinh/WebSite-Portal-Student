<%@ control language="C#" autoeventwireup="true" inherits="Portlets_Student_Question_List, App_Web_lfrsztys" %>
<style type="text/css">
    .auto-style1 {
        color: #CC0000;
    }
    .auto-style2 {
        color: #0066FF;
    }
</style>
<p>
    Mã số sinh viên
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p class="auto-style1">
    <strong>Danh sách câu hỏi đang chờ duyệt.</strong></p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" Width="100%">
        <Columns>
            <asp:BoundField DataField="QuestionID" HeaderText="Mã câu hỏi" />
            <asp:BoundField DataField="QuestionName" HeaderText="Tên câu hỏi" />
            <asp:BoundField DataField="QuestionInfo" HeaderText="Nội dung" HtmlEncode="False" />
            <asp:BoundField DataField="Ngaygui" HeaderText="Ngày yêu cầu" />
        </Columns>
        <PagerSettings PageButtonCount="5" FirstPageText="Trước" LastPageText="Sau" />
    </asp:GridView>
</p>

    <span class="auto-style2"><strong>Danh sách câu hỏi đã được phản hồi.</strong></span><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AllowCustomPaging="False" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" Width="100%">
        <Columns>
            <asp:BoundField DataField="QuestionReID" HeaderText="Mã trả lời" />
            <asp:BoundField DataField="QuestionID" HeaderText="Mã câu hỏi" />
            <asp:BoundField DataField="QuestionName" HeaderText="Tiêu đề" />
            <asp:BoundField DataField="QuestionReDescriptions" HeaderText="Nội dung trả lời" HtmlEncode="False" />
            <asp:BoundField DataField="StaffName" HeaderText="Cán bộ trả lời" />
            <asp:BoundField DataField="Ngayhen" HeaderText="Ngày hẹn" />
        </Columns>
    </asp:GridView>


<p>
    &nbsp;</p>



