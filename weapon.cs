using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // variables
    public float damage = 10f;
    public float range = 3f;
    public float knockback = 2f;
    // raycast will be shooted from the camera
    public Camera Mcamera;   


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
      Shoot();
     }
    }
    void Shoot(){
    //setting up raycast shooted from camera
    RaycastHit hit;
    if (Physics.Raycast(Mcamera.transform.position, Mcamera.transform.forward, out hit, range))
    {
    Debug.Log(hit.transform.name);
    Target target = hit.transform.GetComponent<Target>();
    //giving damage and knockback
    if (target != null){
        target.TakeDamage(damage);
        target.Takekb(knockback);
    }}

}  
    
}
