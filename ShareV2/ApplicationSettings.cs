using System.Collections.Generic;
using System.Windows.Forms;

namespace ShareV2
{
    class ApplicationSettings
    {
        public string WebPath { get; set; }
        public string ExternalAdress { get; set; }
        public bool DeleteOnExit { get; set; }
        public bool StartWithWindows { get; set; }
        public bool AddIndexToWebPath { get; set; }
        public bool MoveToTrash { get; set; }
        public List<ModifierKeys> ModifierKeys { get; set; }
        public Keys Key { get; set; }
        
        public string ScreenshotDateTimeFormatString { get; set; }
    }
}
