using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    
    [SerializeField] GameObject ball1;
    public GameObject ball2;
 

    private void CloneBall()
    {     
        for(int i =0; i<5; i++)
        {
           
            ball2 = Instantiate(ball1, transform.position, transform.rotation);         
            ball2.GetComponent<SpriteRenderer>().color = Color.blue;
            float a = Random.Range(0f, 12f);
            float b = Mathf.Sqrt(148 - a * a);
            ball2.GetComponent<Rigidbody2D>().velocity = new Vector2(a, b);         
            Destroy(gameObject);
           
        }

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CloneBall();
    }
}
