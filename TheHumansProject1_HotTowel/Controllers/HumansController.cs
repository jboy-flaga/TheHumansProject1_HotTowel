using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheHumansProject1_HotTowel.Models;

namespace TheHumansProject1_HotTowel.Controllers
{
    public class HumansController : ApiController
    {
        List<Human> HumansList;

        public HumansController()
        {
            HumansList = new List<Human>()
            {
                new Human(){ Id=1, FirstName="Jboy", MiddleName="Magbanua", LastName="Flaga",
                     Email="jeremiahflaga@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="Jboy.jpg", Address="Kidapawan"
                },
                new Human(){ Id=2, FirstName="Camille", MiddleName="B", LastName="Toledo",
                     Email="camilletoledo@mail.com", BirthDate=DateTime.Now, Gender="Female",
                      Phone="090909090909", Photo="camille.jpg", Address="Kidapawan"
                },
                new Human(){ Id=3, FirstName="Donald", MiddleName="", LastName="Knuth",
                     Email="doanldknuth@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="donaldKnuth.jpeg", Address="Human1Address"
                },
                new Human(){ Id=4, FirstName="Greg", MiddleName="", LastName="Howlett",
                     Email="greghowlett@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="gregHowlett.jpg", Address="Human1Address"
                },
                new Human(){ Id=5, FirstName="Jason", MiddleName="", LastName="Lisle",
                     Email="jasonlisle@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="jasonLisle.jpg", Address="Human1Address"
                },
                new Human(){ Id=6, FirstName="Georgia", MiddleName="", LastName="Purdom",
                     Email="georgiapurdom@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="georgiapurdom.jpeg", Address="Human1Address"
                },
                new Human(){ Id=7, FirstName="John", MiddleName="", LastName="Papa",
                     Email="johnpapa@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="johnpapa.jpg", Address="Human1Address"
                },
                new Human(){ Id=8, FirstName="Scott", MiddleName="", LastName="Hanselman",
                     Email="scottHanselman@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="scottHanselman.jpg", Address="Human1Address"
                },
                new Human(){ Id=9, FirstName="Yves", MiddleName="Human1M", LastName="Maquilan",
                     Email="bonbon@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="bonbon.jpg", Address="Human1Address"
                },
                new Human(){ Id=10, FirstName="Bill", MiddleName="", LastName="Gates",
                     Email="billgates@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="billgates.jpeg", Address="Human1Address"
                },
                new Human(){ Id=11, FirstName="Ken", MiddleName="", LastName="Ham",
                     Email="kenham@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="kenham.jpg", Address="Human1Address"
                },
                new Human(){ Id=12, FirstName="Werner", MiddleName="", LastName="Gitt",
                     Email="wernergitt@mail.com", BirthDate=DateTime.Now, Gender="Male",
                      Phone="090909090909", Photo="wernergitt.jpg", Address="Human1Address"
                },
                //new Human(){ Id=13, FirstName="Human1F", MiddleName="Human1M", LastName="Human1L",
                //     Email="Human1F@mail.com", BirthDate=DateTime.Now, Gender="Male",
                //      Phone="090909090909", Photo="", Address="Human1Address"
                //},
                //new Human(){ Id=14, FirstName="Human1F", MiddleName="Human1M", LastName="Human1L",
                //     Email="Human1F@mail.com", BirthDate=DateTime.Now, Gender="Male",
                //      Phone="090909090909", Photo="", Address="Human1Address"
                //}
            };
        }

        // GET api/humans
        public IEnumerable<Human> Get()
        {
            //return HumansList;
            return HumansList.OrderBy(h => h.LastName).ThenBy(h => h.FirstName);
        }

        // GET api/humans/5
        public Human Get(int id)
        {
            return HumansList.Find(h => h.Id == id);
        }
    }
}