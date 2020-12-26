using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    // [SerializeField] GameStatus status; 
    // [SerializeField] GameStatus game;
    // [SerializeField] Level level1;
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockSparklesVFX;


    [SerializeField] Sprite[] hitSprites;
    [SerializeField] int timesHits;
    Level level;
    private void Start()
    {
        // level1.CountBreakbleBalls();
     
       level = FindObjectOfType<Level>();
        //if (tag == "Breakable")
       // {
            level.CountBlocks();
        //}

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {  
          HandleHit();
        }

    }

    private void ShowNextHitSprite()
    {
        int spriteİndex=timesHits-1;
        if (hitSprites[spriteİndex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteİndex];
        }
        else
        {
            Debug.LogError("Block sprite is missing from array"+gameObject.name);
        }
    }
    private void HandleHit()
    {
        timesHits++;
        int maxHits = hitSprites.Length + 1;
        if (timesHits >= maxHits)
        {
            DestroyBlock();
        }
        else
        {
            ShowNextHitSprite();
        }
    }

    private void DestroyBlock()
    {
        // game.AddToScore();
        //status.GetComponent<GameStatus>().AddToScore();
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
        TriggerSparkles();
       
    }
    public void TriggerSparkles()
    {
        GameObject sprakles = Instantiate(blockSparklesVFX,transform.position,transform.rotation);
        Destroy(sprakles,1f) ;
    }
}
