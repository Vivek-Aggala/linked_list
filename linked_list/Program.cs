using System;
using System.Collections.Generic;
using System.Text;

namespace linked_List
{
    class LinkedList<T>
    {
        // Private class ListNode - external users of the linked list do not
        // need to know how the elements in the list are actaully held
        private class ListNode
        {
            // A ListNode has an element and a pointer to the next node
            public T Element { get; set; }
            public ListNode NextNode { get; set; }

            // Instantiation  method to create a list node of type T
            public ListNode(T element)
            {
                this.Element = element;
                NextNode = null;
            }

            public ListNode(T element, ListNode prevNode)
            {
                this.Element = element;
                prevNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;

        // Instantiation method, head and tail are null
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        // define the public get method to return the count property
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        // Add method to add items to the list
        public void Add(T item)
        {
            if (this.head == null)
            {
                // we have an empty list, create a new head and tail 
                // (they point at the same node)
                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {
                // we have a non empty list, so append new item after tail
                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }

        // Access items at a given index in the list
        public T this[int index]
        {
            // N.B. needs error checking in case index is out of range
            get
            {
                // start at the head of the list, and move index number of places in
                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }
        }
    }
}
