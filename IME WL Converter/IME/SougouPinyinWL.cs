using System;
using System.Collections.Generic;
using System.Text;

namespace Studyzy.IMEWLConverter
{
    public class SougouPinyinWL : IWordLibraryImport,IWordLibraryExport
    {
        #region IWordLibraryImport 成员
        /// <summary>
        /// 通过搜狗细胞词库txt内容构造词库对象
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public WordLibraryList Import(string str)
        {
            WordLibraryList wlList = new WordLibraryList();
            string[] words = str.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                var list = PinyinHelper.GetPinYinListOfString(words[i]);
                for (int j = 0; j < list.Count; j++)
                {
                    WordLibrary wl = new WordLibrary();
                    wl.Word = words[i];
                    wl.PinYin = list[j];
                    wlList.Add(wl);
                }
            }
            return wlList;
        }

        #endregion

        #region IWordLibraryExport 成员

        public string Export(WordLibraryList wlList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < wlList.Count; i++)
            {               
                sb.Append(wlList[i].Word);
                sb.Append("\r\n");
            }
            return sb.ToString();
        }

        public Encoding Encoding
        {
            get { return Encoding.Default; }
        }

        #endregion
    }
}
