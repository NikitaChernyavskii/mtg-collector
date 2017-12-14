﻿using System;
using System.Collections.Generic;
using DAL.DataBase.Models;

namespace DAL.Entities
{
    public class CardSet : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string GathererCode { get; set; }
        public string OldCode { get; set; }
        public string MagicCardsInfoCode { get; set; }
        public string ReleaseDate { get; set; }
        public string Border { get; set; }
        public string Type { get; set; }
        public string Block { get; set; }
        public bool OnlineOnly { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
