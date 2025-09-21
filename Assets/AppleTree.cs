using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    public GameObject litbombPrefab;

    // Speed at which the AppleTree moves
    public float speed = 10f;

    // Distance where AppleTree turns around 
    public float leftAndRightEdge = 24f;

    // Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;

    // Seconds between Apples instantiations
    public float appleDropDelay = 1f;

    public float bombDropDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Start dropping apples
        Invoke("DropApple", 2f);
        Invoke("DropBomb", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    void DropBomb()
    {
        GameObject bomb = Instantiate<GameObject>(litbombPrefab);
        bomb.transform.position = transform.position;
        Invoke("DropBomb", bombDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);   // Move Right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);  // Move Left
        }
        /* else if (Random.value < changeDirChance)
        {
            speed *= -1;    // Change direction
        } */
    }

    void FixedUpdate()
    {
        // Random direction changes are now time-based due to FixedUpdate()
        if (Random.value < changeDirChance)
        {
            speed *= -1;    // Change direction
        }
    }
}
