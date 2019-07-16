using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour{

    public Score score;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(){
        gameObject.SetActive(false);
        score.addCoins();
    }

}
