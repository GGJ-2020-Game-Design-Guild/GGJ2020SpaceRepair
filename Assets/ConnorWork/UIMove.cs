using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMove : MonoBehaviour
{
    public float shown;
    public float hidden;
    public bool show;
    public const float speed = 10;
    private RectTransform rtrans;
    // Start is called before the first frame update
    void Start()
    {
        show = false;
        rtrans = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (show)
        {
            if (transform.position.x < shown)
            {
                rtrans.Translate(speed, 0, 0);
            }
        }
        else {
            if (transform.position.x > hidden)
            {
                rtrans.Translate(-speed, 0, 0);
            }
        }
    }
}
