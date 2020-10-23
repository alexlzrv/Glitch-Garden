using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;


    private void Start() {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if (IsAttackerInLane()) {
            animator.SetBool("IsAttacking", true);
        }
        else {
            animator.SetBool("IsAttacking", false);  
        }
    }


    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
        
    }


    private void SetLaneSpawner() {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners) {
            bool IsClosedEnough = Mathf.Abs(spawner.transform.position.y - transform.position.y) <= .5f;
            if (IsClosedEnough) {
                myLaneSpawner = spawner;
            } 
        }
    }

    private bool IsAttackerInLane() { 
        if (myLaneSpawner.transform.childCount <= 0) {
            return false;
        }
        else {
            return true;
        }
    }
}
