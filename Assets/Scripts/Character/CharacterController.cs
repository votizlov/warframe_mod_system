using Character.States;
using UnityEngine;

namespace Character
{
    public class CharacterController : MonoBehaviour
    {
        private IState initialState;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            initialState.OnUpdate(this);
        }
    }
}
