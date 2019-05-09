 using UnityEngine;
 using UnityEngine.UI;
 
 public class clamp : MonoBehaviour
 {
     // Drag & Drop the gameobject holding the slider in the inspector
     [SerializeField]
     private Slider slider ;
     // Drag & Drop the gameobject of your camera in the inspector        
     [SerializeField]
     private Transform cameraTransform ;
     
     private void Start()
     {
         slider.onValueChanged.AddListener( OnSliderValueChanged ) ;
     }
     
     private void OnSliderValueChanged( float value )
     {
         float angle = Mathf.Lerp( -90, 90, slider.normalizedValue ) ;
         cameraTransform.localRotation = Quaternion.Euler( angle, 0, 0 );
     }
 }