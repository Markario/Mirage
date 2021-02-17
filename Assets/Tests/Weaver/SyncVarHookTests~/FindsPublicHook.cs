using Mirage;

namespace SyncVarHookTests.FindsPublicHook
{
    class FindsPublicHook : NetworkBehaviour
    {
        [SyncVar(hook = nameof(onChangeHealth))]
        int health;

        public void onChangeHealth(int oldValue, int newValue)
        {

        }
    }
}
