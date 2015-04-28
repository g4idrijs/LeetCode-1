
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    ///  类名称：LRUCacheSolution
    /// 
    /// </summary>
    /// * 创建人：xierenhong
    /// * 创建时间：2015/4/28 12:15:55
    /// * 修改人：
    /// * 修改时间：
    /// * 修改备注：
    /// * ==============================================================================*/
    public class LRUCacheSolution
    {
        public static Dictionary<int, int> dict;
        public readonly int _capacity;
        public Queue<int> queue;

        public LRUCacheSolution(int capacity)
        {
            this._capacity = capacity;
            queue = new Queue<int>(capacity);
            dict = new Dictionary<int, int>(capacity);
        }

        public int Get(int key)
        {
            if (dict.ContainsKey(key))
            {
                OperateQueue(key);
                return dict[key];
            }
            return -1;
        }

        public void Set(int key, int value)
        {
            if (!dict.ContainsKey(key))
            {
                if (dict.Keys.Count == _capacity)
                {
                    dict.Remove(queue.Dequeue());
                }
            }
            OperateQueue(key);
            dict[key] = value;
        }

        public void OperateQueue(int key)
        {
            if (queue.Contains(key))
            {
                queue.Enqueue(key);
                queue = new Queue<int>(queue.Distinct());
            }
            else
            {
                if (queue.Count == _capacity)
                    queue.Dequeue();
                queue.Enqueue(key);
            }
        }
    }
}
