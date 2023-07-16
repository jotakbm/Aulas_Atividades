using UnityEngine;

// Pense em como remover lógicas e variaveis duplicadas. Você pode criar novas classes, ou pensar em outras maneiras de evitar códigos desnecessários
// Quanto mais enxuto ficar, melhor. Lembre-se que tornar um código sem repetição é extremamente importante, pois facilita manutenção e reutilização em projetos futuros
namespace Atividades.Duplicated.Weapon
{
    public class WeaponDuplicated : MonoBehaviour
    {
        public int primaryMaxAmmo;
        public int primaryActualAmmo;
        public float primaryReloadTime;
        public float primaryShootDelay;

        public int secondaryMaxAmmo;
        public int secondaryActualAmmo;
        public float secondaryReloadTime;
        public float secondaryShootDelay;

        private float primaryShootDelayTimer;
        private float secondaryShootDelayTimer;
        private bool isPrimaryReloading;
        private bool isSecondaryReloading;

        public void ShootPrimary()
        {

        }

        public void ShootSecondary()
        {

        }

        public void ReloadPrimary()
        {

        }

        public void ReloadSecondary()
        {

        }
    }
}