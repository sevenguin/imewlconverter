# 介绍 #

QQ拼音输入法是个跨平台的输入法，在Windows，Mac，Android，iOS等系统中都有对应版本，这里介绍在Windows下导入和导出QQ拼音输入法的词库。


# qpyd格式QQ分类词库 #

qpyd格式分类词库是一个二进制形式的文件词库，用户可以随意在[QQ输入法官方网站](http://dict.py.qq.com/)下载。本工具支持将qpyd格式词库解析并生成其他格式的词库，但是不支持将其他格式的词库生成qpyd格式的文件。
![http://imewlconverter.googlecode.com/svn/wiki/qpyd.png](http://imewlconverter.googlecode.com/svn/wiki/qpyd.png)

# txt格式中文词库 #

QQ拼音输入法将中文词库和英文词库单独处理，在QQ输入法设置窗口的词库管理选项卡中，单击中文用户词库的“导出”按钮可以将我们平时在QQ输入法中积累的用户词库导出到本地保存。

![http://imewlconverter.googlecode.com/svn/wiki/qqpy.png](http://imewlconverter.googlecode.com/svn/wiki/qqpy.png)

同样，如果需要将其他格式的词库导入到QQ输入法中，只需要使用深蓝词库转换将目标词库选为QQ拼音，将转换后的词库文件保存到硬盘，再单击“导入”按钮即可将其他词库导入。

![http://imewlconverter.googlecode.com/svn/wiki/qqpy_import_chs.png](http://imewlconverter.googlecode.com/svn/wiki/qqpy_import_chs.png)

# txt格式英文词库 #

QQ拼音输入法支持单独对英文词库进行导入导出。对于经常输入英文的朋友，在切换输入法时可以将QQ输入法的英文词库导入其他输入法，也可以将其他输入法的英文词库或英文词典导入到QQ输入法中。
比如要将灵格斯词典中的一本医学词典作为数据源导入到QQ拼音输入法中，可以在深蓝词库转换中将词库源设为灵格斯词典ld2格式，将目标设为“QQ拼音英文”:

![http://imewlconverter.googlecode.com/svn/wiki/lingoes2qqpy.png](http://imewlconverter.googlecode.com/svn/wiki/lingoes2qqpy.png)

然后将转换后的词库文件保存到本地，最后在QQ输入法属性设置中，导入即可。

![http://imewlconverter.googlecode.com/svn/wiki/qqpy_import_eng.png](http://imewlconverter.googlecode.com/svn/wiki/qqpy_import_eng.png)