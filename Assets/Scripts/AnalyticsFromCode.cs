using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsFromCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AnalyticsEvent.GameStart();
    }
}
