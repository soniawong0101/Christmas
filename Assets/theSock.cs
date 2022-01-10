using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theSock : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    private bool clicked = false;
    private float sockRot;
    Vector2 startPos;
    public Animator handAnim;
    float time = 0;
    public Canvas L1Finish;
    AudioSource success;
    AudioSource hitBag;

    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
        anim.enabled = true;
        startPos = transform.position;
        L1Finish.enabled = false;
        success = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        success.enabled = false;
        hitBag = GameObject.Find("HitBagAudio").GetComponent<AudioSource>();
        hitBag.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time > 0 && time < 1)
        {
            transform.position = startPos;
            rb.isKinematic = true;
            handAnim.enabled = true;
            anim.enabled = true;
            time = 0;
        }
        Vector2 hitVector = (Input.mousePosition - transform.position).normalized;

        if (Input.GetMouseButtonDown(0))
        {
            Count.number += 1;
            sockRot = transform.rotation.z;
            rb.isKinematic = false;
            anim.enabled = false;
            rb.AddForce(hitVector * sockRot*2200);
            handAnim.enabled = false;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            time = 2f;
        }
        if(collision.gameObject.tag == "Basket")
        {
            hitBag.enabled = true;
            hitBag.Play();
            L1Finish.enabled = true;
            success.enabled = true;
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "BasketRim")
        {
            hitBag.enabled = true;
            hitBag.Play();
        }
    }
}
