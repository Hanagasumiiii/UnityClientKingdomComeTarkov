using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    public UnityEvent OnDamageDone;
    public UnityEvent OnBroken;
    public UnityEvent OnHealing;
    
    
    public int InitialHealthPoints = 100;

    public int CurrentHP
    {
        get;
        private set;
    } 
    
    private void Awake()
    {
        CurrentHP = InitialHealthPoints;
    }

    public void TakeDamage(int damage)
    {
        if(CurrentHP > 0)
        {
            CurrentHP -= damage;
            OnDamageDone.Invoke();

            if (CurrentHP <= 0)
            {
                OnBroken.Invoke();
            }
        }
    }

    public void Healing(int HealRate)
    {
        CurrentHP += HealRate;
        OnHealing.Invoke();
    }


}
