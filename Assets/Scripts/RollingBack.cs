using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBack : MonoBehaviour {


    public BoxCollider2D groundCollider;
    public float groundHorizontalLength;

	// Use this for initialization
	void Awake () {

        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = 6.9f;
		
	}
	
	// Update is called once per frame
	void Update () {
		

        if(transform.position.x < -groundHorizontalLength)
        {
            RepositionGround();
        }

	}

    public void RepositionGround()
    {
        Vector2 offset =  new Vector2(13f, 0);
        transform.position = (Vector2) transform.position + offset;
    }
}
