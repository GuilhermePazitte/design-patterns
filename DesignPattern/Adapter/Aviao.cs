﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Aviao
    {
        public void Voar(string jogador)
        {
            Console.WriteLine(jogador + " VOOU PARA FRENTE!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo!"); 
        }
    }
}