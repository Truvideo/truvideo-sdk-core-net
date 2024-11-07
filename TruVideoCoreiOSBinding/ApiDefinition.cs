
using System;
using Foundation;
using ObjCRuntime;

namespace TruvideoCoreiOS {

// @interface TruvideoCore : NSObject
[BaseType (typeof(NSObject), Name = "_TtC12TruvideoCore12TruvideoCore")]
[DisableDefaultCtor]
interface TruvideoCore
{
	// @property (readonly, nonatomic, strong, class) TruvideoCore * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	TruvideoCore Shared { get; }

	// -(void)authenticateWithApiKey:(NSString * _Nonnull)apiKey secretKey:(NSString * _Nonnull)secretKey externalId:(NSString * _Nonnull)externalId completionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler;
	[Export ("authenticateWithApiKey:secretKey:externalId:completionHandler:")]
	void AuthenticateWithApiKey (string apiKey, string secretKey, string externalId, Action<NSError> completionHandler);

	// -(void)initAuthenticationWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler __attribute__((objc_method_family("none")));
	[Export ("initAuthenticationWithCompletionHandler:")]
	void InitAuthenticationWithCompletionHandler (Action<NSError> completionHandler);

	// -(void)isAuthenticatedWithCompletionHandler:(void (^ _Nonnull)(BOOL, NSError * _Nullable))completionHandler;
	[Export ("isAuthenticatedWithCompletionHandler:")]
	void IsAuthenticatedWithCompletionHandler (Action<bool, NSError> completionHandler);

	// -(void)isAuthenticationExpiredWithCompletionHandler:(void (^ _Nonnull)(BOOL, NSError * _Nullable))completionHandler;
	[Export ("isAuthenticationExpiredWithCompletionHandler:")]
	void IsAuthenticationExpiredWithCompletionHandler (Action<bool, NSError> completionHandler);
}
}