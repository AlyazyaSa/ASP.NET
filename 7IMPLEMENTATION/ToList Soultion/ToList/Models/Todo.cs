using System.ComponentModel.DataAnnotations;

namespace ToList.Models
{
    public class Todo
    {

        //PRIMARY KEY : unique , notnull , auto increment
        public int Id { get; set; }


        public string Name { get; set; }

        public string? Description { get; set; }


        public bool isFinished { get; set; }
        
        public DateTime CreateData { get; set; }
    }
}
