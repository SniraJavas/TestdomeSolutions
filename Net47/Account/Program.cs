// Each account on a website has a set of access flags that represent a users access.
//   
// Update and extend the enum so that it contains three new access flags:
//   
//  1. A Writer access flag that is made up of the Submit and Modify flags.
//  2. An Editor access flag that is made up of the Delete, Publish and Comment flags.
//  3. An Owner access that is made up of the Writer and Editor flags.


using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Submit = 1,
        Modify = 2,
        Writer = 3,
        Delete = 8,
        Publish = 16,
        Comment = 32,
        Editor = 56,
        Owner = 59
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}