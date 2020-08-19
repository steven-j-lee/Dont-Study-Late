using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    
    [SerializeField] public List<GameObject> pageList;
    public int index = 0;
    public int mistakes = 0;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        pageList[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.E))
        {
            NextPage(pageList, index);
        }

        if (Input.GetKeyDown(KeyCode.Q))
            PrevPage(pageList, index);
        */
    }

    public void NextPage(List<GameObject> list)
    {
        if (index < list.Count - 1)
        {
            list[index].SetActive(false);
            index++;
            list[index].SetActive(true);
            Debug.Log("next page");
            Debug.Log(index);
        }
    }

    public void PrevPage(List<GameObject>list)
    {
        if (index > 0)
        {
            list[index].SetActive(false);
            index--;
            list[index].SetActive(true);
        }
    }
}
