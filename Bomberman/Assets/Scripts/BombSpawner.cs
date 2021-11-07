using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    public int firePower;
    public int numberOfBombs = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && numberOfBombs >= 1){
            Vector2 spawnPos = new Vector2(Mathf.Round(transform.position.x),Mathf.Round(transform.position.y));
            var newBomb = Instantiate(bomb, spawnPos, Quaternion.identity) as GameObject;
            newBomb.GetComponent<Bomb>().firePower = firePower;
            numberOfBombs--;
            Invoke("addBomb", 1);
        }
        
    }

    public void addBomb(){
        numberOfBombs++;
    }
}
