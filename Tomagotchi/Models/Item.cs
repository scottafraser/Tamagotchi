using System;
using System.Collections.Generic;


namespace Tamagotchi.Models
                    
{
    public class Item
    {
        private string _name;
        private int _health;
        private int _hunger;
        private int _sleep;
        private int _play;
        private static List<Item> _pets = new List<Item> { };
        private int _min;
        private int _sec;
        private DateTime timer = DateTime.Now;

        public Item (string name)
        {
            _name = name;
            _health = 100;
            _hunger = 20;
            _sleep = 80;
            _play = 50;
            _pets.Add(this);
        }

        public string GetName()
        {
            return _name;
        }

        public void AddHealth(int health) {
            _health += health;
        }

        public int GetHealth()
        {
            return _health;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public int GetHunger()
        {
            return _hunger;
        }

        public void AddHunger(int newHunger)
        {
            _hunger += newHunger;
        }

        public int GetSleep()
        {
            return _sleep;
        }

        public void AddSleep(int newSleep)
        {
            _sleep += newSleep;
        }

        public int GetPlay()
        {
            return _play;
        }

        public void AddPlay(int newPlay)
        {
            _play += newPlay;
        }

        public static List<Item> GetAll()
        {
            return _pets;
        }

        public int GetMin()
        {
            _min = int.Parse(timer.ToString("mm"));
            return _min;
        }

        public int GetSec()
        {
            _sec = int.Parse(timer.ToString("ss"));
            return _sec;
        }
      

    }
}
