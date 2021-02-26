using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.WarriorScripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerSO", menuName = "PlayerInfo", order = 0)]
public class PlayerSO : ScriptableObject
{
    public int power;
    public int life;
    public int defense;
}

}

    

