using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
namespace Scripts
{
    public class Buttons : MonoBehaviour
{
   public PlayerControl playerControl_script;
   float dirX;
   float moveSpeed = 5f;
   public GameObject warrior_go;
   private bool moveUp,moveDown,moveLeft,moveRight;
   public PlayerAnimations playerAnimations_script;
   
   int id;

    
     void Awake()
    {
       
    }
    void Start()
    {
      
          id = PlayerPrefs.GetInt("CHARACTER");
   
           if(id == 1)
           {
                   playerControl_script = GameObject.Find("Guerreiro").GetComponent<PlayerControl>();
               playerAnimations_script = GameObject.Find("Guerreiro").GetComponent<PlayerAnimations>();
           }
           else if(id == 2)
           {
                   playerControl_script = GameObject.Find("Arqueiro").GetComponent<PlayerControl>();
                playerAnimations_script = GameObject.Find("Arqueiro").GetComponent<PlayerAnimations>();
           }
           else if(id==3)
           {
        
                   playerControl_script = GameObject.Find("Mago").GetComponent<PlayerControl>();
                playerAnimations_script = GameObject.Find("Mago").GetComponent<PlayerAnimations>();
           }
          InitializeBooleanDirections();
    }
   
  

    private void Update() 
    {
        PlayerMovement();
    }


   void InitializeBooleanDirections()
   {
          moveUp = false;
          moveDown = false;
          moveLeft = false;
          moveRight = false;
   }

    public void PlayerMovement()
    {
          if(moveUp)
        {
            playerAnimations_script.StateMovement(1);
            playerControl_script.MoveUp();
        }
        if(moveDown)
        {
            playerAnimations_script.StateMovement(1);
            playerControl_script.MoveDown();
        }
        if(moveLeft)
        {
              playerAnimations_script.StateMovement(3);
            playerControl_script.MoveLeft();
        }
        if(moveRight)
        {
                playerAnimations_script.StateMovement(4);
            playerControl_script.MoveRight();
        }
    }
        

   //INPUT BUTTONS
   public void UnclickMoveUp()
   {
         playerAnimations_script.StateMovement(0);
       moveUp = false;
   }
   public void ClickMoveUp()
   {
      
       moveUp = true;
   }
   public void ClickMoveDown()
   {
       moveDown = true;
   }
   public void UnclickMoveDown()
   {
          playerAnimations_script.StateMovement(0);
       moveDown = false;
   }
   public void CLickMoveLeft()
   {
       
       moveLeft = true;
   }
   public void UnclickMoveLeft()
   {
          playerAnimations_script.StateMovement(0);
       moveLeft = false;
   }
   public void ClickMoveRight()
   {
       moveRight = true;
   }
   public void UnclickMoveRight()
   {
          playerAnimations_script.StateMovement(0);
       moveRight = false;
   }
   public void AttackBtn()
   {
         
            playerControl_script.SimpleAttack();
            
   }
    
}
}

