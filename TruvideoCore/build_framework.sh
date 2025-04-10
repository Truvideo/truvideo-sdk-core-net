xcodebuild archive -scheme "TruvideoCore" -destination generic/platform=iOS -archivePath "archives/TruvideoCore_iOS" -derivedDataPath "$PWD/derivedData" -clonedSourcePackagesDirPath "$HOME/Library/Developer/Xcode/DerivedData/$XCODE_SCHEME" SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcodebuild archive -scheme "TruvideoCore" -destination "generic/platform=iOS Simulator" -archivePath "archives/TruvideoCore_iOS_Simulator" -derivedDataPath "$PWD/derivedData" -clonedSourcePackagesDirPath "$HOME/Library/Developer/Xcode/DerivedData/$XCODE_SCHEME" SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcodebuild -create-xcframework -framework archives/TruvideoCore_iOS.xcarchive/Products/Library/Frameworks/TruvideoCore.framework -framework archives/TruvideoCore_iOS_Simulator.xcarchive/Products/Library/Frameworks/TruvideoCore.framework -output TruvideoCore.xcframework

