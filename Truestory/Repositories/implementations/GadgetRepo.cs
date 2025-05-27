using Truestory.model;

namespace Truestory.Repositories.implementations
{
    public class GadgetRepo : IGadgetRepo
    {

        private List<Gadget> _contextStore { get; set; } = new List<Gadget> {
            new Gadget{
                name = "Google Pixel 6 Pro",
                data = new Data {
                    CPUmodel = "Intel i7",
                    Harddisksize = "1TB",
                    price = 1000.00m,
                    year = 2023
                },
                createdAt = DateTime.UtcNow.AddDays(1)
            },
            new Gadget{
                name = "Apple iPhone 12 Mini, 256GB, Blue",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(2)
            },
            new Gadget{
                name = "Apple iPhone 12 Pro Max",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(3)
            },
            new Gadget{
                name = "Apple iPhone 11, 64GB",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 389.99m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(4)
            },
            new Gadget{
                name = "Samsung Galaxy Z Fold2",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 689.99m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(5)
            },
            new Gadget{
                name = "Apple AirPods",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 120m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(6)
            },
            new Gadget{
                name = "Apple MacBook Pro 16",
                data = new Data {
                    CPUmodel = "Intel Core i9",
                    Harddisksize = "1 TB",
                    price = 1849.99m,
                    year = 2019
                },
                createdAt = DateTime.UtcNow.AddDays(7)
            },
            new Gadget{
                name = "Apple Watch Series 8",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(8)
            },
            new Gadget{
                name = "Beats Studio3 Wireless",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(9)
            },
            new Gadget{
                name = "Apple iPad Mini 5th Gen",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(10)
            },
            new Gadget{
                name = "Apple iPad Mini 5th Gen",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 0m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(11)
            },
            new Gadget{
                name = "Apple iPad Air",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 419.99m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(12)
            },
            new Gadget{
                name = "Apple iPad Air",
                data = new Data {
                    CPUmodel = "N/A",
                    Harddisksize = "N/A",
                    price = 519.99m,
                    year = 0
                },
                createdAt = DateTime.UtcNow.AddDays(13)
            }
        };

        public int AddLaptop(Gadget msg)
        {
           _contextStore.Add(msg);
            return 1;
        }

        public IEnumerable<Gadget> GetAllLaptops()
        {
            return _contextStore;
        }

        public void Remove(Gadget recordToDelete)
        {
            _contextStore.Remove(recordToDelete);

        }
    }
}
