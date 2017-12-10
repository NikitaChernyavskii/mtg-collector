﻿using DAL.DataBase.Models;

namespace DAL.Entities
{
    public class Card : IEntity
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string Layout { get; set; }
        public string Name { get; set; }
        public string[] Names { get; set; }
        public string ManaCost { get; set; }
        public float Cmc { get; set; }
        public string[] Colors { get; set; }
        public string[] ColorIdentity { get; set; }
        public string Type { get; set; }
        public string[] Supertypes { get; set; }
        public string[] Types { get; set; }
        public string[] Subtypes { get; set; }
        public string Rarity { get; set; }
        public string Text { get; set; }
        public string Flavor { get; set; }
        public string Artist { get; set; }
        public string Number { get; set; }
        public string Power { get; set; }
        public string Toughness { get; set; }
        public int? Loyalty { get; set; }
        public int Multiverseid { get; set; }
        public int[] Variations { get; set; }
        public string ImageName { get; set; }
        public string Watermark { get; set; }
        public string Border { get; set; }
        public bool Timeshifted { get; set; }
        public bool Reserved { get; set; }
        public string ReleaseDate { get; set; }

        public virtual CardSet CardSet { get; set; }
        //public virtual CardRarity CardRarity { get; set; }
    }
}
