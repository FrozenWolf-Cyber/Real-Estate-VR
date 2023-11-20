using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class follow_panel : MonoBehaviour
{
    // Start is called before the first frame update     public GameObject plot1, plot2, plot3, plot4, plot5, plot6, plot7;
    // Start is called before the first frame update

    public GameObject cam_spec;
    public GameObject ui_display;
    public Vector3 cam_pos;

   
    
    void Start()
    {
        cam_pos = cam_spec.transform.position;
        Debug.Log("ON START UI DISPLAY"+ui_display.transform.position);
        Debug.Log("ON START CAM SPEC"+cam_spec.transform.position);
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
    //     Debug.Log("BEFORE FOLLOW SCRIPT ui"+cam_spec.transform.position);
    //     Debug.Log("BEFORE FOLLOW SCRIPT cam_spec"+ui_display.transform.position);
    //     // ui_display.transform.position = cam_spec.transform.position + new Vector3(-6f, +60f,-0.34f);
    //     if (cam_pos != cam_spec.transform.position )
    //     {
    //         ui_display.transform.position = ui_display.transform.position + cam_spec.transform.position - cam_pos;
    //         cam_pos = cam_spec.transform.position;
    //     }
    //     Debug.Log("AFTER FOLLOW SCRIPT ui"+ui_display.transform.position);
    //     Debug.Log("AFTER FOLLOW SCRIPT cam_spec"+cam_spec.transform.position);
    //     // Debug.Log(plot1.transform.position);
    }
}
