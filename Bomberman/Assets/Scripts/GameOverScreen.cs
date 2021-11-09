using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void SetUp(int score){
        gameObject.SetActive(true);
        Debug.Log("Gameover");
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton(){
        Debug.Log("Restart");
        SceneManager.LoadScene("FirstScene");
    }

    public void ExitButton(){
        
    }
    
}
