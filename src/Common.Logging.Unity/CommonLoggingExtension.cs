using System.Security;
using Unity;
using Unity.Builder;
using Unity.Extension;
using Unity.Policy;
using Unity.Resolution;

namespace Common.Logging.Unity
{
    [SecuritySafeCritical]
    public class CommonLoggingExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Context.Policies.Set(
                typeof(ILog),
                UnityContainer.All,
                typeof(ResolveDelegateFactory),
                (ResolveDelegateFactory)CreateResolver);
        }

        private ResolveDelegate<BuilderContext> CreateResolver(ref BuilderContext context)
        {
            var declaringType = context.DeclaringType;

            return (ref BuilderContext c) => LogManager.GetLogger(declaringType);
        }
    }
}
