using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFlag : MonoBehaviour
{
    public Item Flag;
    public Item Trigger;

    // Update is called once per frame
    void Update()
    {
        if (Flag.isActiveAndEnabled)
        {
            Trigger.gameObject.SetActive(true);
        }
    }
}
