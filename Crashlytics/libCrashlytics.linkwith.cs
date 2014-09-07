using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libCrashlytics.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64, ForceLoad = true)]
