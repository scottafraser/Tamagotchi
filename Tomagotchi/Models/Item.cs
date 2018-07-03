using System;
namespace Tamagotchi.Models
{
    public class Item
    {
        private string _name;
        private int _health;
        private int _hunger;
        private int _sleep;
        private int _play;

        public Item (string name)
        {
            _name = name;
            _health = 100;
            _hunger = 100;
            _sleep = 100;
            _play = 100;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth(int newHealth)
        {
            _health = newHealth;
        }
        public int GetHunger()
        {
            return _hunger;
        }

        public void SetHunger(int newHunger)
        {
            _hunger = newHunger;
        }

        public int GetSleep()
        {
            return _sleep;
        }

        public void SetSleep(int newSleep)
        {
            _sleep = newSleep;
        }

        public int GetPlay()
        {
            return _play;
        }

        public void SetPlay(int newPlay)
        {
            _play = newPlay;
        }

    }
}
