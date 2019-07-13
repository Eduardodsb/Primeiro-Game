using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    bool gameover = false;
    public float restartdelay = 1f;
    public GameObject completeLevelUI;


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void EndGame(){
        if (gameover == false){
            gameover = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartdelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel(){
        gameover = true;
        completeLevelUI.SetActive(true);
    }
}
