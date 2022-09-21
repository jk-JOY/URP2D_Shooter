using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeInfo : MonoBehaviour
{
    public float megaBytes            //메가바이트
    {
        get { return m_bytes * 0.000001f; }

        set
        {
            if (value <= 0)
            {
                m_bytes = 0;
            }
            else
            {
                m_bytes = value * 1000000f;
            }
        }
    }

    public float kiloBytes             //킬로바이트
    {
        get
        {
            return m_bytes * 0.001f;
        }

        set
        {
            if (value <= 0)
            {
                m_bytes = 0;
            }
            else
            {
                m_bytes = value * 1000f;
            }
        }
    }

    public float bytes             //바이트
    {
        get { return m_bytes; }

        set
        {
            if(value <= 0)
            {
                m_bytes = 0;
            }
            else
            {
                m_bytes = value;
            }
        }
    }

    private float m_bytes = 0;


}
