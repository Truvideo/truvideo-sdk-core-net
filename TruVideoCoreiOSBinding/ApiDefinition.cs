
using System;
using Foundation;
using ObjCRuntime;

namespace TruvideoCoreiOS {

// @interface TruvideoCore : NSObject
//[Preserve(AllMembers = true)]
[BaseType (typeof(NSObject), Name = "_TtC12TruvideoCore12TruvideoCore")]
[DisableDefaultCtor]
//[BaseType(typeof(NSObject))]
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
	
	[Export ("truvideoCoreVersionNumberWithCompletionHandler:")]
	void TruvideoCoreVersionNumber(Action<string, NSError> completionHandler);
	
	[Export ("getAPIKeyWithCompletionHandler:")]
	void GetAPIKey(Action<string, NSError> completionHandler);
	
	[Export ("clearAuthenticationWithCompletionHandler:")]
	void clearAuthentication (Action<string, NSError> completionHandler);
}
}