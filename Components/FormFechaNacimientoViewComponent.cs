using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTestTRC.Components
{
    [ViewComponent(Name = "FormFechaNacimiento")]
    public class FormFechaNacimientoViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
