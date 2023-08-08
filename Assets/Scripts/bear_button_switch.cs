using UnityEngine;

public class bear_button_switch : MonoBehaviour
{
    [SerializeField] GameObject button;
    bool isActive = false;
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
                isActive = !isActive;
                button.SetActive(isActive);
            }

        }
    }
}
