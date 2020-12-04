using System;
using System.Collections.Generic;
using System.Text;

namespace Blogging
{
    public abstract class ContentMaker
    {
        public void MakeContent()
        {
            AddPhoto();
            AddVideo();
            AddText();
        }
        protected abstract void AddPhoto();
        protected abstract void AddVideo();
        protected abstract void AddText();
    }
}
