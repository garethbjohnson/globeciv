using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeUtils : MonoBehaviour {
    public static Globe getGlobe() {
        GameObject globeObject = GameObject.FindWithTag("Globe");
        var GlobeType = typeof(Globe);
        return globeObject.GetComponent(GlobeType) as Globe;
    }
}
