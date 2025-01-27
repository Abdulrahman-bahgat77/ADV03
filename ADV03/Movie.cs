using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }

        public Movie(int id, string? title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id}::{Title}::{Price}";
        }
        public override int GetHashCode()
        {
           // return  this.Id.GetHashCode()+this.Title?.GetHashCode ?? default(int) +this.Price.GetHashCode();
           return HashCode.Combine(Id, Title, Price);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
             Movie other = (Movie)obj   ;
            return this.Id.Equals(other.Id)&& (this.Title?.Equals(other.Title) ?? other.Title is null) &&this.Price.Equals(other.Price);
        }
    }
}
