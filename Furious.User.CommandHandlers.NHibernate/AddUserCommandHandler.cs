using System;
using Furious.User.Domain;
using Furious.Core.Command;
using Furious.User.Commands;
using NHibernate;

namespace Furious.User.CommandHandlers.NHibernate
{
    public class AddUserCommandHandler : ICommandHandler<AddUserCommand>
    {
        private readonly ISession session;

        public AddUserCommandHandler(ISession session)
        {
            this.session = session;
        }

        #region ICommandHandler implementation

        public void Handle(AddUserCommand command)
        {
            var user = new Furious.User.Domain.User
            {
                    Id = command.Id,
                    Username = command.Username,
                    FirstName = command.FirstName,
                    LastName = command.LastName
            };

            session.Save(user);
        }

        #endregion
    }
}

