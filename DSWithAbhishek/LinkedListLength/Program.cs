using System;
using Utils.Helpers;
using Utils.Models;

namespace LinkedListLength
{
    /*
     * \
     * PRG_001
Given a linked list of size N, your task is to complete the function isLengthEvenOrOdd() which contains the head of the linked list and check whether the length of linked list is even or odd.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(10)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(11)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(12)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(13)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(1)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(0)));
            Console.WriteLine(IsLengthEven(LinkedListHelper.GetRandomIntegerLinkedList(2)));
        }

        private static bool IsLengthEven(ListNode<int> head)
        {
            int length = LinkedListHelper.GetLinkedListLength(head);
            Console.Write(length + "\t");
            return length % 2 == 0;
        }
    }
}
