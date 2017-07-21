using UnityEngine;
using System.Collections;
using System;

public class Draw : MonoBehaviour, IUpper {

    void IUpper.Draw()
    {
        StartCoroutine(ITest());
    }

    IEnumerator ITest()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("a");
    }

}
