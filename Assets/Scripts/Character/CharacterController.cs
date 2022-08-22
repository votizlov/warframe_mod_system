using Character.States;
using UnityEngine;

namespace Character
{
    public class CharacterController : MonoBehaviour
    {
        private IState _initialState;
        void Start()
        {
            _initialState = new EmptyState();
        }

        void Update()
        {
            _initialState.OnUpdate(this);
        }

        public void TogglePlayerControl()
        {
            
        }
    }
}
