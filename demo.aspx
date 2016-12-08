<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="js/jquery-3.1.1.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <ul>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <il class="list">
                    <input type="hidden" class="mark" value="<%#Eval("mark")%>" />
                    <div class="blog" style="display:none">
                        日志:<%#Eval("title")%> <%#Eval("createtime")%>
                    </div>
                    <div class="photo" style="display:none">
                        <img src="<%#Eval("imgpath")%>" /> <%#Eval("createtime")%>
                    </div>
                    <div class="talk" style="display:none">
                        说说：<%#Eval("talkbody")%> <%#Eval("createtime")%>
                    </div>
                </il>
                </ItemTemplate>
        </asp:Repeater>
            </ul>
    </div>
        <script>
            var mark = $(".mark");
            var blog = $(".blog");
            var photo = $(".photo");
            var talk = $(".talk");
            for (var i = 0; i < mark.length; i++) {
                if (mark.eq(i).val() == '0') {
                    blog.eq(i).attr('style', 'display:blocl');
                }
                if (mark.eq(i).val() == '1') {
                    photo.eq(i).attr('style', 'display:blocl');
                }
                if (mark.eq(i).val() == '2') {
                    talk.eq(i).attr('style', 'display:blocl');
                }
            }
        </script>
    </form>
</body>
</html>
