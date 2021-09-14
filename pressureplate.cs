using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    public Animator animator;
    public bool weighton;
    void Start()
    {
        animator.SetBool("weight_on", false);
        weighton = false;
    }
    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player") || player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", true);
            weighton = true;
        }
        if (player.gameObject.CompareTag("Player") && player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", true);
            weighton = true;
        }
    }
    public void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player") && player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", false);
            weighton = false;
        }
        if (player.gameObject.CompareTag("Player") || player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", false);
            weighton = false;
        }
    }
    public void OnTriggerStay2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player") && player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", true);
            weighton = true;
        }
        if (player.gameObject.CompareTag("Player") || player.gameObject.CompareTag("rock"))
        {
            animator.SetBool("weight_on", true);
            weighton = true;
        }
    }
}
