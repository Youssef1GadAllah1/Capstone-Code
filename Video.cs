using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class Video
    {
        private string NameVideo;
        private int TimeVideo;
        private DateTime NowVideo;
        private string Department;

        public void UploadVideo(string namevideo, int timevideo,string Department)
        {
            TimeVideo = timevideo;
            NameVideo = namevideo;
            NowVideo = DateTime.Now;
            this.Department = Department;
        }
        public string GetNameVideo()
        {
            return NameVideo;   
        }
        public string GetDepartmentVideo()
        {
            return Department;
        }
        public int GetTimeVideo()
        {
            return TimeVideo;
        }
        public DateTime GetNowVideo()
        {
            return NowVideo;
        }
    }
}
