using expenseSharingProject;
using System.IO;

var group = new Group();
try
{
var groupFile = new StreamWriter(@"C:\Users\Joshua\Desktop\My_folders\C#_ONMS\expenseSharingProject\Text_files\Group.txt");
groupFile.WriteLine(group.GroupName());
groupFile.Close();
// return true;
}
catch(Exception error)
{
    Console.WriteLine($"An error occurred at this place:{0}", error.Message);
}
finally{
    Console.WriteLine("Have a nice dayyyy!!");
}
group.GroupMembers();