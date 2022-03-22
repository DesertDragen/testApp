using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimations : MonoBehaviour
{
    public GameObject boxMove;
    public GameObject boxRotate;
    public GameObject boxScale;

    public void BoxMoveAnimation() {
        boxMove.GetComponent<Animation>().Play();
    }

    public void BoxRotateAnimation() {
        boxRotate.GetComponent<Animation>().Play();
    }

    public void BoxScaleAnimation() {
        boxScale.GetComponent<Animation>().Play();
    }
}
