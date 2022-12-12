using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnMsgPlayer : MonoBehaviour
{
    public Transform[] map;
    public Button m_btn_aRang;
    public Transform parent;
    int a = 0;
    int index = 0;
    int m_stepnumber = -1;
    int m_stepnumber1 = -1;
    int oldNum = -2;
    int oldNum1 = -2;
    List<GameObject> list = new List<GameObject>();//玩家集合
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 3; i++)
        {
            GameObject clone = Instantiate(Resources.Load<GameObject>(i.ToString()));
            clone.transform.parent = parent;
            clone.transform.localPosition = new Vector3(i - 1, 0, 0);
            clone.AddComponent<Player>().m_map = map;
            clone.GetComponent<Player>().btn = gameObject;
            list.Add(clone);

        }
        m_btn_aRang.onClick.AddListener(() =>
        {
            index += 1;
            a = Random.Range(0, 4);
            transform.GetComponentInChildren<Text>().text = a.ToString();
            if (index%2==0)
            {
                if (a!=2)
                {
                    m_stepnumber += a;
                }
               
                if (oldNum != m_stepnumber)
                {
                    if (m_stepnumber == -1)
                    {
                        list[0].GetComponent<Player>().MovePosition(a, 0);
                        m_stepnumber = 0;
                        oldNum = m_stepnumber;
                    }
                    else
                    {
                        list[0].GetComponent<Player>().MovePosition(a, m_stepnumber);
                        oldNum = m_stepnumber;
                    }
                }
                
            }
            else
            {
                if (a != 2)
                {
                    m_stepnumber1 += a;
                }
                if (oldNum1 != m_stepnumber1)
                {
                    if (m_stepnumber1 == -1)
                    {
                        list[1].GetComponent<Player>().MovePosition(a, 0);
                        oldNum1 = m_stepnumber1;
                        m_stepnumber1 = 0;
                    }
                    else
                    {
                        list[1].GetComponent<Player>().MovePosition(a, m_stepnumber1);
                        oldNum1 = m_stepnumber1;
                    }
                }
            }
        });
    }
    private void Action(GameObject go)
    {
        Debug.LogError(go.name + "进入陷阱");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
