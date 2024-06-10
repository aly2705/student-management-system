using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    internal class Admin : User
    {
        public static readonly Roles rol = Roles.Admin;

        public Admin() : base('A', rol) { }

        public Admin(string nume, string prenume, char sex) : base('A', nume, prenume, sex, rol) { }

        public override string ShowPermissions()
        {
            return "Rol: Admin";
        }
    }
}
