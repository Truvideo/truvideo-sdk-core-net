import Foundation
import TruvideoSdk
import CommonCrypto

@objc
final public class TruvideoCore: NSObject {
    
    @objc
    public static let shared = TruvideoCore()
    
    // MARK: - Authentication
    
    
    @objc
    public func authenticate(
        apiKey: String,
        payload: String,
        externalId: String,
        signature: String,
        completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void
    ) {
        Task {
            do {
               try await TruvideoSdk.authenticate(
                    apiKey: apiKey,
                    payload: payload,
                    signature: signature,
                    externalId: externalId
                )
                completionHandler("Authenticated", nil) // Success
            } catch {
                completionHandler(nil, error) // Failure
            }
        }
    }
    
    @objc
    public func generatePayload(completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void) {
        Task {
            do {
                let result = try TruvideoSdk.generatePayload()
                completionHandler(result, nil)
            } catch {
                completionHandler(nil, error)
            }
        }
    }
    
//    @objc
//    public func truvideoSdkVersionString(completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void) {
//        Task {
//            do {
//                let result = try TruvideoCoreVersionString
//                completionHandler(result, nil)
//            } catch {
//                completionHandler(nil, error)
//            }
//        }
//    }
    
    @objc
    public func truvideoCoreVersionNumber(completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void) {
        Task {
            do {
                let result = TruvideoCoreVersionNumber
                completionHandler("\(result)", nil)
            }
        }
    }
    
    @objc
    public func initAuthentication(completionHandler: @escaping (_ success: String, _ error: Error?) -> Void) {
        Task {
            do {
                try await TruvideoSdk.initAuthentication()
                completionHandler("Authenticated Successfully", nil)
            } catch {
                completionHandler("false", error)
            }
        }
    }
    
    @objc public func getAPIKey(completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void) {
        Task {
            do {
                let result = try TruvideoSdk.apiKey()
                completionHandler(result, nil)
            } catch {
                completionHandler(nil, error)
            }
        }
    }

    @objc
    public func isAuthenticated(completionHandler: @escaping (_ result: String, _ error: Error?) -> Void) {
        
        Task {
            do {
                let result = try TruvideoSdk.isAuthenticated()
                completionHandler("\(result)", nil)
            } catch {
                completionHandler("false", error)
            }
        }
    }

    @objc
    public func isAuthenticationExpired(completionHandler: @escaping (_ result: String, _ error: Error?) -> Void) {
        Task {
            do {
                let result = try TruvideoSdk.isAuthenticationExpired()
                completionHandler("\(result)", nil)
            } catch {
                completionHandler("false", error)
            }
        }
    }

    // MARK: - HMAC SHA-256
    public func toSha256String(payload: String, secretKey: String, completionHandler: @escaping (_ result: String?, _ error: Error?) -> Void) {
        guard let keyData = secretKey.data(using: .utf8),
              let payloadData = payload.data(using: .utf8) else {
            completionHandler(nil, NSError(domain: "HMAC Error", code: -1, userInfo: [NSLocalizedDescriptionKey: "Invalid key or payload encoding"]))
            return
        }

        var macData = Data(count: Int(CC_SHA256_DIGEST_LENGTH))
        macData.withUnsafeMutableBytes { macBytes in
            keyData.withUnsafeBytes { keyBytes in
                payloadData.withUnsafeBytes { payloadBytes in
                    CCHmac(
                        CCHmacAlgorithm(kCCHmacAlgSHA256),
                        keyBytes.baseAddress, keyBytes.count,
                        payloadBytes.baseAddress, payloadBytes.count,
                        macBytes.baseAddress
                    )
                }
            }
        }

        let hashString = macData.map { String(format: "%02x", $0) }.joined()
        completionHandler(hashString, nil)
    }
    
    @objc
    public func clearAuthentication(completionHandler: @escaping (_ result: String, _ error: Error?) -> Void){
        Task{
            do{
                try TruvideoSdk.clearAuthentication()
                completionHandler("Authentication Cleared", nil)
            } catch {
                completionHandler("Clear Authentication Failed", nil)
            }
        }
       
    }
}
