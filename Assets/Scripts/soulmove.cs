using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;

    private bool isMoving;

    public Vector2 input;

    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input != Vector2.zero)
            {
                var targetPos=transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;


            }
        }
    }
    IEnumerator Move(Vector3 targetPos)
    {
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            targetPos = Vector3.MoveTowards(transform.position, targetPos, movespeed * Time.deltaTime);
        }
    }

}
