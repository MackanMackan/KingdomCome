using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    public GameObject audioSource;
    PlayerRescources rescources;
    float counter = 0;
    bool canCollect = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rescources = player.GetComponent<PlayerRescources>();
        rb.velocity = new Vector2(Random.Range(-2, 2), Random.Range(2, 6));
    }


    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > 0.5)
        {
            canCollect = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Instantiate(audioSource).GetComponent<AudioClips>().PlayGoldHitGroundSFX();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Collector") && canCollect)
        {
            rescources.AddGold();
            Instantiate(audioSource,transform.position,Quaternion.identity).GetComponent<AudioClips>().PlayGoldCollectSFX();
            Destroy(gameObject);
        }
    }
}
