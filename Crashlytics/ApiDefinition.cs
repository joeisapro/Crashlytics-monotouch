using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Crashlytics
{
    [BaseType (typeof (NSObject))]
    public partial interface Crashlytics {

        [Export ("apiKey", ArgumentSemantic.Copy)]
        string ApiKey { get; }

        [Export ("version", ArgumentSemantic.Copy)]
        string Version { get; }

        [Export ("debugMode")]
        bool DebugMode { get; set; }

        [Export ("delegate", ArgumentSemantic.Assign)]
        NSObject Delegate { get; set; }

        [Static, Export ("startWithAPIKey:")]
        Crashlytics StartWithAPIKey (string apiKey);

        [Static, Export ("startWithAPIKey:afterDelay:")]
        Crashlytics StartWithAPIKey (string apiKey, double delay);

        [Static, Export ("startWithAPIKey:delegate:")]
        Crashlytics StartWithAPIKey (string apiKey, NSObject del);

        [Static, Export ("startWithAPIKey:delegate:afterDelay:")]
        Crashlytics StartWithAPIKey (string apiKey, NSObject del, double delay);

        [Static, Export ("sharedInstance")]
        Crashlytics SharedInstance { get; }

        [Export ("crash")]
        void Crash ();

        [Export ("userIdentifier")]
        string UserIdentifier { set; }

        [Export ("userName")]
        string UserName { set; }

        [Export ("userEmail")]
        string UserEmail { set; }

        [Export ("setObjectValue:forKey:")]
        void SetObjectValue (NSObject value, string key);

        [Export ("setIntValue:forKey:")]
        void SetIntValue (int value, string key);

        [Export ("setBoolValue:forKey:")]
        void SetBoolValue (bool value, string key);

        [Export ("setFloatValue:forKey:")]
        void SetFloatValue (float value, string key);

//        [Static, Export ("setObjectValue:forKey:")]
//        void SetObjectValue (NSObject value, string key);
//
//        [Static, Export ("setIntValue:forKey:")]
//        void SetIntValue (int value, string key);
//
//        [Static, Export ("setBoolValue:forKey:")]
//        void SetBoolValue (bool value, string key);
//
//        [Static, Export ("setFloatValue:forKey:")]
//        void SetFloatValue (float value, string key);
    }

    [Model, BaseType (typeof (NSObject))]
    public partial interface CLSCrashReport {

        [Export ("identifier")]
        string Identifier { get; }

        [Export ("customKeys")]
        NSDictionary CustomKeys { get; }

        [Export ("bundleVersion")]
        string BundleVersion { get; }

        [Export ("bundleShortVersionString")]
        string BundleShortVersionString { get; }

        [Export ("crashedOnDate")]
        NSDate CrashedOnDate { get; }

        [Export ("OSVersion")]
        string OSVersion { get; }

        [Export ("OSBuildVersion")]
        string OSBuildVersion { get; }
    }

    [Model, BaseType (typeof (NSObject))]
    public partial interface CrashlyticsDelegate {

        [Export ("crashlyticsDidDetectCrashDuringPreviousExecution:")]
        void  DidDetectCrashDuringPreviousExecution (Crashlytics crashlytics);

        [Export ("crashlytics:didDetectCrashDuringPreviousExecution:")]
        void DidDetectCrashDuringPreviousExecution (Crashlytics crashlytics, CLSCrashReport crash);
    }

}

