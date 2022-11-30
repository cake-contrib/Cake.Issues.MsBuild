﻿namespace Cake.Issues.MsBuild
{
    using Cake.Core.Diagnostics;

    /// <summary>
    /// Base class for all MSBuild log file format.
    /// </summary>
    public abstract class BaseMsBuildLogFileFormat : BaseLogFileFormat<MsBuildIssuesProvider, MsBuildIssuesSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMsBuildLogFileFormat"/> class.
        /// </summary>
        /// <param name="log">The Cake log instance.</param>
        protected BaseMsBuildLogFileFormat(ICakeLog log)
            : base(log)
        {
        }

        /// <summary>
        /// Validates a file path.
        /// </summary>
        /// <param name="filePath">Full file path.</param>
        /// <param name="repositorySettings">Repository settings.</param>
        /// <returns>Tuple containing a value if validation was successful, and file path relative to repository root.</returns>
        protected (bool Valid, string FilePath) ValidateFilePath(string filePath, IRepositorySettings repositorySettings)
        {
            filePath.NotNullOrWhiteSpace(nameof(filePath));
            repositorySettings.NotNull(nameof(repositorySettings));

            // Ignore files from outside the repository.
            if (!filePath.IsInRepository(repositorySettings))
            {
                return (false, string.Empty);
            }

            // Make path relative to repository root.
            filePath = filePath.MakeFilePathRelativeToRepositoryRoot(repositorySettings);

            return (true, filePath);
        }
    }
}
