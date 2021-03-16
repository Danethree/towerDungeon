using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Objects
{
    public class OpenButtonC : MonoBehaviour
{
    public Chest chest_script;
    

   public void btnOpen()
   {
     
       chest_script.OpenTreasureChest();
   }
}

}
