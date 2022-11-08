using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.MergeTwoLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListNode list1 = new ListNode(1, new ListNode(2));
            ListNode list2 = new ListNode(3, new ListNode(4));
            var solution = new Solution();

            Console.WriteLine(solution.MergeTwoList(list1, list2));

            Console.ReadLine();
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode MergeTwoList(ListNode list1, ListNode list2)
            {
                return list1;
            }
        }
    }
}
