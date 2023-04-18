using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "Enemy", menuName = "Create Scriptable/Enemy")]
public class SO_Enemy : ScriptableObject{

    [BoxGroup("Basic Info")] public string enemyName;

    [BoxGroup("Basic Info")] [Multiline] public string enemyDescription;

    [BoxGroup("Rewards")] public int killReward;

    [BoxGroup("Attributes")] public float health;
    [BoxGroup("Attributes")] public float movementSpeed;
}