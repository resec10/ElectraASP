SET IDENTITY_INSERT Computers ON;
INSERT INTO Computers (ID, Title, Subtitle, ImageLink) VALUES
(1, 'Magnificent Intel Gaming/Streaming Build', 'Intel Core i7-14700K'+ CHAR(13) + CHAR(10)+'Parametric Video Card (Chipset: GeForce RTX 4070 Ti SUPER; Length: 224 mm - 403 mm; Cooling: 2 Fans, 3 Fans, 120 mm Radiator, ...)', 'img/index/card-img/image 8.png'),
(2, 'Entry Level Intel Gaming Build', 'Intel Core i3-13100F'+CHAR(13)+CHAR(10)+'Parametric Video Card (Chipset: Radeon RX 6600). Montech X3 Mesh ATX Mid Tower', 'img/index/card-img/image 37.png'),
(3, 'Excellent AMD Gaming/Streaming Build', 'AMD Ryzen 5 7600X'+CHAR(13)+CHAR(10)+'Parametric Video Card (Chipset: GeForce RTX 4070 SUPER; Cooling: 2 Fans, 3 Fans). Fractal Design Pop Mini Air Micro ATX Mid Tower', 'img/index/card-img/image 9.png'),
(4, 'Glorious Intel Gaming/Streaming Build', 'Intel Core i9-14900K'+CHAR(13)+CHAR(10)+'Parametric Video Card (Chipset: GeForce RTX 4090; Length: 224 mm - 403 mm; Cooling: 2 Fans, 3 Fans, 120 mm Radiator, ...) Corsair iCUE 5000D RGB AIRFLOW ATX Mid Tower', 'img/completedBuilds/image 43.png'),
(5, 'Magnificent AMD Gaming/Streaming Build', 'AMD Ryzen 7 7800X3D'+CHAR(13)+CHAR(10)+'Parametric Video Card (Chipset: GeForce RTX 4070 Ti SUPER; Length: 224 mm - 403 mm; Cooling: 2 Fans, 3 Fans, 120 mm Radiator, ...) NZXT H6 Flow RGB ATX Mid Tower', 'img/completedBuilds/image 44.png'),
(6, 'Enthusiast AMD Gaming/Streaming Build', 'AMD Ryzen 5 7600X'+CHAR(13)+CHAR(10)+'Parametric Video Card (Chipset: GeForce RTX 4070 Ti SUPER; Length: 224 mm - 403 mm; Cooling: 2 Fans, 3 Fans, 120 mm Radiator, ...) Fractal Design Pop Air RGB ATX Mid Tower', 'img/completedBuilds/image 45.png');

SET IDENTITY_INSERT Computers OFF;
SET IDENTITY_INSERT CPU_Table ON;
INSERT INTO CPU_Table (ID, CoreCount, PerformanceCoreBoost, PerformanceBoostClock, TDP, IntegratedGraphics, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 20, 5.5, 5.6, 125, 'Intel UHD', 'img/completedView/image 29.png', 'Intel Core i7-14700K 3.4GHz 20-Core', 389.99, 'We''re running an Intel Core i7-14700K, which reaches a turbo frequency of 5.6GHz. The 14700K has 8 Performance-cores with 16 threads, along with 12 Efficient-cores. It features an unlocked multiplier for easy overclocking. In addition to better performance now, overclocking can also help your CPU stave off obsolescence for a good while longer.', 107, 125, 1),
(2, 4, 4.5, 3.4, 110, 'Intel UHD','img/completedView/image 38.png', 'Intel Core i3-13100F 3.4 GHz Quad-Core', 119.99, 'Our CPU of choice is the Intel Core i3-13100F. This CPU is inexpensive but still packs a punch with its 4 cores/8 threads and 4.3 GHz turbo frequency. The Core i3-13100F includes a CPU cooler, so a 3rd-party cooler isn''t necessary. However, if you''d your PC to run cooler or quieter, you can pick up a compatible third-party cooler.', 107, 125, 2),
(3, 6, 4.7, 5.3, 105, 'Radeon', 'img/completedView/image 48.png', 'AMD Ryzen 5 7600X 4.7 GHz 6-Core', 208.99, 'Our Excellent AMD Gaming/Streaming Build is centered around the Ryzen 5 7600X. Since it is overclockable and does not come with a stock cooler we have added the AK400 ZERO DARK to the build. This is an excellent air cooler that will allow a modest overclock without overheating or becoming noisy.', 107, 125, 3),
(4, 24, 3.2, 5.6, 125, 'Intel UHD', 'img/completedView/image 58.png', 'Intel Core i9-14900K 3.2 GHz 24-Core', 539.99, 'The Intel Core i9-14900K is one of the fastest gaming CPUs available. It offers 8 Performance-cores, 16 Performance threads, 16 Efficient-cores, a base frequency of 3.2GHz, and a turbo frequency of 6GHz. The unlocked multiplier enables easy and significant overclocking.', 107, 125, 4),
(5, 8, 4.2, 5, 120, 'Radeon', 'img/completedView/image 60.png', 'AMD Ryzen 7 7800X3D 4.2 GHz 8-Core', 389.99, 'The Ryzen 7 7800X3D is an 8-core processor that utilizes AMD SMT technology for a total of 16 threads.', 107, 125, 5),
(6, 6, 4.7, 5.3, 105, 'Radeon', 'img/completedView/image 48.png', 'AMD Ryzen 5 7600X 4.7 GHz 6-Core', 208.99, 'Our Excellent AMD Gaming/Streaming Build is centered around the Ryzen 5 7600X. Since it is overclockable and does not come with a stock cooler we have added the AK400 ZERO DARK to the build. This is an excellent air cooler that will allow a modest overclock without overheating or becoming noisy.', 107, 125, 6);


