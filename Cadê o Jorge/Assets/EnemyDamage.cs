using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private GameController controll;

    void Start(){
        controll = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Player"){
            controll.PlayerDie();
            }
 }
}
