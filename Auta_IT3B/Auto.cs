﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Auta_IT3B
{
    public class Auto
    {
        private int naklad;

        public int Naklad { get => naklad; }
        public string Znacka { get; }
        public int Nosnost { get; }

        public Auto(string znacka, int nosnost)
        {
            Znacka = znacka;
            Nosnost = nosnost;
        }

        public int Nalozit(int naklad)
        {
            var misto = Nosnost - Naklad;
            if(misto < naklad)
            {
                this.naklad += misto;
                return misto;
            }
            else
            {
                this.naklad += naklad;
                return naklad;
            }            
        }

        public int Vylozit(int naklad)
        {
            if (Naklad < naklad)
            {
                var vylozeni = Naklad;
                this.naklad = 0;
                return vylozeni;
            }
            else
            {
                this.naklad -= naklad;
                return naklad;
            }
        }

        public int Zaparkovat()
        {
            var vylozeni = Naklad;
            this.naklad = 0;
            return vylozeni;
        }
    }
}
