import Foundation
import TruvideoSdk
import CommonCrypto

@objc
final public class TruvideoCoreSdk: NSObject {
    
    @objc
    public static let shared = TruvideoCoreSdk()
    
    @objc
    public func authenticate(
        apiKey: String,
        secretKey: String,
        externalId: String
    ) async throws {
        let payload = try await generatePayload()
        let signature = toSha256String(payload: payload, secretKey: secretKey)
        try await TruvideoSdk.authenticate(
            apiKey: apiKey,
            payload: payload,
            signature: signature,
            externalId: externalId
        )
    }
    
    func generatePayload() async throws -> String {
        try TruvideoSdk.generatePayload()
    }
    
    @objc
    public func initAuthentication() async throws {
        try await TruvideoSdk.initAuthentication()
    }
    
    @objc
    public func isAuthenticated() async throws -> Bool  {
        try TruvideoSdk.isAuthenticated()
    }

    @objc
    public func isAuthenticationExpired() async throws -> Bool  {
        try TruvideoSdk.isAuthenticationExpired()
    }

    func toSha256String(payload: String, secretKey: String) -> String {
        let hmac256 = CCHmacAlgorithm(kCCHmacAlgSHA256)
        var macData = Data(count: Int(CC_SHA256_DIGEST_LENGTH))

        secretKey.withCString { keyCString in
            payload.withCString { msgCString in
                macData.withUnsafeMutableBytes { macDataBytes in
                    guard let keyBytes = UnsafeRawPointer(keyCString)?.assumingMemoryBound(to: UInt8.self),
                          let msgBytes = UnsafeRawPointer(msgCString)?.assumingMemoryBound(to: UInt8.self) else {
                        return
                    }

                    CCHmac(
                        hmac256,
                        keyBytes, Int(strlen(keyCString)),
                        msgBytes, Int(strlen(msgCString)),
                        macDataBytes.bindMemory(to: UInt8.self).baseAddress
                    )
                }
            }
        }

        return macData.map { String(format: "%02x", $0) }
            .joined()
    }
}
