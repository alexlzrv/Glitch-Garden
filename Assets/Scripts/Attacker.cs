using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
   
    float currentSpeed = 0.6f;
    GameObject currentTarget;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target) {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }
}
