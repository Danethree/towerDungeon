using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts.ScriptableObjects;
using UnityEngine.UI;

namespace Scripts.WarriorScripts
{
    public class PlayerLife : MonoBehaviour
{

    public PlayerSO playerScriptalbe;
    public int life;
    public int numberOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public PlayerAnimations player_anim;
    private Text pointTxt;
    private void Awake() {
        
        life = playerScriptalbe.life;
        numberOfHearts = life;
        
    }
   
   private void Start() {
        pointTxt = GameObject.Find("pointsTxt").GetComponent<Text>();
   }
   
    void Update()
    {
          
       ControlHearts();
       
    }



    void ControlHearts()
    {
         if(life>numberOfHearts)
        {
             life = numberOfHearts;
        }
       
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<life)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i<numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

   public float TakeDamage()
    {
          player_anim.DamageAnim();
       life = life -1;
 

       return life;
    }

   //little-2 hearts
   //medium-3 hearts
   //hard- 6 hearts
   public float RestoreLife(int recoverIntensity)
   {
       life = life + recoverIntensity;
       return life;
   }

   public void VerifyGameCondition()
   {
       if(life<=0)
       {
         
           GameManager.instance.GameOver();
       }
   }
   
}
}


