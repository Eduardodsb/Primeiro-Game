using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour{

    public Score score;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start(){
       score = FindObjectOfType<Score>();
       audio = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(){
        audio.Play();
        gameObject.SetActive(false);
        score.addCoins();
    }

}
