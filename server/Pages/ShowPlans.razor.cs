using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace Anno.Pages
{
    public partial class ShowPlansComponent
    {
        public int[] ShowYears;

        public ShowPlansComponent()
        {
            List<int> years = new List<int>();
            for (int i = 14; i > -1; i--) // If it's 2021, this does 2021-(15+1) aka 2005. It does +1, so includes 2022.. next year!
            {
                years.Add(DateTime.Now.Year - i + 1);
                ShowYears = years.ToArray();
            }
        }
    }
}
