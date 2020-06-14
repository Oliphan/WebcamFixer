using System;
using AForge.Video.DirectShow;

namespace WebcamFixer
{
    class WebcamFixer
    {
        static void Main(string[] args)
        {
            FilterInfoCollection filterCol = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterCol)
            {
                VideoCaptureDevice tmp = new VideoCaptureDevice(filterInfo.MonikerString);
                try
                {
                    tmp.SetCameraProperty((CameraControlProperty)(19), 0, CameraControlFlags.None);
                }
                catch { }
            }
        }
    }
}
