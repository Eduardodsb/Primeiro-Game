using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public int coins = 0;
    

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        scoreText.text = (coins + player.position.z).ToString("0");
    }

    public void addCoins(){
        coins = coins + 1000;
    }

}
