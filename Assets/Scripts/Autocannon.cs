using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Autocannon : GenericTower{
    //These attributes are unique to the Autocannon
    public GameObject muzzleLeft;
    public GameObject muzzleRight;
    private GameObject[] _enemies;
    private string _firingMuzzle = "left";

    //This attribute is shared attributes with all towers
    public SO_Tower tower;

    private float _timeElapsed;

    private void Start() {
        _enemies = GameObject.FindGameObjectsWithTag("PinkEnemy");
        Debug.Log(_enemies[0].transform.position);
    }

    private void Update() {
        if (_enemies[0]){
            
            Rotate(_enemies[0]);

            _timeElapsed += Time.deltaTime;
            if (_timeElapsed >= 1 / tower.fireRate){
                Fire(_enemies[0]);
                _timeElapsed = 0;
            }
        }
    }

    protected override void Fire(GameObject targetedEnemy) {
        GameObject bulletFired;

        if (_firingMuzzle == "left"){
            _firingMuzzle = "right";
            bulletFired = Instantiate(tower.bulletPrefab, muzzleLeft.transform.position, Quaternion.identity);
        }
        else{
            _firingMuzzle = "left";
            bulletFired = Instantiate(tower.bulletPrefab, muzzleRight.transform.position, Quaternion.identity);
        }

        Vector2 direction = targetedEnemy.transform.position - bulletFired.transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        bulletFired.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        bulletFired.GetComponent<Rigidbody2D>().AddForce(direction.normalized * 10, ForceMode2D.Impulse);

        Debug.DrawRay(muzzleLeft.transform.position, direction, Color.red, 2.0f);
    }
}