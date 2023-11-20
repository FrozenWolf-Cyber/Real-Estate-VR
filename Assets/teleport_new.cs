using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.UI;


public class teleport_new : MonoBehaviour
{
     public GameObject plot1, plot2, plot3, plot4, plot5, plot6, plot7;
    // Start is called before the first frame update
    public Button m_YourFirstButton;
    public GameObject cam;
    public GameObject cam_spec;
    public GameObject ui_display;
    public Vector3 cam_pos;

    public GameObject step;
    public StepManager  step_manager;
    public List<Camera> cams = new List<Camera>();
   
    
    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        // if (m_YourFirstButton == null)
        // {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        // Debug.Log("BUTTON NOT CREATED");
        // }
        for(int i = 0; i < cams.Count; i++)
        {
   // Code to be repeated.
        cams[i].enabled = false;
        }

        cams[0].enabled = true;
        step_manager.m_CurrentStepIndex  = 0;
        Debug.Log("BUTTON CREATED");
        // Debug.Log("ON START UI DISPLAY"+ui_display.transform.position);
    }

    void TaskOnClick()
    {
        if (step_manager.m_CurrentStepIndex > 6){
            step_manager.m_CurrentStepIndex = step_manager.m_CurrentStepIndex%7;
        }

        Debug.Log("You have clicked the TELEPORT button!"+step_manager.m_CurrentStepIndex);
        //Output this to console when Button1 or Button3 is clicked
        if (step_manager.m_CurrentStepIndex == 0){
            cams[0].enabled = false;
            cams[1].enabled = true;
            Debug.Log("Teleporting to plot 1");
        cam.transform.position = plot1.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 1){
            cams[1].enabled = false;
            cams[2].enabled = true;

            Debug.Log("Teleporting to plot 2");
        cam.transform.position = plot2.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 2){
            cams[2].enabled = false;
            cams[3].enabled = true;
            Debug.Log("Teleporting to plot 3");
        cam.transform.position = plot3.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 3){
            cams[3].enabled = false;
            cams[4].enabled = true;
            Debug.Log("Teleporting to plot 4");
        cam.transform.position = plot4.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 4){
            cams[4].enabled = false;
            cams[5].enabled = true;
            Debug.Log("Teleporting to plot 5");
        cam.transform.position = plot5.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 5){
            cams[5].enabled = false;
            cams[6].enabled = true;
            Debug.Log("Teleporting to plot 6");
        cam.transform.position = plot6.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }
        else if (step_manager.m_CurrentStepIndex == 6){
            cams[6].enabled = false;
            cams[0].enabled = true;
            Debug.Log("Teleporting to plot 7");
        cam.transform.position = plot7.transform.position + new Vector3(23.6f, 0f, -16.2f);
        }

    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        // Debug.Log("step_manager"+step_manager.m_CurrentStepIndex);
        // ui_display.transform.position = cam_spec.transform.position + new Vector3(-6f, +60f,-0.34f);
        // if (cam_pos != cam_spec.transform.position )
        // {
        //     ui_display.transform.position = cam_spec.transform.position - cam_pos;
        //     cam_pos = cam_spec.transform.position;
        // }
        // Debug.Log("ui"+ui_display.transform.position);
        // Debug.Log("cam_spec"+ui_display.transform.position);
        // // Debug.Log(plot1.transform.position);
    }
}