using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.EnemyScriptableObjects
{
    [CreateAssetMenu(fileName = "EnemySO", menuName = "EnemyInfo", order = 1)]
public class EnemySO : ScriptableObject {
    public float speed;
    public float life;
    public float timeToStop;

}
}


