using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class JumpVB : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject model, vbutton;

    // Start is called before the first frame update
    void Start()
    {
        this.vbutton = GameObject.Find("JumpButton");
        vbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        this.model = GameObject.Find("unitychan");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        this.model.GetComponent<Animator>().Play("JUMP00", -1, 0f);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        return;
    }
}
