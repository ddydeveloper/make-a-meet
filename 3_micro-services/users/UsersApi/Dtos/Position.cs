using System;

namespace UsersApi.Dtos
{
    public class Position
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public DateTime Created { get; set; }
    }
}