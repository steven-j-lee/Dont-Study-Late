using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetName : MonoBehaviour
{
    [SerializeField] TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetText(SystemInfo.deviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
