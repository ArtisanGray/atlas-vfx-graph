using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class MouseControl : MonoBehaviour
{
    public VisualEffect vfxgraph;
    float mousex;
    float mousey;
    Vector2 mousepos;
    // Start is called before the first frame update
    void Start()
    {
        mousex = 0.0f;
        mousey = 0.0f;
        mousepos = Vector2.zero;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        mousex = Input.GetAxisRaw("Mouse X");
        mousey = Input.GetAxisRaw("Mouse Y");

        mousepos += new Vector2(mousex, mousey);
        vfxgraph.SetVector2("Mouse Input", mousepos);
        if (mousepos.x > 5.0f || mousepos.x < -5.0f || mousepos.y > 3.0f || mousepos.y < -3.0f)
        {
            mousepos = Vector2.zero;
        }

    }
}
