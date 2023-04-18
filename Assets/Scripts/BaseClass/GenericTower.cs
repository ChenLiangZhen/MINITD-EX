using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericTower : MonoBehaviour{
    protected virtual void Rotate(GameObject targetedEnemy) {
        
        Vector3 direction = targetedEnemy.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gameObject.transform.GetChild(0).transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    protected abstract void Fire(GameObject targetedEnemy);
} 