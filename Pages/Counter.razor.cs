using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BethanysPieShopHRM.App;
using Microsoft.AspNetCore.Components;

namespace CICalc.Pages
{
    public partial class Counter : ComponentBase{
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

    }
}