
using libreria_DALS.Data.Models;
using System.Collections.Generic;

namespace libreria_DALS.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Books> Books {get; set;}  
        

    }
}
