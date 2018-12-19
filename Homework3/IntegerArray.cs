using System;
using System.Diagnostics.Contracts;
using System.Linq;

public class IntegerArray
{
    private int[] integerArray;

    public IntegerArray()
    {
        integerArray = new int[] { };
    }

    [ContractInvariantMethod]
    private void IntegerArrayInvariant()
    {
        Contract.Invariant(this.integerArray != null);
        var ints = this.integerArray as int[];
        Contract.Invariant(ints != null);
    }

    public void addElem(int x)
    {
        Contract.Requires(integerArray != null);
        Contract.Requires(integerArray.Length >= 0);

        var length = integerArray.Length;

        var newArray = new int[length + 1];

        for (var i = 0; i < length; i++)
        {
            Contract.Assert(newArray.Length > integerArray.Length);
            Contract.Assert(newArray != null);
            Contract.Assert(integerArray != null);
            Contract.Assert(i > 0);

            newArray[i] = integerArray[i];
        }

        newArray[length] = x;

        integerArray = newArray;

        Contract.Assume(this.integerArray.Contains(x));
        Contract.Ensures(this.integerArray != null);
        Contract.Ensures(length > 0);
        Contract.Ensures(this.integerArray.Contains(x));
        Contract.Ensures(this.integerArray.Length > length);
    }

    public void delElem(int x)
    {
        Contract.Requires(integerArray != null);
        Contract.Requires(integerArray.Length > 0);

        var length = integerArray.Length;

        var newArray = new int[length - 1];

        for (var i = 0; i < length; i++)
        {
            Contract.Assert(newArray != null);
            Contract.Assert(integerArray != null);
            Contract.Assert(newArray.Length < integerArray.Length);
            Contract.Assert(i > 0);

            if (integerArray[i] != x)
            {
                newArray[i] = integerArray[i];
            }
        }

        integerArray = newArray;

        Contract.Ensures(this.integerArray != null);
        Contract.Assume(!this.integerArray.Contains(x));
        Contract.Ensures(!this.integerArray.Contains(x));
        Contract.Ensures(this.integerArray.Length < length);
    }

    public void DisplayArray()
    {
        Contract.Requires(integerArray != null);
        Contract.Requires(integerArray.Length > 0);

        foreach (var item in integerArray)
        {
            Console.WriteLine(item);
        }
    }
}