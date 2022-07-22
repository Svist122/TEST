//==================================================================================================================
//
// VREyeRaycaster.cs
// Helper class to attach to the VR hand that raycasts where the user is pointing to select/deselect Buttons.
// It reacts to objects tagged as:  "InteractivesObjects" and send a trigger mesagge so objects can react
// Example provided to change color in the cubes.
//
//==================================================================================================================

using UnityEngine;
using UnityEngine.UI;


public class VREyeRaycaster : MonoBehaviour
{
    public LaserPointer lp;

    public Transform eyeTransform;
    public LayerMask layers;

    public OVRInput.RawButton inputManager = OVRInput.RawButton.RIndexTrigger;

    private GameObject hitObject;
    private Rigidbody myRigidbody;
    private Color originalColor = Color.white;
    private int layerInteractiveObjects;

    


    public bool IsLaserHitted() { return hitObject != null; }
    public GameObject GetLaserHittedObject() { return hitObject; }

    private void Start()
    {
        if (eyeTransform == null) { eyeTransform = this.transform; }

        layerInteractiveObjects = LayerMask.NameToLayer("InteractiveObjects");
    }

    private RaycastHit hit;
    private void Update()
    {

        // do a forward raycast to see if we hit an object
        if (Physics.Raycast(eyeTransform.position, eyeTransform.forward, out hit, 10f, layers))
        {
            hitObject = hit.collider.gameObject;
            myRigidbody = hitObject.GetComponent<Rigidbody>();
        }
        else
        {
            hitObject = null;
            myRigidbody = null;
        }

        if (hitObject == null) { return; }

        CheckHitInteractiveObjects(hitObject);
    }

    private void CheckHitInteractiveObjects(GameObject _hitObject)
    {
        if (hitObject.layer != layerInteractiveObjects) { return; }

        if (OVRInput.GetDown(inputManager))
        {
            _hitObject.SendMessage("InteractionTriggered", SendMessageOptions.DontRequireReceiver);
        }
    }
}
