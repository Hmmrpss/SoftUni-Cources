using System;
using System.Collections;

class RandomList : ArrayList
{
    public string RandomString()
    {
        var rand = new Random();
        var index = rand.Next(Count);
        var returnValue = this[index];
        RemoveAt(index);
        return returnValue.ToString();
    }
}
