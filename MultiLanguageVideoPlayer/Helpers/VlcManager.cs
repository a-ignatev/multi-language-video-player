using System.Diagnostics;

namespace MultiLanguageVideoPlayer.Helpers
{
    public class VlcManager
    {
        private Process _vlcPlayer;
        private Process _vlcPlayer2;

        public bool IsInitialized =>
            _vlcPlayer != null && _vlcPlayer2 != null &&
            !_vlcPlayer.HasExited && !_vlcPlayer2.HasExited;

        public void Init()
        {
            Trace.WriteLine("Init VLC Manager");
            _vlcPlayer = CreateVlcProcess(VlcClient.FirstPlayerPort);
            _vlcPlayer.Start();

            _vlcPlayer2 = CreateVlcProcess(VlcClient.SecondPlayerPort);
            _vlcPlayer2.Start();
        }

        private static Process CreateVlcProcess(int port)
        {
            return new Process
            {
                StartInfo =
                {
                    FileName = Properties.Settings.Default.VlcPath,
                    Arguments = $"--intf rc --rc-host 127.0.0.1:{port} --rc-quiet",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = false
                }
            };
        }

        internal void Stop()
        {
            Trace.WriteLine("Stop VLC Manager");

            if (_vlcPlayer != null && !_vlcPlayer.HasExited)
                _vlcPlayer.Kill();
            if (_vlcPlayer2 != null && !_vlcPlayer2.HasExited)
                _vlcPlayer2.Kill();
        }
    }
}