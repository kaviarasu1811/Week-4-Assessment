﻿using System;

class StackNode
{
    public int Data;
    public StackNode? Next; // Nullable
    public StackNode(int data) { Data = data; Next = null; }
}

class Stack
{
    private StackNode? top; // Nullable

    public void Push(int data)
    {
        StackNode newNode = new StackNode(data);
        newNode.Next = top;
        top = newNode;
    }

    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        top = top.Next;
    }

    public void DisplayTop()
    {
        Console.WriteLine($"Top: {(top != null ? top.Data : -1)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.DisplayTop(); // Top: 30

        stack.Pop();
        stack.DisplayTop(); // Top: 20

        stack.Pop();
        stack.Pop();
        stack.Pop(); // "Stack is empty"
    }
}
