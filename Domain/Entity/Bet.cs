using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Bet
    {
        public int Result { get; set; }
        public Withdrawal Withdrawal { get; set; }
        public Deposit Deposit { get; set; }
        public GameRule GameRule { get; set; }


    }
}
