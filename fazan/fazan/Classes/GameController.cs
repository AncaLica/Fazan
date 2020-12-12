using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fazan.Classes
{
    class GameController : Fazan
    {
        protected string Input { set; get; }
        public void SendInput(string input)
        {
            this.Input = input;
        }

        public void MakeTheGame()
        {
            GameController Gc = new GameController();

            Gc.VerifyInput(Input);
        }

    }
}
