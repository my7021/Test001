using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform m_txt;

    void Update()
    {
        Move();
        Rotate();
        Size();
    }

    void Move()
    {
        float axisH = Input.GetAxisRaw("Horizontal");
        float axisV = Input.GetAxisRaw("Vertical");
        transform.Translate(axisH, axisV, 0 * Time.deltaTime * 7);
    }

    void Rotate()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            m_txt.transform.Rotate(0, 0, 1);
        }

        if (Input.GetKey(KeyCode.E))
        {
            m_txt.transform.Rotate(0, 0, -1);
        }
    }

    void Size()
    {
        if(Input.GetMouseButton(0))
            m_txt.transform.localScale = m_txt.transform.localScale * 1.01f;

        if (Input.GetMouseButton(1))
            m_txt.transform.localScale = m_txt.transform.localScale * 0.99f;
    }
}
