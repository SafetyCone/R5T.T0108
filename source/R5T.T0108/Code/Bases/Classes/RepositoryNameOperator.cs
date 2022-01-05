using System;


namespace R5T.T0108
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RepositoryNameOperator : IRepositoryNameOperator
    {
        #region Static
        
        public static RepositoryNameOperator Instance { get; } = new();

        #endregion
    }
}