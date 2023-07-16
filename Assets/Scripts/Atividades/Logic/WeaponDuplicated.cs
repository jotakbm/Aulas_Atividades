using UnityEngine;

// Pense em como remover l�gicas e variaveis duplicadas. Voc� pode criar novas classes, ou pensar em outras maneiras de evitar c�digos desnecess�rios
// Quanto mais enxuto ficar, melhor. Lembre-se que tornar um c�digo sem repeti��o � extremamente importante, pois facilita manuten��o e reutiliza��o em projetos futuros
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