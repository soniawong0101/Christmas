using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBone : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    private float sockRot;
    Vector2 startPos;
    public Animator handAnim;
    float time = 0;
    public Canvas L2Finish;
    AudioSource success;
    AudioSource hitBowl;
    AudioSource hitGround;
    AudioSource hitPuppy;
    int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
        anim.enabled = true;
        startPos = transform.position;
        L2Finish.enabled = false;
        success = GameObject.Find("AudioSource2").GetComponent<AudioSource>();
        success.enabled = false;
        hitBowl = GameObject.Find("HitBowlAudio").GetComponent<AudioSource>();
        hitBowl.enabled = false;
        hitGround = GameObject.Find("HitGroundAudio").GetComponent<AudioSource>();
        hitGround.enabled = false;
        hitPuppy = GameObject.Find("HitPuppyAudio").GetComponent<AudioSource>();
        hitPuppy.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time>0 && time < 1)
        {
            transform.position = startPos;
            rb.isKinematic = true;
            handAnim.enabled = true;
            anim.enabled = true;
            time = 0;
            count = 1;
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
            //time = 3f;
            //if (time <= 0)
            //{
            hitGround.enabled = true;
            hitGround.Play();
            time = 2f;
            //}
        }
        if(collision.gameObject.tag == "Bowl")
        {
            L2Finish.enabled = true;
            hitBowl.enabled = true;
            hitBowl.Play();
            success.enabled = true;
            Time.timeScale = 0;
        }
        if(collision.gameObject.tag == "BowlRim")
        {
            hitBowl.enabled = true;
            hitBowl.Play();
        }
        if (collision.gameObject.tag == "Puppy")
        {
            count--;
            if (count == 0)
            {
                hitPuppy.enabled = true;
                hitPuppy.Play();
            }
            time = 2f;
        }
    }
}
