using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClassSystem : MonoBehaviour {

    public int strength=5, dexterity=5, intelligence=5, luck=5, armor=5;
    public int level =1, experience=0;
    public int currenthp, maxhp;
    public int StartHP = 100;
    public bool isDead;
    public int Gold;
    public bool IsWarrior, IsRogue, IsWizard;
 

    public void Warrior()
    {
        IsWarrior = true;
        strength = strength + 2;
        dexterity = dexterity - 2;
        intelligence = intelligence - 2;
        armor = armor + 2;
        luck = 5;
    }

    public void Rogue()
    {
        IsRogue = true;
        dexterity = dexterity + 2;
        strength = strength - 2;
        intelligence = intelligence - 1;
        armor = armor + 1;
        luck = 5;
    }

    public void Wizard()
    {
        IsWizard = true;
        intelligence = intelligence + 2;
        dexterity = dexterity - 2;
        strength = strength - 2;
        armor = armor + 1;
        luck = 5;
    }
   
    /*
        if (IsWarrior== true)
        {
            strength = strength + 2;
            dexterity = dexterity - 2;
            intelligence = intelligence - 2;
            armor = armor + 2;
            luck = 5;
        }

        else if (IsWizard == true)
        {
            intelligence = intelligence + 2;
            dexterity = dexterity - 2;
            strength = strength - 2;
            armor = armor + 1;
            luck = 5;
        }

        else if(IsRogue == true)
        {
            dexterity = dexterity + 2;
            strength = strength - 2;
            intelligence = intelligence - 1;
            armor = armor + 1;
            luck = 5;
        } */

    

   
 }
