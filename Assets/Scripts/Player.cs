using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow)) 
       {
       transform.Translate(-speed * Time.deltaTime, 0, 0  );
       }
        if(Input.GetKey(KeyCode.RightArrow)) 
       {
       transform.Translate(speed * Time.deltaTime, 0, 0  );
       }
        if(Input.GetKey(KeyCode.UpArrow)) 
       {
       transform.Translate(0, speed * Time.deltaTime, 0  );
       }
        if(Input.GetKey(KeyCode.DownArrow)) 
       {
       transform.Translate(0, -speed * Time.deltaTime, 0  );
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Keys")
        {
            score++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Walls")
        {
            Debug.Log("Wall hit");
        }
    }
}
