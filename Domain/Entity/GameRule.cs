using Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GameRule
    {
        private GameResult _gameResult;



        public GameResult GameResult
        {
            get { return _gameResult; }
            set
            {
                _gameResult = value;

                Game();
            }
        }
        public Deposit Deposit { get; set; }
        public Withdrawal Withdrawal { get; set; }


        public void Game()
        {
            _gameResult = GameResult.Win40;
            Withdrawal.Amount = Deposit.Fund * 2;
        }

        

    }
}
