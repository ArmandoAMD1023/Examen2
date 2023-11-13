//using AccesoDatos.Context;
//using AccesoDatos.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AccesoDatos.Operaciones
//{
//    public class AutorDAO
//    {
//        public ApplicationDbContext context = new ApplicationDbContext();

//        // Endpoint para consultar a todas las asignaturas de la BD.
//        public List<Autor> SeleccionarTodosAutores()
//        {
//            var autores = context.Autor.ToList<Autor>();
//            return autores;
//        }
//        public Autor ObtenerAutor(int id)
//        {
//            var autor = context.Autor.Where(a => a.Id == id).FirstOrDefault();
//            return autor;
//        }
//        public bool insertar(int id, string nombre)
//        {
//            try
//            {
//                Autor autor = new Autor();
//                autor.Id = id;
//                autor.Name = nombre;

//                context.Autor.Add(autor);
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
