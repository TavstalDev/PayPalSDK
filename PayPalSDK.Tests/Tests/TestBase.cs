using Tavstal.PayPalSDK.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.PayPalSDK.Tests.Tests;

public abstract class TestBase
{
    protected readonly ITestOutputHelper _testOutputHelper;
    protected readonly List<Resource> _resources = [];

    protected TestBase(ITestOutputHelper testOutputHelper, string[] responsePaths)
    {
        _testOutputHelper = testOutputHelper;
        foreach (string path in responsePaths)
            _resources.Add(Resource.FromFile(path));
    }
}