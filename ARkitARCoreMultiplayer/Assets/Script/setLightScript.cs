using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLightScript : MonoBehaviour {

	// Use this for initializationpublic bool on = false;
    // public bool on2 = false;
    // public bool on3 = false;

    public bool BrakeL = false;
    public bool ReverseL = false;
    public bool FrontL = false;
    public bool TailL = false;
    public bool IndicatorL = false;
    public bool IndicatorR = false;
    // public bool INDICATORS = false;


    public GameObject BL;
    public GameObject RL;
    public GameObject FL;    
    
    public GameObject TL;    
    public GameObject IL;
    public GameObject IR;

    //public Material FLM;
    //public Material TLM;
    //public Material RLM;
    //public Material ILM;
    //public Material IRM;

	public void setFrontLight()
	{
        if (FrontL == false)
        {
            FrontL = true;
            FL.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            FrontL = false;
            FL.SetActive(false);
        }
	}
    public void setBrakeLights()
	{
        if (BrakeL == false)
        {
            BrakeL = true;
            BL.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            BrakeL = false;
            BL.SetActive(false);
        }
	}
    public void setTailLights()
	{
        if (TailL == false)
        {
            TailL = true;
            TL.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            TailL = false;
            TL.SetActive(false);
        }
	}
    public void setReverseLights()
	{
        if (ReverseL == false)
        {
            ReverseL = true;
            RL.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            ReverseL = false;
            RL.SetActive(false);
        }
	}
    public void setLeftIndicators()
	{
        if (IndicatorL == false)
        {
            IndicatorL = true;
            IL.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            IndicatorL = false;
            IL.SetActive(false);
        }
	}
    public void setRightIndicators()
	{
        if (IndicatorR == false)
        {
            IndicatorR = true;
            IR.SetActive(true);
            // FLM.EnableKeyword("_EMISSION");
        }
        else {
            IndicatorR = false;
            IR.SetActive(false);
        }
	}
    
}
