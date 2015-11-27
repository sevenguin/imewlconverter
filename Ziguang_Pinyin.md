# 介绍 #

紫光拼音输入法算是比较老牌的拼音输入法了，在当年大家还在痛苦的使用着智能ABC的时候，出现了紫光拼音和拼音加加实在让人眼前一亮。当时觉得好好用。
现在紫光拼音输入法改名叫紫光华宇拼音输入法了，也支持自己格式的分类词库，同时支持文本词库的导入导出。


# 导入 #

紫光拼音支持txt格式的文本词库导入和uwl格式分类词库的导入。例如要将某个搜狗细胞词库导入到紫光拼音中，可以在深蓝词库转换中选择源词库为scel格式的细胞词库，目标词库选择“紫光拼音”，然后将转换后的词库保存到本地。
再到紫光拼音输入法的属性设置界面的“词库管理”选项卡，选中“用户词库”并单击“导入”按钮，选择我们保存在本地的txt文件，紫光将对词库进行分析，并给出提示：

![http://imewlconverter.googlecode.com/svn/wiki/ziguang_import.png](http://imewlconverter.googlecode.com/svn/wiki/ziguang_import.png)

我们可以忽略错误，单击“是”按钮，继续导入工作，系统将会把文本词库导入到我们选中的“用户词库”中，并给出结果：

![http://imewlconverter.googlecode.com/svn/wiki/ziguang_import2.png](http://imewlconverter.googlecode.com/svn/wiki/ziguang_import2.png)

需要注意的是，紫光拼音不支持单字作为词条，所以在转换时，需要选中“忽略一个字的词”选项。

# 导出 #

紫光拼音的词库导出分为文本格式的导出和uwl格式的词库备份。
在紫光的词库管理选项卡中，选中“用户词库”，然后单击下面的“导出”按钮，即可将这个词库导出成文本。该文本可以再经过深蓝词库转换的处理，转换成其他输入法的词库。
当然备份成uwl格式的词库也可以被深蓝词库转换解析。

# uwl分类词库 #

紫光拼音的分类词库是uwl后缀的二进制文件，可以在[官方网站下载](http://www.unispim.com/wordlib/index.php)。用户备份的用户词库也是uwl格式，其内部格式有些区别，不过都可以被深蓝词库转换解析。

从网站下载需要的uwl格式分类词库，然后在深蓝词库转换中选择该文件，并设置词库源为“紫光拼音词库uwl”，目标词库是我们需要转换的词库，比如要转换成百度拼音输入法，单击转换按钮即可完成uwl格式的解析和转换：

![http://imewlconverter.googlecode.com/svn/wiki/ziguang_uwl.png](http://imewlconverter.googlecode.com/svn/wiki/ziguang_uwl.png)