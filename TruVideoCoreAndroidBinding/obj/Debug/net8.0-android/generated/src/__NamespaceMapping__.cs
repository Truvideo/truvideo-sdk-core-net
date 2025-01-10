using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.truvideo.sdk.core", Managed="Com.Truvideo.Sdk.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.truvideo.sdk.core.examples", Managed="Com.Truvideo.Sdk.Core.Examples")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.truvideo.sdk.core.interfaces", Managed="Com.Truvideo.Sdk.Core.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common", Managed="Truvideo.Sdk.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.adapter.http", Managed="Truvideo.Sdk.Common.Adapter.Http")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.adapter.log", Managed="Truvideo.Sdk.Common.Adapter.Log")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.di.config", Managed="Truvideo.Sdk.Common.DI.Config")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.domain.usecases", Managed="Truvideo.Sdk.Common.Domain.Usecases")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.exceptions", Managed="Truvideo.Sdk.Common.Exceptions")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.interfaces", Managed="Truvideo.Sdk.Common.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.model", Managed="Truvideo.Sdk.Common.Model")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.repository.local_storage", Managed="Truvideo.Sdk.Common.Repository.Local_storage")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.auth", Managed="Truvideo.Sdk.Common.Service.Auth")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.connectivity", Managed="Truvideo.Sdk.Common.Service.Connectivity")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.http", Managed="Truvideo.Sdk.Common.Service.Http")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.ip", Managed="Truvideo.Sdk.Common.Service.IP")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.local_storage", Managed="Truvideo.Sdk.Common.Service.Local_storage")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.log", Managed="Truvideo.Sdk.Common.Service.Log")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.service.log.interfaces", Managed="Truvideo.Sdk.Common.Service.Log.Interfaces")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.shared", Managed="Truvideo.Sdk.Common.Shared")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.usecases.auth", Managed="Truvideo.Sdk.Common.Usecases.Auth")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.usecases.connectivity", Managed="Truvideo.Sdk.Common.Usecases.Connectivity")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.usecases.ip", Managed="Truvideo.Sdk.Common.Usecases.IP")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "truvideo.sdk.common.util", Managed="Truvideo.Sdk.Common.Util")]

delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate long _JniMarshal_PPLJ_J (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate void _JniMarshal_PPLJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6);
delegate IntPtr _JniMarshal_PPLLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7);
delegate IntPtr _JniMarshal_PPLLLLLLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7, IntPtr p8);
delegate IntPtr _JniMarshal_PPLLLZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, bool p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPLLLZZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, bool p3, bool p4, IntPtr p5);
delegate IntPtr _JniMarshal_PPLLZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLZZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, bool p3, IntPtr p4);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPLZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLZZL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, IntPtr p3);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

