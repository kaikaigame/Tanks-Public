using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    // This class is used to make sure world space UI
    // elements such as the health bar face the correct direction.

    // Use relative rotation should be used for this gameobject?
    public bool m_UseRelativeRotation = true;

    // The local rotatation at the start of the scene.
    private Quaternion m_RelativeRotation;
    
    private void Start()
    {
        m_RelativeRotation = transform.parent.localRotation;
    }

    private void Update()
    {
        if (m_UseRelativeRotation)
            transform.rotation = m_RelativeRotation;
    }
}