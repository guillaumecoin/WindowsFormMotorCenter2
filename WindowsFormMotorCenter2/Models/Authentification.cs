using CryptSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormMotorCenter2.Models
{
    class Authentification
    {

        motorcenterContext model = new motorcenterContext();

        public bool AuthentifierUtilisateur(string login, string password)
        {
            Employe employe = model.Employes.FirstOrDefault(e => e.NomEmploye == login);
            if (employe == null)
                return false;

            return password.Equals(employe.MotDePasse, StringComparison.OrdinalIgnoreCase);

        }
    }
}
