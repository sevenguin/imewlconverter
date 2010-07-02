using System;
using System.Collections.Generic;
using System.Text;

namespace Studyzy.IMEWLConverter
{
    public class SinglePinyin:PinYinFactory
    {
       private Dictionary<char, string> dic;
       public SinglePinyin()
       {
           dic = new Dictionary<char, string>();
           string list = PinyinDic.SinglePinYin;
           string[] pyList = list.Split(' ');

           for (int i = 0; i < pyList.Length; i++)
           {
               var py = pyList[i].Split(';')[0];
               var words = pyList[i].Split(';')[1];
               for (int j = 0; j < words.Length; j++)
               {
                   dic.Add(words[j], py);
               }
           }
       }

       public override List<string> GetPinYinOfChar(char str)
       {

           return new List<string>() { dic[str] };

       }

        public override List<List<string>> GetPinYinListOfString(string str)
        {
            List<List<string>> pyList = new List<List<string>>();
            List<string> pys = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                pys.Add(dic[str[i]]);
            }
            pyList.Add(pys);
            return pyList;
        }
    }
}
