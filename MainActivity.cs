using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AndroidSymbols;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        NativeCrash();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NativeCrash()
    {
        _ = strlen(null!);
    }

    [DllImport("libc")]
    private static extern int strlen(string s);
}