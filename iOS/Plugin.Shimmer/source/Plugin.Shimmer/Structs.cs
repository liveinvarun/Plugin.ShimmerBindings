using System;
using ObjCRuntime;

namespace Plugin.Shimmer
{
	[Native]
	public enum FBShimmerDirection : ulong
	{
		Right,
		Left,
		Up,
		Down
	}
}

