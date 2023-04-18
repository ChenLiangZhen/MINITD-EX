using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameplayUI : MonoBehaviour{
    
    private VisualElement _root;
    private Button _btnStartWave;
    private Button _btnToggle;
    private Label _lbEntitiesVar;
    private void OnEnable() {
        
        _root = GetComponent<UIDocument>().rootVisualElement;
        
        _btnStartWave = _root.Q<Button>("BtnStartWave");
        _btnToggle = _root.Q<Button>("BtnToggle");
        _lbEntitiesVar = _root.Q<Label>("LbEntitiesVar");
        
        _btnStartWave.clicked += () => { Debug.Log("Start Wave"); };
    }

    void Update() {

        int gameObjectCount = SceneManager.GetActiveScene().GetRootGameObjects().Length;
        _lbEntitiesVar.text = gameObjectCount.ToString();

    }
}