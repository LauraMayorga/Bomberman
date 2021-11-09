using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Text pointsText;
    public void SetUp(int score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton(){
        Debug.Log("Restart");
        SceneManager.LoadScene("FirstScene");
    }

    public void ExitButton(){
        
    }
}
    
