using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.LinkedLists
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            var dic = new Dictionary<int, int>();
            var i = 0;

            while (head != null)
            {
                dic[++i] = head.val;
                head = head.next;
            }

            var arr = dic.Select(d => d.Value).ToArray();

            var a = string.Join(string.Empty, arr);
            Array.Reverse(arr);
            var b = string.Join(string.Empty, arr);

            return a == b;
        }
    }
}
