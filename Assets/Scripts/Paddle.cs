using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 14f;
    [SerializeField] float screenWidthInUnits = 16f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float moousePosInUnits=Input.mousePosition.x / Screen.width*screenWidthInUnits;
        // Debug.Log(moousePosInUnits);
        // float deger = Mathf.Clamp(moousePosInUnits, minX, maxX);
       // Vector2 paddlePos = new Vector2(deger, transform.position.y);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
     
       paddlePos.x=Mathf.Clamp(moousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
