using System.Drawing;


namespace ShareV2
{
    // Used to Configure the Recorder
    public class RecorderParams
    {
        public RecorderParams() { }

        public string FileName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int FramesPerSecond { get; set; }
        public int Quality { get; set; }
        public Point UpperLeft { get; set; }
        public FileFormat fileFormat { get; set; }

        public enum FileFormat
        {
            GIF, WEBM
        }
    }
}