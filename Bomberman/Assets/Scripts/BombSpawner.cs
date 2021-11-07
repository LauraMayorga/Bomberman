using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class BombSpawner : NetworkBehaviour
{
    public GameObject bomb;
    public int firePower;
    public int numberOfBombs = 2;


    // Update is called once per frame
    void Update()
    {
        if(!isLocalPlayer){
            return;
        }
        if(Input.GetButtonDown("Jump") && numberOfBombs >= 1){
            CmdSpawnBomb();
        }
        
    }

    [Command]
    private void CmdSpawnBomb(){
        Vector2 spawnPos = new Vector2(Mathf.Round(transform.position.x),Mathf.Round(transform.position.y));
        var newBomb = Instantiate(bomb, spawnPos, Quaternion.identity) as GameObject;
        newBomb.GetComponent<Bomb>().firePower = firePower;
        numberOfBombs--;
        NetworkServer.Spawn(newBomb);
        Invoke("addBomb", 1);
    }

    public void addBomb(){
        numberOfBombs++;
    }
}
