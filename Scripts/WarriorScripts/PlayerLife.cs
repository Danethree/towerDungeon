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

    private void Awake() {
        
        life = playerScriptalbe.life;
        numberOfHearts = life;
        
    }
   
   private void Start() {
       
   }
   
    void Update()
    {
           VerifyGameCondition();
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

    float TakeDamage()
    {
       
       life = life -1;
       

       return life;
    }

   private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.CompareTag("enemy"))
       {
        
           TakeDamage();
       }
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

