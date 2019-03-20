# Unity.CommonLogging [![Build Status](https://travis-ci.com/mikecud/Unity.CommonLogging.svg?branch=master)](https://travis-ci.com/mikecud/Unity.CommonLogging)

Unity extension to integrate with [Common.Logging](https://github.com/net-commons/common-logging) logging abstraction.

## Installation

Unity.CommonLogging is available on NuGet. Just search for "Unity.CommonLogging" in NuGet Package Manager or use command:
```
Install-Package Unity.CommonLogging
```

## Usage

- Add `CommonLoggingExtension` extension

```C#
container = new UnityContainer();
container.AddNewExtension<CommonLoggingExtension>();
```
- Add `ILog` interface to constructor of the class that depends on Common.Logging.

```C#
public class CommongLoggingExtensionTestClass
{
    public CommongLoggingExtensionTestClass(ILog logger)
    {
    }
  ...
}
- That's it!

## License

Dual licensed under "The Unlicense" and MIT. 

"The Unlicense" is recommended for most cases, because it let's you use DynamicWhereBuilder with no restrictions under no conditions. If "The Unlicense" is for some reason not suitable for you, take it under MIT license. 

Check out [LICENSE.md](LICENSE.md) file for more information.