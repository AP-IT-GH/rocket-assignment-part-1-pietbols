using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCurrentCanvas : MonoBehaviour
{
    public void RemoveCanvas()
    {
        this.gameObject.SetActive(false);
    }
}
