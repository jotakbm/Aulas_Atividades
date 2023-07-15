using UnityEngine;

public class Herarquia : MonoBehaviour
{
    #region Abstract & Interface

    public abstract class Animal : MonoBehaviour
    {
        public string animalName;
        public string description;

        protected int lifeTime;
        protected int maxSatiety;
        private int satiety;
        private bool isDead;

        public virtual void Initialize()
        {
            satiety = maxSatiety;
        }

        public void Eat(int value)
        {
            satiety += value;
        }

        private void GetHungry()
        {
            satiety--;
            if (satiety <= 0)
            {
                Die();
            }
        }

        protected virtual void MakeSound()
        {

        }

        private void Die()
        {
            isDead = true;
            Debug.Log(isDead);
        }
    }

    public abstract class Mamifero : Animal
    {
        public void DoMilk()
        {
            // Gera leite
        }
    }

    public abstract class Peixe : Animal
    {

    }

    #region Aves
    public abstract class Ave : Animal
    {
        protected Color corDaPena;
    }

    public class Sabia : Ave, IVoador
    {
        public override void Initialize()
        {
            animalName = "Sabia";
            description = "Um Sabiá";
            corDaPena = Color.red;
            maxSatiety = 25;
        }

        public void Fly()
        {
            // Faz Voar.
        }
    }

    public class Pato : Ave, IVoador, INadador
    {
        public override void Initialize()
        {
            animalName = "Pato";
            description = "Um Pato";
            corDaPena = Color.white;
            maxSatiety = 35;
        }

        public void Dive()
        {
            // Faz Mergulhar;
        }

        public void Swim()
        {
            // Faz Nadar;
        }

        public void Fly()
        {
            // Voar;
        }

        protected override void MakeSound()
        {
            Debug.Log("Quack");
        }
    }

    public class Pinguin : Ave
    {
        public override void Initialize()
        {
            animalName = "Pinguim";
            description = "Um Pinguim";
            corDaPena = Color.black;
            maxSatiety = 30;
        }
    }
    #endregion

    #endregion

    #region Interfaces
    public interface IVoador
    {
        public void Fly();
    }

    public interface INadador
    {
        public void Swim();

        public void Dive();
    }
    #endregion
}