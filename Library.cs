using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        List<T> items = new List<T>();
        Dictionary<string, T> dictionary = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (!dictionary.ContainsKey(item.Title))
            {
                items.Add(item);
                dictionary[item.Title] = item;
            }
            else
            {
                Console.WriteLine("Объект с таким же именем уже существует");
            }
        }


        public bool Remove(string title)
        {
            if (dictionary.ContainsKey(title))
            {
                var item = dictionary[title];
                dictionary.Remove(title);
                items.Remove(item);
                return true;
            }
            return false;
        }


        public T FindByTitle(string title)
        {
            if (dictionary.ContainsKey(title))
            {
                return dictionary[title];
            }
            return null;
        }


        public IEnumerable<T> FilterByYear(int year)
        {
            return items.Where(y => y.YearPublished == year);
        }


        public IEnumerable<T> GetAllAvailable()
        {
            return items.Where(i => i.IsAvailable == true);
        }
        

        public List<Book> FindBooks(int year)
        {
            try
            {
                return items.OfType<Book>().Where(y => y.YearPublished == year || y.YearPublished > year).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR\n{ex.Message}");
            }
            return null;
        }


        public List<Movie> FindFilms()
        {
            try
            {
                return items.OfType<Movie>().OrderByDescending(m => m.Duration).ToList();
            }
            catch ( Exception ex )
            {
                Console.WriteLine($"ERROR\n{ex.Message}");
            }
            return null;
        }

        public List<T> FindNotAvailable()
        {
            try
            {
                return items.OfType<T>().OrderByDescending(m => m.IsAvailable).ToList();
            }
            catch ( Exception ex )
            {
                Console.WriteLine($"ERROR\n{ex.Message}");
            }
            return null;
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Название: {item.Title}\n" +
                    $"Автор: {item.Author}\n" +
                    $"Год публикации: {item.YearPublished}\n" +
                    $"Статус: {item.IsAvailable}\n");
            }
        }
    }
}
