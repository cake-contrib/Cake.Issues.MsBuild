﻿namespace Cake.Issues.MsBuild.Tests
{
    using System;
    using System.Collections.Generic;
    using Cake.Core.Diagnostics;

    internal class FakeMsBuildLogFileFormat : BaseMsBuildLogFileFormat
    {
        public FakeMsBuildLogFileFormat(ICakeLog log)
           : base(log)
        {
        }

        public new (bool Valid, string FilePath) ValidateFilePath(string filePath, IRepositorySettings repositorySettings)
        {
            return base.ValidateFilePath(filePath, repositorySettings);
        }

        public override IEnumerable<IIssue> ReadIssues(
            MsBuildIssuesProvider issueProvider,
            IRepositorySettings repositorySettings,
            MsBuildIssuesSettings issueProviderSettings)
        {
            throw new NotImplementedException();
        }
    }
}
