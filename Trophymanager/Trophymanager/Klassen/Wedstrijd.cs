﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trophymanager.Klassen
{
    public class Wedstrijd
    {
        public int Wedstrijdcode { get; set; }
        public Club ThuisTeam { get; set; }
        public Club UitTeam { get; set; }
        public DateTime Speeldatum { get; set; }
        public string Uitslag { get; set; }
        public Competitie Competitie { get; set; }

        public Wedstrijd(Club thuisTeam, Club uitTeam, DateTime speeldatum, Competitie competitie)
        {
            this.ThuisTeam = thuisTeam;
            this.UitTeam = uitTeam;
            this.Speeldatum = speeldatum;
            this.Competitie = Competitie;
        }

        public void SpeelWedstrijd()
        {
            //TODO
        }

    }
}