SET IDENTITY_INSERT CPU_Table OFF;
SET IDENTITY_INSERT Cases ON;
INSERT INTO Cases (ID, Type, Color, PowerSupply, SidePanel, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 'ATX Mid Tower', 'Black', 'None', 'Tempered Glass', 'img/completedView/image 45.png', 'be quiet! Pure Base 500 FX ATX', 129.99, 'All of our components are housed in the be quiet! Pure Base 500 FX case. This case features a black design with a tempered glass side panel window. It includes one front panel USB 3 port, one USB Type-C port, RGB front panel, a PSU shroud, and a number of cable management holes and tie-offs to help your build look cleaner. It can also comfortably fit full-sized video cards and large CPU coolers.', 87, 114, 1),
(2, 'ATX Mid Tower', 'Black', 'Rear Mount', 'Tempered Glass', 'img/completedView/image 35.png', 'Montech X3 Mesh ATX', 59.99, 'The Montech X3 Mesh comes with a whopping six pre-installed LED fans. It''s an ATX mid tower case with 1x USB 3.2 Gen 1 port and 2x USB 2.0 ports on the front of the case, and it features a tempered glass side panel window. It provides several cable management holes and a couple patterned magnetic dust filters for easy removal and cleaning.', 87, 114, 2),
(3, 'Micro ATX Mid Tower', 'Black', 'Bottom Mount', 'Tempered Glass, Alloy Steel', 'img/completedView/image 55.png', 'Fractal Design Pop Mini Air MicroATX', 89.99, 'All of our components are housed in the Fractal Design Pop Mini Air case. This case comes with two USB3 ports, an optional USB-C port (requires a separate purchase), a large tempered glass side panel and fits full-size graphics cards without issue. It provides several cable management holes as well as a mesh front panel for better airflow', 87, 114, 3),
(4, 'ATX Mid Tower', 'Black', 'Rear Mount', 'Alloy Steel', 'img/completedView/image 59.png', 'Corsair iCUE 5000D RGB AIRFLOW ATX', 184.99, 'The Corsair 5000D AIRFLOW features great airflow, a tempered glass window. Inside the case are a PSU shroud, cable management holes, and tie-offs, which will make the PC easier to keep looking clean. The front panel features 2x USB 3.2 Type-A and 1x USB 3.2 Type-C ports.', 87, 114, 4),
(5, 'ATX Mid Tower', 'Black', 'None', 'Tempered Glass', 'img/completedView/image 45.png', 'be quiet! Pure Base 500 FX ATX', 129.99, 'All of our components are housed in the be quiet! Pure Base 500 FX case. This case features a black design with a tempered glass side panel window. It includes one front panel USB 3 port, one USB Type-C port, RGB front panel, a PSU shroud, and a number of cable management holes and tie-offs to help your build look cleaner. It can also comfortably fit full-sized video cards and large CPU coolers.', 87, 114, 5),
(6, 'Micro ATX Mid Tower', 'Black', 'Bottom Mount', 'Tempered Glass, Alloy Steel', 'img/completedView/image 55.png', 'Fractal Design Pop Mini Air MicroATX', 89.99, 'All of our components are housed in the Fractal Design Pop Mini Air case. This case comes with two USB3 ports, an optional USB-C port (requires a separate purchase), a large tempered glass side panel and fits full-size graphics cards without issue. It provides several cable management holes as well as a mesh front panel for better airflow', 87, 114, 6);

