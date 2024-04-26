using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales
{
    internal class SalesClass
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int telephone { get; set; }
        public string gender { get; set; }
        public string si1 { get; set; }
        public string si2 { get; set; }
        public string si3 { get; set; }
        public string si4 { get; set; }

        public SalesClass(string name, string lastname, int tel, string gender, string si1, string si2, string si3, string si4) 
        {
            this.name = name;
            this.lastName = lastname;
            this.telephone = tel;
            this.gender = gender;
            this.si1 = si1;
            this.si2 = si2;
            this.si3 = si3;
            this.si4 = si4;

        }
    }
}
