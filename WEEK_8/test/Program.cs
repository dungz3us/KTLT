using System;
using System.Collections;
class GFG
{

    // Stores the history of all
    // the queries that have been
    // processed on the document
    static Stack Undo = new Stack();

    // Stores the elements
    // of REDO query
    static Stack Redo = new Stack();

    // Function to perform
    // "WRITE X" operation
    static void WRITE(Stack Undo, char X)
    {

        // Push an element to
        // the top of stack
        Undo.Push(X);
    }

    // Function to perform
    // "UNDO" operation
    static void UNDO(Stack Undo, Stack Redo)
    {

        // Stores top element
        // of the stack
        char X = (char)Undo.Peek();

        // Erase top element
        // of the stack
        Undo.Pop();

        // Push an element to
        // the top of stack
        Redo.Push(X);
    }

    // Function to perform
    // "REDO" operation
    static void REDO(Stack Undo, Stack Redo)
    {

        // Stores the top element
        // of the stack
        char X = (char)Redo.Peek();

        // Erase the top element
        // of the stack
        Redo.Pop();

        // Push an element to
        // the top of the stack
        Undo.Push(X);
    }

    // Function to perform
    // "READ" operation
    static void READ(Stack Undo)
    {

        // Store elements of stack
        // in reverse order
        Stack revOrder = new Stack();

        // Traverse Undo stack
        while (Undo.Count > 0)
        {

            // Push an element to
            // the top of stack
            revOrder.Push(Undo.Peek());

            // Erase top element
            // of stack
            Undo.Pop();
        }

        while (revOrder.Count > 0)
        {

            // Print the top element
            // of the stack
            Console.Write(revOrder.Peek());
            Undo.Push(revOrder.Peek());

            // Erase the top element
            // of the stack
            revOrder.Pop();
        }

        Console.Write(" ");
    }

    // Function to perform the
    // queries on the document
    static void QUERY(string[] Q)
    {
        // Stores total count
        // of queries
        int N = Q.Length;

        // Traverse all the query
        for (int i = 0; i < N; i++)
        {
            if (Q[i] == "UNDO")
            {
                UNDO(Undo, Redo);
            }
            else if (Q[i] == "REDO")
            {
                REDO(Undo, Redo);
            }
            else if (Q[i] == "READ")
            {
                READ(Undo);
            }
            else
            {
                WRITE(Undo, Q[i][6]);
            }
        }
    }

    static void Main()
    {
        string[] Q = { "WRITE A", "WRITE B", "WRITE C", "UNDO", "READ", "REDO", "READ" };
        QUERY(Q);
        Console.ReadKey();
    }
}