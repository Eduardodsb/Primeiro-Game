using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour{

    public Score score;
    public GameObject audioEffect;

    // Start is called before the first frame update
    void Start(){
       score = FindObjectOfType<Score>();
        audioEffect = GameObject.Find("SoundEffect");
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(){
        audioEffect.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
        score.addCoins();
    }

}
