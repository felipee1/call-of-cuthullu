using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCT.Shared.Entities;

namespace CCT.CCT.DOMAIN.USERBC.Entities
{
    public class Perfil: Entity
    {
        
        
            public Perfil(User user)
            {
                Userp = user;
            }
            public User Userp { get; set; }
            public List<Conquest> VisibleConquest { get; private set; }

            //conquistas
            public void AddConquest(User user, String name_conquest, List<Conquest> VisibleConquest)
            {
                foreach (var el in user.conquest)
                {
                    if (el.Name_conquest == name_conquest)
                    {
                        VisibleConquest.Add(el);
                    }
                }
            }
            public void Erase_Conquest(List<Conquest> VisibleConquest, String name_conquest)
            {
                foreach (var el in VisibleConquest)
                {
                    if (el.Name_conquest == name_conquest)
                    {
                        VisibleConquest.Remove(el);
                    }

                }
            }
        }
    
}
