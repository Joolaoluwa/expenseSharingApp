// See https://aka.ms/new-console-template for more information

// Expense Paying App
using expenseSharingProject;

var group = new Group();

var groupName = group.GroupName();
var noOfMembers = group.NoOfMembers();
Console.WriteLine(groupName);
Console.WriteLine(noOfMembers);
group.GroupMembers();
