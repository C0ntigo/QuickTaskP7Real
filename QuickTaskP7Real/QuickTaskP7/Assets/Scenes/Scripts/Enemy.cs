using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed = 5f; 
    void Start()
    {

    }
    void Update()
    {
        if (player == null)
            return;


        transform.LookAt(player);


        float distance = Vector3.Distance(transform.position, player.position);


        if (distance > 1f)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"));


        }
    }
}
