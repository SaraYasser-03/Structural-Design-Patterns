using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.DownloadsProxy
{
    public class DownloadProxy : Download
    {
        private RealDownload realDownload;
        private string targetFile;

        public DownloadProxy(string targetFile)
        {
            this.targetFile = targetFile;
        }

        public void downloadVideo()
        {
            if(realDownload == null)
            {
                this.realDownload = new RealDownload(this.targetFile);
            }
            realDownload.downloadVideo();
        }
    }
}
