using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demoHerramientas.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public List<Alumno> Alumnos { get; set; }


    //metodo tipo ngOnInit
    public void OnGet()
    {
        List<Alumno> ListadoAlumno = new List<Alumno>{
            new Alumno{DNI = 12345678, Nombre = "Juan", Apellido = "Perez"},
            new Alumno{DNI = 12345679, Nombre = "Pedro", Apellido = "Perez"},
            new Alumno{DNI = 12345680, Nombre = "Maria", Apellido = "Perez"}
        };
        Alumnos = ListadoAlumno;
    }

    public void OnPost() 
    {
        
    }


}    

    public class Alumno
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
