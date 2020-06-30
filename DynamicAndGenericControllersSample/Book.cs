using System;
 

namespace DynamicAndGenericControllersSample
{

     

    [GeneratedController("api/book2")]
    public class Booka
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }

}
