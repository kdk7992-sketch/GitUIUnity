using UnityEngine;

[System.Serializable]
public class UserData
{
    public string Name;
    public int Cash;
    public int Balance;

    public UserData(string name, int cash, int balance)
    {
       Name = name;
       Cash = cash;
       Balance = balance;
    }
}
