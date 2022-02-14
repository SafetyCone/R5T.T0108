using System;

using R5T.Magyar;

using R5T.T0108;

using Instances = R5T.T0108.X001.Instances;


namespace System
{
    public static class IRepositoryNameOperatorExtension
    {
        public static string GetDefaultNamespaceName(this IRepositoryNameOperator _,
            string repositoryName)
        {
            // Default namespace name is just the repository name.
            var output = repositoryName;
            return output;
        }

        public static string GetLibraryName(this IRepositoryNameOperator _,
            string repositoryName)
        {
            // The library name is just the repository name.
            var output = repositoryName;
            return output;
        }

        public static string GetRepositoryDirectoryName(this IRepositoryNameOperator _,
            string repositoryName)
        {
            Instances.PathOperator.VerifyNoInvalidPathCharacters(repositoryName);

            // The repository directory name is just the repository name.
            var output = repositoryName;
            return output;
        }

        public static string GetRepositoryName(this IRepositoryNameOperator _,
            string repositoryDirectoryName)
        {
            // Default is just the directory name.
            return repositoryDirectoryName;
        }

        public static char GetRepositoryNameTokenSeparatorCharacter(this IRepositoryNameOperator _)
        {
            return Characters.Period;
        }

        public static string GetRepositoryNameTokenSeparatorString(this IRepositoryNameOperator _)
        {
            return Strings.Period;
        }

        /// <summary>
        /// Chooses <see cref="GetRepositoryNameTokenSeparatorString(IRepositoryNameOperator)"/> (string) as the default.
        /// </summary>
        public static string GetRepositoryNameTokenSeparator(this IRepositoryNameOperator _)
        {
            var output = _.GetRepositoryNameTokenSeparatorString();
            return output;
        }

        public static string CombineTokens(this IRepositoryNameOperator _,
            params string[] repositoryNameTokens)
        {
            var output = String.Join(_.GetRepositoryNameTokenSeparator(), repositoryNameTokens);
            return output;
        }
    }
}
