﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero.Models
{
    public class Superheroes
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string alterEgo { get; set; }
        public string superHeroAbility { get; set; }
        public string secondSuperHeroAbility { get; set; }
        public string catchphrase { get; set; }
    }
}