using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMake : MonoBehaviour
{
    [SerializeField] PageManager pageManager;
    public bool isAnswer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"
           && gameObject.tag == "Answer"
           && Input.GetKeyDown(KeyCode.E))
        {
            pageManager.NextPage(pageManager.pageList);
            Debug.Log("Made the right choice");
        }
        else if (other.gameObject.tag == "Player"
            && gameObject.tag == "Wrong"
            && Input.GetKeyDown(KeyCode.E))
        {
            pageManager.mistakes++;
            Debug.Log("chosen wrong answer");
        }
    }
}
