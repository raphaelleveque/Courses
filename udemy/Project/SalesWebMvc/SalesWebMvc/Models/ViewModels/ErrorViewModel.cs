using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace SalesWebMvc.Models.ViewModels;

public class ErrorViewModel {
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
