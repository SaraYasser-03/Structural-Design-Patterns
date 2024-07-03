using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.DownloadsProxy
{
    public class RealDownload : Download
    {
        private string targetFile;
        private string targetData;

        public RealDownload(string targetFile)
        {
            this.targetFile = targetFile;
            downloadFromInternet();
        }
        private void downloadFromInternet()
        {
            this.targetData = "Download From Internet";
        }
        public void downloadVideo()
        {
            Console.WriteLine(this.targetData);
        }
    }
}
