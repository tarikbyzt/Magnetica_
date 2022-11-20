using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Health : MonoBehaviour
{
    public static Health Current;
    public int maxHealth = 100;
    public Slider healthBar;
    public int currentHealth;
    public ParticleSystem healParticle;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Current = this;
        currentHealth =60;
    }
    private void Update()
    {
        healthBar.DOValue(currentHealth, 0.3f);
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            anim.SetBool("Carpma", false);
            anim.SetBool("IsDead", true);
            anim.SetBool("Running", false);
            LevelController.Current.GameOver();
           // Play Death animation
            
            //show Gameover screen
        }
    }
    public void Heal(int amount)
    {
        currentHealth += amount;
        healParticle.Play();
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
