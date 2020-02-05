using System;
using System.Collections.Generic;
using System.Text;

namespace ImageClassificationTest
{
    public class InMemoryImageData
    {
        public readonly byte[] Image;
        public readonly string Label;
        public readonly string ImageFileName;

        public InMemoryImageData(byte[] image, string label, string imageFileName)
        {
            Image = image;
            Label = label;
            ImageFileName = imageFileName;
        }
    }
}
