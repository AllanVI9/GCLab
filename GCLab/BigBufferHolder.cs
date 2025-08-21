using System.ComponentModel.DataAnnotations;

namespace GCLab;

// =====================================================
// 2) LOH + cache estático sem política de expiração
// =====================================================
static class BigBufferHolder
{
    public static byte[] Run()
    {        
        var data = new byte[84_999]; 
        GlobalCache.Add(data);
        GlobalCache.Clear();
        return data;
    }
}
