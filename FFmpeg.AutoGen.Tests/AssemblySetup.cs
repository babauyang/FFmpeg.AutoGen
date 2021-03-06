using NUnit.Framework;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Tests
{
    [SetUpFixture]
    public class AssemblySetup
    {
        [OneTimeSetUp]
        public void Setup()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                ffmpeg.RootPath = "/lib/x86_64-linux-gnu/";
            }
        }
    }
}
