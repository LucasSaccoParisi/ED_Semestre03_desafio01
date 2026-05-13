using System;
using Senac.ED.BST;

public class Program {
    public static void Main(string[] args) {
        BST bst = new BST();
        
        bst.Insert(15);
        bst.Insert(10);
        bst.Insert(8);
        bst.Insert(12);
        bst.Insert(20);
        bst.Insert(21);
        
        Console.WriteLine("In-order traversal (Sorted keys):");
        bst.PrintInOrder();
        Console.WriteLine("Visualização mais legal:");
        bst.PrintNicely();
    }
}
