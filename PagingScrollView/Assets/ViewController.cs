using UnityEngine;
using System.Collections;

[RequireComponent(typeof(RectTransform))]
public class ViewController : MonoBehaviour {

    private RectTransform cachedRectTransform;
    public RectTransform CachedRectTransform
    {
        get
        {
            if (cachedRectTransform == null)
                cachedRectTransform = GetComponent<RectTransform>();
            return cachedRectTransform;
        }
    }

    public virtual string Title { get { return ""; } set { } }
}
