<%@ control language="C#" autoeventwireup="true" inherits="Portlets_Staff_Question_List, App_Web_lfrsztys" %>
<style type="text/css">
    .auto-style1 {
        color: #FF0000;
    }
    .auto-style2 {
        color: #FF6600;
    }
    .auto-style3 {
        color: #0000FF;
    }
</style>

<p class="auto-style1">
    <strong>Danh sách câu hỏi của sinh viên chưa phản hồi.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Theo đơn vị
    <asp:DropDownList ID="Depart_Combo" runat="server">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Lọc" />
    </strong></p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" Width="100%" AllowPaging="True" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
    <Columns>
        <asp:HyperLinkField DataTextField="QuestionID" HeaderText="Mã câu hỏi" DataNavigateUrlFields="QuestionID" DataNavigateUrlFormatString="../Staff_Question_Reply.aspx?Name={0}">
                      
         <HeaderStyle Width="80px" />
        </asp:HyperLinkField>
        <asp:BoundField DataField="QuestionName" HeaderText="Tên câu hỏi" />
        <asp:BoundField DataField="Ngaytao" HeaderText="Ngày tạo" />
        <asp:BoundField DataField="QuestionInfo" HeaderText="Chi tiết câu hỏi" HtmlEncode="False" />
       
        <asp:BoundField DataField="StudentID" HeaderText="Mã SV" />
        <asp:BoundField DataField="DepartmentName" HeaderText="Đơn vị" />
       
              
    </Columns>
</asp:GridView>
<p class="auto-style3">
    <strong>Danh sách câu hỏi của sinh viên đang phản hồi.</strong></p>
<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnPageIndexChanging="GridView2_PageIndexChanging" PageSize="5">
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="QuestionReID" DataNavigateUrlFormatString="../Staff_Question_Reply_Update.aspx?Name={0}" DataTextField="QuestionReID" HeaderText="Mã trả lời" />
                      
        <asp:BoundField DataField="QuestionID" HeaderText="Mã Câu hỏi" />
        <asp:BoundField DataField="QuestionName" HeaderText="Tên câu hỏi" />
       
        <asp:BoundField DataField="Ngaytao" HeaderText="Ngày Y/C" />
        <asp:BoundField DataField="QuestionReDescriptions" HeaderText="Chi tiết trả lời" HtmlEncode="False" />
       
        <asp:BoundField DataField="NgayTraloi" HeaderText="Ngày trả lời" />
        <asp:BoundField DataField="Ngayhen" HeaderText="Thời gian lịch hẹn" />
        <asp:BoundField DataField="StudentID" HeaderText="Mã sinh viên" />
        <asp:BoundField DataField="StaffName" HeaderText="Nhân viên trả lời" />
        <asp:BoundField DataField="DepartmentName" HeaderText="Đơn vị" />
        <asp:BoundField DataField="Stutus" HeaderText="Trạng thái" />
    </Columns>
    <PagerSettings PageButtonCount="5" />
</asp:GridView>
<p class="auto-style2">
    <strong>Danh sách câu hỏi của sinh viên đã phản hồi.</strong></p>
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnPageIndexChanging="GridView2_PageIndexChanging" PageSize="8" OnSelectedIndexChanging="GridView2_SelectedIndexChanging" AllowPaging="True">
    <Columns>
        <asp:HyperLinkField DataNavigateUrlFields="QuestionReID" DataNavigateUrlFormatString="../Staff_Question_Reply_Update.aspx?Name={0}" DataTextField="QuestionReID" HeaderText="Mã trả lời" />
                      
        <asp:BoundField DataField="QuestionID" HeaderText="Mã Câu hỏi" />
        <asp:BoundField DataField="QuestionName" HeaderText="Tên câu hỏi" />
       
        <asp:BoundField DataField="Ngaytao" HeaderText="Ngày Y/C" />
        <asp:BoundField DataField="QuestionReDescriptions" HeaderText="Chi tiết trả lời" HtmlEncode="False" />
       
        <asp:BoundField DataField="NgayTraloi" HeaderText="Ngày trả lời" />
        <asp:BoundField DataField="Ngayhen" HeaderText="Thời gian lịch hẹn" />
        <asp:BoundField DataField="StudentID" HeaderText="Mã sinh viên" />
        <asp:BoundField DataField="StaffName" HeaderText="Nhân viên trả lời" />
        <asp:BoundField DataField="DepartmentName" HeaderText="Đơn vị" />
        <asp:BoundField DataField="Stutus" HeaderText="Trạng thái" />


    </Columns>


    <PagerSettings PageButtonCount="8" />
</asp:GridView>
<p>
    Người dùng: <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

&nbsp; Đơn vị <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

</p>






&nbsp;








