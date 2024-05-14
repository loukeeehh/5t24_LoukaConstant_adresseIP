﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_LoukaConstant_adresseIP
{
    public struct Adresse
    {
        public int[] adresseIP;
        public string nom;
        //préparation du tableau à 4 places
        //initialisation du nom au vide

        public Adresse()
        {
            adresseIP = new int[4];
            for (int i = 0; i < 4; i++)
            {
                adresseIP[i] = 0;
            }
            nom = "";
        }
    }
}
