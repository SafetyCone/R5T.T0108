using System;

using R5T.T0108;

using Instances = R5T.T0108.X000.Instances;


namespace System
{
    public static class IRepositoryNameOperatorExtensions
    {
        public static string AdjustRepositoryName(this IRepositoryNameOperator _,
            string repositoryNameStem,
            bool isPrivate)
        {
            var output = isPrivate
                ? _.CombineTokens(repositoryNameStem, Instances.NameToken.Private())
                : repositoryNameStem
                ;

            return output;
        }
    }
}