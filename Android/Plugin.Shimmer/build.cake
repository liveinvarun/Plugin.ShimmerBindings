
#load "../../common.cake"

var TARGET = Argument ("t", Argument ("target", "Default"));

var JAR_VERSION = "0.5.0";
var JAR_URL = string.Format ("https://repo1.maven.org/maven2/com/facebook/shimmer/shimmer/{0}/shimmer-{0}.aar", JAR_VERSION);
var JAR_DEST = "./externals/ShimmerLayout.aar";

var buildSpec = new BuildSpec () {
	Libs = new ISolutionBuilder [] {
		new DefaultSolutionBuilder {
			SolutionPath = "./source/Plugin.ShimmerLayout.sln",
			OutputFiles = new [] { 
				new OutputFileCopy {
					FromFile = "./source/Plugin.ShimmerLayout/bin/Release/Plugin.ShimmerLayout.dll",
				}
			}
		}
	},

	NuGets = new [] {
		new NuGetInfo { NuSpec = "./nuget/Plugin.ShimmerLayout.nuspec" },
	},

	Components = new [] {
		new Component { ManifestDirectory = "./component" },
	},
};

Task ("externals")
	.Does (() => 
{
	if (!DirectoryExists ("./externals/"))
		CreateDirectory ("./externals");

	if (!FileExists (JAR_DEST))
		DownloadFile (JAR_URL, JAR_DEST);
});


Task ("clean").IsDependentOn ("clean-base").Does (() => 
{	
	DeleteFiles ("./externals/*.aar");
});

SetupXamarinBuildTasks (buildSpec, Tasks, Task);

RunTarget (TARGET);
