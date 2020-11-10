using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Accord.Video.FFMPEG;


namespace ShareV2
{

    public class Recorder : IDisposable
    {
        #region Fields

        readonly RecorderParams Params;
        readonly Thread screenThread;
        readonly ManualResetEvent stopThread = new ManualResetEvent(false);
        VideoSaver vs;
        #endregion

        public Recorder(RecorderParams Params)
        {
            this.Params = Params ?? throw new ArgumentNullException(nameof(Params), "Params was null.");
            vs = new VideoSaver(Params);

            screenThread = new Thread(RecordScreen)
            {
                Name = typeof(Recorder).Name + ".RecordScreen",
                IsBackground = true
            };

            screenThread.Start();
        }

        public void Dispose()
        {
            stopThread.Set();
            screenThread.Join();
            
            stopThread.Dispose();
        }


        

        void RecordScreen()
        {
            var frameInterval = TimeSpan.FromSeconds(1 / (double)Params.FramesPerSecond);
            var timeTillNextFrame = TimeSpan.Zero;

            while (!stopThread.WaitOne(timeTillNextFrame))
            {
                var timestamp = DateTime.Now;
                using var image = Screenshot();
                vs.AddFrame(image);

                timeTillNextFrame = timestamp + frameInterval - DateTime.Now;
                if (timeTillNextFrame < TimeSpan.Zero)
                    timeTillNextFrame = TimeSpan.Zero;
            }
            vs.Dispose();
        }

        public Bitmap Screenshot()
        {
            var BMP = new Bitmap(Params.Width, Params.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            var g = Graphics.FromImage(BMP);
            g.CopyFromScreen(Params.UpperLeft, Point.Empty, new Size(Params.Width, Params.Height), CopyPixelOperation.SourceCopy);
            return BMP;
        }
    }
}