SET IDENTITY_INSERT Cases OFF;
SET IDENTITY_INSERT Coolers ON;
INSERT INTO Coolers (ID, FanRPM, NoiseLevel, Color, RadiatorSize, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, '500-1850', 28, 'Black', 160, 'img/completedView/image 30.png', 'Deepcool AK620 ZERO DARK 68.99 CFM', 59.99, 'For better CPU cooling performance, we are using the Deepcool AK620 ZERO DARK.', 103, 103, 1),
(3, '500-1850', 28, 'Black', 160, 'img/completedView/image 30.png', 'Deepcool AK620 ZERO DARK 68.99 CFM', 59.99, 'For better CPU cooling performance, we are using the Deepcool AK620 ZERO DARK.', 103, 103, 3),
(4, '200-1800', 10, 'Black', 120, 'img/completedView/image 65.png', 'ARCTIC Liquid Freezer II 360 A-RGB 48.8 CFM Liquid', 149.99, 'We recommend liquid cooling to take better advantage of the Core i9-14900K''s performance potential. In this guide we are using the ARCTIC Liquid Freezer II 360 A-RGB.', 161, 48, 4),
(5, '500-1850', 28, 'Black', 160, 'img/completedView/image 30.png', 'Deepcool AK620 ZERO DARK 68.99 CFM', 59.99, 'For better CPU cooling performance, we are using the Deepcool AK620 ZERO DARK.', 103, 103, 5),
(6, '500-1850', 29, 'Black', 120, 'img/completedView/ak400.png', 'Deepcool AK400 ZERO DARK 66.47 CFM', 39.99, 'AK400 ZERO DARK is an excellent air cooler that will allow a modest overclock without overheating or becoming noisy.', 103, 103, 6);

SET IDENTITY_INSERT Coolers OFF;
SET IDENTITY_INSERT Powers ON;
INSERT INTO Powers (ID, Type, EfficiencyRating, Wattage, Modular, Color, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 'ATX', '80+ Platinum', 1000, 1, 'Black', 'img/completedView/image 46.png', 'Super Flower Leadex SE 1000 W 80+ Platinum Certified', 139.99, 'We''re using a parametric selection of well-reviewed units, all of which are 80+ Bronze certified or above and can provide plenty of power for this build. Note that because there are issues with PSU availability right now, some non-modular PSUs have been added to the build to help you get the parts you need. These are still high quality PSUs.', 136, 125, 1),
(2, 'ATX', '80+ Gold', 600, 0, 'Black', 'img/completedView/image 36.png', 'Apevia Prestige 600 W 80+ Gold Certified ATX', 51.99, 'Powering the build is a sparse selection of some of the most well-reviewed PSUs available - all without breaking the bank. All of them are certified 80+ Gold and fully-or semi-modular.', 136, 125, 2), 
(3, 'ATX', '80+ Platinum', 1000, 1, 'Black', 'img/completedView/image 46.png', 'Super Flower Leadex SE 1000 W 80+ Platinum Certified', 139.99, 'We''re using a parametric selection of well-reviewed units, all of which are 80+ Bronze certified or above and can provide plenty of power for this build. Note that because there are issues with PSU availability right now, some non-modular PSUs have been added to the build to help you get the parts you need. These are still high quality PSUs.', 136, 125, 3),
(4, 'ATX', '80+ Platinum', 1000, 1, 'Black', 'img/completedView/image 46.png', 'Super Flower Leadex SE 1000 W 80+ Platinum Certified', 139.99, 'We''re using a parametric selection of well-reviewed units, all of which are 80+ Bronze certified or above and can provide plenty of power for this build. Note that because there are issues with PSU availability right now, some non-modular PSUs have been added to the build to help you get the parts you need. These are still high quality PSUs.', 136, 125, 4),
(5, 'ATX', '80+ Platinum', 1000, 1, 'Black', 'img/completedView/image 46.png', 'Super Flower Leadex SE 1000 W 80+ Platinum Certified', 139.99, 'We''re using a parametric selection of well-reviewed units, all of which are 80+ Bronze certified or above and can provide plenty of power for this build. Note that because there are issues with PSU availability right now, some non-modular PSUs have been added to the build to help you get the parts you need. These are still high quality PSUs.', 136, 125, 5),
(6, 'ATX', '80+ Gold', 850, 1, 'Black', 'img/completedView/psu.png', 'Cooler Master MWE Gold 850 - V2 850 W 80+ Gold Certified Fully Modular ATX', 94.99, 'For our power supply, we''re using a parametric selection of well-reviewed fully modular units, all of which are 80+ Gold certified or above and can provide plenty of power for this build.', 130, 75, 6);

