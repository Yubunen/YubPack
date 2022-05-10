using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YubPack {
    public class MyCalc {
        private List<int> list = new List<int>();
        public List<int> List { get { return list; } }
        public MyCalc() { }
        public MyCalc(List<int> list) { this.list = list; }
        public void Add(int item) { list.Add(item); }
        public void Clear() { list.Clear(); }
        public bool Contains(int item) { return list.Contains(item); }
        public int IndexOf(int item) { return list.IndexOf(item); }
        public int Sum {
            get {
                int sum = 0;
                foreach (int item in list) {
                    sum += item;
                }
                return sum;
            }
        }
    }
}
