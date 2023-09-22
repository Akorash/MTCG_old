using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTCG
{
    // "Server"
    internal class Game
    {
        private const string TITLE = "Monster Trading Card Game";

        private readonly List<User> _users = new();
        private List<User> _waitingList = new();
        private readonly List<Card> _cards;

        // Instances of Battles once two players are matched
        public Game() { }
        public void Run()
        {
            // Cards predefned

            // Game waits for login and play
            _users[0] = new User();
            _users[1] = new User();

            // If server recieves a play from the user

        }
        private void ShowScoreboard() { }
        private void Match() { }

    }
}
