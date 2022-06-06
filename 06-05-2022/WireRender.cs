using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireRender : MonoBehaviour
{
    [SerializeField] private LineRenderer line;
    [SerializeField] private Transform[] posList;
    [SerializeField] Animator anim;

    void Start()
    {
 
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        line.SetVertexCount(posList.Length);

        for (int x = 0; x < posList.Length; x++)
        {
            line.SetPosition(x, posList[x].position);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
         anim.SetBool("Interacted", true);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Interacted", false);
    }
}
