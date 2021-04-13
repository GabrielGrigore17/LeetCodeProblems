using System;

namespace AddTwoNumbers
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            bool buff = false;
            int curr;
            ListNode output = new ListNode();
            ListNode temp = output;

            while(l1 != null && l2 != null){
                curr = l1.val + l2.val;
                if(buff){
                    temp.next = new ListNode((curr + 1) % 10);
                    if(curr + 1 < 10)
                        buff = false;
                }
                else{
                    temp.next = new ListNode((curr) % 10);
                    if(curr > 9)
                        buff = true;
                }
                temp = temp.next;
                l1 = l1.next;
                l2 = l2.next;
            }

            ListNode remainder = l1 == null ? l2 : l1;

            if(buff)
                while(buff){
                    if(remainder == null){
                        temp.next = new ListNode(1);
                        break;
                    }
                    curr = remainder.val + 1;
                    temp.next = new ListNode((curr) % 10);
                    if(curr < 10){
                        temp.next.next = remainder.next;
                        buff = false;
                    }
                    remainder = remainder.next;
                    temp = temp.next;
                }
            else
                temp.next = remainder;
            return output.next;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
