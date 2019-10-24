#if UNITY_IOS
using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartLookUnity {
  public partial class SmartLook {

    static partial void SetupAndStartRecordingInternal(string key) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void SetupAndStartRecordingInternal(string key, int frameRate) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void SetupInternal(string key) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void SetupInternal(string key, int frameRate) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void StartFullscreenSensitiveModeInternal() {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void StopFullscreenSensitiveModeInternal() {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void SetReferrerInternal(string referrer, string source) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void StartRecordingInternal() {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    static partial void StopRecordingInternal() {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        
      }
    }

    [DllImport("__Internal")]
    static extern void SmartlookInit(string key);

    static partial void InitInternal(string key) { 
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookInit(key);
      }
    }

    [DllImport("__Internal")]
    static extern void SmartlookInitWithFramerate(string key, int framerate);

    static partial void InitInternal(string key, int frameRate) { 
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookInitWithFramerate(key, frameRate);
      }
    }
    
    [DllImport("__Internal")] 
    static extern void SmartlookRecordEvent(string eventName);
    
    static partial void RecordEventInternal(string eventName) { 
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookRecordEvent(eventName);
      }
    }


    [DllImport("__Internal")]
    static extern void SmartlookRecordEventWithProperties(string eventName, string properties);

    static partial void RecordEventInternal(string eventName, string properties) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookRecordEventWithProperties(eventName, properties);
      }
    }

    //[DllImport("__Internal")] 
    //static extern void SmartlookRecordEvent(string eventName);
    
    static partial void RecordNavigationEventInternal(string screenName, NavigationEventType direction) { 
      if (Application.platform == RuntimePlatform.IPhonePlayer) {

      }
    }
    
    [DllImport("__Internal")]
    static extern void SmartlookSetUserIdentifier(string userIdentifier);

    static partial void SetUserIdentifierInternal(string userIdentifier) {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookSetUserIdentifier(userIdentifier);
      }
    }
    
    [DllImport("__Internal")]
    static extern void SmartlookPauseRecording();
    
    static partial void PauseRecordingInternal() { 
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookPauseRecording();
      }
    }
    
    [DllImport("__Internal")]
    static extern void SmartlookResumeRecording();

    static partial void ResumeRecordingInternal() {
      if (Application.platform == RuntimePlatform.IPhonePlayer) {
        SmartlookResumeRecording();
      }
    }
  }
}
#endif
