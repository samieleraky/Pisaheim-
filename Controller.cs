using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pisaheim
{
    public class Controller
    {
        // Properties using List<T>
        public List<Book> Books { get; }
        public List<Amulet> Amulets { get; }
        public List<Course> Courses { get; }

        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }

        //AddToList method overloads
        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet) 
        {
            Amulets.Add(amulet);
        
        }

        public void AddToList(Course course) 
        {
            Courses.Add(course);
        }
    }
}
