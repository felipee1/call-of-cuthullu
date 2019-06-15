using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCT.Shared.Entities;

namespace CCT.CCT.DOMAIN.USERBC.Entities
{
    public class Conquest : Entity
    {
        //TODO: propriedades, Construtor
        public Conquest(String name_conquest, String type_conquest)
        {
            Name_conquest = name_conquest;
            Type_conquest = type_conquest;
        }

        public string Name_conquest { get; private set; }
        public string Type_conquest { get; private set; }
    }
}
