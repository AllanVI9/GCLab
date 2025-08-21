using System.Text;

namespace GCLab;

// ===================================
// 4) Concatenação de string ineficiente
// ===================================
static class ConcatWork
{
    public static string Bad()
    {
        string s = string.Empty;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 50_000; i++)
        {
            sb.Append(i);
        }

        s = sb.ToString();
        return s;
    }    
}
