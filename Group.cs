using System;

namespace expenseSharingProject;
public class Group : Person,IGroup
{
    public string GroupName()
    {
        Console.WriteLine("What would you like your group name to be: ");
        return Console.ReadLine();
    }
    public int NoOfMembers()
    {
        Console.WriteLine("How many members are in your group of friends: ");
        return int.Parse(Console.ReadLine());
    }

    public bool GroupMembers()
    {
        // var groupCollection = new Dictionary <string, string>();
        var members = NoOfMembers();
        StreamWriter groupDatabase = new StreamWriter(@"C:\Users\Joshua\Desktop\My_folders\C#_ONMS\expenseSharingProject\Text_files\Group.txt");
        try
        {
            for(int count = 0; count < members; count++)
            {
                string? fullName = FullName();
                string? password = Password();
                groupDatabase.WriteLine($"{fullName} {password}");
            }
        }
        catch(Exception err)
        {
            Console.WriteLine($"ERRORRRRRR: {0}", err.Message);
        }
        groupDatabase.Close();
        return true;
}

}