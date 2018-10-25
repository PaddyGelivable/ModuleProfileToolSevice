namespace ModuleProfileToolSevice.Migrations
{
    using System.Data.Entity.Migrations;
    using ModuleProfileToolSevice.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ModuleProfileToolSevice.Models.ModuleProfileToolSeviceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModuleProfileToolSeviceContext context)
        {
            context.ModuleInfoes.AddOrUpdate(x => x.Id,
                new ModuleInfo() { Id = 1, VendorID = 58, VendorName = "Spectrum Control", CatalogName = "2080-IF4XOF4-SC", Description = "4 Channel Analog Input and 4 Channel Analog Output", InputWord = 14, MaximumBaudRate = "16", MaximumLength = 16, MinFWVersion = 9, ModuleID = "N/A", ModuleSeries = "A", ModuleRevision = "1.1", OutPutWord = 5, ProductCode = 114, ProductType = 10, ProfileRevision = "1", FilePath = "./modulefiles/Spectrum Controls 2085sc-IF8U_v1_1.zip" },
                new ModuleInfo() { Id = 2, VendorID = 58, VendorName = "Spectrum Control", CatalogName = "2085-OB32-SC", Description = "32-channel DC source output module", InputWord = 0, MaximumBaudRate = "16", MaximumLength = 0, MinFWVersion = 9, ModuleID = "N/A", ModuleSeries = "A", ModuleRevision = "1.1", OutPutWord = 32, ProductCode = 115, ProductType = 7, ProfileRevision = "1", FilePath = "./modulefiles/Spectrum Controls 2085sc-IF8U_v1_1.zip" },
                new ModuleInfo() { Id = 3, VendorID = 58, VendorName = "Spectrum Control", CatalogName = "2085-OV32-SC", Description = "32-channel DC sink output module", InputWord = 0, MaximumBaudRate = "16", MaximumLength = 0, MinFWVersion = 9, ModuleID = "N/A", ModuleSeries = "A", ModuleRevision = "1.1", OutPutWord = 32, ProductCode = 116, ProductType = 7, ProfileRevision = "1", FilePath = "./modulefiles/Spectrum Controls 2085sc-IF8U_v1_1.zip" },
                new ModuleInfo() { Id = 4, VendorID = 58, VendorName = "Spectrum Control", CatalogName = "2085sc-IF16C", Description = "16 Channel Analog Current Input", InputWord = 25, MaximumBaudRate = "16", MaximumLength = 48, MinFWVersion = 9, ModuleID = "N/A", ModuleSeries = "A", ModuleRevision = "1.1", OutPutWord = 5, ProductCode = 112, ProductType = 10, ProfileRevision = "2", FilePath = "./modulefiles/Spectrum Controls 2085sc-IF8U_v1_1.zip" }
                );
        }
    }
}
