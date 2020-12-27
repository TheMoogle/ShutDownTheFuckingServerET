using UnityEngine;

namespace ShutDownTheFuckingServerET
{
    public class Plugin : PluginFramework.Plugin
    {
        public override void OnDisable()
        {
            Debug.LogError("HOW?!?!?!?!?");
        }

        public override void OnEnable()
        {
            Application.Quit();
        }
    }
}
