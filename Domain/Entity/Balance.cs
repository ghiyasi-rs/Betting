
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Balance
    {
        public Balance()
        {
                CurrentBalance = 0;
        }

        [Range(0, 2147483647,
        ErrorMessage = "Your minimum balance must be {1}")]
        public double CurrentBalance { get; set; } 
    }
}
