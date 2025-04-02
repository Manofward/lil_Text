using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Editor
{
    [Serializable]
    public class DocumentData
    {
        public string Text { get; set; }
        public List<TextColorData> TextColors { get; set; } = new List<TextColorData>();
        public List<AlignmentData> Alignments { get; set; } = new List<AlignmentData>();
        public List<FontData> Fonts { get; set; } = new List<FontData>();
        public List<string> ImagePaths { get; set; } = new List<string>();
    }

    [Serializable]
    public class TextColorData
    {
        public int Index { get; set; }
        public int R {  get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

    [Serializable]
    public class AlignmentData
    {
        public int LineIndex { get; set; }
        public HorizontalAlignment Alignment { get; set; } // Store the alignment type
    }

    [Serializable]
    public class FontData
    {
        public int LineIndex { get; set; }
        public string FontFamily { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
    }
}
