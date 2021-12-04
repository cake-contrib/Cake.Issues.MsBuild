#load nuget:?package=Cake.Recipe&version=2.2.1

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Cake.Issues.MsBuild",
    repositoryOwner: "cake-contrib",
    repositoryName: "Cake.Issues.MsBuild",
    appVeyorAccountName: "cakecontrib",
    shouldGenerateDocumentation: false);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context,
    dupFinderExcludePattern: new string[] { BuildParameters.RootDirectoryPath + "/src/Cake.Issues.MsBuild.Tests/**/*.cs", BuildParameters.RootDirectoryPath + "/src/Cake.Issues.MsBuild*/**/*.AssemblyInfo.cs"  },
    testCoverageFilter: "+[*]* -[xunit.*]* -[Cake.Core]* -[Cake.Testing]* -[*.Tests]* -[Cake.Issues]* -[Cake.Issues.Testing]* -[Shouldly]* -[Microsoft.Build*]* -[StructuredLogger]* -[DiffEngine]* -[EmptyFiles]*",
    testCoverageExcludeByAttribute: "*.ExcludeFromCodeCoverage*",
    testCoverageExcludeByFile: "*/*Designer.cs;*/*.g.cs;*/*.g.i.cs");

Build.RunDotNetCore();
