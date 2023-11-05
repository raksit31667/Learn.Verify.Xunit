using System.Runtime.CompilerServices;
using Xunit;

namespace Learn.Verify.Xunit.Test;

public class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifyDiffPlex.Initialize();
    }
}
