using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace JowiTRUCO.Class
{
    class Players
    {
        public Players(string name)
        {
            this.Name = name;
        }
        private int Wins { get; set;} = 0;
        private string Name { get; set; }
        private int Score { get; set; }
        private int[] Cards { get; set; } = new int[3];
        private bool Hand { get; set; } = false;
        public void SetCards()
        {
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                Cards[i] = rand.Next(1, 41);
            }
        }
        public int[] getCards()
        {
            return Cards;
        }
        public string getName() 
        {
            return Name; 
        }
        public int getScore()
        {
            return Score;
        }
        public void setHand(bool Hand)
        {
            this.Hand = Hand;
        }
        public bool getHand()
        {
            return Hand;
        }
        public void deleteCard(int position)
        {
            this.Cards[position - 1] = 0;
        }
        public void addWin()
        {
            this.Wins ++;
        }
        public void resetWins()
        {
            this.Wins = 0;
        }
    }
}