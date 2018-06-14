namespace Tailor.Models
{
    public class PanelModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public PanelBody Body { get; set; } = new PanelBody();
        public string Info { get; set; }
        public string Price { get; set; }

        public bool HasInfo()
        {
            return !string.IsNullOrEmpty(Info);
        }
    }

    public class PanelBody
    {
        public bool IncludeType { get; set; }
        public bool IncludeStatus { get; set; }
        public PanelDateFilter DateFilter { get; set; } = new PanelDateFilter();
    }

    public class PanelDateFilter
    {
        public bool Include { get; set; }
        public string Title { get; set; }
    }
}