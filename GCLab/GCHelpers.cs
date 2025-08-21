namespace GCLab;

// =============================
// Helpers de GC e diagnóstico
// =============================
static class GCHelpers
{
    public static void FullCollect()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}
