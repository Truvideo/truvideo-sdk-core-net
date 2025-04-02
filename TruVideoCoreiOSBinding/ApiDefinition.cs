
using System;
using Foundation;
using ObjCRuntime;

namespace TruvideoCoreiOS {


[BaseType (typeof(NSObject), Name = "_TtC12TruvideoCore12TruvideoCore")]
[DisableDefaultCtor]

interface TruvideoCore
{
	// @property (readonly, nonatomic, strong, class) TruvideoCore * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	TruvideoCore Shared { get; }
	
	[Export ("authenticateWithApiKey:payload:externalId:signature:completionHandler:")]
	void AuthenticateWithApiKey (string apiKey, string payload, string externalId,string signature, Action<string, NSError> completionHandler);
	
	[Export ("initAuthenticationWithCompletionHandler:")]
	void InitAuthenticationWithCompletionHandler (Action<string, NSError> completionHandler);
	
	[Export ("isAuthenticatedWithCompletionHandler:")]
	void IsAuthenticatedWithCompletionHandler (Action<string, NSError> completionHandler);
	
	[Export ("isAuthenticationExpiredWithCompletionHandler:")]
	void IsAuthenticationExpiredWithCompletionHandler (Action<string, NSError> completionHandler);
	
	[Export ("generatePayloadWithCompletionHandler:")]
	void GeneratePayload (Action<string, NSError> completionHandler);
	
	[Export ("toSha256StringWithPayload:secretKey:completionHandler:")]
	void ToSha256String (string payload,string secretKey,Action<string, NSError> completionHandler);
}
}