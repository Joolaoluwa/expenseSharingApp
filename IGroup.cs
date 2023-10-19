using System;

namespace expenseSharingProject;

public interface IGroup
{
        string GroupName();
        int NoOfMembers();
        bool GroupMembers();
}

