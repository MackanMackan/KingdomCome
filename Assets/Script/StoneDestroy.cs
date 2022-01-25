using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDestroy : MonoBehaviour
{
    public GameObject stonePebbles;
    public GameObject sfxSource;
    AudioClips audioClips;
    void Start()
    {
        audioClips = sfxSource.GetComponent<AudioClips>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collector") && Input.GetKey(KeyCode.E))
        {
            Instantiate(audioClips, transform.position, Quaternion.identity).PlayStonePickSFX();
            Instantiate(stonePebbles, new Vector2(transform.position.x,transform.position.y), Quaternion.identity);
            Instantiate(stonePebbles, new Vector2(transform.position.x,transform.position.y), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
