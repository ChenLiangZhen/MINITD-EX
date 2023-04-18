using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "Tower", menuName = "Create Scriptable/Tower")]
public class SO_Tower : ScriptableObject{

    [BoxGroup("Basic Info")]
    public string towerName;
    
    [BoxGroup("Basic Info")] [Multiline]
    public string towerDescription;

    [BoxGroup("Costs")]
    public int baseCost;
    
    [BoxGroup("Costs")]
    public int upgradeCost;
    
    [BoxGroup("Attributes")] public float fireRange;
    [BoxGroup("Attributes")] public float fireRate;
    
    [BoxGroup("Attributes")] public float damage;
    [BoxGroup("Attributes")] public float blastRadius;
    [BoxGroup("Attributes")] public float blastDamage;

    [BoxGroup("Attributes")] public float bulletSpeed;
    [BoxGroup("Attributes")] public GameObject bulletPrefab;
}