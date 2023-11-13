//using AccesoDatos.Context;
//using AccesoDatos.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AccesoDatos.Operaciones
//{
//    public class LibroDAO
//    {
//        public ApplicationDbContext context = new ApplicationDbContext();
//        public List<Libros> SeleccionarTodosLibros()
//        {
//            var libros = context.Libro.ToList<Libro>();
//            return libros;
//        }
//        public Libro ObtenerLibro(int id)
//        {
//            var libro = context.Libro.Where(a => a.Id == id).FirstOrDefault();
//            return libro;
//        }
//        public bool insertar(int id, string nombre, int autorID, int chapters, int pages, decimal price)
//        {
//            try
//            {
//                Libro libro = new Libro();
//                libro.Id = id;
//                libro.Title = nombre;
//                libro.AutorId = autorID;
//                libro.Chapters = chapters;
//                libro.Pages = pages;
//                libro.Price = price;

//                context.Libro.Add(libro);
//                context.SaveChanges();
//                return true;

//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//    }
//}
