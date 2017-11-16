namespace CardsDownloadApp.Models.MtgJson
{
    public class MtgJsonSet
    {
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
        public MtgJsonCard[] Cards { get; set; }
    }
}
