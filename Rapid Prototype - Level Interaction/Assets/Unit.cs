using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int Health;
    public int toughness;
    public int curHealth;
    public int dmg;
     

    void Start(){
        Health = 100;
        curHealth = 100; 
        toughness = 5; 
        dmg = 10; 
    }

    public void DealDamage(int atk){
        curHealth -= atk/5; 

        if(curHealth <=0){
            // dead
        }else{
            // alive 
        }
    }
    
}
