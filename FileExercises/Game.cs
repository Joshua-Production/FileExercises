using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercises
{// you you looking bro
    internal class Game
    {
        public void Run()
        {
            TextIO text = new TextIO();
            text.Run();

            SerializeIO serialize = new SerializeIO();
            serialize.Run();
        }
    }
}
