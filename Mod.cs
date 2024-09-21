using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;

namespace Any_Asset_Named
{
    public class Mod : IMod
    {
        //public static ILog log = LogManager.GetLogger($"{nameof(Any_Asset_Named)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            //log.Info(nameof(OnLoad));

           // if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
                //log.Info($"Current mod asset at {asset.path}");

        }

        public void OnDispose()
        {
            //log.Info(nameof(OnDispose));
        }
    }
}
