
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
namespace NinjaDomain {
    public class Ninja {
        public int Id { get; private set;}
        public string Name { get; set; }
        public bool ServedInOnIwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; private set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class Clan{
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipment {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
}
