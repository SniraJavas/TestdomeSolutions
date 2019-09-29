using System;
using System.Collections.Generic;

public class TextInput
{
    protected List<char> Storage;

    public TextInput()
    {
        Storage = new List<char>();
    }

    public virtual void Add(char character)
    {
        Storage.Add(character);
    }

    public string GetValue()
    {
        return new string(Storage.ToArray());
    }
}

public class NumericInput : TextInput
{
    public override void Add(char character)
    {
        if (char.IsNumber(character))
        {
            base.Add(character);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());
    }
}