using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    Rigidbody playerbody;
    public bool hitted;
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        playerbody = GetComponent<Rigidbody>();
    }
    public void TakeDamage(float amount){
        health -= amount;
        if (health <= 0f){
            Die();
        }
    }
    public void Takekb(float amount){
        //we take reference from other script
        Debug.Log("takingkb");
        hitted = true;
    }
    void Die(){
        Destroy(gameObject);
    }
    public void Update(){
        // here we give knockback to the player u can change values
        if (hitted){
            playerbody.AddForce(0, 50, 50, ForceMode.Impulse);
            hitted = false;}
        
    }
}
