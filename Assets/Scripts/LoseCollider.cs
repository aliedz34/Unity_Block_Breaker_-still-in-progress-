﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpriteRenderer>().color==Color.blue)
        {
            Destroy(collision.gameObject);
        }
        else
        {
            SceneManager.LoadScene("Game Over");
        }
            
    }
             
    }
   

