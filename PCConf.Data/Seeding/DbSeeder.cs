namespace PCConf.Data.Seeding
{
    using Microsoft.Extensions.DependencyInjection;
    using PCConf.Models.Parts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AppContext = AppContext;

    public static class DbSeeder
    {
        public static void CreateDbAndSampleData(IServiceProvider applicationServices)
        {
            using (var serviceScope = applicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<AppContext>())
                {
                    if (context.Database.EnsureCreated())
                    {
                        Initialize(context);
                    }
                }
            }
        }

        private static void Initialize(AppContext context)
        {
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(
                    new List<Brand>
                    {
                        new Brand
                        {
                            Name = "Intel",
                            Logo = "intel.svg"
                        },
                        new Brand
                        {
                            Name = "AMD",
                            Logo = "amd.svg"
                        },
                        new Brand
                        {
                            Name = "ASRock",
                            Logo = "asrock.svg"
                        },
                        new Brand
                        {
                            Name = "GIGABYTE",
                            Logo = "gigabyte.svg"
                        },
                        new Brand
                        {
                            Name = "NVidia",
                            Logo = "nvidia.svg"
                        },
                        new Brand
                        {
                            Name = "Kingston",
                            Logo = "kingston.svg"
                        },
                        new Brand
                        {
                            Name = "ADATA",
                            Logo = "adata.svg"
                        },
                        new Brand
                        {
                            Name = "SeaGate",
                            Logo = "seagate.svg"
                        },
                        new Brand
                        {
                            Name = "CoolerMaster",
                            Logo = "coolermaster.svg"
                        },
                        new Brand
                        {
                            Name = "nzxt",
                            Logo = "nzxt.svg"
                        },
                        new Brand
                        {
                            Name = "COUGAR",
                            Logo = "cougar.svg"
                        }
                    });

                context.SaveChanges();
            }

            if (!context.CpuSockets.Any())
            {
                var intel = context.Brands.First(x => x.Name.Equals("Intel"));
                var amd = context.Brands.First(x => x.Name.Equals("AMD"));

                context.CpuSockets.AddRange(
                    new List<CpuSocket>
                    {
                        new CpuSocket
                        {
                            Name = "LGA-1151"
                        },
                        new CpuSocket
                        {
                            Name = "LGA-2066"
                        },
                        new CpuSocket
                        {
                            Name = "LGA-1200"
                        },
                        new CpuSocket
                        {
                            Name = "TR4"
                        },
                        new CpuSocket
                        {
                            Name = "sTRX4"
                        }
                    });

                context.SaveChanges();
            }

            if (!context.RamTypes.Any())
            {
                context.RamTypes.AddRange(
                    new List<RamType>
                    {
                        new RamType
                        {
                            Name = "DDR2",
                        },
                        new RamType
                        {
                            Name = "DDR3",
                        },
                        new RamType
                        {
                            Name = "DDR4"
                        }
                    });

                context.SaveChanges();
            }

            if (!context.VideoCardInterfaces.Any())
            {
                context.VideoCardInterfaces.AddRange(
                    new List<Interface>
                    {
                        new Interface
                        {
                            Name = "PCI-Express",
                        },
                        new Interface
                        {
                            Name = "PCI-Express-16",
                        },
                        new Interface
                        {
                            Name = "PCI-Express-32"
                        }
                    });

                context.SaveChanges();
            }

            if (!context.Processors.Any())
            {
                var intel = context.Brands.First(x => x.Name.Equals("Intel"));
                var amd = context.Brands.First(x => x.Name.Equals("AMD"));

                context.Processors.AddRange(
                    new List<Processor>
                    {
                            new Processor
                            {
                                Brand = intel,
                                Model = "i3-3006",
                                CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-1151")),
                                Cache = 6,
                                Frequency = 2900,
                                TurboBoostFrequency = 3200,
                                PhysicalCores = 2,
                                LogicalCores = 4,
                                IntegratedGraphics = true,
                                RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                                Price = GetRandomDecimal(100, 800),
                                WarrantyPeriod = 24
                            },
                            new Processor
                            {
                                Brand = intel,
                                Model = "i5-3006",
                                CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-1151")),
                                Cache = 8,
                                Frequency = 3200,
                                TurboBoostFrequency = 3500,
                                PhysicalCores = 3,
                                LogicalCores = 6,
                                IntegratedGraphics = true,
                                RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                                Price = GetRandomDecimal(100, 800),
                                WarrantyPeriod = 24
                            },
                            new Processor
                            {
                                Brand = intel,
                                Model = "i7-7740X",
                                CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-2066")),
                                Cache = 8,
                                Frequency = 4000,
                                TurboBoostFrequency = 4300,
                                PhysicalCores = 4,
                                LogicalCores = 8,
                                IntegratedGraphics = true,
                                RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                                Price = GetRandomDecimal(100, 800),
                                WarrantyPeriod = 24
                            },
                            new Processor
                            {
                                Brand = amd,
                                Model = "Threadripper 2990",
                                CpuSocket = context.CpuSockets.First(x => x.Name.Equals("TR4")),
                                Cache = 4,
                                Frequency = 3000,
                                TurboBoostFrequency = 3300,
                                PhysicalCores = 2,
                                LogicalCores = 4,
                                IntegratedGraphics = true,
                                RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                                Price = GetRandomDecimal(100, 800),
                                WarrantyPeriod = 24
                            },
                            new Processor
                            {
                                Brand = amd,
                                Model = "Threadripper 3990",
                                CpuSocket = context.CpuSockets.First(x => x.Name.Equals("sTRX4")),
                                Cache = 6,
                                Frequency = 3900,
                                TurboBoostFrequency = 4400,
                                PhysicalCores = 4,
                                LogicalCores = 8,
                                IntegratedGraphics = true,
                                RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                                Price = GetRandomDecimal(100, 800),
                                WarrantyPeriod = 24
                            }
                    });;

                context.SaveChanges();
            }

            if (!context.Formats.Any())
            {
                context.Formats.AddRange(
                    new List<Format>
                {
                    new Format
                    {
                        Name = "ATX"
                    },
                    new Format
                    {
                        Name = "Mini ITX"
                    },
                    new Format
                    {
                        Name = "Micro ATX"
                    }
                });

                context.SaveChanges();
            }

            if (!context.MotherBoards.Any())
            {
                var asRock = context.Brands.First(x => x.Name.Equals("ASRock"));
                var gigabyte = context.Brands.First(x => x.Name.Equals("GIGABYTE"));

                context.MotherBoards.AddRange(
                    new List<MotherBoard>
                    {
                        new MotherBoard
                        {
                            Brand = asRock,
                            Model = "Ax5055",
                            Chipset = "AMD B450",
                            CpuSocket = context.CpuSockets.First(x => x.Name.Equals("TR4")),
                            DualChannelSupport = true,
                            MaxRamCapacity = 32,
                            RamSlotsCount = 4,
                            RamType = context.RamTypes.First(x => x.Name.Equals("DDR3")),
                            Format = context.Formats.First(x => x.Name.Equals("ATX")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 36
                        },
                        new MotherBoard
                        {
                            Brand = asRock,
                            Model = "BC255",
                            Chipset = "AMD C250",
                            CpuSocket = context.CpuSockets.First(x => x.Name.Equals("sTRX4")),
                            DualChannelSupport = true,
                            MaxRamCapacity = 64,
                            RamSlotsCount = 4,
                            RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                            Format = context.Formats.First(x => x.Name.Equals("Mini ITX")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 36
                        },
                        new MotherBoard
                        {
                            Brand = gigabyte,
                            Model = "SX255",
                            Chipset = "Intel rs2",
                            CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-1151")),
                            DualChannelSupport = true,
                            MaxRamCapacity = 64,
                            RamSlotsCount = 4,
                            RamType = context.RamTypes.First(x => x.Name.Equals("DDR3")),
                            Format = context.Formats.First(x => x.Name.Equals("Mini ITX")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 32
                        },
                        new MotherBoard
                        {
                            Brand = gigabyte,
                            Model = "ZA543",
                            Chipset = "Intel 55423",
                            CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-1200")),
                            DualChannelSupport = true,
                            MaxRamCapacity = 32,
                            RamSlotsCount = 2,
                            RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                            Format = context.Formats.First(x => x.Name.Equals("Micro ATX")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24
                        },
                        new MotherBoard
                        {
                            Brand = gigabyte,
                            Model = "554432",
                            Chipset = "Intel AD54",
                            CpuSocket = context.CpuSockets.First(x => x.Name.Equals("LGA-2066")),
                            DualChannelSupport = true,
                            MaxRamCapacity = 64,
                            RamSlotsCount = 4,
                            RamType = context.RamTypes.First(x => x.Name.Equals("DDR4")),
                            Format = context.Formats.First(x => x.Name.Equals("ATX")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 36
                        }
                    });

                context.SaveChanges();
            }

            if (!context.Rams.Any())
            {
                var kingston = context.Brands.First(x => x.Name.Equals("Kingston"));
                var adata = context.Brands.First(x => x.Name.Equals("ADATA"));
                var ddr3 = context.RamTypes.First(x => x.Name.Equals("DDR3"));
                var ddr4 = context.RamTypes.First(x => x.Name.Equals("DDR4"));

                context.Rams.AddRange(
                    new List<Ram>{
                    new Ram
                    {
                        Brand = kingston,
                        Model = "55a",
                        Size = 16,
                        ModulesCount = 2,
                        SingleModuleSize = 8,
                        Type = ddr3,
                        Frequency = 1666,
                        Price = GetRandomDecimal(100, 800),
                        WarrantyPeriod = 24
                    },
                    new Ram
                    {
                        Brand = kingston,
                        Model = "55ab",
                        Size = 8,
                        ModulesCount = 1,
                        SingleModuleSize = 1,
                        Type = ddr3,
                        Frequency = 1888,
                        Price = GetRandomDecimal(100, 800),
                        WarrantyPeriod = 24
                    },
                    new Ram
                    {
                        Brand = adata,
                        Model = "rt5",
                        Size = 32,
                        ModulesCount = 4,
                        SingleModuleSize = 8,
                        Type = ddr4,
                        Frequency = 2400,
                        Price = GetRandomDecimal(100, 800),
                        WarrantyPeriod = 24
                    },
                    new Ram
                    {
                        Brand = adata,
                        Model = "rt66",
                        Size = 64,
                        ModulesCount = 2,
                        SingleModuleSize = 32,
                        Type = ddr4,
                        Price = GetRandomDecimal(100, 800),
                        Frequency = 3200,
                        WarrantyPeriod = 12
                    },
                    new Ram
                    {
                        Brand = kingston,
                        Model = "bbt35",
                        Size = 8,
                        ModulesCount = 1,
                        SingleModuleSize = 8,
                        Type = ddr4,
                        Frequency = 3200,
                        Price = GetRandomDecimal(100, 800),
                        WarrantyPeriod = 24
                    }
                    });

                context.SaveChanges();
            }

            if (!context.VideoRamTypes.Any())
            {
                context.VideoRamTypes.AddRange(
                    new List<VideoRamType>
                {
                    new VideoRamType
                    {
                        Name = "GDDR5"
                    },
                    new VideoRamType
                    {
                        Name = "GDDR5X"
                    },
                    new VideoRamType
                    {
                        Name = "GDDR6"
                    },
                    new VideoRamType
                    {
                        Name = "GDDR4"
                    },
                    new VideoRamType
                    {
                        Name = "GDDR3"
                    }
                });

                context.SaveChanges();
            }

            if (!context.VideoCards.Any())
            {
                var nVidia = context.Brands.First(x => x.Name.Equals("NVidia"));
                var amd = context.Brands.First(x => x.Name.Equals("AMD"));

                context.VideoCards.AddRange(
                    new List<VideoCard>
                    {
                        new VideoCard
                        {
                            Brand = nVidia,
                            BusWidth = 128,
                            Chipset = "Nvidia GeForce",
                            GraphicsProcessor = "GT 1030",
                            VideoRam = 4,
                            VideoRamType = context.VideoRamTypes.First(x => x.Name.Equals("GDDR5")),
                            Length = 280,
                            Interface = context.VideoCardInterfaces.First(x => x.Name.Equals("PCI-Express-16")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24,
                        },
                        new VideoCard
                        {
                            Brand = nVidia,
                            BusWidth = 258,
                            Chipset = "Nvidia GeForce",
                            GraphicsProcessor = "GT 2050",
                            VideoRam = 8,
                            VideoRamType = context.VideoRamTypes.First(x => x.Name.Equals("GDDR5x")),
                            Length = 320,
                            Interface = context.VideoCardInterfaces.First(x => x.Name.Equals("PCI-Express-16")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24
                        },
                        new VideoCard
                        {
                            Brand = nVidia,
                            BusWidth = 512,
                            Chipset = "Nvidia GeForce",
                            GraphicsProcessor = "GT 3090",
                            VideoRam = 64,
                            VideoRamType = context.VideoRamTypes.First(x => x.Name.Equals("GDDR6")),
                            Length = 340,
                            Interface = context.VideoCardInterfaces.First(x => x.Name.Equals("PCI-Express-32")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24
                        },
                        new VideoCard
                        {
                            Brand = amd,
                            BusWidth = 256,
                            Chipset = "AMD Radeon",
                            GraphicsProcessor = "RX 6900 XT",
                            VideoRam = 16,
                            VideoRamType = context.VideoRamTypes.First(x => x.Name.Equals("GDDR6")),
                            Length = 300,
                            Interface = context.VideoCardInterfaces.First(x => x.Name.Equals("PCI-Express")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24
                        },
                        new VideoCard
                        {
                            Brand = amd,
                            BusWidth = 128,
                            Chipset = "AMD Radeon",
                            GraphicsProcessor = "Radeon RX 550",
                            VideoRam = 4,
                            VideoRamType = context.VideoRamTypes.First(x => x.Name.Equals("GDDR5")),
                            Length = 250,
                            Interface = context.VideoCardInterfaces.First(x => x.Name.Equals("PCI-Express")),
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 24
                        }
                    });

                context.SaveChanges();
            }

            if (!context.Certificates.Any())
            {
                context.Certificates.AddRange(
                    new List<Certificate>
                    {
                        new Certificate
                        {
                            Name = "80+ gold"
                        },
                        new Certificate
                        {
                            Name = "80+ silver"
                        },
                        new Certificate
                        {
                            Name = "80+ bronze"
                        }
                    });

                context.SaveChanges();

            }

            if (!context.PowerSuplies.Any())
            {
                var cm = context.Brands.First(x => x.Name.Equals("CoolerMaster"));
                var nzxt = context.Brands.First(x => x.Name.Equals("nzxt"));

                context.PowerSuplies.AddRange(
                    new List<PowerSuply>
                    {
                        new PowerSuply
                        {
                            Brand = cm,
                            Model = "a1",
                            Certificate = context.Certificates.First(x => x.Name.Equals("80+ gold")),
                            Price = GetRandomDecimal(100, 800),
                            Output = 700,
                            WarrantyPeriod = 24
                        },
                        new PowerSuply
                        {
                            Brand = cm,
                            Model = "a2",
                            Certificate = context.Certificates.First(x => x.Name.Equals("80+ silver")),
                            Price = GetRandomDecimal(100, 800),
                            Output = 600,
                            WarrantyPeriod = 24
                        },
                        new PowerSuply
                        {
                            Brand = cm,
                            Model = "a3",
                            Certificate = context.Certificates.First(x => x.Name.Equals("80+ bronze")),
                            Price = GetRandomDecimal(100, 800),
                            Output = 500,
                            WarrantyPeriod = 24
                        },
                        new PowerSuply
                        {
                            Brand = nzxt,
                            Model = "kraken 3",
                            Certificate = context.Certificates.First(x => x.Name.Equals("80+ gold")),
                            Price = GetRandomDecimal(100, 800),
                            Output = 700,
                            WarrantyPeriod = 24
                        },
                        new PowerSuply
                        {
                            Brand = nzxt,
                            Model = "kraken",
                            Certificate = context.Certificates.First(x => x.Name.Equals("80+ bronze")),
                            Price = GetRandomDecimal(100, 800),
                            Output = 500,
                            WarrantyPeriod = 24
                        }
                    });

                context.SaveChanges();
            }

            if (!context.PcCases.Any())
            {
                var cm = context.Brands.First(x => x.Name.Equals("CoolerMaster"));
                var cougar = context.Brands.First(x => x.Name.Equals("COUGAR"));
                var atx = context.Formats.First(x => x.Name.Equals("ATX"));
                var mini = context.Formats.First(x => x.Name.Equals("Mini ITX"));
                var micro = context.Formats.First(x => x.Name.Equals("Micro ATX"));

                context.PcCases.AddRange(
                    new List<PcCase>
                    {
                        new PcCase
                        {
                            Brand = cm,
                            Model = "tower 11",
                            MaxCoolerSize = 155,
                            MaxVideoCardSize = 300,
                            Weight = 4,
                            SidePanel = "glass",
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 12
                        },
                        new PcCase
                        {
                            Brand = cm,
                            Model = "tower 110",
                            MaxCoolerSize = 155,
                            MaxVideoCardSize = 330,
                            Weight = 4.5,
                            SidePanel = "glass",
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 12
                        },
                        new PcCase
                        {
                            Brand = cougar,
                            Model = "cm z210",
                            MaxCoolerSize = 186,
                            MaxVideoCardSize = 350,
                            Weight = 5,
                            SidePanel = "glass",
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 12
                        },
                        new PcCase
                        {
                            Brand = cougar,
                            Model = "cm 5210",
                            MaxCoolerSize = 200,
                            MaxVideoCardSize = 400,
                            Weight = 6,
                            SidePanel = "metal",
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 12
                        },
                        new PcCase
                        {
                            Brand = cougar,
                            Model = "ct 560",
                            MaxCoolerSize = 130,
                            MaxVideoCardSize = 280,
                            Weight = 2,
                            SidePanel = "metal",
                            Price = GetRandomDecimal(100, 800),
                            WarrantyPeriod = 12
                        }
                    });

                context.SaveChanges();

                var cases = context.PcCases.ToList();

                foreach (var item in cases)
                {
                    if (cases.IndexOf(item) == 3)
                    {
                        item.Formats =
                       new List<PcCaseFormat>
                       {
                            new PcCaseFormat
                            {
                                PcCase = item,
                                PcCaseId = item.Id.Value,
                                Format = micro
                            },
                            new PcCaseFormat
                            {
                                PcCase = item,
                                PcCaseId = item.Id.Value,
                                Format = mini
                            }
                       };
                    }
                    else if (cases.IndexOf(item) == 4)
                    {
                        item.Formats =
                           new List<PcCaseFormat>
                           {
                                new PcCaseFormat
                                {
                                    PcCase = item,
                                    PcCaseId = item.Id.Value,
                                    Format = micro
                                }
                           };
                    }
                    else
                    {
                        item.Formats =
                           new List<PcCaseFormat>
                           {
                                new PcCaseFormat
                                {
                                    PcCase = item,
                                    PcCaseId = item.Id.Value,
                                    Format = atx
                                },
                                new PcCaseFormat
                                {
                                    PcCase = item,
                                    PcCaseId = item.Id.Value,
                                    Format = mini
                                }
                           };
                    }
                }

                context.SaveChanges();
            }

            if (!context.StorageDriveTypes.Any())
            {
                context.StorageDriveTypes.AddRange(
                    new List<StorageDriveType>
                    {
                        new StorageDriveType
                        {
                            Name = "HDD"
                        },
                        new StorageDriveType
                        {
                            Name = "SSD"
                        },
                        new StorageDriveType
                        {
                            Name = "M.2"
                        }
                    });

                context.SaveChanges();
            }

            if (!context.StorageDrives.Any())
            {
                var kingston = context.Brands.First(x => x.Name.Equals("Kingston"));
                var sg = context.Brands.First(x => x.Name.Equals("SeaGate"));

                context.StorageDrives.AddRange(
                    new List<StorageDrive>
                    {
                        new StorageDrive
                        {
                            Brand = kingston,
                            Model = "abc 55",
                            Capacity = 1024,
                            Type = context.StorageDriveTypes.First(x => x.Name.Equals("HDD")),
                            ReadSpeed = 50,
                            WriteSpeed = 80,
                            Price = GetRandomDecimal(100, 800)
                        },
                        new StorageDrive
                        {
                            Brand = sg,
                            Model = "sg br5",
                            Capacity = 512,
                            Price = GetRandomDecimal(100, 800),
                            Type = context.StorageDriveTypes.First(x => x.Name.Equals("SSD")),
                            ReadSpeed = 250,
                            WriteSpeed = 380
                        },
                        new StorageDrive
                        {
                            Brand = kingston,
                            Model = "rtt 55",
                            Capacity = 256,
                            Price = GetRandomDecimal(100, 800),
                            Type = context.StorageDriveTypes.First(x => x.Name.Equals("SSD")),
                            ReadSpeed = 250,
                            WriteSpeed = 287
                        },
                        new StorageDrive
                        {
                            Brand = sg,
                            Model = "gb55",
                            Capacity = 2048,
                            Price = GetRandomDecimal(100, 800),
                            Type = context.StorageDriveTypes.First(x => x.Name.Equals("M.2")),
                            ReadSpeed = 800,
                            WriteSpeed = 970
                        },
                        new StorageDrive
                        {
                            Brand = sg,
                            Model = "trt 55",
                            Capacity = 1024,
                            Price = GetRandomDecimal(100, 800),
                            Type = context.StorageDriveTypes.First(x => x.Name.Equals("HDD")),
                            ReadSpeed = 120,
                            WriteSpeed = 140
                        }
                    });

                context.SaveChanges();
            }
        }

        private static decimal GetRandomDecimal(int min, int max)
        {
            var random = new Random();
            var next = random.NextDouble();

            return Convert.ToDecimal(min + (next * (max - min)));
        }
    }
}