using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShareV2.RecorderParams;

namespace ShareV2
{
    class VideoSaver : IDisposable
    {
        private VideoFileWriter vFWriter;
        AnimatedGif.AnimatedGifCreator gif;
        private RecorderParams Params;
        public VideoSaver(RecorderParams Params)
        {
            this.Params = Params;
            switch (Params.fileFormat)
            {
                case FileFormat.GIF:
                    var frameInterval = TimeSpan.FromSeconds(1 / (double)Params.FramesPerSecond);
                    gif = AnimatedGif.AnimatedGif.Create(Params.FileName, frameInterval.Milliseconds, 1);
                    break;
                case FileFormat.WEBM:
                    vFWriter = new VideoFileWriter();
                    vFWriter.Open(Params.FileName, Params.Width, Params.Height, Params.FramesPerSecond);
                    break;
            }

        }

        public void AddFrame(Bitmap frame)
        {
            switch (Params.fileFormat)
            {
                case FileFormat.GIF:
                    AddGifFrame(frame);
                    break;
                case FileFormat.WEBM:
                    AddWebmFrame(frame);
                    break;
            }
        }

        public void Dispose()
        {
            if(vFWriter != null)vFWriter.Close();
            if(gif != null)gif.Dispose();
        }

        private void AddWebmFrame(Bitmap image)
        {
            vFWriter.WriteVideoFrame(image);
        }

        private void AddGifFrame(Bitmap image)
        {
            gif.AddFrameAsync(image, -1, AnimatedGif.GifQuality.Bit8);
        }
    }
}
