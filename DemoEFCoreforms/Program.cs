using DemoEFCoreforms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEFCoreforms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new ApplicationsDbContext())
            {
                /*var estudiante1 = new Estudiante()
                {
                    Id = 1,
                    Nombres = "Eistein Dolores"
                };*/

                /* var curso1 = new Curso()
                 {
                     Nombre = "Programacion 1"
                 };

                 var curso2 = new Curso()
                 {
                     Nombre = "Cálculo"
                 };

                 var curso3 = new Curso()
                 {
                     Nombre = "Estadística"
                 };
                 context.AddRange(new Curso[] { curso1, curso2, curso3 });
                 context.SaveChanges();*/

                /*var curso1 = context.Cursos.First();
                var estudiante1 = context.Estudiantes.First();
                var estudiantecurso = new EstudianteCurso()
                {
                    CursoId = curso1.Id,
                    EstudianteId = estudiante1.Id
                };
                context.Add(estudiantecurso);
                context.SaveChanges();

                */
                //"####################
                // traemos toda la data de estudiante
                var todoLosEstudianteCursos = context.EstudianteCursos.ToList();
                //traemos toda la data de estudiante cursos inclyendo la informacion de los estudiantes y cursos
                var todosConDataRelacionada = context.EstudianteCursos
                    .Include(x => x.Estudiante)
                    .Include(x => x.Curso).ToList();

                var estudianteId = context.Estudiantes.Select(x => x.Id).First();
                //trameos todos los cursos de un esduante específico
                var studentCourses = context.EstudianteCursos
                    .Where(x => x.EstudianteId == estudianteId)
                    .Include(x => x.Curso).ToList();

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
