using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static BlazorMovies.Client.Shared.MainLayout;

namespace MoviesApp.Client.Pages
{
    public partial class Counter
    {
         
        private int currentCount = 0; 
        
        public void IncrementCount()
        {
            currentCount++;
          
        }      
    }
}
