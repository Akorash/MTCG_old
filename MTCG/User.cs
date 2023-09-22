using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MTCG
{
    internal class User
    {
        public readonly int Id;
        private string Username { get; set; } = string.Empty;
        private readonly string _password = string.Empty;
        public List<Card>? Deck { get; set; } = null;
        private List<Card>? _stack = null;
        private int _coins = 20;

        public User() { }
        private void DefineDeck()
        {
            PrintStack();
            // Get input from user
            // ChooseCard() five times
            // While i > 5 
            // Deck[i] = 

            // OPT: Save cards in a list
        }
        private void PrintStack() 
        {
            // Print the cards available in the stack so that it looks nice :)
        }

        // Server request, provides deck

        // Request to Log in 
        
        // Make sure you can only call the Battle method when logged in
        private void Battle()
        {
            // If a player is logged in
            // If a player requests the server to play
            // Signal the server (Game) to put you on the waiting list
            // And, send the server your deck (?) and Id
        }
        private int ChooseCard() 
        {
            // Gets input from user (number)
            // Only indecies from the deck
            // If input is valid, returns index from deck
            return 0;
        }
        private void BuyCards() { }
        private void TradeCard() { }
        private bool SuffiCoins() { return _coins >= 5; }
    }
}

// Health, Card, 

// You can have a private set; (priavate setter)

// Internal -> only visible in assembly
// 