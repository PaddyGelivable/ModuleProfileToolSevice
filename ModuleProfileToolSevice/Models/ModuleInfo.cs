using System.ComponentModel.DataAnnotations;


namespace ModuleProfileToolSevice.Models
{
    public class ModuleInfo
    {
        public int Id { get; set; } [Required]
        public string VendorName { get; set; }
        public string ModuleID { get; set; }
        public int ProductCode { get; set; }
        public int VendorID { get; set; }
        public int ProductType { get; set; }
        public string CatalogName { get; set; }
        public string ModuleRevision { get; set; }
        public string ModuleSeries { get; set; }
        public string ProfileRevision { get; set; }
        public string MaximumBaudRate { get; set; }
        public int MinFWVersion { get; set; }
        public int InputWord { get; set; }
        public int OutPutWord { get; set; }
        public string Description { get; set; }
        public int MaximumLength { get; set; }
        public string FilePath { get; set; }
    }
}