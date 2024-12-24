using Balta.ContentContext.Enums;

namespace Balta.ContentContext  {

    public class Course : Content {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; } // 2802 etc
        public IList<Module> Modules { get; set; }

        public int DurationInMinutes  { get; set; }

        public EContentLevel Level { get; set; } ///Aqui uso um Enum de level, EVITE USAR STRING EM CASOS COMO ESSE, POR CAUSA DO DB FUTURAMENTE.

    }


}