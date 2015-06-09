// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICommandHandler.cs" company="Furious Solutions">
//   Copyright © Furious Solutions 2015
// </copyright>
// <summary>
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Furious.Core.Command
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}

