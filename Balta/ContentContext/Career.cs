namespace Balta.ContentContext  {

    public class Career : Content {
        public Career ()
        {
            Items = new List<CareerItem> ();
        }
        public IList<CareerItem> Items { get; set; }    
        public int TotalCourses => Items.Count; //expression body, isso é um get, sem um set, e como ta na mesma linha, posso fazer assim
    }


}