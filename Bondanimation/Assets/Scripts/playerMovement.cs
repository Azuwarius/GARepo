using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Animator myAnimator;
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0) ;
       
        {
            myAnimator.SetBool("Jumping", true);
        }

        if (Input.GetAxis("Horizontal") != 0) //is the player moving left or right
        {
            myAnimator.SetBool("walking", true);

            if (Input.GetAxis("Horizontal") < 0)
            {

                transform.rotation = Quaternion.Euler(0, 180, 0);

            }


            if (Input.GetAxis("Horizontal") > 0)
            {

                transform.rotation = Quaternion.Euler(0, 0, 0);

            }


        }
        else
        {

            myAnimator.SetBool("walking", false);


        }
    }

} 

    