using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.UI;

public class create_building : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject b1, b2, b3;
    public GameObject plot5, plot6, plot7;
    public Button m_YourFirstButton;
    public StepManager  step_manager;
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Placing!");
        //Output this to console when Button1 or Button3 is clicked
        if (step_manager.m_CurrentStepIndex > 6){
            step_manager.m_CurrentStepIndex = step_manager.m_CurrentStepIndex%7;
        }

        if (step_manager.m_CurrentStepIndex > 6){
            step_manager.m_CurrentStepIndex = step_manager.m_CurrentStepIndex%7;
        }

        Debug.Log("You have clicked the TELEPORT button!"+step_manager.m_CurrentStepIndex);
        //Output this to console when Button1 or Button3 is clicked

         if (step_manager.m_CurrentStepIndex == 4){
                    GameObject go = GameObject.Instantiate(b1);
        go.transform.position =  plot5.transform.position;
            Debug.Log("Placing to plot 5");
        }
        else if (step_manager.m_CurrentStepIndex == 5){
            GameObject go = GameObject.Instantiate(b1);
        go.transform.position =  plot6.transform.position;
            Debug.Log("Placing to plot 6");
        }
        else if (step_manager.m_CurrentStepIndex == 6){
            GameObject go = GameObject.Instantiate(b1);
        go.transform.position =  plot7.transform.position;
            Debug.Log("Placing to plot 7");
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
