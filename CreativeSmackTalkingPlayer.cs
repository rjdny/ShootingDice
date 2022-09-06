using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        public List<string> Taunts { get; set; }
        public override int Roll()
        {
            base.Taunt = Taunts[new Random().Next(0, Taunts.Count)];
            return base.Roll();
        }
    }
}