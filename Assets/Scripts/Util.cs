using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour{
    
    public int targetFrameRate = 30;
    void Awake() {
        Application.targetFrameRate = 0;
    }
}