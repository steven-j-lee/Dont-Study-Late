using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayCast : MonoBehaviour
{
    private GameObject raycastedOBJ;
    [SerializeField] PageManager pageManager;
    [SerializeField] private int rayCastLenght = 20;
    [SerializeField] private LayerMask interactableLayer;
    [SerializeField] ChoiceMake choice;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit collision;
        Vector3 line = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position,
            line,
            out collision,
            rayCastLenght,
            interactableLayer.value))
        {
            //checks for answers
            if (collision.collider.CompareTag("Answer")
                && Input.GetKeyDown(KeyCode.E))
            {
                pageManager.NextPage(pageManager.pageList);
                Debug.Log("Made the right choice");
            }
            else if (collision.collider.CompareTag("Wrong")
                && Input.GetKeyDown(KeyCode.E))
            {
                pageManager.mistakes++;
                Debug.Log("chosen wrong answer");
                Debug.Log("mistakes: " + pageManager.mistakes);
            }
        }
        
    }
}
