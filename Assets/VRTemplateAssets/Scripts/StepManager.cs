using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Controls the steps in the in coaching card.
    /// </summary>
    public class StepManager : MonoBehaviour
    {
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;

            [SerializeField]
            public string buttonText;
        }

        [SerializeField]
        public TextMeshProUGUI m_StepButtonTextField;
        

        [SerializeField]
        List<Step> m_StepList = new List<Step>();
        public List<Camera> cams = new List<Camera>();

        public int m_CurrentStepIndex = 0;
        
        
        public void Next()
        {
            
            Debug.Log("ON NEXT CALLED");
            m_StepList[m_CurrentStepIndex].stepObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_StepList.Count;
            m_StepList[m_CurrentStepIndex].stepObject.SetActive(true);
            m_StepButtonTextField.text = "Next Site";

                    if (m_CurrentStepIndex > 6){
            m_CurrentStepIndex = m_CurrentStepIndex%7;
        }

        // Debug.Log("You have clicked the TELEPORT button!"+m_CurrentStepIndex);
        //Output this to console when Button1 or Button3 is clicked
        if (m_CurrentStepIndex == 0){
            cams[0].enabled = false;
            cams[1].enabled = true;
            Debug.Log("NAV to plot 1");
        }
        else if (m_CurrentStepIndex == 1){
            cams[1].enabled = false;
            cams[2].enabled = true;

            Debug.Log("NAV to plot 2");

        }
        else if (m_CurrentStepIndex == 2){
            cams[2].enabled = false;
            cams[3].enabled = true;
            Debug.Log("NAV to plot 3");

        }
        else if (m_CurrentStepIndex == 3){
            cams[3].enabled = false;
            cams[4].enabled = true;
            Debug.Log("NAV to plot 4");

        }
        else if (m_CurrentStepIndex == 4){
            cams[4].enabled = false;
            cams[5].enabled = true;
            Debug.Log("Teleporting to plot 5");

        }
        else if (m_CurrentStepIndex == 5){
            cams[5].enabled = false;
            cams[6].enabled = true;
            Debug.Log("NAV to plot 6");

        }
        else if (m_CurrentStepIndex == 6){
            cams[6].enabled = false;
            cams[0].enabled = true;
            Debug.Log("NAV to plot 7");

        }
        }
    }
}
