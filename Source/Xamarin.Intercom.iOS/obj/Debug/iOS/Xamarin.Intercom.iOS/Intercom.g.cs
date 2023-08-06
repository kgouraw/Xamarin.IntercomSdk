//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Xamarin.Intercom.iOS {
	[Register("Intercom", true)]
	public unsafe partial class Intercom : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("Intercom");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Intercom () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Intercom (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Intercom (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enableLogging")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableLogging ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("enableLogging"));
		}
		[Export ("handleIntercomPushNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleIntercomPushNotification (NSDictionary userInfo)
		{
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleIntercomPushNotification:"), userInfo__handle__);
		}
		[Export ("hideMessenger")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideMessenger ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("hideMessenger"));
		}
		[Export ("isIntercomPushNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsIntercomPushNotification (NSDictionary userInfo)
		{
			var userInfo__handle__ = userInfo!.GetNonNullHandle (nameof (userInfo));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isIntercomPushNotification:"), userInfo__handle__);
		}
		[Export ("logEventWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LogEventWithName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("logEventWithName:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("logEventWithName:metaData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LogEventWithName (string name, NSDictionary metaData)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var metaData__handle__ = metaData!.GetNonNullHandle (nameof (metaData));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("logEventWithName:metaData:"), nsname, metaData__handle__);
			CFString.ReleaseNative (nsname);
		}
		[Export ("logout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Logout ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("logout"));
		}
		[Export ("presentConversationList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentConversationList ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("presentConversationList"));
		}
		[Export ("presentHelpCenter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentHelpCenter ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("presentHelpCenter"));
		}
		[Export ("presentMessageComposer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentMessageComposer ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("presentMessageComposer"));
		}
		[Export ("presentMessageComposerWithInitialMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentMessageComposerWithInitialMessage (string message)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("presentMessageComposerWithInitialMessage:"), nsmessage);
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("presentMessenger")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PresentMessenger ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("presentMessenger"));
		}
		[Export ("registerUnidentifiedUser")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterUnidentifiedUser ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("registerUnidentifiedUser"));
		}
		[Export ("registerUserWithEmail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterUserWithEmail (string email)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsemail = CFString.CreateNative (email);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("registerUserWithEmail:"), nsemail);
			CFString.ReleaseNative (nsemail);
		}
		[Export ("registerUserWithUserId:email:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterUserWithUserId (string userId, string email)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			var nsuserId = CFString.CreateNative (userId);
			var nsemail = CFString.CreateNative (email);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("registerUserWithUserId:email:"), nsuserId, nsemail);
			CFString.ReleaseNative (nsuserId);
			CFString.ReleaseNative (nsemail);
		}
		[Export ("registerUserWithUserId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterUserWithUserId (string userId)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("registerUserWithUserId:"), nsuserId);
			CFString.ReleaseNative (nsuserId);
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Reset ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("reset"));
		}
		[Export ("setApiKey:forAppId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetApiKey (string apiKey, string appId)
		{
			if (apiKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			if (appId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (appId));
			var nsapiKey = CFString.CreateNative (apiKey);
			var nsappId = CFString.CreateNative (appId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setApiKey:forAppId:"), nsapiKey, nsappId);
			CFString.ReleaseNative (nsapiKey);
			CFString.ReleaseNative (nsappId);
		}
		[Export ("setBottomPadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetBottomPadding (nfloat bottomPadding)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("setBottomPadding:"), bottomPadding);
		}
		[Export ("setDeviceToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDeviceToken (NSData deviceToken)
		{
			var deviceToken__handle__ = deviceToken!.GetNonNullHandle (nameof (deviceToken));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setDeviceToken:"), deviceToken__handle__);
		}
		[Export ("setInAppMessagesVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInAppMessagesVisible (bool visible)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setInAppMessagesVisible:"), visible);
		}
		[Export ("setLauncherVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLauncherVisible (bool visible)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setLauncherVisible:"), visible);
		}
		[Export ("setNeedsStatusBarAppearanceUpdate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetNeedsStatusBarAppearanceUpdate ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("setNeedsStatusBarAppearanceUpdate"));
		}
		[Export ("setUserHash:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserHash (string userHash)
		{
			if (userHash is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userHash));
			var nsuserHash = CFString.CreateNative (userHash);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserHash:"), nsuserHash);
			CFString.ReleaseNative (nsuserHash);
		}
		[Export ("updateUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateUser (ICMUserAttributes userAttributes)
		{
			var userAttributes__handle__ = userAttributes!.GetNonNullHandle (nameof (userAttributes));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("updateUser:"), userAttributes__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int UnreadConversationCount {
			[Export ("unreadConversationCount")]
			get {
				return global::ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("unreadConversationCount"));
			}
		}
	} /* class Intercom */
}
