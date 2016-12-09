# DTUnionDemo
给小学妹做的demo，将3张表合成1张并在一个页中显示

#html知识补充
##input标签
`<input type="hidden" value="xxx">`
这是一个input标签，跟加上了`type="hidden"`之后就变成了隐藏的值，教务管理系统也用到了类似的项，用于隐藏的数据传递
##div
`<div></div>`
作为一个块级元素，简单理解就是将标签分组
#jquery知识补充
这次用到的js基本是jquery语法，使用jquery时先引用jquery的库文件
`<script src="js/jquery-3.1.1.min.js"></script>`
这段代码一般会出现在`<head></head>`中，必须要在使用jquery的上方引入

##变量命名
`var x = value`
js中使用泛型变量var而不是用实型，虽然有number string 等类型但是还是不要使用为好，会被写js的人鄙视。

##选择器
`$("#xxx")`
id='xxx'的元素，如果存在多个选择第一个
`$(".xxx")`
class='xxx'的元素，如果存在多个则选择出一个对象数组，而后使用eq(i)来选择确定的第i个元素
##取值
`xxx.val()`
val()函数作为取值常用，如果是input就取value，其他情况自己去了解
##修改属性
`xxx.attr('propertyName','value')`
暂时理解为将xxx元素的propertyName属性修改为value值。详情去看js

#demo相关
##数据库
###综述
|表名|作用|
|:-------|:-------|
|blog|日志表|
|photo|照片表|
|talk|说说表|

###blog表
|列名|数据类型|是否可空|作用|
|:-------|:-------|:-----|:---------|
|id|int|否|主键，唯一标识，自增|
|title|nvarchar(50)|否|日志标题|
|body|nvarchar(100)|否|日志主体|
|createtime|datetime|否|创建时间|

###photo表
|列名|数据类型|是否可空|作用|
|:-------|:-------|:-----|:---------|
|id|int|否|主键，唯一标识，自增|
|imgpath|nvarchar(100)|否|照片的路径|
|createtime|datetime|否|创建时间|

###talk表
|列名|数据类型|是否可空|作用|
|:-------|:-------|:-----|:---------|
|id|int|否|主键，唯一标识，自增|
|body|nvarchar(100)|否|说说的内容|
|createtime|datetime|否|创建时间|

##数据模型
在demo使用如下模型同时存储3张表的内容

| 所属 | 列名 | 作用 |映射关系|
|：------|：------|：------|：------|
| 共有 | mark | 标记 |日志=0,照片=1，说说=2|
| 共有 | id | 动态的id |*.id|
| blog | title | 日志标题 |blog.title|
| blog | body | 日志主体 |blog.body|
| photo | imgpath | 照片的路径 |photo.imgpath|
| talk | talkbody | 说说的内容 |talk.body|
| 共有 | createtime | 创建时间 |*.createtime|