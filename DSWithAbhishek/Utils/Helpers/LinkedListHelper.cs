using System;
using System.Collections.Generic;
using System.Text;
using Utils.Models;

namespace Utils.Helpers
{
    public class LinkedListHelper
    { 
        private static System.Random random = new System.Random();
        public static ListNode<int> GetRandomIntegerLinkedList(int length = 10)
        {
            if(length <= 0)
            {
                return null;
            }

            ListNode<int> head = new ListNode<int>()
            {
                value = random.Next()
            };

            ListNode<int> curent = head;

            while(length > 1)
            {
                ListNode<int> nextElement = new ListNode<int>()
                {
                    value = random.Next()
                };
                curent.next = nextElement;
                curent = nextElement;
                length--;
            }
            return head;
        }


        public static void PrintLinkedList<T>(ListNode<T> head)
        {
            if(head == null)
            {
                return;
            }

            while (head != null)
            {
                Console.Write(head.value + "\t");
                head = head.next;
            }
        }


        public static int GetLinkedListLength<T>(ListNode<T> head)
        {
            int c = 0;

            while(head != null)
            {
                c++;
                head = head.next;
            }

            return c;

        }
    }
}
