// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryHandler.cs" company="Furious Solutions">
//   Copyright © Furious Solutions 2015
// </copyright>
// <summary>
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Furious.Core.Query
{
    public interface IQueryHandler<TQuery, TQueryProjection> where TQuery : IQuery<TQueryProjection>
    {
        TQueryProjection Handle(TQuery query);
    }
}

