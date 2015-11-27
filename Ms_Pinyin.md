# 介绍 #

微软拼音2010和Win8下自带的“微软拼音简捷输入法”支持扩展词典的导入，使用深蓝词库转换可以生成微软拼音的扩展词典，将其他输入法词库导入到微软拼音中。


# 操作 #

以从搜狗输入法转移到Win8平台下的微软拼音简捷输入法为例，首先将搜狗输入法的词库备份到本地，形成一个bin格式的文件。然后使用深蓝词库转换，选择词库源为搜狗拼音备份词库bin，目标词库选择“微软拼音”，然后单击“转换”按钮即可将搜狗备份词库生成微软拼音的扩展词库，将该词库保存到本地硬盘，是一个dctx格式的文件。双击该文件，就回弹出如图的窗口

![http://imewlconverter.googlecode.com/svn/wiki/mspy1.png](http://imewlconverter.googlecode.com/svn/wiki/mspy1.png)

单击确认按钮，即可完成词库的导入。如图：

![http://imewlconverter.googlecode.com/svn/wiki/mspy2.png](http://imewlconverter.googlecode.com/svn/wiki/mspy2.png)

# 注意 #
微软拼音支持一次导入的词库数量不能太大，可能上限是5W个词条，如果源词库的词条数太多，那么生成的扩展词典在安装时会报如下错误。

![http://imewlconverter.googlecode.com/svn/wiki/mspy_error.png](http://imewlconverter.googlecode.com/svn/wiki/mspy_error.png)

可以使用深蓝词库转换中的文件分割工具，点击帮助菜单下的“文件分割”选项，将我们要作为源的文本词库（如果是搜狗bin格式或者其他二进制文件格式，那么需要先转换成搜狗txt或者其他纯文本文件，然后再分割。）分割成5W个词条一个文件，然后再逐个对这些文件进行转换成微软拼音词库，再进行导入。