SET IDENTITY_INSERT Powers OFF;
SET IDENTITY_INSERT Motherboards ON;
INSERT INTO Motherboards (ID, Socket, FormFactor, MaxMemory, MemorySlots, Color, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 'LGA 1700', 'ATX', 64, 4, 'Black', 'img/completedView/image 31.png', 'MSI PRO Z790-S WIFI ATX LGA1700', 159.99, 'We''re using a parametric filter of Z790 motherboards to actively select the best-priced motherboard available.', 156, 81, 1),
(2, 'LGA 1700', 'Micro ATX', 128, 4, 'Black',  'img/completedView/image 39.png', 'MSI PRO B760M-P DDR4 Micro ATX LGA1700', 99.99, 'We''re using a parametric filter to constantly select the best-priced ATX or mATX motherboard while meeting selected criteria. In this case, we are filtering for B760 chipsets and 4 DDR4 DIMM slots for future expansion. The compatibility engine will filter out anything not compatible with the build. The motherboards are also capable of using the CPU''s integrated GPU.', 156, 81, 2),
(3, 'AM5', 'Micro ATX ', 96, 2, 'White', 'img/completedView/image 49.png', 'ASRock B650M-H/M.2+ Micro ATX AM5', 99.99, 'We''re using a parametric filter for B650 mATX motherboards with at least one USB3.2 Gen2 header for front panel USB-C ports. Our compatibility and pricing engines will automatically select the best-priced motherboard that is compatible with the rest of the build and there should not be any issues with BIOS compatibility or required updates to support the CPU.', 156, 81, 3),
(4, 'LGA 1700', 'ATX', 64, 4, 'Black', 'img/completedView/image 31.png', 'MSI PRO Z790-S WIFI ATX LGA1700', 159.99, 'We''re using a parametric filter of Z790 motherboards to actively select the best-priced motherboard available.', 156, 81, 4),
(5, 'LGA 1700', 'ATX', 64, 4, 'Black', 'img/completedView/image 31.png', 'MSI PRO Z790-S WIFI ATX LGA1700', 159.99, 'We''re using a parametric filter of Z790 motherboards to actively select the best-priced motherboard available.', 156, 81, 5),
(6, 'AM5', 'ATX', 256, 4, 'Grey/Black', 'img/completedView/motherboard.png', 'Gigabyte B650 EAGLE AX ATX AM5', 139.99, 'We''re using a parametric filter for B650 ATX motherboards with at least one USB3.2 Gen2 header for front panel USB-C port. Our compatibility and pricing engines will automatically select the best-priced motherboard that is compatible with the rest of the build and there should not be any issues with BIOS compatibility or required updates to support the CPU.', 156, 86, 6);

SET IDENTITY_INSERT Motherboards OFF;
SET IDENTITY_INSERT RAM_Table ON;
INSERT INTO RAM_Table (ID, Speed, Modules, Color, FirstWordLatency, CASLatency, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 'DDR5-6000', '2 x 16GB', 'White', 10, 30, 'img/completedView/image 32.png', 'Silicon Power XPOWER Zenith Gaming 32 GB DDR5-6000', 94.99, 'For memory, we''re filtering for the best-priced 2x16GB kit of DDR5 RAM with a heatsink. We''ve limited it to DDR5-6000 and faster speeds and CAS latency of 30 or lower.', 156, 81, 1),
(2, 'DDR4-3200', '2 x 8GB', 'Black', 10, 16, 'img/completedView/image 41.png', 'Silicon Power GAMING 16 GB DDR4-3200 CL16', 32.99, 'For this build and most machines outside of the top end we opted to go with 16GB of DDR4 memory with CAS latency no higher than 18 clock cycles. The parametric filter finds the best price on 2x8GB kits of memory that are within Intel''s recommended specifications.', 156, 81, 2),
(3, 'DDR5-6000', '2 x 16GB', 'White', 10, 30, 'img/completedView/image 32.png', 'Silicon Power XPOWER Zenith Gaming 32 GB DDR5-6000', 94.99, 'For memory, we''re filtering for the best-priced 2x16GB kit of DDR5 RAM with a heatsink. We''ve limited it to DDR5-6000 and faster speeds and CAS latency of 30 or lower.', 156, 81, 3),
(4, 'DDR5-6000', '2 x 16GB', 'White', 10, 30, 'img/completedView/image 32.png', 'Silicon Power XPOWER Zenith Gaming 32 GB DDR5-6000', 94.99, 'For memory, we''re filtering for the best-priced 2x16GB kit of DDR5 RAM with a heatsink. We''ve limited it to DDR5-6000 and faster speeds and CAS latency of 30 or lower.', 156, 81, 4),
(5, 'DDR5-6000', '2 x 16GB', 'White', 10, 30, 'img/completedView/image 32.png', 'Silicon Power XPOWER Zenith Gaming 32 GB DDR5-6000', 94.99, 'For memory, we''re filtering for the best-priced 2x16GB kit of DDR5 RAM with a heatsink. We''ve limited it to DDR5-6000 and faster speeds and CAS latency of 30 or lower.', 156, 81, 5),
(6, 'DDR5-6000', '2 x 16GB', 'Black', 10, 30,  'img/completedView/ram.png', 'Silicon Power Value Gaming 32 GB (2 x 16 GB) DDR5-6000 CL30', 94.99, 'We are filtering for a 2x16GB kit of DDR5 RAM with a speed of at least DDR5-6000 and maximum Cas latency of 40 to target the sweet spot for the 7000 series CPUs.', 156, 81, 6);

