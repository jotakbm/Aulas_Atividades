using UnityEngine;

// Pense em como remover lógicas e variaveis duplicadas. Você pode criar novas classes, ou pensar em outras maneiras de evitar códigos desnecessários
// Quanto mais enxuto ficar, melhor. Lembre-se que tornar um código sem repetição é extremamente importante, pois facilita manutenção e reutilização em projetos futuros
namespace Atividades.Duplicated.Player
{
    public class DuplicatedPlayerActivity : MonoBehaviour
    {
        public float maxEnergyShield;
        public float actualEnergyShield;

        public float maxLife;
        public float actualLife;
        public float lifeRegen;
        public float lifeRegenTime;
        private float lifeRegenTimer;

        public float maxMana;
        public float actualMana;
        public float manaRegen;
        public float manaRegenTime;
        private float manaRegenTimer;

        public float maxStamina;
        public float actualStamina;
        public float staminaRegen;
        public float staminaRegenTime;
        private float staminaRegenTimer;

        public float maxHungry;
        public float actualHungry;
        public float hungryDecay;
        public float hungryDecayTime;
        private float hungryDecayTimer;

        public int maxExp;
        public int exp;
        public int level;
    }
}