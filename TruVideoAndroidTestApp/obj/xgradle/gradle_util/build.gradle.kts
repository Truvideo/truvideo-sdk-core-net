plugins {
    alias(libs.plugins.androidApplication)
    alias(libs.plugins.jetbrainsKotlinAndroid)
}

android {
    namespace = "tech.tuyen_vuduc.gradle_util"
    compileSdk = 34

    defaultConfig {
        minSdk = 26
        targetSdk = 34
        versionCode = 1
        versionName = "1.0"
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
    kotlinOptions {
        jvmTarget = "1.8"
    }
}

dependencies {
implementation("org.jetbrains.kotlinx:kotlinx-serialization-json-jvm:1.6.3")
implementation("org.jetbrains.kotlinx:kotlinx-serialization-json:1.6.3")
implementation("io.ktor:ktor-io:2.3.11")
implementation("io.ktor:ktor-utils:2.3.11")
implementation("io.ktor:ktor-http:2.3.11")
implementation("io.ktor:ktor-websockets:2.3.11")
implementation("io.ktor:ktor-serialization:2.3.11")
implementation("io.ktor:ktor-websocket-serialization:2.3.11")
implementation("io.ktor:ktor-serialization-kotlinx:2.3.11")
implementation("io.ktor:ktor-serialization-kotlinx-json:2.3.11")
implementation("io.ktor:ktor-events:2.3.11")
implementation("io.ktor:ktor-client-core:2.3.11")
implementation("io.ktor:ktor-client-json:2.3.11")
implementation("io.ktor:ktor-client-okhttp:2.3.11")
implementation("io.ktor:ktor-client-content-negotiation:2.3.11")

}