using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    [Serializable]
    class Counter
    {
        private Dictionary<string, int> CountDict = new Dictionary<string, int>();

        public int GetCount(string key)
        {
            if (CountDict.ContainsKey(key))
                return CountDict[key];
            return -1;
        }

        public void Increase(string key)
        {
            if (CountDict.ContainsKey(key))
                CountDict[key]++;
            else
                CountDict.Add(key, 1);
        }
    }
}
