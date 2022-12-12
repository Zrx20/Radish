using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Transform[] m_map;
    public GameObject btn;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void MovePosition(int numtype,int num)
    {
        if (numtype == 2)
        {
            
            Debug.LogError("转萝卜");
        }
        else
        {
            if (num < m_map.Length)
            {
                if (m_map[num].tag == "xianjing")
                {
                    Debug.Log("陷阱");
                    btn.SendMessage("Action", gameObject, SendMessageOptions.DontRequireReceiver);
                }
                else
                {
                    if (m_map[num].childCount == 0)
                    {
                        transform.parent = m_map[num];
                        transform.position = m_map[num].position + new Vector3(0, 1, 0);
                    }
                    else
                    {
                        transform.parent = m_map[num + 1];
                        transform.position = m_map[num + 1].position + new Vector3(0, 1, 0);
                    }
                }
            }
            else
            {
                transform.parent = m_map[15];
                transform.position = m_map[15].position + new Vector3(0, 1, 0);
                Debug.LogError("游戏成功");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
