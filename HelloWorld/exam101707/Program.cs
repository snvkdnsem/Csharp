using System;

class DataStore
{
    private string[] strArr = new string[10]; // internal data storage

    public DataStore() { }
    public string this [int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            return strArr[index];
        }
        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            strArr[index] = value;
        }
    }

    public string this[string name] // if문에 ToLower가 string이므로 [string name]으로 작성해줘야한다.
    {
        get
        {
            foreach (string s in strArr) // if문에 ToLower가 string이므로 string s로 작성 해줘야한다.
            {
                if (s.ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataStore strStore = new DataStore();
        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";

        Console.WriteLine(strStore["ONE"]);
        Console.WriteLine(strStore["two"]);
        Console.WriteLine(strStore["Three"]);
        Console.WriteLine(strStore["FOUR"]);
    }
}

