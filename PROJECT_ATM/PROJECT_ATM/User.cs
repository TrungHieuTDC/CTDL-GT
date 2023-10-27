using System;

    internal class User
    {
    //fields
        private string id;
        private string pin;
    public int dem;

    //constructor
    public User(string id, string pin)
    {
        this.Id = id;
        this.Pin = pin;
        this.dem = 0;
    }

    public string Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public string Pin
    {
        get
        {
            return pin;
        }

        set
        {
            pin = value;
        }
    }

    //properties

    //method
    public string toString()
    {
        return $"{Id, -15}{Pin,-15}";
    }
}

