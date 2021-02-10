using System;
using System.Collections.Generic;

namespace Exercise {
    public class Stack {
        private List<object> list;
        public Stack () {
            list = new List<object>();
        }

        public void Push(Object obj) {
            list.Add(obj);
        }

        public object Pop() {
            var item = list[list.Count-1];
            list.RemoveAt((list.Count-1));
            return item;
        }

        public void Clear() {
            list.Clear();
        }

        public int Length {
            get {
                return list.Count;
            }
        }
    }
}