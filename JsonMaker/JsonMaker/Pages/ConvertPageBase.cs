using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonMaker.Pages
{
    public class ConvertPageBase: ComponentBase
    {

        public string InputText { get; set; }
        public string OutputText { get; set; }



        protected override async Task OnInitializedAsync()
        {

        }

        public void Convert()
        {
            OutputText = InputText;
        }
    }
}
