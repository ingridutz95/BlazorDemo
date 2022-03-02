using BlazorWebApp.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebApp.Client.Pages
{
    public partial class EmployeeModal
    {
        [Parameter]
        public EventCallback<bool> OnClose { get; set; }
        [Parameter]
        public EmployeeModel Employee { get; set; }

        private Task ModalCancel()
        {
            return OnClose.InvokeAsync(false);
        }

    }
}
