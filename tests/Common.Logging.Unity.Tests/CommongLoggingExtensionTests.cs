using Common.Logging.Configuration;
using Common.Logging.Simple;
using FluentAssertions;
using Unity;
using Xunit;

namespace Common.Logging.Unity.Tests
{
    /// <summary>
    /// Test class that depends on logger
    /// </summary>
    public class CommongLoggingExtensionTestClass
    {
        public readonly ILog Logger;

        public CommongLoggingExtensionTestClass(ILog logger)
        {
            Logger = logger;
        }
    }

    /// <summary>
    /// Testing class
    /// </summary>
    public class CommongLoggingExtensionTests
    {
        [Fact]
        public void ResolveTestClass_TestClassHasLoggerOfProperType()
        {
            // Arrange
            LogManager.Configure(new LogConfiguration
            {
                FactoryAdapter = new FactoryAdapterConfiguration
                {
                    Type = typeof(DebugLoggerFactoryAdapter).FullName
                }
            });

            var logger = LogManager.GetLogger<CommongLoggingExtensionTestClass>() as DebugOutLogger;
            var container = new UnityContainer();
            container.AddNewExtension<CommonLoggingExtension>();

            // Act
            var testClassInstance = container.Resolve<CommongLoggingExtensionTestClass>();

            // Assert
            testClassInstance.Should().NotBeNull();
            (testClassInstance.Logger as DebugOutLogger).Should().NotBeNull();
            (testClassInstance.Logger as DebugOutLogger).Name.Should().BeSameAs(logger.Name);
        }
    }
}
