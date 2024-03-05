using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   public int maxHealth = 100;
   public int maxEnergy = 100;
   public int currentHealth;
   public int currentEnergy;
   public int count = 0;
   public Boolean real;
   public Collider2D hitbox;
   public SceneMover SceneMover;
   public Gameover GameOver;


   public HealthBar healthBarReal;
   public EnergyBar energyBarReal;
//Grouping the real/dream bars into a single change operation
   public void MaxHealthBarsUpdate(int health)
   {
     healthBarReal.SetMaxHealth(health);
   }

   public void MaxEnergyBarsUpdate(int energy)
   {
     energyBarReal.SetMaxEnergy(energy);

   }

   public void HealthBarsUpdate(int health)
   {
     healthBarReal.SetHealth(health);

   }

   public void EnergyBarsUpdate(int energy)
   {
     energyBarReal.SetEnergy(energy);

   }
//End grouping of real/dream bar updates

   void Start()
   {
        currentHealth = maxHealth;
        MaxHealthBarsUpdate(maxHealth);
        currentEnergy = maxEnergy;
        MaxEnergyBarsUpdate(maxEnergy);
   }

   void Update()
   {
        if (!real)//The timer for Dream World
        {
          count+=1;
          if (0 == count%600) TakeEnergy(1);
        }

        if (currentHealth <= 0 || currentEnergy <= 0)
        {
          GameOver.SetUp();
        }

   }
   public Collider2D Hitbox()
   {
    return hitbox;
   }

   public void TakeDamage(int damage)
   {
        currentHealth -= damage;
        HealthBarsUpdate(currentHealth);
   }

   public void TakeEnergy(int energy)
   {
        currentEnergy -= energy;
        EnergyBarsUpdate(currentEnergy);
   }
   
   public void Flip()
   {
     real = !real;
   }
}
