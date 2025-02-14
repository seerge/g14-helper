using NAudio.CoreAudioApi;

namespace GHelper.Helpers
{
    internal class Audio
    {
        public static bool ToggleMute()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var commDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
                var consoleDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
                var mmDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

                bool status = !commDevice.AudioEndpointVolume.Mute;

                commDevice.AudioEndpointVolume.Mute = status;
                consoleDevice.AudioEndpointVolume.Mute = status;
                mmDevice.AudioEndpointVolume.Mute = status;

                Logger.WriteLine(commDevice.ToString() + ":" + status);
                Logger.WriteLine(consoleDevice.ToString() + ":" + status);
                Logger.WriteLine(mmDevice.ToString() + ":" + status);

                return status;
            }
        }

        public static bool IsMuted()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var commDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);

                return commDevice.AudioEndpointVolume.Mute;
            }
        }
    }
}
