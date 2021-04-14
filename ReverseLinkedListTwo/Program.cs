using System;

namespace ReverseLinkedListTwo
{
    class Program
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode ReverseBetween(ListNode head, int left, int right) {
            if(head.next == null || head == null)
                return head;
            bool flag = left==1 ? true : false;
            ListNode dummyhead = new ListNode();
            dummyhead.next = head;
            ListNode dummytail = new ListNode();
            dummytail.next = head;
            ListNode output = new ListNode();
            output.next = head;
            int amount = right - left;
            while(left-- > 1){
                dummyhead = dummyhead.next;
            }
            while(right-- > -1){
                dummytail = dummytail.next;
            }
            var reversemid = ReverseList(dummyhead.next, amount);
            dummyhead.next = reversemid;
            dummyhead = dummyhead.next;
            if(flag)
                output.next = dummyhead;
            while(dummyhead.next != null){
                dummyhead = dummyhead.next;
            }
            dummyhead.next = dummytail;
            return output.next;
        }
        public ListNode ReverseList(ListNode head, int amount) {
            ListNode prev = null;
            ListNode curr = head;
            while(amount-- > -1){
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
