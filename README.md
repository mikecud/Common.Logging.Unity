# Common.Logging.Unity [![Build Status](https://travis-ci.com/mikecud/Common.Logging.Unity.svg?branch=master)](https://travis-ci.com/mikecud/Common.Logging.Unity)

Unity extension to integrate with [Common.Logging](https://github.com/net-commons/common-logging) logging abstraction.

## Installation

Common.Logging.Unity is available on NuGet. Just search for "Common.Logging.Unity" in NuGet Package Manager or use command:

```
Install-Package Common.Logging.Unity
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
```
- That's it!

## License

Dual licensed under ["The Unlicense"](LICENSE.md) and ["MIT"](LICENSE.MIT.md) .

"The Unlicense" is recommended for most cases, because it let's you use extension with no restrictions under no conditions. If "The Unlicense" is for some reason not suitable for you, take it under MIT license. 

In any case, feel free to use this piece of software for any purposes (including commercial use).
