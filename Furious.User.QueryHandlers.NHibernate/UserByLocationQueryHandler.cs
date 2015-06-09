using Furious.User.Queries;
using Furious.Core.Query;
using NHibernate;

namespace Furious.User.QueryHandlers.NHibernate
{
    public class UserByLocationQueryHandler : IQueryHandler<UserByUsernameQuery, Furious.User.Domain.User>
    {
        private readonly ISession session;

        public UserByLocationQueryHandler(ISession session)
        {
            this.session = session;
        }

        #region IQueryHandler implementation

        public Furious.User.Domain.User Handle(UserByUsernameQuery query)
        {
            return session.Get<Furious.User.Domain.User>(query.Username);
        }

        #endregion
    }
}

