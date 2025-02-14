using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;
using System.Diagnostics;
using System.Windows.Forms;

namespace GHelper.Helpers
{
    internal class AudioIndicatorApplicationContext : ApplicationContext, IMMNotificationClient, IDisposable
    {
        private MMDeviceEnumerator deviceEnumerator;
        private object lockObj = new();
        private MMDevice? microphone;
        private bool isMuted;
        public AudioIndicatorApplicationContext()
        {
            deviceEnumerator = new MMDeviceEnumerator();
            var result=deviceEnumerator.RegisterEndpointNotificationCallback(this);
            if(result!=0)
            {
                Logger.WriteLine($"RegisterEndpointNotificationCallback Failed, Code: {result}");
                return;
            }
            SetDefaultMicrophone();
        }
        private void SetDefaultMicrophone()
        {
            lock(lockObj)
            {
                var newmicrophone = deviceEnumerator.HasDefaultAudioEndpoint(DataFlow.Capture, Role.Communications) ? deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications) : null;
                bool hasChangedMic = newmicrophone?.ID != microphone?.ID;
                if (microphone != null && hasChangedMic)
                {
                    microphone.AudioEndpointVolume.OnVolumeNotification -= AudioEndpointVolume_OnVolumeNotification;
                    microphone = null;
                }

                if (newmicrophone != null && hasChangedMic)
                {
                    newmicrophone.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
                }

                microphone = newmicrophone;
                UpdateMuteStatus();
            }
        }

        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (data.Muted != isMuted)
            {
                UpdateMuteStatus(data.Muted);
            }
        }

        private void UpdateMuteStatus(bool muted)
        {
            isMuted = muted;
            if (!OptimizationService.IsRunning() && AppConfig.IsVivoZenbook())
            {
                Program.acpi.DeviceSet(AsusACPI.MicMuteLed, muted ? 1 : 0, "MicmuteLed");
            }
        }

        private void UpdateMuteStatus()
        {
            if (microphone != null)
            {
                UpdateMuteStatus(microphone.AudioEndpointVolume.Mute);
            }
            else
            {
                UpdateMuteStatus(false);
            }
        }

        public bool? ToggleMute()
        {
            if (microphone != null)
            {
                bool result;
                result = microphone.AudioEndpointVolume.Mute = !microphone.AudioEndpointVolume.Mute;
                return result;
            }
            else
            {
                return null;
            }
        }

        public void OnDeviceStateChanged(string deviceId, DeviceState newState)
        {
            SetDefaultMicrophone();
        }

        public void OnDeviceAdded(string pwstrDeviceId)
        {
            SetDefaultMicrophone();
        }

        public void OnDeviceRemoved(string deviceId)
        {
            SetDefaultMicrophone();
        }

        public void OnDefaultDeviceChanged(DataFlow flow, Role role, string defaultDeviceId)
        {
            SetDefaultMicrophone();
        }

        public void OnPropertyValueChanged(string pwstrDeviceId, PropertyKey key) 
        {
            SetDefaultMicrophone();
        }

        protected override void Dispose(bool disposing)
        {
            if (microphone != null)
            {
                microphone.AudioEndpointVolume.OnVolumeNotification -= AudioEndpointVolume_OnVolumeNotification;
                microphone = null;
            }
            deviceEnumerator.UnregisterEndpointNotificationCallback(this);
            deviceEnumerator.Dispose();
            base.Dispose(disposing);
        }
    }
}
