namespace Character.States
{
    public interface IState
    {
        void OnEnter(CharacterController controller);
        void OnUpdate(CharacterController controller);
        void OnExit(CharacterController controller);
    }
}
