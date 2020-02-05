using System;
using System.Collections.Generic;
using System.Text;

namespace ImageClassificationTest
{
    public class ImageData
    {

        public readonly string ImagePath;
        public readonly string Label;

        public ImageData(string imagePath, string label)
        {
            ImagePath = imagePath;
            Label = label;
        }
    }
}
