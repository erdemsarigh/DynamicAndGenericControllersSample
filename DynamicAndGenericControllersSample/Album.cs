using System;
 
namespace DynamicAndGenericControllersSample
{



    [GeneratedController("api/album2")]
    public class Albuma
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }
    }

     

}
