using Android.Runtime;

namespace Plugin.ShimmerLayout
{ 
    public partial class
        Shimmer : global::Java.Lang.Object
    {
        public partial class AlphaHighlightBuilder : global::Plugin.ShimmerLayout.Shimmer.Builder
        {
            
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override Java.Lang.Object RawThis
                => new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
        }

        public partial class ColorHighlightBuilder : global::Plugin.ShimmerLayout.Shimmer.Builder
        {
            // Error CS0534: 'Shimmer.AlphaHighlightBuilder' does not implement inherited abstract member 'Shimmer.Builder.RawThis.get'
            protected override Java.Lang.Object RawThis
                => new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/facebook/shimmer/Shimmer$Builder;")), JniHandleOwnership.TransferLocalRef);
        }
    }
}
