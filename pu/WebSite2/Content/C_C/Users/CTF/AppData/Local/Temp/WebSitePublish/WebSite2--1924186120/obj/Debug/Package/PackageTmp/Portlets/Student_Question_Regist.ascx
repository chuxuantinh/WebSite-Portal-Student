<%@ control language="C#" autoeventwireup="true" inherits="Portlets_WebUserControl, App_Web_lfrsztys" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<style type="text/css">
    .auto-style1 {
        width:100%;
    }
    .chutinh 

    {
        margin-top:20px;


    }
    .auto-style2 {
        height: 10px;
        color: #800000;
        text-align: center;
    }
    .auto-style3 {
        width: 100%;
        height: 26px;
    }
    .auto-style4 {
        height: 19px;
    }
</style>
<script runat="server">
</script>

<table id="table" cellspacing="0" cellpadding="0" width="100%" border="0" class="chutinh">
    <tr>
		<td width="100%" height="25">
			<table id="table3" height="100%" cellspacing="0" cellpadding="0" width="100%" border="0">
        <td class="auto-style2">
                                    <strong>THÔNG TIN NỘI DUNG SINH VIÊN LIÊN HỆ</strong></td>
 
    <tr>
    <td class="auto-style1">
         Mã câu hỏi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox_Macauhoi" runat="server" Enabled="False"></asp:TextBox>

                <br />
       
         <br />
               
    </td>
</tr>

    <tr>
    <td class="auto-style3">
        Mã số sinh viên:
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              

        <br />
             <br />
    </td>
</tr>

  <tr>
      <td class="auto-style1">
          Tiêu đề câu hỏi&nbsp; <asp:TextBox ID="TextBox1" runat="server"  Width="329px"></asp:TextBox>
   
   
          <br />
   
         
   
          <br />
   
         
   
      </td>
  </tr>

    <tr>
      <td class="auto-style1">
           Phòng ban tiếp nhận:&nbsp; <asp:DropDownList ID="Depart_Combo" runat="server">
    </asp:DropDownList>
           <br />
           <br />
      </td>
  </tr>
    <tr>
      <td class="auto-style1">
           <strong>Nội dung sinh viên cần liên hệ. </strong>
      </td>
  </tr>

       <td height="22" align="left" class="auto-style1">
                <FCKeditorV2:FCKeditor ID="fckDiscussion" runat="server" BasePath="~/fckeditor/" Width="600px" Height="350px">
                    </FCKeditorV2:FCKeditor>
                <br />
            </td>
    
    <tr>
        <td class="auto-style4">    
           
    Thời gian: 
            <asp:TextBox ID="TextBox4" runat="server"  Width="159px" Enabled="False"></asp:TextBox>

            
            </td>
        </tr>
    <tr>
            <td>
                <br />
</tr>
    </td>
       <tr>
        <td>  <asp:Button ID="Button1" runat="server" Text="Gửi" OnClick="Button1_Click" />
    &nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Thoát" />
            

    </tr>

  


</table>
		    <p>
                &nbsp;</p>
		</td>
	</tr>
</table>
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