SET IDENTITY_INSERT RAM_Table OFF;
SET IDENTITY_INSERT SSD_Table ON;
INSERT INTO SSD_Table (ID, Capacity, Type, Cache, FormFactor, Interface, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 1, 'SSD', 0, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/completedView/image 23.png', 'Western Digital Black SN850X 1 TB M.2-2280 PCIe 4.0 X4 NVME', 84.99, 'We are using a parametric selection of well-reviewed 1TB NVME M.2 SSDs. Everyone''s storage needs differ, so you may wish to select similar SSDs with different capacities or even adding in a mechanical HDD for larger storage needs.', 129, 36, 1),
(2, 1, 'SSD', 1024, 'M.2-2280', 'M.2 PCIe 3.0 X4', 'img/completedView/image 33.png', 'Leven JPS600 1 TB M.2-2280 PCIe 3.0 X4 NVME', 58.99, 'We''re also using a parametric filter to select the best priced NVME SSD available that is at least 480GB. Everyone''s storage needs are different, so feel free to change drive capacity or add a drive to fit yours.', 129, 36, 2),
(3, 2, 'SSD', 2048, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/completedView/image 43.png', 'Silicon Power UD85 2 TB M.2-2280 PCIe 4.0 X4 NVME', 102.99, 'We''re using parametric filters to incorporate a PCIe Gen 4.0 x4 NVME M.2 SSD with at least 2TB of space. Everyone''s storage needs differ so feel free to add or remove capacity as needed', 129, 50, 3),
(4, 1, 'SSD', 0, 'M.2-2280', 'M.2 PCIE 4.0 X4', 'img/completedView/image 23.png', 'Western Digital Black SN850X 1 TB M.2-2280 PCIe 4.0 X4 NVME', 84.99, 'We are using a parametric selection of well-reviewed 1TB NVME M.2 SSDs. Everyone''s storage needs differ, so you may wish to select similar SSDs with different capacities or even adding in a mechanical HDD for larger storage needs.', 129, 36, 4),
(5, 1, 'SSD', 0, 'M.2-2280', 'M.2 PCIE 4.0 X4', 'img/completedView/image 23.png', 'Western Digital Black SN850X 1 TB M.2-2280 PCIe 4.0 X4 NVME', 84.99, 'We are using a parametric selection of well-reviewed 1TB NVME M.2 SSDs. Everyone''s storage needs differ, so you may wish to select similar SSDs with different capacities or even adding in a mechanical HDD for larger storage needs.', 129, 36, 5),
(6, 2, 'SSD', 2048, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/completedView/image 43.png', 'Silicon Power UD85 2 TB M.2-2280 PCIe 4.0 X4 NVME', 102.99, 'We''re using parametric filters to incorporate a PCIe Gen 4.0 x4 NVME M.2 SSD with at least 2TB of space. Everyone''s storage needs differ so feel free to add or remove capacity as needed', 129, 50, 6);

SET IDENTITY_INSERT SSD_Table OFF;
SET IDENTITY_INSERT VideoCards ON;
INSERT INTO VideoCards (ID, Chipset, Memory, CoreClock, BoostClock, Color, ImageLink, Name, Price, Description, ImageWidth, ImageHeight, ComputerID) VALUES
(1, 'NVIDIA GeForce RTX 4070 Ti', 16, 2340, 2650, 'Black', 'img/completedView/image 34.png', 'R8 Gaming VERTO OC GeForce RTX 4070 Ti 16 GB', 799.99, 'Our GPU is NVIDIA''s GeForce RTX 4070 Ti SUPER. Consider pairing it with a high refresh rate and/or high resolution monitor to take full advantage of the card''s capabilities. The parametric filter is set for the best-priced RTX 4070 Ti SUPER available, but feel free to click the "From parametric filter" link to browse our listing of all RTX 4070 Ti SUPERs. For those interested in VR, the RTX 4070 Ti SUPER will have no problem playing any and and all applications currently on the market. To keep the noise and temperatures down, we''ve the filter to includes a minimum length and a minimum of 2 fans to avoid "mini" versions of the card, which prioritize fitting into small builds, such as an ITX case.', 150, 106, 1),
(2, 'Radeon RX 6600', 8, 2044, 2491, 'Gray/Blue', 'img/completedView/image 40.png', 'Gigabyte EAGLE Radeon RX 6600 8 GB', 189.99, 'We have set a parametric filter for the best-priced Radeon RX 6600, which will let you play any popular game available today, including Valorant, Fortnite, PUBG, Apex Legends, and Minecraft.', 150, 106, 2),
(3, 'NVIDIA GeForce RTX 4070 SUPER', 12, 2490, 2490, 'Black', 'img/completedView/image 50.png', 'Zotac Twin Edge GeForce RTX 4070 SUPER 12 GB', 589.99, 'For our GPU, the newly released NVIDIA GeForce RTX 4070 SUPER is one of the better price for performance cards on the market. The RTX 4070 SUPER will provide a consistent 60 FPS on many demanding games like PUBG at Ultra at 1080p, and even 1440p for some games like Apex Legends. It''ll also handle Fortnite with zero issues. For those interested in VR, this card will have no problem playing any and all applications currently on the market.', 150, 106, 3),
(4, 'NVIDIA GeForce RTX 4090', 24, 2565, 2595, 'Black', 'img/completedView/image 56.png', 'Asus TUF GAMING GeForce RTX 4090 24 GB', 1599.99, 'The GeForce RTX 4090 by NVIDIA is one of the fastest GPUs in existence. You should definitely pair it with a high refresh rate and/or high resolution monitor to take full advantage of the card''s capabilities. For those interested in VR, the RTX 4090 will have no problem playing any and and all applications currently on the market. NVIDIA''s NVENC encoding feature will offload the task of streaming to the GPU with a minimal performance hit when using OBS (Open Broadcaster Software), while still providing image quality on par with (or better than) “x264 Fast” quality. To keep noise and temperature down, the parametric filter is set for an RTX 4090 with at least two fans to avoid blower style and “mini” cards.', 150, 106, 4),
(5, 'NVIDIA GeForce RTX 4070 Ti SUPER', 16, 2340, 2655, 'Black/Purple', 'img/completedView/image 66.png', 'PNY XLR8 Gaming VERTO EPIC-X RGB OC GeForce RTX 4070 Ti SUPER 16 GB', 799.99, 'Our GPU is NVIDIA''s GeForce RTX 4070 Ti SUPER. Consider pairing it with a high refresh rate and/or high resolution monitor to take full advantage of the card''s capabilities. The parametric filter is set for the best-priced RTX 4070 Ti SUPER available, but feel free to click the "From parametric filter" link to browse our listing of all RTX 4070 Ti SUPERs. For those interested in VR, the RTX 4070 Ti SUPER will have no problem playing any and and all applications currently on the market. To keep the noise and temperatures down, we''ve the filter to includes a minimum length and a minimum of 2 fans to avoid "mini" versions of the card, which prioritize fitting into small builds, such as an ITX case.', 150, 106, 5),
(6, 'NVIDIA GeForce RTX 4070 Ti SUPER', 16, 2610, 2610, 'Black', 'img/completedView/rtx4070.png', 'MSI GeForce RTX 4070 Ti SUPER 16G AERO', 589.99, 'Our GPU is the NVIDIA GeForce RTX 4070 Ti SUPER. Consider pairing it with a high refresh rate and/or high resolution monitor to take full advantage of the card''s capabilities. For those interested in VR, the RTX 4070 Ti SUPER will have no problem playing any and and all applications currently on the market.', 150, 106, 6);


SET IDENTITY_INSERT VideoCards OFF;
SET IDENTITY_INSERT CPU_Table ON;
INSERT INTO CPU_Table(ID, CoreCount, PerformanceCoreBoost, PerformanceBoostClock, TDP, IntegratedGraphics, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 8, 4.2, 5, 120, 'Radeon', 'img/buildPC/AMD-Ryzen-7-7800X3D-(3) 1.png', 'AMD Ryzen 7 7800X', 369, 163, 149),
(8, 24, 3.2, 6, 125, 'Intel UHD', 'img/buildPC/intel_bx8071514900k_core_i9_14900k_24_core_lga_1781469 1.png', 'Intel Core i9-14900K', 539, 163, 149),
(9, 6, 4.7, 5.3, 105, 'Radeon', 'img/buildPC/xstore 1.png', 'AMD Ryzen 5 7500X', 205, 128, 149),
(10, 20, 3.4, 5.6, 125, 'Intel UHD', 'img/buildPC/617EhDDXYfL 1.png', 'Intel Core i7-14700K', 399.99, 123, 149),
(11, 16, 4.2, 5.7, 120, 'Radeon', 'img/buildPC/LD0006014130_0006016756 1.png', 'AMD Ryzen 9 7950X', 591.99, 123, 149);


SET IDENTITY_INSERT CPU_Table OFF;
SET IDENTITY_INSERT Cases ON;
INSERT INTO Cases (ID, Type, Color, PowerSupply, SidePanel, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 'ATX Mid Tower', 'Black', 'None', 'Tinted Tempered Glass', 'img/buildPC/image 19.png', 'Corsair 4000D Airflow', 104.99, 98, 149),
(8, 'ATX Mid Tower', 'Black', 'None', 'Tempered Glass', 'img/buildPC/image 20.png', 'NZXT H5 Flow', 94.99, 117, 149),
(9, 'ATX Mid Tower', 'White', 'None', 'Tempered Glass', 'img/buildPC/image 21.png', 'NZXT H9 Flow', 154.99, 127, 149),
(10, 'ATX Mid Tower', 'Black', 'None', 'Tempered Glass', 'img/buildPC/image 22.png', 'Montech AIR 903 MAX', 69.99, 95, 149),
(11, 'MicroATX Mini Tower', 'Gray', 'None', 'Acrylic', 'img/buildPC/image 23.png', 'Cooler Master MasterBox Q300L', 39.99, 134, 149);

SET IDENTITY_INSERT Cases OFF;
SET IDENTITY_INSERT Coolers ON;
INSERT INTO Coolers (ID, FanRPM, NoiseLevel, Color, RadiatorSize, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, '1550', 25.6, 'Black', 0, 'img/buildPC/71j6VKsz-fL 1.png', 'Thermalright Peerless Assassin 120 SE', 33.99, 133, 149),
(8, '650-1800', 27, 'Black', 240, 'img/buildPC/LD0005687233_1 1.png', 'Cooler Master MASTERLIQUID ML240L RGB V2', 99.99, 146, 149),
(9, '550-2100', 34.1, 'Black', 360, 'img/buildPC/7107JaxG7XL 1.png', 'Corsair iCUE H150i ELITE CAPELLIX XT', 179.99, 120, 120),
(10, '500-2000', 31.6, 'Black', 0, 'img/buildPC/AG400-BK-ARGB-(9) 1.png', 'Deepcool GAMMAXX AG400 ARGB', 299.99, 148, 146),
(11, '500-1800', 30.6, 'Black', 240, 'img/buildPC/nzxt_rl_kr240_b1_kraken_240_rgb_240mm_1765798 1.png', 'NZXT Kraken 240', 129.99, 146, 146),
(12, '800-2000', 26, 'Black', 0, 'img/buildPC/h212blacke_g1-zoom 1.png', 'Cooler Master Hyper 212 Black Edition', 29.99, 133, 133),
(13, '300-1500 RPM', 24.6, 'White/Brown', 0, 'img/buildPC/LD0001599799_2 1.png', 'Noctua NH-D15', 109.95, 149, 149);

SET IDENTITY_INSERT Coolers OFF;
SET IDENTITY_INSERT Motherboards ON;
INSERT INTO Motherboards (ID, Socket, FormFactor, MaxMemory, MemorySlots, Color, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 'AM5', 'ATX', 192, 4, 'Black', 'img/buildPC/modelblock-gaming-pd 1.png', 'MSI B650 GAMING PLUS WIFI', 159.99, 115, 145),
(8, 'AM5', 'ATX', 192, 4, 'Black/Silver', 'img/buildPC/1303 1.png', 'Asus ROG STRIX B650-A GAMING WIFI', 259.99, 115, 145),
(9, 'AM5', 'ATX', 192, 4, 'Black/Gray', 'img/buildPC/76557017-16ed-414e-91e1-6404386e44a0 1.png', 'Gigabyte B650 GAMING X AX', 189.99, 104, 145),
(10, 'AM5', 'Micro ATX', 192, 4, 'Blue/Gray', 'img/buildPC/76557017-16ed-414e-91e1-6404386e44a0 1 (1).png', 'Asus PRIME B550M-A WIFI II', 109.99, 104, 145),
(11, 'AM5', 'Micro ATX', 192, 4, 'Black/Gray', 'img/buildPC/71px5ZVL7KL 1.png', 'ASRock B650M Pro RS', 134.99, 119, 145);

SET IDENTITY_INSERT Motherboards OFF;
SET IDENTITY_INSERT RAM_Table ON;
INSERT INTO RAM_Table (ID, Speed, Modules, Color, FirstWordLatency, CASLatency, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 'DDR4-3200', '2 x 8GB', 'Black/Yellow', 10, 16, 'img/buildPC/51gLnYN1W7L 1.png', 'Corsair Vengeance LPX', 39.99, 133, 48),
(8, 'DDR5-6000', '2 x 16GB', 'Black/Yellow', 12, 36, 'img/buildPC/51c+p6RY+AL 1.png', 'G.Skill Trident Z5 RGB', 117.99, 133, 79),
(9, 'DDR5-6000', '2 x 16GB', 'White', 12, 36, 'img/buildPC/61fJwCBAX6L 1.png', 'Corsair Vengeance RGB', 127.99, 133, 66),
(10, 'DDR5-6000', '2 x 16GB', 'White', 10, 30, 'img/buildPC/TeamGroup-T-Force-Delta-RGB-32GB-16GBx2-DDR5-5200MHz-White-Memory-FF4D532G5200HC40CDC01 1.png', 'TEAMGROUP T-Force Delta RGB', 109.99, 145, 145),
(11, 'DDR4-3200', '2 x 8GB', 'Black', 10, 16, 'img/buildPC/71vXXYW44HL 1.png', 'Silicon Power GAMING', 32.99, 145, 145);

SET IDENTITY_INSERT RAM_Table OFF;
SET IDENTITY_INSERT SSD_Table ON;
INSERT INTO SSD_Table (ID, Capacity, Type, Cache, FormFactor, Interface, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 2, 'SSD', 2048, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/buildPC/image 10.png', 'Samsung 980 PRO', 166.92, 149, 41),
(8, 1, 'SSD', 1024, 'M.2-2280', 'M.2 PCIe 3.0 X4', 'img/buildPC/image 11.png', 'Samsung 970 Evo Plus', 94.99, 149, 41),
(9, 4, 'SSD', 4096, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/buildPC/image 12.png', 'Samsung 990 PRO', 318.99, 149, 41),
(10, 1, 'SSD', 4096, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/buildPC/image 13.png', 'Kingston NV2', 60.99, 149, 41),
(11, 1, 'SSD', 0, 'M.2-2280', 'M.2 PCIe 4.0 X4', 'img/buildPC/image 14.png', 'Crucial P3 Plus', 61.99, 149, 41);

SET IDENTITY_INSERT SSD_Table OFF;
SET IDENTITY_INSERT VideoCards ON;
INSERT INTO VideoCards (ID, Chipset, Memory, CoreClock, BoostClock, Color, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 'GeForce RTX 3060 12GB', 12, 1320, 1777, 'Black', 'img/buildPC/image 15.png', 'MSI GeForce RTX 3060 Ventus 2X 12G', 289.99, 153, 145),
(8, 'GeForce RTX 4070', 12, 1920, 2490, 'Black', 'img/buildPC/image 16.png', 'GIGABYTE Windforce OC', 549.99, 153, 145),
(9, 'GeForce RTX 4060', 8, 1830, 2535, 'Black', 'img/buildPC/image 17.png', 'Asus DUAL OC', 304.99, 153, 145),
(10, 'GeForce RTX 4090', 24, 2235, 2640, 'Black', 'img/buildPC/image 18.png', 'Asus ROG STRIX GAMING OC', 1999.99, 153, 145);

SET IDENTITY_INSERT VideoCards OFF;
SET IDENTITY_INSERT Powers ON;
INSERT INTO Powers (ID, Type, EfficiencyRating, Wattage, Modular, Color, ImageLink, Name, Price, ImageWidth, ImageHeight) VALUES
(7, 'ATX', '80+ Gold', 750, 1, 'Black', 'img/buildPC/image 24.png', 'Corsair RM750e', 99.99, 163, 137),
(8, 'ATX', '80+ Gold', 850, 0, 'White/Black', 'img/buildPC/image 25.png', 'Corsair RM850', 139.99, 163, 137),
(9, 'ATX', '80+', 500, 0, 'Black', 'img/buildPC/image 26.png', 'Thermaltake Smart', 39.99, 163, 108),
(10, 'ATX', '80+ Platinum', 750, 1, 'Black', 'img/buildPC/image 27.png', 'Corsair SF750', 169.99, 163, 131),
(11, 'ATX', '80+ Bronze', 650, 0, 'Black', 'img/buildPC/image 28.png', 'MSI MAG A650BN', 64.99, 163, 146);


Select * from cases;