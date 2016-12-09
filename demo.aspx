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
                    <%--这是一个标记位，表明这条状态是个啥--%>
                    
                    <input type="hidden" class="mark" value="<%#Eval("mark")%>" />
                    <%--日志的div显示日志的基本内容--%>
                    <%--style="display:none" ----- 块隐藏     style="display:block" ------ 块显示--%>
                    <div class="blog" style="display:none">
                        日志:<%#Eval("title")%> <%#Eval("createtime")%>
                    </div>
                    <%--照片的div显示照片的基本内容--%>
                    <div class="photo" style="display:none">
                        <img src="<%#Eval("imgpath")%>" /> <%#Eval("createtime")%>
                    </div>
                    <%--说说的div显示说说的基本内容--%>
                    <div class="talk" style="display:none">
                        说说：<%#Eval("talkbody")%> <%#Eval("createtime")%>
                    </div>
                </il>
                </ItemTemplate>
        </asp:Repeater>
            </ul>
    </div>
        <script>
            var mark = $(".mark");//所有的标记位-------*代码意义：所有class=mark的标签
            var blog = $(".blog");//所有的日志div
            var photo = $(".photo");//所有的照片div
            var talk = $(".talk");//所有的说说div
            for (var i = 0; i < mark.length; i++) {//遍历对象数组mark
                if (mark.eq(i).val() == '0') {      //判断标志位---------*代码意义：mark.eq(i)----mark数组中第i个元素，即第i个class=mark的标签。
                    //mark.eq(i).val()----元素的值，对应该标签就是value。
                    blog.eq(i).attr('style', 'display:block');//如果标志位表明是日志，就把日志的块改为显示
                    //blog.eq(i).attr('propertyName','value')  将元素blog.eq(i)的propertyName属性的值改为value
                }
                if (mark.eq(i).val() == '1') {
                    photo.eq(i).attr('style', 'display:block');//如果标志位表明是照片，就把照片的块改为显示
                }
                if (mark.eq(i).val() == '2') {
                    talk.eq(i).attr('style', 'display:block');//如果标志位表明是说说，就把说说的块改为显示
                }
            }
        </script>
    </form>
</body>
</html>
