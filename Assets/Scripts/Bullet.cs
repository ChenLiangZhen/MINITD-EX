using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
    public float destructTimer = 10f;

    void Start() {
        Destroy(gameObject, destructTimer);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.CompareTag("PinkEnemy")){
            Destroy(collision.gameObject);
        }
        
        Debug.Log("COLLIDED");
    }

    void Update() { }
}