﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Card
    {

        private string Face { get; }
        private string Suit { get; }


        public Card(string face,string suit)
        {
            Face = face;
            Suit = suit;
    }

        public override string ToString() => $"{Face} of {Suit}";
        
            
        }
    }
