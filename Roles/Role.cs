using AmongUs.GameOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TOHE.Translator;

namespace TOHE.Roles;

//base of role 
public abstract class Role
{
    protected Role(string color, CustomRoleType roleType,RoleTypes Vanilla) 
    {
        Name = GetType().Name;

    }

    public string Name;
}


