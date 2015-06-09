using System;
using Furious.Core.Query;

namespace Furious.User.Queries
{
    public class UserByUsernameQuery : IQuery<User>
    {
        public UserByUsernameQuery(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get;
            private set;
        }
    }
}

