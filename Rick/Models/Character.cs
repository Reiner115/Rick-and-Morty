namespace Rick_And_Morty.Models
{
    using System;
    using System.Collections.Generic;

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public Origin Origin { get; set; }
        public Location Location { get; set; }
        public string Image { get; set; }
        public List<string> Episode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Status: {Status}, Species: {Species}, Type: {Type}, Gender: {Gender}, Origin: {Origin?.Name}, Location: {Location?.Name}, Image: {Image}, Url: {Url}, Created: {Created}";
        }
    }

    public class Origin
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

}
