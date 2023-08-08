using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherry_switch_animation : MonoBehaviour
{
    [SerializeField] Animator anim;
    Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

            if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                anim.enabled = !anim.enabled;    
            }
        }
    }
}
