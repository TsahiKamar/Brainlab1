using Brainlab1.DataAccess;
using Brainlab1.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brainlab1.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class CarWorkShopController : ControllerBase
    {

        private readonly AppDbContext _context;

        public CarWorkShopController(AppDbContext context) 
        {
            _context = context;

            if (!_context.generalInfo.Any())
            {
                this._GENERALINFO.ForEach(s => _context.generalInfo.Add(s));
                _context.SaveChanges();
            }

            if (!_context.customers.Any())
            {
                this._CUSTOMERS.ForEach(s => _context.customers.Add(s));
                _context.SaveChanges();
            }

            if (!_context.employees.Any())
            {
                this._EMPLOYEES.ForEach(s => _context.employees.Add(s));
                _context.SaveChanges();
            }

            if (!_context.cars.Any())
            {
                this._CARS.ForEach(s => _context.cars.Add(s));
                _context.SaveChanges();
            }

            if (!_context.carReplacementParts.Any())
            {
                this._REPLACEMENTPARTS.ForEach(s => _context.carReplacementParts.Add(s));
                _context.SaveChanges();
            }


            if (!_context.prices.Any())
            {
                this._PRICELIST.ForEach(s => _context.prices.Add(s));
                _context.SaveChanges();
            }
            if (!_context.carService.Any())
            {
                this._CARSERVICE.ForEach(s => _context.carService.Add(s));
                _context.SaveChanges();
            }

            if (!_context.invoices.Any())
            {
                this._INVOICES.ForEach(s => _context.invoices.Add(s));
                _context.SaveChanges();
            }


        }

        private List<GeneralInfo> _GENERALINFO = new List<GeneralInfo>
            {
                    new GeneralInfo { id = "1",name = "Ofek",phones= "{ '0523555666','035556666' }",address="Hertzel 100 Tel-Aviv",manager = "Moshe Erlich" },
                    new GeneralInfo { id = "2",name = "Oran",phones="{ '0543555667','095556667' }",address="Aba Hillel 1 Ramat-Gan",manager = "Moshe Erlich" }

            };

            private List<Customers> _CUSTOMERS = new List<Customers>
            {
                    new Customers { id = "1",name = "Ofek",tel="0523555666" },
                    new Customers { id = "2",name = "Oran",tel="0543555667" }
            };

            private List<Employees> _EMPLOYEES = new List<Employees>
            {
                    new Employees { nmbr = 10, name = "Dan Almagor",profession = "Mechanic team manager",salary=12200,isSupervisor = true },
                    new Employees { nmbr = 11, name = "Rama Cohen",profession = "Mechanic",salary=22021,isSupervisor = false }
            };
          

            private List<Cars> _CARS = new List<Cars>
            {
                    new Cars { carLicenseNumber = "1",carType = "Hyundai Tuson",carModel="2020",customer = "{id :'1',name: 'Ofek',tel: '0523555666'}" },
                    new Cars { carLicenseNumber = "2",carType = "Tesla 3",carModel="2021",customer =  "{id : '2',name : 'Oran',tel: '0543555666'}" },
                    new Cars { carLicenseNumber = "3",carType = "Porche 911",carModel="2010",customer = " {id : '1',name : 'Ofek',tel:'0523555666'} " }

            };


             private List<CarReplacementParts> _REPLACEMENTPARTS = new List<CarReplacementParts>
            {
                    new CarReplacementParts { partNumber = 1, name = "Left mirror", carType = "Hyundai Tuson",carModel="2020",price = 250 },
                    new CarReplacementParts { partNumber = 2,name = "Right mirror",carType = "Hyundai Tuson",carModel="2020",price =250 },
                    new CarReplacementParts { partNumber = 1,name = "Left mirror",carType = "Tesla 3",carModel="2021",price = 2050 },
                    new CarReplacementParts { partNumber = 2,name = "Right mirror",carType = "Tesla 3",carModel="2021",price =2050 },
                    new CarReplacementParts { partNumber = 1,name = "Left mirror",carType = "Porche 911",carModel="2021",price = 3050 },
                    new CarReplacementParts { partNumber = 2,name = "Right mirror",carType = "Porche 911",carModel="2020",price =3050 },
                    new CarReplacementParts { partNumber = 3,name = "Left door",carType = "Porche 911",carModel="2010",price = 10000 }
            };


            private List<CarService> _CARSERVICE = new List<CarService>
            {
                    new CarService { carLicenseNumber = "1",startTime = new DateTime(),finishTime=new DateTime(),status = 0,assignEmployees = " { name : 'Dan Almagor',profession : 'Mechanic team manager',salary:32200,isSupervisor : true } ",partsUsed = "{ id : 1,name : 'Left mirror',description : 'left side mirror' } "  },
                    new CarService { carLicenseNumber = "2",startTime = new DateTime(),finishTime=new DateTime(),status = 0,assignEmployees = " { name : 'Rama Cohen',profession : 'Mechanic',salary:12200,isSupervisor : false } ",partsUsed = "{ id : 2,name : 'Right mirror',description : 'right side mirror' } "  },
                    new CarService { carLicenseNumber = "3",startTime = new DateTime(),finishTime=new DateTime(),status = 0,assignEmployees = " { name : 'Rama Cohen',profession : 'Mechanic',salary:12200,isSupervisor : false } ",partsUsed = "{ id : 3,name : 'Right door',description : 'right side door' } "  },
                
            };

            private List<PriceList> _PRICELIST = new List<PriceList>
            {
                    new PriceList { carType = "Hyundai Tuson",carModel="2020",hourWorkPrice = 100 },
                    new PriceList { carType = "Tesla 3",carModel="2021",hourWorkPrice = 300 }
            };

            private List<Invoices> _INVOICES = new List<Invoices>
            {
                    new Invoices { customerId = "1",customerName = "Ofek" , date = new DateTime(),amount =  560 , details = "Mirror fix" },
                    new Invoices { customerId = "2",customerName = "Oran" , date = new DateTime(),amount =  3500 , details = "Door replace" }
             };


    }
}
