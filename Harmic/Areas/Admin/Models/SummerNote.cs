namespace Harmic.Areas.Admin.Models
{
    public class SummerNote
    {
        public SummerNote(string idEditor, bool loadLibrary = true)
        {
            IDEditor = idEditor;
            loadLibrary = loadLibrary;
        }

        public string IDEditor { get; set; }
        public bool LoadLibrary { get; set; }
        public int Height { set; get; } = 500;


    }

}
