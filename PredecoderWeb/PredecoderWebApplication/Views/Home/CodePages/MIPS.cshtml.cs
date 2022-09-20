using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PredecoderWebApplication.Views.Home
{
    public class MIPSCodePageModel : PageModel
    {
        public string Code { get; private set; }
        public void OnGet()
        {
        }
    }
}
