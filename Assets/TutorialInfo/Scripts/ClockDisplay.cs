using AISystem.Common.Module;
using TMPro;
using UnityEngine;


namespace AISystem.Demo
{
    public class ClockDisplay : MonoBehaviour
    {
        public ModuleService moduleService;
        [SerializeField]private TextMeshPro text;


        // Update is called once per frame
        void Update()
        {
            text.text = moduleService.GetTimeService().GetTimeOfDay().ToString();
        }
    }
}