using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    public WheelCollider onsolcol;
    public WheelCollider onsagcol;
    public WheelCollider arkasagcol;
    public WheelCollider arkasolcol;

    public GameObject onsol;
    public GameObject onsag;
    public GameObject arkasag;
    public GameObject arkasol;

    public float maxMotorGucu;
    public float maxDonusAcisi;
    public float motor;
    public float FrenGucu;
    float frentork;


    int vites = 0;
    float donus;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (vites==1)
        {
             frentork= FrenGucu * Mathf.Abs(Input.GetAxis("Geri"));
        }
        else
        {
             frentork = FrenGucu * Mathf.Abs(Input.GetAxis("Ileri"));
        }
        
        if (frentork < 0.05)
        {
            arkasagcol.motorTorque = motor;
            arkasolcol.motorTorque = motor;
            arkasagcol.brakeTorque = 0;
            arkasolcol.brakeTorque = 0;
        }
        else
        {
            arkasagcol.brakeTorque = frentork;
            arkasolcol.brakeTorque = frentork;
        }
        if (vites == 0)
        {
            if (Input.GetKeyUp(KeyCode.Keypad1))
            {
                vites = 1;
            }
            if (Input.GetKeyUp(KeyCode.Keypad2))
            {
                vites = 2;
            }

        }
        if (vites == 1)
        {
            
            motor = maxMotorGucu * Input.GetAxis("Ileri");
            donus = maxDonusAcisi * Input.GetAxis("Horizontal");
            onsolcol.steerAngle = onsagcol.steerAngle = donus;
            arkasagcol.motorTorque = motor;
            arkasolcol.motorTorque = motor;
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
                vites = 0;
            }
            if (Input.GetKeyUp(KeyCode.Keypad2))
            {
                vites = 2;
            }
        }
        if (vites == 2)
        {
            motor = maxMotorGucu * Input.GetAxis("Geri");
            donus = maxDonusAcisi * Input.GetAxis("Horizontal");
            onsolcol.steerAngle = onsagcol.steerAngle = donus;
            arkasagcol.motorTorque = motor;
            arkasolcol.motorTorque = motor;
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
                vites = 0;
            }
            if (Input.GetKeyUp(KeyCode.Keypad1))
            {
                vites = 1;
            }
        }





        SanalTeker();
    }
    void SanalTeker()
    {
        Quaternion rot;
        Vector3 pos;
        onsolcol.GetWorldPose(out pos, out rot);
        onsol.transform.position = pos;
        onsol.transform.rotation = rot;

        onsagcol.GetWorldPose(out pos, out rot);
        onsag.transform.position = pos;
        onsag.transform.rotation = rot;

        arkasolcol.GetWorldPose(out pos, out rot);
        arkasol.transform.position = pos;
        arkasol.transform.rotation = rot;

        arkasagcol.GetWorldPose(out pos, out rot);
        arkasag.transform.position = pos;
        arkasag.transform.rotation = rot;
    }
}
