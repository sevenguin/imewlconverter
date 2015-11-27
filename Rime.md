# 介绍 #

Rime中州韵输入法引擎是一个跨平台的开源输入法引擎，在Linux上叫中州韵，在Windows下叫小狼毫，在Mac上叫鼠须管。该输入法是一个开源输入法，软件下载地址：http://code.google.com/p/rimeime/
经过试用，这是一款非常不错的输入法，尤其是在Linux和Mac下其他好用的输入法太少。

# 小狼毫 #

首先将深蓝词库转换中将目标选成“中州韵”，然后转换并保存到硬盘上。接下来是在Windows的托盘图标中找到小狼毫的图标，右击选择“用户词典管理”，然后选择luna\_pinyin，单击“导入文本码表”，选中刚才保存的文件，马上就可以将我们的词库导入到小狼毫的词库中了。

![http://images.cnblogs.com/cnblogs_com/studyzy/201211/201211021654503441.png](http://images.cnblogs.com/cnblogs_com/studyzy/201211/201211021654503441.png)

**注意：中州韵本身是一款繁体输入法，如果导入的词库是简体，那么可能会和默认的繁体词库重复，所以建议打开深蓝词库转换的简体转繁体选项，该选项在“高级设置”的“简繁体转换设置”里面。**

# 鼠须管 #

该词库同样可以导入到Mac版的鼠须管输入法中，下载鼠须管的词库[导入工具](http://code.google.com/p/rimeime/downloads/detail?name=rime_dict_manager_0.9.2_osx.zip&can=2&q=)，然后按照导入工具的命令格式，将我们的搜狗拼音词库导入到鼠须管的命令为：

./rime\_dict\_manager –i luna\_pinyin Sougou.txt

运行结果如图所示，正确导入了我们的搜狗词库。

![http://images.cnblogs.com/cnblogs_com/studyzy/201211/201211021654514214.png](http://images.cnblogs.com/cnblogs_com/studyzy/201211/201211021654514214.png)