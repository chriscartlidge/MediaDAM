using System;
using Furious.Core.Command;

namespace Furious.User.Commands
{
    public class AddUserCommand : ICommand
    {
        public AddUserCommand(Guid id, string username, string firstName, string lastName)
        {
            this.Id = id;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string Username
        {
            get;
            private set;
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }
    }
}

