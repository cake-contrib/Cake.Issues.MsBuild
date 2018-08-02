namespace Cake.Issues.MsBuild.LogFileFormat
{
    using System;
    using System.Collections.Generic;
    using Cake.Core.Diagnostics;
    using Microsoft.Build.Logging.StructuredLogger;

    /// <summary>
    /// MsBuild log format as written by the <c>MSBuildStructuredLog</c> logger.
    /// </summary>
    internal class MSBuildStructuredLogFileFormat : BaseMsBuildLogFileFormat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MSBuildStructuredLogFileFormat"/> class.
        /// </summary>
        /// <param name="log">The Cake log instance.</param>
        public MSBuildStructuredLogFileFormat(ICakeLog log)
            : base(log)
        {
        }

        /// <inheritdoc/>
        public override IEnumerable<IIssue> ReadIssues(
            MsBuildIssuesProvider issueProvider,
            IssueCommentFormat format,
            RepositorySettings repositorySettings,
            MsBuildIssuesSettings msBuildIssuesSettings)
        {
#pragma warning disable SA1123 // Do not place regions within elements
            #region DupFinder Exclusion
#pragma warning restore SA1123 // Do not place regions within elements

            issueProvider.NotNull(nameof(issueProvider));
            repositorySettings.NotNull(nameof(repositorySettings));
            msBuildIssuesSettings.NotNull(nameof(msBuildIssuesSettings));

            #endregion

            var result = new List<IIssue>();

            //var binLogReader = new BinLogReader();

            //var logger = BuildLogReader.Read(filePath)
            //var logger = new StructuredLogger();

            throw new NotImplementedException();
        }
    }
}
