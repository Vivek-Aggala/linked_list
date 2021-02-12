using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {

        private class ListNode
        {

            public T Element { get; set; }
            public ListNode NextNode { get; set; }

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
        private ListNode tail;
        private int count;
        private ListNode head;
        


        public LinkedList()
        {
            this.tail = null;
            this.count = 0;
            this.head = null;
            
        }


        public int Count
        {
            get
            {
                return this.count;
            }
        }

        
        public void Add(T item)
        {
            if (this.head == null)
            {

                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {

                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }


        public T this[int index]
        {

            get
            {

                ListNode currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                return currentNode.Element;
            }
        }
        private void RemoveListNode(ListNode node, ListNode prevNode)
        {
            count--;
            if (count == 0)
            {
               
                this.head = null;
                this.tail = null;
            }
            else if (prevNode == null)
            {
                
                this.head = node.NextNode;
            }
            else
            {
                
                prevNode.NextNode = node.NextNode;
            }
            
            if (object.ReferenceEquals(this.tail, node))
            {
                this.tail = prevNode;
            }


        }
        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid index: " + index);
            }

            ListNode currentNode = this.head;
            ListNode prevNode = null;
            int currentIndex = 0;
            
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            
            RemoveListNode(currentNode, prevNode);
            
            return currentNode.Element;
        }
        public int Remove(T item)
        {
            
            int currentIndex = 0;
            ListNode currentNode = this.head;
            ListNode prevNode = null;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            if (currentNode != null)
            {
                RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                
                return -1;
            }

        }
        public int IndexOf(T item)
        {
            int index = 0;
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.Element, item))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }
            return -1;
        }









    }
}
