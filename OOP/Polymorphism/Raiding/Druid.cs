﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int BasePower = 80;
        public Druid(string name)
            : base(name, BasePower)
        {
        }
        public override string CastAbality()
        {
            return $"{nameof(Druid)} - {this.Name} healed for {Power}";
        }
    }
}
