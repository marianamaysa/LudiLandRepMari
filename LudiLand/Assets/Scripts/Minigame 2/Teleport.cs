using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject teleport01, teleport02, teleport03;

    Vector3 local01, local02, local03;

    public string localTag = "Local1, Local2, Local3";

    void Start()
    {
        local01 = teleport01.transform.position;
        local02 = teleport02.transform.position;
        local03 = teleport03.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(TeleportDelay(local01));
            //TeleportObject(local01);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(TeleportDelay(local02));
            //TeleportObject(local02);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(TeleportDelay(local03));
            //TeleportObject(local03);

        }
    }

    void TeleportObject(Vector3 teleport)
    {
        gameObject.transform.position = teleport;
        Debug.Log(teleport + "position");
    }

    IEnumerator TeleportDelay (Vector3 teleport)
    {
        TeleportObject(teleport);
        yield return null;
    }

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }
}
