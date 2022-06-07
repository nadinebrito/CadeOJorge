using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform playerPosition;
    public float enemyVelocity;
    private float direction;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Follow_Player();
    }

    private void Follow_Player()
    {
        if(playerPosition.gameObject != null)
        {
            direction = gameObject.GetComponent<Transform>().position.x - playerPosition.GetComponent<Transform>().position.x;
            anim.SetFloat("Horizontal", direction);
            transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, enemyVelocity * Time.deltaTime);
        }
    }
}
